﻿
namespace QLVT
{
    partial class frm_rpCT_HDNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label lblTu;
            this.btnXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLVT.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.NHANVIENTableAdapter = new QLVT.DSTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpDen = new DevExpress.XtraEditors.DateEdit();
            this.dtpTu = new DevExpress.XtraEditors.DateEdit();
            this.btnXemX = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            mANVLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblTu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(186, 160);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(38, 13);
            mANVLabel.TabIndex = 3;
            mANVLabel.Text = "MANV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(439, 218);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 13);
            label3.TabIndex = 44;
            label3.Text = "Đến";
            // 
            // lblTu
            // 
            lblTu.AutoSize = true;
            lblTu.Location = new System.Drawing.Point(204, 218);
            lblTu.Name = "lblTu";
            lblTu.Size = new System.Drawing.Size(20, 13);
            lblTu.TabIndex = 42;
            lblTu.Text = "Từ";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(385, 307);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(135, 44);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "XEM NHẬP";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXemN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT HOẠT ĐỘNG CỦA NHÂN VIÊN";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NHANVIEN";
            this.bdsNV.DataSource = this.DS;
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DONDHTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.DONDHTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.NHANVIENTableAdapter;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MANV", true));
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(239, 157);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(101, 21);
            this.cmbNhanVien.TabIndex = 4;
            // 
            // dtpDen
            // 
            this.dtpDen.EditValue = new System.DateTime(2022, 3, 23, 0, 0, 0, 0);
            this.dtpDen.Location = new System.Drawing.Point(476, 215);
            this.dtpDen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDen.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dtpDen.Size = new System.Drawing.Size(103, 20);
            this.dtpDen.TabIndex = 45;
            // 
            // dtpTu
            // 
            this.dtpTu.EditValue = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpTu.Location = new System.Drawing.Point(239, 215);
            this.dtpTu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTu.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dtpTu.Size = new System.Drawing.Size(101, 20);
            this.dtpTu.TabIndex = 43;
            // 
            // btnXemX
            // 
            this.btnXemX.Location = new System.Drawing.Point(626, 307);
            this.btnXemX.Name = "btnXemX";
            this.btnXemX.Size = new System.Drawing.Size(135, 44);
            this.btnXemX.TabIndex = 46;
            this.btnXemX.Text = "XEM XUẤT";
            this.btnXemX.UseVisualStyleBackColor = true;
            this.btnXemX.Click += new System.EventHandler(this.btnXemX_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cboChiNhanh);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Location = new System.Drawing.Point(-8, 54);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(827, 78);
            this.panelControl1.TabIndex = 47;
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(266, 19);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(300, 21);
            this.cboChiNhanh.TabIndex = 1;
            this.cboChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cboChiNhanh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi nhánh";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(476, 158);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(193, 20);
            this.txtHoTen.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "HOTEN";
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(149, 307);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(136, 44);
            this.btnPre.TabIndex = 50;
            this.btnPre.Text = "PREVIEW";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // frm_rpCT_HDNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnXemX);
            this.Controls.Add(this.dtpDen);
            this.Controls.Add(label3);
            this.Controls.Add(lblTu);
            this.Controls.Add(this.dtpTu);
            this.Controls.Add(mANVLabel);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXem);
            this.Name = "frm_rpCT_HDNV";
            this.Text = "frmCT_HDNV";
            this.Load += new System.EventHandler(this.frm_rpCT_HDNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label1;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private DevExpress.XtraEditors.DateEdit dtpDen;
        private DevExpress.XtraEditors.DateEdit dtpTu;
        private System.Windows.Forms.Button btnXemX;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPre;
    }
}