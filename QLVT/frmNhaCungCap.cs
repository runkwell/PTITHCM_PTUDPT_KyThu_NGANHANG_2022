using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLVT
{
    public partial class frmNhaCungCap : Form
    {
        int vitri = 0;
        int check = 0;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void nHACCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNCC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DONDHTableAdapter.Fill(this.DS.DONDH);

            this.NHACCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHACCTableAdapter.Fill(this.DS.NHACC);

            cboChiNhanh.DataSource = Program.bds_dspm;  //sao chép dspm đã load ở form đăng nhập.
            cboChiNhanh.DisplayMember = "TENCN";
            cboChiNhanh.ValueMember = "TENSERVER";
            cboChiNhanh.SelectedIndex = Program.mChinhanh;
            panelControl2.Enabled = false;
            if (Program.mGroup == "CONGTY")
            {
                cboChiNhanh.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = false;
            }
            else
            {
                cboChiNhanh.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = true;
            }
        }

        private void cboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cboChiNhanh.SelectedValue.ToString();
            if (cboChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
            else
            {
                this.NHACCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHACCTableAdapter.Fill(this.DS.NHACC);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNCC.Position; // giữ vị trí kh hiện tại
            panelControl2.Enabled = true;
            bdsNCC.AddNew();
            txtMaNCC.Enabled = true;
            txtMaNCC.Focus();

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcNCC.Enabled = false;
            check = 1;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String mancc = ((DataRowView)bdsNCC[bdsNCC.Position])["MANCC"].ToString();
            if (bdsDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhà cung cấp này vì đã có đơn đặt hàng!!!", "",
                    MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa NCC này ??", "Xác nhận",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // Giữ lại cmnd hiện tại đang đứng để nếu xóa ở máy hiện tại thành công mà xóa ở CSDL thất bại thì ta sẽ fill data về lại máy và nhờ cmnd đó thì con trỏ nó sẽ nhảy đến cmnd vừa xóa.
                    bdsNCC.RemoveCurrent();  // Xóa trên máy hiện tại trước, sau đó mới xóa trên CSDL sau.
                    this.NHACCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHACCTableAdapter.Update(this.DS.NHACC); // xóa dữ liệu đó ở CSDL.
                    this.NHACCTableAdapter.Fill(this.DS.NHACC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa . Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.NHACCTableAdapter.Fill(this.DS.NHACC);   // Trường hợp xóa ở máy hiện tại thành công nhưng xóa trên CSDL bị lỗi thì ta phải tải về lại máy hiện tại.
                    bdsNCC.Position = bdsNCC.Find("MANCC", mancc);  // đưa con trỏ nhảy đến vị trí manv đã xóa thất bại trước đó.
                    return;
                }
            }
            if (bdsNCC.Count == 0) btnXoa.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNCC.Position;
            txtMaNCC.Enabled = false;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcNCC.Enabled = false;
            check = 2;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaNCC.Text.Trim() == "")
            {
                MessageBox.Show("Mã NCC không được thiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                return;
            }
            if (tENNCCTextEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên NCC không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tENNCCTextEdit.Focus();
                return;
            }

            try
            {
                if (check == 1)
                {
                    string strLenh = "DECLARE @RC INT " +
                               "EXEC @RC = SP_CHECKMANCCEXISTS " +
                               "@MANCC=" + txtMaNCC.Text.Trim() + " " +
                                "SELECT 'Result' = @RC";
                    SqlDataReader dataReader = null;
                    dataReader = Program.ExecSqlDataReader(strLenh);
                    // Đọc và lấy 
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("NCC này đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNCC.Focus();
                        return;
                    }
                }
                bdsNCC.EndEdit();    // kết thúc quá trình tạo. -> Ghi vào trong bds.
                bdsNCC.ResetCurrentItem();   //Đưa những thông tin đó lên lưới.
                this.NHACCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHACCTableAdapter.Update(this.DS.NHACC); // Update trên adapter có 3 nghĩa: vừa là insert, update, delete. Nó tùy vào tình huống cụ thể để đưa lệnh tương ứng.
                //this.KHACHHANGTableAdapter.Fill(this.DS.KhachHang);
                if (check == 1)
                {
                    MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
                }
                else if (check == 2)
                {
                    MessageBox.Show("Cập nhật thành công!", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            check = 0;
            gcNCC.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNCC.CancelEdit();
            this.NHACCTableAdapter.Fill(this.DS.NHACC);
            if (btnThem.Enabled == false) bdsNCC.Position = vitri;
            gcNCC.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NHACCTableAdapter.Fill(this.DS.NHACC);   // tải lại Khách hàng.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Tải lại : " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
