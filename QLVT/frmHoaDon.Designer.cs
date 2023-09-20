
namespace QLVT
{
    partial class frmHoaDon
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
            System.Windows.Forms.Label sOHDLabel;
            System.Windows.Forms.Label nGAYLAPLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLVT.DS();
            this.bdsHD = new System.Windows.Forms.BindingSource(this.components);
            this.HOADONTableAdapter = new QLVT.DSTableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.CT_HOADONTableAdapter = new QLVT.DSTableAdapters.CT_HOADONTableAdapter();
            this.bdsCT_HD = new System.Windows.Forms.BindingSource(this.components);
            this.gcHD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.nGAYLAPDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.txtSoHD = new DevExpress.XtraEditors.TextEdit();
            this.cT_HOADONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOHD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChiTiet = new System.Windows.Forms.Button();
            sOHDLabel = new System.Windows.Forms.Label();
            nGAYLAPLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYLAPDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYLAPDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_HOADONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sOHDLabel
            // 
            sOHDLabel.AutoSize = true;
            sOHDLabel.Location = new System.Drawing.Point(52, 27);
            sOHDLabel.Name = "sOHDLabel";
            sOHDLabel.Size = new System.Drawing.Size(39, 13);
            sOHDLabel.TabIndex = 0;
            sOHDLabel.Text = "SOHD:";
            // 
            // nGAYLAPLabel
            // 
            nGAYLAPLabel.AutoSize = true;
            nGAYLAPLabel.Location = new System.Drawing.Point(286, 27);
            nGAYLAPLabel.Name = "nGAYLAPLabel";
            nGAYLAPLabel.Size = new System.Drawing.Size(56, 13);
            nGAYLAPLabel.TabIndex = 2;
            nGAYLAPLabel.Text = "NGAYLAP:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(531, 27);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(39, 13);
            mANVLabel.TabIndex = 4;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(44, 86);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(47, 13);
            mAKHOLabel.TabIndex = 6;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(303, 86);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(39, 13);
            mAKHLabel.TabIndex = 8;
            mAKHLabel.Text = "MAKH:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnLuu,
            this.btnPhucHoi,
            this.btnXoa,
            this.btnTaiLai,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaiLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu Chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 2;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Caption = "Tải Lại";
            this.btnTaiLai.Id = 5;
            this.btnTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.Image")));
            this.btnTaiLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.LargeImage")));
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLai_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1467, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 542);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1467, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 518);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1467, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 518);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cboChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1467, 78);
            this.panelControl1.TabIndex = 9;
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(130, 23);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(320, 21);
            this.cboChiNhanh.TabIndex = 1;
            this.cboChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cboChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHD
            // 
            this.bdsHD.DataMember = "HOADON";
            this.bdsHD.DataSource = this.DS;
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DONDHTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = this.CT_HOADONTableAdapter;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.DONDHTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = this.HOADONTableAdapter;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CT_HOADONTableAdapter
            // 
            this.CT_HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCT_HD
            // 
            this.bdsCT_HD.DataMember = "FK_CT_HOADON_HOADON";
            this.bdsCT_HD.DataSource = this.bdsHD;
            // 
            // gcHD
            // 
            this.gcHD.DataSource = this.bdsHD;
            this.gcHD.Location = new System.Drawing.Point(0, 102);
            this.gcHD.MainView = this.gridView1;
            this.gcHD.MenuManager = this.barManager1;
            this.gcHD.Name = "gcHD";
            this.gcHD.Size = new System.Drawing.Size(800, 220);
            this.gcHD.TabIndex = 15;
            this.gcHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOHD,
            this.colNGAYLAP,
            this.colMANV,
            this.colMAKHO,
            this.colMAKH});
            this.gridView1.GridControl = this.gcHD;
            this.gridView1.Name = "gridView1";
            // 
            // colSOHD
            // 
            this.colSOHD.FieldName = "SOHD";
            this.colSOHD.Name = "colSOHD";
            this.colSOHD.Visible = true;
            this.colSOHD.VisibleIndex = 0;
            // 
            // colNGAYLAP
            // 
            this.colNGAYLAP.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAYLAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYLAP.FieldName = "NGAYLAP";
            this.colNGAYLAP.Name = "colNGAYLAP";
            this.colNGAYLAP.Visible = true;
            this.colNGAYLAP.VisibleIndex = 1;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 2;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 3;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(mAKHLabel);
            this.panelControl2.Controls.Add(this.txtMaKH);
            this.panelControl2.Controls.Add(mAKHOLabel);
            this.panelControl2.Controls.Add(this.txtMaKho);
            this.panelControl2.Controls.Add(mANVLabel);
            this.panelControl2.Controls.Add(this.txtMaNV);
            this.panelControl2.Controls.Add(nGAYLAPLabel);
            this.panelControl2.Controls.Add(this.nGAYLAPDateEdit);
            this.panelControl2.Controls.Add(sOHDLabel);
            this.panelControl2.Controls.Add(this.txtSoHD);
            this.panelControl2.Location = new System.Drawing.Point(0, 322);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 175);
            this.panelControl2.TabIndex = 16;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHD, "MAKH", true));
            this.txtMaKH.Location = new System.Drawing.Point(348, 83);
            this.txtMaKH.MenuManager = this.barManager1;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 9;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHD, "MAKHO", true));
            this.txtMaKho.Location = new System.Drawing.Point(97, 83);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(100, 20);
            this.txtMaKho.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHD, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(576, 24);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 5;
            // 
            // nGAYLAPDateEdit
            // 
            this.nGAYLAPDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHD, "NGAYLAP", true));
            this.nGAYLAPDateEdit.EditValue = null;
            this.nGAYLAPDateEdit.Location = new System.Drawing.Point(348, 24);
            this.nGAYLAPDateEdit.MenuManager = this.barManager1;
            this.nGAYLAPDateEdit.Name = "nGAYLAPDateEdit";
            this.nGAYLAPDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYLAPDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYLAPDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.nGAYLAPDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.nGAYLAPDateEdit.Size = new System.Drawing.Size(100, 20);
            this.nGAYLAPDateEdit.TabIndex = 3;
            // 
            // txtSoHD
            // 
            this.txtSoHD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHD, "SOHD", true));
            this.txtSoHD.Location = new System.Drawing.Point(97, 24);
            this.txtSoHD.MenuManager = this.barManager1;
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(100, 20);
            this.txtSoHD.TabIndex = 1;
            // 
            // cT_HOADONGridControl
            // 
            this.cT_HOADONGridControl.DataSource = this.bdsCT_HD;
            this.cT_HOADONGridControl.Location = new System.Drawing.Point(824, 102);
            this.cT_HOADONGridControl.MainView = this.gridView2;
            this.cT_HOADONGridControl.MenuManager = this.barManager1;
            this.cT_HOADONGridControl.Name = "cT_HOADONGridControl";
            this.cT_HOADONGridControl.Size = new System.Drawing.Size(631, 220);
            this.cT_HOADONGridControl.TabIndex = 20;
            this.cT_HOADONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOHD1,
            this.colMAHH,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.cT_HOADONGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colSOHD1
            // 
            this.colSOHD1.FieldName = "SOHD";
            this.colSOHD1.Name = "colSOHD1";
            this.colSOHD1.Visible = true;
            this.colSOHD1.VisibleIndex = 0;
            // 
            // colMAHH
            // 
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.DisplayFormat.FormatString = "N0";
            this.colSOLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.DisplayFormat.FormatString = "N0";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(835, 364);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(141, 57);
            this.btnChiTiet.TabIndex = 21;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 562);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.cT_HOADONGridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcHD);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYLAPDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYLAPDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_HOADONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsHD;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.HOADONTableAdapter HOADONTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.CT_HOADONTableAdapter CT_HOADONTableAdapter;
        private System.Windows.Forms.BindingSource bdsCT_HD;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.DateEdit nGAYLAPDateEdit;
        private DevExpress.XtraEditors.TextEdit txtSoHD;
        private DevExpress.XtraGrid.GridControl gcHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOHD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.GridControl cT_HOADONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOHD1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.Button btnChiTiet;
    }
}