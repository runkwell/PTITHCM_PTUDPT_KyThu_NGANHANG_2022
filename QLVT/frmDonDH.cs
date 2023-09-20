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
    public partial class frmDonDH : Form
    {
        int vitri = 0;
        int check = 0;
        public frmDonDH()
        {
            InitializeComponent();
        }

        public Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void dONDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmDonDH_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.CT_DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CT_DONDHTableAdapter.Fill(this.DS.CT_DONDH);

            this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);

            this.DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DONDHTableAdapter.Fill(this.DS.DONDH);

            cboChiNhanh.DataSource = Program.bds_dspm;  //sao chép dspm đã load ở form đăng nhập.
            cboChiNhanh.DisplayMember = "TENCN";
            cboChiNhanh.ValueMember = "TENSERVER";
            cboChiNhanh.SelectedIndex = Program.mChinhanh;
            panelControl2.Enabled = false;
            btnChiTiet.Enabled = true;
            nGAYLAPDateEdit.EditValue = DateTime.Today;
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
                this.DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DONDHTableAdapter.Fill(this.DS.DONDH);
                this.CT_DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CT_DONDHTableAdapter.Fill(this.DS.CT_DONDH);
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDDH.Position;
            txtMaDDH.Enabled = false;
            txtMaNV.Enabled = false;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = btnChiTiet.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcDDH.Enabled = false;
            check = 2;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDDH.Position; // giữ vị trí kh hiện tại
            panelControl2.Enabled = true;
            bdsDDH.AddNew();
            txtMaDDH.Enabled = true;
            txtMaDDH.Focus();
            txtMaNV.Text = Program.username.Trim();
            txtMaNV.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = btnChiTiet.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcDDH.Enabled = false;
            check = 1;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã DDH không được thiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDDH.Focus();
                return;
            }

            if (txtMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã NCC không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                return;
            }
            try
            {
                if (check == 1)
                {
                    string strLenh = "DECLARE @RC INT " +
                               "EXEC @RC = SP_CHECKMADDHEXISTS " +
                               "@MADDH=" + txtMaDDH.Text.Trim() + " " +
                                "SELECT 'Result' = @RC";
                    SqlDataReader dataReader = null;
                    dataReader = Program.ExecSqlDataReader(strLenh);
                    // Đọc và lấy 
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Don DH này đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaDDH.Focus();
                        return;
                    }
                }
                bdsDDH.EndEdit();    // kết thúc quá trình tạo. -> Ghi vào trong bds.
                bdsDDH.ResetCurrentItem();   //Đưa những thông tin đó lên lưới.
                this.DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DONDHTableAdapter.Update(this.DS.DONDH); // Update trên adapter có 3 nghĩa: vừa là insert, update, delete. Nó tùy vào tình huống cụ thể để đưa lệnh tương ứng.
                this.CT_DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CT_DONDHTableAdapter.Fill(this.DS.CT_DONDH);
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
            gcDDH.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = btnChiTiet.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDDH.CancelEdit();
            this.DONDHTableAdapter.Fill(this.DS.DONDH);
            if (btnThem.Enabled == false) bdsDDH.Position = vitri;
            gcDDH.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = btnChiTiet.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maddh = ((DataRowView)bdsDDH[bdsDDH.Position])["MADDH"].ToString();
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa DDH này vì đã có phiếu nhập!!!", "",
                    MessageBoxButtons.OK);
                return;
            }
            else if (bdsCT_DONDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa DDH này vì đã có mặt hàng!!!", "",
                    MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa DDH này ??", "Xác nhận",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // Giữ lại cmnd hiện tại đang đứng để nếu xóa ở máy hiện tại thành công mà xóa ở CSDL thất bại thì ta sẽ fill data về lại máy và nhờ cmnd đó thì con trỏ nó sẽ nhảy đến cmnd vừa xóa.
                    bdsDDH.RemoveCurrent();  // Xóa trên máy hiện tại trước, sau đó mới xóa trên CSDL sau.
                    this.DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.DONDHTableAdapter.Update(this.DS.DONDH); // xóa dữ liệu đó ở CSDL.
                    this.DONDHTableAdapter.Fill(this.DS.DONDH);
                    this.CT_DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CT_DONDHTableAdapter.Fill(this.DS.CT_DONDH);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.DONDHTableAdapter.Fill(this.DS.DONDH);   // Trường hợp xóa ở máy hiện tại thành công nhưng xóa trên CSDL bị lỗi thì ta phải tải về lại máy hiện tại.
                    bdsDDH.Position = bdsDDH.Find("MADDH", maddh);  // đưa con trỏ nhảy đến vị trí manv đã xóa thất bại trước đó.
                    return;
                }
            }
            if (bdsDDH.Count == 0) btnXoa.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.DONDHTableAdapter.Fill(this.DS.DONDH);
                this.CT_DONDHTableAdapter.Fill(this.DS.CT_DONDH);// tải lại Khách hàng.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Tải lại đơn đặt hàng: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Program.maddh = txtMaDDH.Text.ToString().Trim();

            Form frm = this.CheckExists(typeof(frmCT_DDH));
            if (frm != null) frm.Activate();
            else
            {
                frmCT_DDH f = new frmCT_DDH();
                f.Show();
            }

        }

        private void txtMaDDH_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
