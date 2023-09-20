
namespace QLVT
{
    partial class frmCT_DDH
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
            System.Windows.Forms.Label mADDHLabel;
            System.Windows.Forms.Label mAHHLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCT_DDH));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLVT.DS();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.hANGHOATableAdapter = new QLVT.DSTableAdapters.HANGHOATableAdapter();
            this.bdsHH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCT_DDH = new System.Windows.Forms.BindingSource(this.components);
            this.btnTT = new System.Windows.Forms.Button();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.cT_DONDHTableAdapter = new QLVT.DSTableAdapters.CT_DONDHTableAdapter();
            this.gcCT_DDH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dONGIASpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sOLUONGSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaHH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDDH = new DevExpress.XtraEditors.TextEdit();
            this.gcHH = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALHH = new DevExpress.XtraGrid.Columns.GridColumn();
            mADDHLabel = new System.Windows.Forms.Label();
            mAHHLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mADDHLabel
            // 
            mADDHLabel.AutoSize = true;
            mADDHLabel.Location = new System.Drawing.Point(44, 35);
            mADDHLabel.Name = "mADDHLabel";
            mADDHLabel.Size = new System.Drawing.Size(47, 13);
            mADDHLabel.TabIndex = 0;
            mADDHLabel.Text = "MADDH:";
            // 
            // mAHHLabel
            // 
            mAHHLabel.AutoSize = true;
            mAHHLabel.Location = new System.Drawing.Point(293, 35);
            mAHHLabel.Name = "mAHHLabel";
            mAHHLabel.Size = new System.Drawing.Size(40, 13);
            mAHHLabel.TabIndex = 2;
            mAHHLabel.Text = "MAHH:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(32, 97);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(59, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(282, 97);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(51, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
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
            this.btnXoa,
            this.btnPhucHoi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi)});
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
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1173, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 591);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1173, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 567);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1173, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 567);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DONDHTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.DONDHTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = this.hANGHOATableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // bdsHH
            // 
            this.bdsHH.DataMember = "HANGHOA";
            this.bdsHH.DataSource = this.DS;
            // 
            // bdsCT_DDH
            // 
            this.bdsCT_DDH.DataMember = "CT_DONDH";
            this.bdsCT_DDH.DataSource = this.DS;
            // 
            // btnTT
            // 
            this.btnTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.Location = new System.Drawing.Point(674, 393);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(133, 54);
            this.btnTT.TabIndex = 15;
            this.btnTT.Text = "Tổng Tiền";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // txtTT
            // 
            this.txtTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.Location = new System.Drawing.Point(842, 405);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(215, 29);
            this.txtTT.TabIndex = 16;
            // 
            // cT_DONDHTableAdapter
            // 
            this.cT_DONDHTableAdapter.ClearBeforeFill = true;
            // 
            // gcCT_DDH
            // 
            this.gcCT_DDH.DataSource = this.bdsCT_DDH;
            this.gcCT_DDH.Location = new System.Drawing.Point(0, 30);
            this.gcCT_DDH.MainView = this.gridView1;
            this.gcCT_DDH.MenuManager = this.barManager1;
            this.gcCT_DDH.Name = "gcCT_DDH";
            this.gcCT_DDH.Size = new System.Drawing.Size(580, 260);
            this.gcCT_DDH.TabIndex = 28;
            this.gcCT_DDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADDH,
            this.colMAHH,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView1.GridControl = this.gcCT_DDH;
            this.gridView1.Name = "gridView1";
            // 
            // colMADDH
            // 
            this.colMADDH.FieldName = "MADDH";
            this.colMADDH.Name = "colMADDH";
            this.colMADDH.Visible = true;
            this.colMADDH.VisibleIndex = 0;
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(dONGIALabel);
            this.panelControl2.Controls.Add(this.dONGIASpinEdit);
            this.panelControl2.Controls.Add(sOLUONGLabel);
            this.panelControl2.Controls.Add(this.sOLUONGSpinEdit);
            this.panelControl2.Controls.Add(mAHHLabel);
            this.panelControl2.Controls.Add(this.txtMaHH);
            this.panelControl2.Controls.Add(mADDHLabel);
            this.panelControl2.Controls.Add(this.txtMaDDH);
            this.panelControl2.Location = new System.Drawing.Point(0, 296);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(580, 275);
            this.panelControl2.TabIndex = 29;
            // 
            // dONGIASpinEdit
            // 
            this.dONGIASpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_DDH, "DONGIA", true));
            this.dONGIASpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dONGIASpinEdit.Location = new System.Drawing.Point(339, 94);
            this.dONGIASpinEdit.MenuManager = this.barManager1;
            this.dONGIASpinEdit.Name = "dONGIASpinEdit";
            this.dONGIASpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dONGIASpinEdit.Properties.DisplayFormat.FormatString = "N0";
            this.dONGIASpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dONGIASpinEdit.Properties.IsFloatValue = false;
            this.dONGIASpinEdit.Properties.Mask.EditMask = "N00";
            this.dONGIASpinEdit.Size = new System.Drawing.Size(100, 20);
            this.dONGIASpinEdit.TabIndex = 7;
            // 
            // sOLUONGSpinEdit
            // 
            this.sOLUONGSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_DDH, "SOLUONG", true));
            this.sOLUONGSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOLUONGSpinEdit.Location = new System.Drawing.Point(97, 94);
            this.sOLUONGSpinEdit.MenuManager = this.barManager1;
            this.sOLUONGSpinEdit.Name = "sOLUONGSpinEdit";
            this.sOLUONGSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOLUONGSpinEdit.Properties.IsFloatValue = false;
            this.sOLUONGSpinEdit.Properties.Mask.EditMask = "N00";
            this.sOLUONGSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.sOLUONGSpinEdit.TabIndex = 5;
            // 
            // txtMaHH
            // 
            this.txtMaHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_DDH, "MAHH", true));
            this.txtMaHH.Location = new System.Drawing.Point(339, 32);
            this.txtMaHH.MenuManager = this.barManager1;
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(100, 20);
            this.txtMaHH.TabIndex = 3;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_DDH, "MADDH", true));
            this.txtMaDDH.Location = new System.Drawing.Point(97, 32);
            this.txtMaDDH.MenuManager = this.barManager1;
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(100, 20);
            this.txtMaDDH.TabIndex = 1;
            // 
            // gcHH
            // 
            this.gcHH.DataSource = this.bdsHH;
            this.gcHH.Location = new System.Drawing.Point(649, 30);
            this.gcHH.MainView = this.gridView2;
            this.gcHH.MenuManager = this.barManager1;
            this.gcHH.Name = "gcHH";
            this.gcHH.Size = new System.Drawing.Size(524, 260);
            this.gcHH.TabIndex = 33;
            this.gcHH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH1,
            this.colTENHH,
            this.colDVT,
            this.colSOLUONGTON,
            this.colMALHH});
            this.gridView2.GridControl = this.gcHH;
            this.gridView2.Name = "gridView2";
            // 
            // colMAHH1
            // 
            this.colMAHH1.FieldName = "MAHH";
            this.colMAHH1.Name = "colMAHH1";
            this.colMAHH1.Visible = true;
            this.colMAHH1.VisibleIndex = 0;
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
            // frmCT_DDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 611);
            this.Controls.Add(this.gcHH);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcCT_DDH);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCT_DDH";
            this.Text = "frmCT_DDH";
            this.Load += new System.EventHandler(this.frmCT_DDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHH)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.BindingSource bdsHH;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.TextBox txtTT;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private System.Windows.Forms.BindingSource bdsCT_DDH;
        private DSTableAdapters.CT_DONDHTableAdapter cT_DONDHTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SpinEdit dONGIASpinEdit;
        private DevExpress.XtraEditors.SpinEdit sOLUONGSpinEdit;
        private DevExpress.XtraEditors.TextEdit txtMaHH;
        private DevExpress.XtraEditors.TextEdit txtMaDDH;
        private DevExpress.XtraGrid.GridControl gcCT_DDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.GridControl gcHH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHH;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraGrid.Columns.GridColumn colMALHH;
    }
}