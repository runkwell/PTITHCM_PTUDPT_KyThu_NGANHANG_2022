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
    
    public partial class frmKhachHang : Form
    {
        int vitri = 0;
        string macn = "";
        int check = 0;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOADONTableAdapter.Fill(this.DS.HOADON);

            this.KHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);

            macn = ((DataRowView)bdsKH[0])["MACN"].ToString();
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
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void cboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cboChiNhanh.SelectedValue.ToString();

            if (cboChiNhanh.SelectedIndex != Program.mChinhanh) //nếu ta chọn chi nhánh khác với chi nhánh ở thời điểm đăng nhập thì ta sẽ dùng tk HTKN;
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
                MessageBox.Show("Lỗi kết nối về chi nhánh mới!", "", MessageBoxButtons.OK);
            else
            {
                this.KHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;    // gán thông tin đăng nhập vào các Adapter tương ứng để fill lấy thông tin đúng với thông tin đăng nhập.
                this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKH.Position; // giữ vị trí kh hiện tại
            panelControl2.Enabled = true;
            bdsKH.AddNew();
            txtMaKH.Enabled = true;
            txtMaKH.Focus();
            txtMaCN.Text = macn;
            txtMaCN.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcKH.Enabled = false;
            check = 1;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKH.Position;
            txtMaKH.Enabled = false;
            txtMaCN.Enabled = false;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcKH.Enabled = false;
            check = 2;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tENKHTextEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên khách hàng không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tENKHTextEdit.Focus();
                return;
            }
            if (txtMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã khách hàng không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }

            //String PhoneNumber = "0\\d{9,10}";
            //if (txtSDT.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Số điện thoại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtSDT.Focus();
            //    return;
            //}
            //if (!Regex.IsMatch(txtSDT.Text.Trim(), PhoneNumber))
            //{
            //    MessageBox.Show("Nhập sai định dạng SĐT!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtSDT.Focus();
            //    return;
            //}
            try
            {
                if (check == 1)
                {
                    string strLenh = "DECLARE @RC INT " +
                               "EXEC @RC = SP_CHECKKHEXISTS " +
                               "@MAKH=" + txtMaKH.Text.Trim() + " " +
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
                        txtMaKH.Focus();
                        return;
                    }
                }
                bdsKH.EndEdit();    // kết thúc quá trình tạo. -> Ghi vào trong bds.
                bdsKH.ResetCurrentItem();   //Đưa những thông tin đó lên lưới.
                this.KHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHACHHANGTableAdapter.Update(this.DS.KHACHHANG); // Update trên adapter có 3 nghĩa: vừa là insert, update, delete. Nó tùy vào tình huống cụ thể để đưa lệnh tương ứng.
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
            gcKH.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKH.CancelEdit();
            this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
            if (btnThem.Enabled == false) bdsKH.Position = vitri;
            gcKH.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);   // tải lại Khách hàng.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Tải lại danh sách khách hàng: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String makh = ((DataRowView)bdsKH[bdsKH.Position])["MAKH"].ToString();
            if (bdsHD.Count > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng này vì đã có hóa đơn mua hàng!!!", "",
                    MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này ??", "Xác nhận",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // Giữ lại cmnd hiện tại đang đứng để nếu xóa ở máy hiện tại thành công mà xóa ở CSDL thất bại thì ta sẽ fill data về lại máy và nhờ cmnd đó thì con trỏ nó sẽ nhảy đến cmnd vừa xóa.
                    bdsKH.RemoveCurrent();  // Xóa trên máy hiện tại trước, sau đó mới xóa trên CSDL sau.
                    this.KHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KHACHHANGTableAdapter.Update(this.DS.KHACHHANG); // xóa dữ liệu đó ở CSDL.
                    this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);   // Trường hợp xóa ở máy hiện tại thành công nhưng xóa trên CSDL bị lỗi thì ta phải tải về lại máy hiện tại.
                    bdsKH.Position = bdsKH.Find("MAKH", makh);  // đưa con trỏ nhảy đến vị trí manv đã xóa thất bại trước đó.
                    return;
                }
            }
            if (bdsKH.Count == 0) btnXoa.Enabled = false;
        }
    }
}
