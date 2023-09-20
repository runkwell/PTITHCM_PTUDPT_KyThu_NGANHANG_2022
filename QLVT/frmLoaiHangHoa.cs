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
    public partial class frmLoaiHangHoa : Form
    {
        int vitri = 0;
        int check = 0;
        public frmLoaiHangHoa()
        {
            InitializeComponent();
        }

        private void lOAIHANGHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLHH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmLoaiHangHoa_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.HANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.HANGHOATableAdapter.Fill(this.DS.HANGHOA);
            
            this.LOAIHANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOAIHANGHOATableAdapter.Fill(this.DS.LOAIHANGHOA);

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
                this.LOAIHANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOAIHANGHOATableAdapter.Fill(this.DS.LOAIHANGHOA);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLHH.Position; // giữ vị trí kh hiện tại
            panelControl2.Enabled = true;
            bdsLHH.AddNew();
            txtMaLHH.Enabled = true;
            txtMaLHH.Focus();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcLHH.Enabled = false;
            check = 1;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLHH.Position;
            txtMaLHH.Enabled = false;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcLHH.Enabled = false;
            check = 2;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLHH.Text.Trim() == "")
            {
                MessageBox.Show("Mã NCC không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLHH.Focus();
                return;
            }
            if (tENLHHTextEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên NCC không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tENLHHTextEdit.Focus();
                return;
            }
            try
            {
                if (check == 1)
                {
                    string strLenh = "DECLARE @RC INT " +
                               "EXEC @RC = SP_CHECKMALHHEXISTS " +
                               "@MALHH=" + txtMaLHH.Text.Trim() + " " +
                                "SELECT 'Result' = @RC";
                    SqlDataReader dataReader = null;
                    dataReader = Program.ExecSqlDataReader(strLenh);
                    // Đọc và lấy 
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLHH.Focus();
                        return;
                    }
                }
                bdsLHH.EndEdit();    // kết thúc quá trình tạo. -> Ghi vào trong bds.
                bdsLHH.ResetCurrentItem();   //Đưa những thông tin đó lên lưới.
                this.LOAIHANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOAIHANGHOATableAdapter.Update(this.DS.LOAIHANGHOA); // Update trên adapter có 3 nghĩa: vừa là insert, update, delete. Nó tùy vào tình huống cụ thể để đưa lệnh tương ứng.
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
            gcLHH.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLHH.CancelEdit();
            this.LOAIHANGHOATableAdapter.Fill(this.DS.LOAIHANGHOA);
            if (btnThem.Enabled == false) bdsLHH.Position = vitri;
            gcLHH.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String malhh = ((DataRowView)bdsLHH[bdsLHH.Position])["MALHH"].ToString();
            if (bdsHH.Count > 0)
            {
                MessageBox.Show("Không thể xóa loại hàng này vì đã có hàng hóa !!!", "",
                    MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này ??", "Xác nhận",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // Giữ lại cmnd hiện tại đang đứng để nếu xóa ở máy hiện tại thành công mà xóa ở CSDL thất bại thì ta sẽ fill data về lại máy và nhờ cmnd đó thì con trỏ nó sẽ nhảy đến cmnd vừa xóa.
                    bdsLHH.RemoveCurrent();  // Xóa trên máy hiện tại trước, sau đó mới xóa trên CSDL sau.
                    this.LOAIHANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOAIHANGHOATableAdapter.Update(this.DS.LOAIHANGHOA); // xóa dữ liệu đó ở CSDL.
                    this.LOAIHANGHOATableAdapter.Fill(this.DS.LOAIHANGHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.LOAIHANGHOATableAdapter.Fill(this.DS.LOAIHANGHOA);   // Trường hợp xóa ở máy hiện tại thành công nhưng xóa trên CSDL bị lỗi thì ta phải tải về lại máy hiện tại.
                    bdsLHH.Position = bdsLHH.Find("MALHH", malhh);  // đưa con trỏ nhảy đến vị trí manv đã xóa thất bại trước đó.
                    return;
                }
            }
            if (bdsLHH.Count == 0) btnXoa.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOAIHANGHOATableAdapter.Fill(this.DS.LOAIHANGHOA);   // tải lại Khách hàng.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Tải lại danh sách khách hàng: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
