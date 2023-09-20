
namespace QLVT
{
    partial class frmCT_PN
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
            System.Windows.Forms.Label sOPNLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCT_PN));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new QLVT.DS();
            this.bdsCT_PN = new System.Windows.Forms.BindingSource(this.components);
            this.cT_PHIEUNHAPTableAdapter = new QLVT.DSTableAdapters.CT_PHIEUNHAPTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cT_DONDHTableAdapter = new QLVT.DSTableAdapters.CT_DONDHTableAdapter();
            this.bdsCT_DDH = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTTPN = new System.Windows.Forms.TextBox();
            this.txtTTDDH = new System.Windows.Forms.TextBox();
            this.btnTTPN = new System.Windows.Forms.Button();
            this.btnTTDDH = new System.Windows.Forms.Button();
            this.gcCT_PN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCT_DDH = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dONGIASpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtSL = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoPN = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHH = new DevExpress.XtraEditors.TextEdit();
            mAHHLabel = new System.Windows.Forms.Label();
            sOPNLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_PN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_PN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAHHLabel
            // 
            mAHHLabel.AutoSize = true;
            mAHHLabel.Location = new System.Drawing.Point(274, 36);
            mAHHLabel.Name = "mAHHLabel";
            mAHHLabel.Size = new System.Drawing.Size(40, 13);
            mAHHLabel.TabIndex = 0;
            mAHHLabel.Text = "MAHH:";
            // 
            // sOPNLabel
            // 
            sOPNLabel.AutoSize = true;
            sOPNLabel.Location = new System.Drawing.Point(44, 36);
            sOPNLabel.Name = "sOPNLabel";
            sOPNLabel.Size = new System.Drawing.Size(38, 13);
            sOPNLabel.TabIndex = 2;
            sOPNLabel.Text = "SOPN:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(23, 92);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(59, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(263, 92);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
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
            this.barDockControlTop.Size = new System.Drawing.Size(1222, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 564);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1222, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 540);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1222, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 540);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Id = 5;
            this.btnHieuChinh.Name = "btnHieuChinh";
            // 
            // btnXoa
            // 
            this.btnXoa.Id = 6;
            this.btnXoa.Name = "btnXoa";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCT_PN
            // 
            this.bdsCT_PN.DataMember = "CT_PHIEUNHAP";
            this.bdsCT_PN.DataSource = this.DS;
            // 
            // cT_PHIEUNHAPTableAdapter
            // 
            this.cT_PHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DONDHTableAdapter = this.cT_DONDHTableAdapter;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = this.cT_PHIEUNHAPTableAdapter;
            this.tableAdapterManager.DONDHTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_DONDHTableAdapter
            // 
            this.cT_DONDHTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCT_DDH
            // 
            this.bdsCT_DDH.DataMember = "CT_DONDH";
            this.bdsCT_DDH.DataSource = this.DS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHI TIẾT PHIẾU NHẬP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(823, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "CHI TIẾT ĐƠN ĐẶT HÀNG";
            // 
            // txtTTPN
            // 
            this.txtTTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTPN.Location = new System.Drawing.Point(659, 383);
            this.txtTTPN.Name = "txtTTPN";
            this.txtTTPN.Size = new System.Drawing.Size(155, 26);
            this.txtTTPN.TabIndex = 9;
            this.txtTTPN.TextChanged += new System.EventHandler(this.txtTTPN_TextChanged);
            // 
            // txtTTDDH
            // 
            this.txtTTDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTDDH.Location = new System.Drawing.Point(946, 383);
            this.txtTTDDH.Name = "txtTTDDH";
            this.txtTTDDH.Size = new System.Drawing.Size(155, 26);
            this.txtTTDDH.TabIndex = 10;
            // 
            // btnTTPN
            // 
            this.btnTTPN.Location = new System.Drawing.Point(659, 422);
            this.btnTTPN.Name = "btnTTPN";
            this.btnTTPN.Size = new System.Drawing.Size(155, 51);
            this.btnTTPN.TabIndex = 11;
            this.btnTTPN.Text = "Tổng tiền phiếu nhập";
            this.btnTTPN.UseVisualStyleBackColor = true;
            this.btnTTPN.Click += new System.EventHandler(this.btnTTPN_Click);
            // 
            // btnTTDDH
            // 
            this.btnTTDDH.Location = new System.Drawing.Point(946, 422);
            this.btnTTDDH.Name = "btnTTDDH";
            this.btnTTDDH.Size = new System.Drawing.Size(155, 51);
            this.btnTTDDH.TabIndex = 12;
            this.btnTTDDH.Text = "Tổng tiền đơn đặt hàng";
            this.btnTTDDH.UseVisualStyleBackColor = true;
            this.btnTTDDH.Click += new System.EventHandler(this.btnTTDDH_Click);
            // 
            // gcCT_PN
            // 
            this.gcCT_PN.DataSource = this.bdsCT_PN;
            this.gcCT_PN.Location = new System.Drawing.Point(0, 67);
            this.gcCT_PN.MainView = this.gridView1;
            this.gcCT_PN.MenuManager = this.barManager1;
            this.gcCT_PN.Name = "gcCT_PN";
            this.gcCT_PN.Size = new System.Drawing.Size(609, 244);
            this.gcCT_PN.TabIndex = 16;
            this.gcCT_PN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOPN,
            this.colMAHH,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView1.GridControl = this.gcCT_PN;
            this.gridView1.Name = "gridView1";
            // 
            // colSOPN
            // 
            this.colSOPN.FieldName = "SOPN";
            this.colSOPN.Name = "colSOPN";
            this.colSOPN.Visible = true;
            this.colSOPN.VisibleIndex = 0;
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
            // gcCT_DDH
            // 
            this.gcCT_DDH.DataSource = this.bdsCT_DDH;
            this.gcCT_DDH.Location = new System.Drawing.Point(683, 67);
            this.gcCT_DDH.MainView = this.gridView2;
            this.gcCT_DDH.MenuManager = this.barManager1;
            this.gcCT_DDH.Name = "gcCT_DDH";
            this.gcCT_DDH.Size = new System.Drawing.Size(527, 244);
            this.gcCT_DDH.TabIndex = 16;
            this.gcCT_DDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADDH,
            this.colMAHH1,
            this.colSOLUONG1,
            this.colDONGIA1});
            this.gridView2.GridControl = this.gcCT_DDH;
            this.gridView2.Name = "gridView2";
            // 
            // colMADDH
            // 
            this.colMADDH.FieldName = "MADDH";
            this.colMADDH.Name = "colMADDH";
            this.colMADDH.Visible = true;
            this.colMADDH.VisibleIndex = 0;
            // 
            // colMAHH1
            // 
            this.colMAHH1.FieldName = "MAHH";
            this.colMAHH1.Name = "colMAHH1";
            this.colMAHH1.Visible = true;
            this.colMAHH1.VisibleIndex = 1;
            // 
            // colSOLUONG1
            // 
            this.colSOLUONG1.DisplayFormat.FormatString = "N0";
            this.colSOLUONG1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOLUONG1.FieldName = "SOLUONG";
            this.colSOLUONG1.Name = "colSOLUONG1";
            this.colSOLUONG1.Visible = true;
            this.colSOLUONG1.VisibleIndex = 2;
            // 
            // colDONGIA1
            // 
            this.colDONGIA1.DisplayFormat.FormatString = "N0";
            this.colDONGIA1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDONGIA1.FieldName = "DONGIA";
            this.colDONGIA1.Name = "colDONGIA1";
            this.colDONGIA1.Visible = true;
            this.colDONGIA1.VisibleIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(dONGIALabel);
            this.panelControl2.Controls.Add(this.dONGIASpinEdit);
            this.panelControl2.Controls.Add(sOLUONGLabel);
            this.panelControl2.Controls.Add(this.txtSL);
            this.panelControl2.Controls.Add(sOPNLabel);
            this.panelControl2.Controls.Add(this.txtSoPN);
            this.panelControl2.Controls.Add(mAHHLabel);
            this.panelControl2.Controls.Add(this.txtMaHH);
            this.panelControl2.Location = new System.Drawing.Point(0, 317);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(609, 241);
            this.panelControl2.TabIndex = 17;
            // 
            // dONGIASpinEdit
            // 
            this.dONGIASpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_PN, "DONGIA", true));
            this.dONGIASpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dONGIASpinEdit.Location = new System.Drawing.Point(320, 89);
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
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_PN, "SOLUONG", true));
            this.txtSL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSL.Location = new System.Drawing.Point(88, 89);
            this.txtSL.MenuManager = this.barManager1;
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSL.Properties.IsFloatValue = false;
            this.txtSL.Properties.Mask.EditMask = "N00";
            this.txtSL.Size = new System.Drawing.Size(100, 20);
            this.txtSL.TabIndex = 5;
            // 
            // txtSoPN
            // 
            this.txtSoPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_PN, "SOPN", true));
            this.txtSoPN.Location = new System.Drawing.Point(88, 33);
            this.txtSoPN.MenuManager = this.barManager1;
            this.txtSoPN.Name = "txtSoPN";
            this.txtSoPN.Size = new System.Drawing.Size(100, 20);
            this.txtSoPN.TabIndex = 3;
            // 
            // txtMaHH
            // 
            this.txtMaHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_PN, "MAHH", true));
            this.txtMaHH.Location = new System.Drawing.Point(320, 33);
            this.txtMaHH.MenuManager = this.barManager1;
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(100, 20);
            this.txtMaHH.TabIndex = 1;
            // 
            // frmCT_PN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 584);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcCT_DDH);
            this.Controls.Add(this.gcCT_PN);
            this.Controls.Add(this.btnTTDDH);
            this.Controls.Add(this.btnTTPN);
            this.Controls.Add(this.txtTTDDH);
            this.Controls.Add(this.txtTTPN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCT_PN";
            this.Text = "frmCT_PN";
            this.Load += new System.EventHandler(this.frmCT_PN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_PN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_PN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPN.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsCT_PN;
        private DS DS;
        private DSTableAdapters.CT_PHIEUNHAPTableAdapter cT_PHIEUNHAPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.CT_DONDHTableAdapter cT_DONDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCT_DDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private System.Windows.Forms.Button btnTTDDH;
        private System.Windows.Forms.Button btnTTPN;
        private System.Windows.Forms.TextBox txtTTDDH;
        private System.Windows.Forms.TextBox txtTTPN;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SpinEdit dONGIASpinEdit;
        private DevExpress.XtraEditors.SpinEdit txtSL;
        private DevExpress.XtraEditors.TextEdit txtSoPN;
        private DevExpress.XtraEditors.TextEdit txtMaHH;
        private DevExpress.XtraGrid.GridControl gcCT_DDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMADDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA1;
        private DevExpress.XtraGrid.GridControl gcCT_PN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
    }
}