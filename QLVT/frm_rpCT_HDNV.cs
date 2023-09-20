﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
namespace QLVT
{
    public partial class frm_rpCT_HDNV : Form
    {
        String macn;
        public frm_rpCT_HDNV()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frm_rpCT_HDNV_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            cboChiNhanh.DataSource = Program.bds_dspm;  //sao chép dspm đã load ở form đăng nhập.
            cboChiNhanh.DisplayMember = "TENCN";
            cboChiNhanh.ValueMember = "TENSERVER";
            cboChiNhanh.SelectedIndex = Program.mChinhanh;
            macn = cboChiNhanh.Text.ToString();
            if (Program.mGroup == "CONGTY")
            {
                cboChiNhanh.Enabled = true;
            }
            else
            {
                cboChiNhanh.Enabled = false;
            }

            GetNV();
            txtHoTen.Text = cmbNhanVien.SelectedValue.ToString();
        }
        private void GetNV()
        {
            if (Program.mloginDN == "") return;
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối data", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DataTable db = new DataTable();
            String sql = "SELECT * FROM dbo.V_DS_NV";
            SqlDataAdapter da = new SqlDataAdapter(sql, Program.conn);
            da.Fill(db);
            bdsNV.DataSource = db;
            cmbNhanVien.DataSource = bdsNV;
            cmbNhanVien.DisplayMember = "MANV";
            cmbNhanVien.ValueMember = "HOTEN";
        }

        private void btnXemN_Click(object sender, EventArgs e)
        {
            if (dtpTu.Text.Length == 0 || dtpDen.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống ngày chọn liệt kê\n Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dtpTu.Text.Equals(dtpDen.Text))
            {
                MessageBox.Show("Ngày không hợp lệ!\n Vui lòng chọn lại ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String userName = cmbNhanVien.Text.ToString();

            string strLenh = "DECLARE @RC INT " +
                               "EXEC @RC = SP_getNV " +
                               "@MANV=" + cmbNhanVien.Text.Trim() + ", @NHOM=" + Program.mGroup + " "+
                                "SELECT 'Result' = @RC";
            SqlDataReader dataReader = null;
            dataReader = Program.ExecSqlDataReader(strLenh);
            // Đọc và lấy 
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            


            MessageBox.Show(userName+"-"+ dtpTu.Text +"-"+ dtpDen.Text + "-" + macn, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Xrpt_HDNV_N Xrpt = new Xrpt_HDNV_N(userName,dtpTu.Text, dtpDen.Text, macn);

            Xrpt.xrlMaNV.Text = dataReader.GetSqlValue(0).ToString();
            Xrpt.xrlHoTen.Text = dataReader.GetSqlValue(1).ToString();
            Xrpt.xrlPhai.Text = dataReader.GetSqlValue(2).ToString();
            Xrpt.xrlNgaySinh.Text = dataReader.GetSqlValue(3).ToString();
            DateTime dt1 = DateTime.Parse(Xrpt.xrlNgaySinh.Text);
            Xrpt.xrlNgaySinh.Text = dt1.ToString("dd-MM-yyyy");
            Xrpt.xrlDiaChi.Text = dataReader.GetSqlValue(4).ToString();
            Xrpt.xrlSDT.Text = dataReader.GetSqlValue(5).ToString();
            dataReader.Close();

            //Xrpt.label1.Text = "HOẠT ĐỘNG CỦA NHÂN VIÊN";
            ReportPrintTool print = new ReportPrintTool(Xrpt);
            print.ShowPreviewDialog();
        }

        private void btnXemX_Click(object sender, EventArgs e)
        {
            if (dtpTu.Text.Length == 0 || dtpDen.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống ngày chọn liệt kê\n Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dtpTu.Text.Equals(dtpDen.Text))
            {
                MessageBox.Show("Ngày không hợp lệ!\n Vui lòng chọn lại ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String userName = cmbNhanVien.Text.ToString();
            string strLenh = "DECLARE @RC INT " +
                              "EXEC @RC = SP_getNV " +
                              "@MANV=" + cmbNhanVien.Text.Trim() + ", @NHOM=" + Program.mGroup + " " +
                               "SELECT 'Result' = @RC";
            SqlDataReader dataReader = null;
            dataReader = Program.ExecSqlDataReader(strLenh);
            // Đọc và lấy 
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());


            MessageBox.Show(userName + "-" + dtpTu.Text + "-" + dtpDen.Text +"-"+macn, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Xrpt_HDNV_X Xrpt = new Xrpt_HDNV_X(userName,dtpTu.Text, dtpDen.Text,macn);

            Xrpt.xrlMaNV.Text = dataReader.GetSqlValue(0).ToString();
            Xrpt.xrlHoTen.Text = dataReader.GetSqlValue(1).ToString();
            Xrpt.xrlPhai.Text = dataReader.GetSqlValue(2).ToString();
            Xrpt.xrlNgaySinh.Text = dataReader.GetSqlValue(3).ToString();
            DateTime dt1 = DateTime.Parse(Xrpt.xrlNgaySinh.Text);
            Xrpt.xrlNgaySinh.Text = dt1.ToString("dd-MM-yyyy");
            Xrpt.xrlDiaChi.Text = dataReader.GetSqlValue(4).ToString();
            if (Xrpt.xrlDiaChi.Text.Trim() == "NULL")
            {
                Xrpt.xrlDiaChi.Text = "";
            }
            Xrpt.xrlSDT.Text = dataReader.GetSqlValue(5).ToString();
            if (Xrpt.xrlSDT.Text.Trim() == "NULL")
            {
                Xrpt.xrlSDT.Text = "";
            }
            dataReader.Close();

            // Xrpt.label1.Text = "DANH SÁCH PHIẾU XUẤT CỦA NHÂN VIÊN" + txtHoTen.Text.Trim() + " TỪ " + dtpTu.Text + " ĐẾN " + dtpDen.Text + " CỦA" + macn;
            ReportPrintTool print = new ReportPrintTool(Xrpt);
            print.ShowPreviewDialog();
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
                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            GetNV();
            txtHoTen.Text = cmbNhanVien.SelectedValue.ToString();
            macn = cboChiNhanh.Text.ToString();
        }
    }
}
