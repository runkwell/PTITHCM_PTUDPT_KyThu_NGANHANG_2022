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

    public partial class frmHoaDon : Form
    {
        int vitri = 0;
        int check = 0;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHD.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.CT_HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CT_HOADONTableAdapter.Fill(this.DS.CT_HOADON);

            this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOADONTableAdapter.Fill(this.DS.HOADON);

            cboChiNhanh.DataSource = Program.bds_dspm;  //sao chép dspm đã load ở form đăng nhập.
            cboChiNhanh.DisplayMember = "TENCN";
            cboChiNhanh.ValueMember = "TENSERVER";
            cboChiNhanh.SelectedIndex = Program.mChinhanh;
            nGAYLAPDateEdit.EditValue = DateTime.Today;
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
                this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOADONTableAdapter.Fill(this.DS.HOADON);
                this.CT_HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CT_HOADONTableAdapter.Fill(this.DS.CT_HOADON);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsHD.Position; // giữ vị trí kh hiện tại
            panelControl2.Enabled = true;
            bdsHD.AddNew();
            txtSoHD.Enabled = true;
            txtSoHD.Focus();
            txtMaNV.Text = Program.username.Trim();
            txtMaNV.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcHD.Enabled = false;
            check = 1;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsHD.Position;
            txtSoHD.Enabled = false;
            txtMaNV.Enabled = false;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcHD.Enabled = false;
            check = 2;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtSoHD.Text.Trim() == "")
            {
                MessageBox.Show("Số HD không được thiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoHD.Focus();
                return;
            }

            if (txtMaKho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã kho không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKho.Focus();
                return;
            }
            if (txtMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã khách hàng không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }
            try
            {
                if (check == 1)
                {
                    string strLenh = "DECLARE @RC INT " +
                               "EXEC @RC = SP_CHECKSOHDEXISTS " +
                               "@SOHD=" + txtSoHD.Text.Trim() + " " +
                                "SELECT 'Result' = @RC";
                    SqlDataReader dataReader = null;
                    dataReader = Program.ExecSqlDataReader(strLenh);
                    // Đọc và lấy 
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Hóa đơn này đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSoHD.Focus();
                        return;
                    }
                }
                bdsHD.EndEdit();    // kết thúc quá trình tạo. -> Ghi vào trong bds.
                bdsHD.ResetCurrentItem();   //Đưa những thông tin đó lên lưới.
                this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOADONTableAdapter.Update(this.DS.HOADON); // Update trên adapter có 3 nghĩa: vừa là insert, update, delete. Nó tùy vào tình huống cụ thể để đưa lệnh tương ứng.
                this.CT_HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CT_HOADONTableAdapter.Fill(this.DS.CT_HOADON);
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
            gcHD.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHD.CancelEdit();
            this.HOADONTableAdapter.Fill(this.DS.HOADON);
            if (btnThem.Enabled == false) bdsHD.Position = vitri;
            gcHD.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String sohd = ((DataRowView)bdsHD[bdsHD.Position])["SOHD"].ToString();
            if (bdsCT_HD.Count > 0)
            {
                MessageBox.Show("Không thể xóa HD này vì đã lập danh sách mua hàng!!!", "",
                    MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa HD này ??", "Xác nhận",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // Giữ lại cmnd hiện tại đang đứng để nếu xóa ở máy hiện tại thành công mà xóa ở CSDL thất bại thì ta sẽ fill data về lại máy và nhờ cmnd đó thì con trỏ nó sẽ nhảy đến cmnd vừa xóa.
                    bdsHD.RemoveCurrent();  // Xóa trên máy hiện tại trước, sau đó mới xóa trên CSDL sau.
                    this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.HOADONTableAdapter.Update(this.DS.HOADON); // xóa dữ liệu đó ở CSDL.
                    this.HOADONTableAdapter.Fill(this.DS.HOADON);
                    this.CT_HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CT_HOADONTableAdapter.Fill(this.DS.CT_HOADON);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa . Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.HOADONTableAdapter.Fill(this.DS.HOADON);   // Trường hợp xóa ở máy hiện tại thành công nhưng xóa trên CSDL bị lỗi thì ta phải tải về lại máy hiện tại.
                    bdsHD.Position = bdsHD.Find("SOHD", sohd);  // đưa con trỏ nhảy đến vị trí manv đã xóa thất bại trước đó.
                    return;
                }
            }
            if (bdsHD.Count == 0) btnXoa.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.HOADONTableAdapter.Fill(this.DS.HOADON);   // tải lại Khách hàng.
                this.CT_HOADONTableAdapter.Fill(this.DS.CT_HOADON);
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

        public Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Program.sohd = txtSoHD.Text.ToString().Trim();
            Form frm = this.CheckExists(typeof(frmCT_PX));
            if (frm != null) frm.Activate();
            else
            {
                frmCT_PX f = new frmCT_PX();
                f.Show();
            }
        }
    }
}
