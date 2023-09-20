
namespace QLVT
{
    partial class frmHangHoa
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
            System.Windows.Forms.Label mAHHLabel;
            System.Windows.Forms.Label tENHHLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.Windows.Forms.Label mALHHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
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
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLVT.DS();
            this.bdsHH = new System.Windows.Forms.BindingSource(this.components);
            this.HANGHOATableAdapter = new QLVT.DSTableAdapters.HANGHOATableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.CT_DONDHTableAdapter = new QLVT.DSTableAdapters.CT_DONDHTableAdapter();
            this.CT_HOADONTableAdapter = new QLVT.DSTableAdapters.CT_HOADONTableAdapter();
            this.CT_PHIEUNHAPTableAdapter = new QLVT.DSTableAdapters.CT_PHIEUNHAPTableAdapter();
            this.bdsCT_PN = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCT_HD = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCT_DONDH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLHH = new System.Windows.Forms.BindingSource(this.components);
            this.LOAIHANGHOATableAdapter = new QLVT.DSTableAdapters.LOAIHANGHOATableAdapter();
            this.gcHH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaLHH = new DevExpress.XtraEditors.TextEdit();
            this.sOLUONGTONSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENHHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHH = new DevExpress.XtraEditors.TextEdit();
            mAHHLabel = new System.Windows.Forms.Label();
            tENHHLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            mALHHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_PN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_DONDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTONSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENHHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAHHLabel
            // 
            mAHHLabel.AutoSize = true;
            mAHHLabel.Location = new System.Drawing.Point(47, 35);
            mAHHLabel.Name = "mAHHLabel";
            mAHHLabel.Size = new System.Drawing.Size(40, 13);
            mAHHLabel.TabIndex = 0;
            mAHHLabel.Text = "MAHH:";
            // 
            // tENHHLabel
            // 
            tENHHLabel.AutoSize = true;
            tENHHLabel.Location = new System.Drawing.Point(303, 35);
            tENHHLabel.Name = "tENHHLabel";
            tENHHLabel.Size = new System.Drawing.Size(44, 13);
            tENHHLabel.TabIndex = 2;
            tENHHLabel.Text = "TENHH:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(568, 35);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(30, 13);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "DVT:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(47, 103);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(80, 13);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "SOLUONGTON:";
            // 
            // mALHHLabel
            // 
            mALHHLabel.AutoSize = true;
            mALHHLabel.Location = new System.Drawing.Point(303, 103);
            mALHHLabel.Name = "mALHHLabel";
            mALHHLabel.Size = new System.Drawing.Size(45, 13);
            mALHHLabel.TabIndex = 8;
            mALHHLabel.Text = "MALHH:";
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
            this.barCheckItem1,
            this.btnHieuChinh,
            this.btnLuu,
            this.btnPhucHoi,
            this.btnXoa,
            this.btnTaiLai,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(74, 133);
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
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 5;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Caption = "Tải Lại";
            this.btnTaiLai.Id = 6;
            this.btnTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.Image")));
            this.btnTaiLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.LargeImage")));
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLai_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
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
            this.barDockControlTop.Size = new System.Drawing.Size(852, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 503);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(852, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 479);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(852, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 479);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 1;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cboChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(852, 65);
            this.panelControl1.TabIndex = 21;
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(162, 16);
            this.cboChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(398, 21);
            this.cboChiNhanh.TabIndex = 1;
            this.cboChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cboChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            // bdsHH
            // 
            this.bdsHH.DataMember = "HANGHOA";
            this.bdsHH.DataSource = this.DS;
            // 
            // HANGHOATableAdapter
            // 
            this.HANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DONDHTableAdapter = this.CT_DONDHTableAdapter;
            this.tableAdapterManager.CT_HOADONTableAdapter = this.CT_HOADONTableAdapter;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = this.CT_PHIEUNHAPTableAdapter;
            this.tableAdapterManager.DONDHTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = this.HANGHOATableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CT_DONDHTableAdapter
            // 
            this.CT_DONDHTableAdapter.ClearBeforeFill = true;
            // 
            // CT_HOADONTableAdapter
            // 
            this.CT_HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // CT_PHIEUNHAPTableAdapter
            // 
            this.CT_PHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCT_PN
            // 
            this.bdsCT_PN.DataMember = "FK_CT_PHIEUNHAP_HANGHOA";
            this.bdsCT_PN.DataSource = this.bdsHH;
            // 
            // bdsCT_HD
            // 
            this.bdsCT_HD.DataMember = "FK_CT_HOADON_HANGHOA";
            this.bdsCT_HD.DataSource = this.bdsHH;
            // 
            // bdsCT_DONDH
            // 
            this.bdsCT_DONDH.DataMember = "FK_CT_DONDH_HANGHOA";
            this.bdsCT_DONDH.DataSource = this.bdsHH;
            // 
            // bdsLHH
            // 
            this.bdsLHH.DataMember = "LOAIHANGHOA";
            this.bdsLHH.DataSource = this.DS;
            // 
            // LOAIHANGHOATableAdapter
            // 
            this.LOAIHANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // gcHH
            // 
            this.gcHH.DataSource = this.bdsHH;
            this.gcHH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHH.Location = new System.Drawing.Point(0, 89);
            this.gcHH.MainView = this.gridView1;
            this.gcHH.MenuManager = this.barManager1;
            this.gcHH.Name = "gcHH";
            this.gcHH.Size = new System.Drawing.Size(852, 220);
            this.gcHH.TabIndex = 27;
            this.gcHH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colTENHH,
            this.colDVT,
            this.colSOLUONGTON,
            this.colMALHH});
            this.gridView1.GridControl = this.gcHH;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHH
            // 
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 0;
            // 
            // colTENHH
            // 
            this.colTENHH.FieldName = "TENHH";
            this.colTENHH.Name = "colTENHH";
            this.colTENHH.Visible = true;
            this.colTENHH.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.DisplayFormat.FormatString = "N0";
            this.colSOLUONGTON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // colMALHH
            // 
            this.colMALHH.FieldName = "MALHH";
            this.colMALHH.Name = "colMALHH";
            this.colMALHH.Visible = true;
            this.colMALHH.VisibleIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(mALHHLabel);
            this.panelControl2.Controls.Add(this.txtMaLHH);
            this.panelControl2.Controls.Add(sOLUONGTONLabel);
            this.panelControl2.Controls.Add(this.sOLUONGTONSpinEdit);
            this.panelControl2.Controls.Add(dVTLabel);
            this.panelControl2.Controls.Add(this.dVTTextEdit);
            this.panelControl2.Controls.Add(tENHHLabel);
            this.panelControl2.Controls.Add(this.tENHHTextEdit);
            this.panelControl2.Controls.Add(mAHHLabel);
            this.panelControl2.Controls.Add(this.txtMaHH);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 309);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(852, 194);
            this.panelControl2.TabIndex = 28;
            // 
            // txtMaLHH
            // 
            this.txtMaLHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHH, "MALHH", true));
            this.txtMaLHH.Location = new System.Drawing.Point(354, 100);
            this.txtMaLHH.MenuManager = this.barManager1;
            this.txtMaLHH.Name = "txtMaLHH";
            this.txtMaLHH.Size = new System.Drawing.Size(100, 20);
            this.txtMaLHH.TabIndex = 9;
            // 
            // sOLUONGTONSpinEdit
            // 
            this.sOLUONGTONSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHH, "SOLUONGTON", true));
            this.sOLUONGTONSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOLUONGTONSpinEdit.Location = new System.Drawing.Point(133, 100);
            this.sOLUONGTONSpinEdit.MenuManager = this.barManager1;
            this.sOLUONGTONSpinEdit.Name = "sOLUONGTONSpinEdit";
            this.sOLUONGTONSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOLUONGTONSpinEdit.Properties.IsFloatValue = false;
            this.sOLUONGTONSpinEdit.Properties.Mask.EditMask = "N00";
            this.sOLUONGTONSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.sOLUONGTONSpinEdit.TabIndex = 7;
            // 
            // dVTTextEdit
            // 
            this.dVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHH, "DVT", true));
            this.dVTTextEdit.Location = new System.Drawing.Point(604, 32);
            this.dVTTextEdit.MenuManager = this.barManager1;
            this.dVTTextEdit.Name = "dVTTextEdit";
            this.dVTTextEdit.Size = new System.Drawing.Size(100, 20);
            this.dVTTextEdit.TabIndex = 5;
            // 
            // tENHHTextEdit
            // 
            this.tENHHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHH, "TENHH", true));
            this.tENHHTextEdit.Location = new System.Drawing.Point(353, 32);
            this.tENHHTextEdit.MenuManager = this.barManager1;
            this.tENHHTextEdit.Name = "tENHHTextEdit";
            this.tENHHTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENHHTextEdit.TabIndex = 3;
            // 
            // txtMaHH
            // 
            this.txtMaHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHH, "MAHH", true));
            this.txtMaHH.Location = new System.Drawing.Point(93, 32);
            this.txtMaHH.MenuManager = this.barManager1;
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(100, 20);
            this.txtMaHH.TabIndex = 1;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 523);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcHH);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHangHoa";
            this.Text = "frmHangHoa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_PN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_DONDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTONSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENHHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHH.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsHH;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DSTableAdapters.HANGHOATableAdapter HANGHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DSTableAdapters.CT_PHIEUNHAPTableAdapter CT_PHIEUNHAPTableAdapter;
        private System.Windows.Forms.BindingSource bdsCT_PN;
        private DSTableAdapters.CT_HOADONTableAdapter CT_HOADONTableAdapter;
        private System.Windows.Forms.BindingSource bdsCT_HD;
        private DSTableAdapters.CT_DONDHTableAdapter CT_DONDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCT_DONDH;
        private System.Windows.Forms.BindingSource bdsLHH;
        private DSTableAdapters.LOAIHANGHOATableAdapter LOAIHANGHOATableAdapter;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaLHH;
        private DevExpress.XtraEditors.SpinEdit sOLUONGTONSpinEdit;
        private DevExpress.XtraEditors.TextEdit dVTTextEdit;
        private DevExpress.XtraEditors.TextEdit tENHHTextEdit;
        private DevExpress.XtraEditors.TextEdit txtMaHH;
        private DevExpress.XtraGrid.GridControl gcHH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHH;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraGrid.Columns.GridColumn colMALHH;
    }
}