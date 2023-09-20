
namespace QLVT
{
    partial class frmCT_PX
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
            System.Windows.Forms.Label mAHHLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCT_PX));
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
            this.DS = new QLVT.DS();
            this.bdsCT_HD = new System.Windows.Forms.BindingSource(this.components);
            this.cT_HOADONTableAdapter = new QLVT.DSTableAdapters.CT_HOADONTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.hANGHOATableAdapter = new QLVT.DSTableAdapters.HANGHOATableAdapter();
            this.gcCT_HD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsHH = new System.Windows.Forms.BindingSource(this.components);
            this.gcHH = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dONGIASpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtSL = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaHH = new DevExpress.XtraEditors.TextEdit();
            this.txtSoHD = new DevExpress.XtraEditors.TextEdit();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.btnTT = new System.Windows.Forms.Button();
            sOHDLabel = new System.Windows.Forms.Label();
            mAHHLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sOHDLabel
            // 
            sOHDLabel.AutoSize = true;
            sOHDLabel.Location = new System.Drawing.Point(39, 33);
            sOHDLabel.Name = "sOHDLabel";
            sOHDLabel.Size = new System.Drawing.Size(39, 13);
            sOHDLabel.TabIndex = 0;
            sOHDLabel.Text = "SOHD:";
            // 
            // mAHHLabel
            // 
            mAHHLabel.AutoSize = true;
            mAHHLabel.Location = new System.Drawing.Point(289, 33);
            mAHHLabel.Name = "mAHHLabel";
            mAHHLabel.Size = new System.Drawing.Size(40, 13);
            mAHHLabel.TabIndex = 2;
            mAHHLabel.Text = "MAHH:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(19, 84);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(59, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(278, 84);
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
            this.btnLuu,
            this.btnPhucHoi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
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
            this.btnLuu.Id = 1;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 2;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1251, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 516);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1251, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1251, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 492);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCT_HD
            // 
            this.bdsCT_HD.DataMember = "CT_HOADON";
            this.bdsCT_HD.DataSource = this.DS;
            // 
            // cT_HOADONTableAdapter
            // 
            this.cT_HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DONDHTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = this.cT_HOADONTableAdapter;
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
            // gcCT_HD
            // 
            this.gcCT_HD.DataSource = this.bdsCT_HD;
            this.gcCT_HD.Location = new System.Drawing.Point(0, 30);
            this.gcCT_HD.MainView = this.gridView1;
            this.gcCT_HD.MenuManager = this.barManager1;
            this.gcCT_HD.Name = "gcCT_HD";
            this.gcCT_HD.Size = new System.Drawing.Size(630, 220);
            this.gcCT_HD.TabIndex = 5;
            this.gcCT_HD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOHD,
            this.colMAHH,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView1.GridControl = this.gcCT_HD;
            this.gridView1.Name = "gridView1";
            // 
            // colSOHD
            // 
            this.colSOHD.FieldName = "SOHD";
            this.colSOHD.Name = "colSOHD";
            this.colSOHD.Visible = true;
            this.colSOHD.VisibleIndex = 0;
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
            // bdsHH
            // 
            this.bdsHH.DataMember = "HANGHOA";
            this.bdsHH.DataSource = this.DS;
            // 
            // gcHH
            // 
            this.gcHH.DataSource = this.bdsHH;
            this.gcHH.Location = new System.Drawing.Point(673, 30);
            this.gcHH.MainView = this.gridView2;
            this.gcHH.MenuManager = this.barManager1;
            this.gcHH.Name = "gcHH";
            this.gcHH.Size = new System.Drawing.Size(547, 220);
            this.gcHH.TabIndex = 5;
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(dONGIALabel);
            this.panelControl2.Controls.Add(this.dONGIASpinEdit);
            this.panelControl2.Controls.Add(sOLUONGLabel);
            this.panelControl2.Controls.Add(this.txtSL);
            this.panelControl2.Controls.Add(mAHHLabel);
            this.panelControl2.Controls.Add(this.txtMaHH);
            this.panelControl2.Controls.Add(sOHDLabel);
            this.panelControl2.Controls.Add(this.txtSoHD);
            this.panelControl2.Location = new System.Drawing.Point(0, 265);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(630, 224);
            this.panelControl2.TabIndex = 10;
            // 
            // dONGIASpinEdit
            // 
            this.dONGIASpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_HD, "DONGIA", true));
            this.dONGIASpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dONGIASpinEdit.Location = new System.Drawing.Point(335, 81);
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
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_HD, "SOLUONG", true));
            this.txtSL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSL.Location = new System.Drawing.Point(84, 81);
            this.txtSL.MenuManager = this.barManager1;
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSL.Properties.IsFloatValue = false;
            this.txtSL.Properties.Mask.EditMask = "N00";
            this.txtSL.Size = new System.Drawing.Size(100, 20);
            this.txtSL.TabIndex = 5;
            // 
            // txtMaHH
            // 
            this.txtMaHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_HD, "MAHH", true));
            this.txtMaHH.Location = new System.Drawing.Point(335, 30);
            this.txtMaHH.MenuManager = this.barManager1;
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(100, 20);
            this.txtMaHH.TabIndex = 3;
            // 
            // txtSoHD
            // 
            this.txtSoHD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_HD, "SOHD", true));
            this.txtSoHD.Location = new System.Drawing.Point(84, 30);
            this.txtSoHD.MenuManager = this.barManager1;
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(100, 20);
            this.txtSoHD.TabIndex = 1;
            // 
            // txtTT
            // 
            this.txtTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.Location = new System.Drawing.Point(856, 338);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(215, 29);
            this.txtTT.TabIndex = 18;
            // 
            // btnTT
            // 
            this.btnTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.Location = new System.Drawing.Point(688, 326);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(133, 54);
            this.btnTT.TabIndex = 17;
            this.btnTT.Text = "Tổng Tiền";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // frmCT_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 536);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcHH);
            this.Controls.Add(this.gcCT_HD);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCT_HD";
            this.Text = "frmCT_HD";
            this.Load += new System.EventHandler(this.frmCT_HD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private System.Windows.Forms.BindingSource bdsCT_HD;
        private DS DS;
        private DSTableAdapters.CT_HOADONTableAdapter cT_HOADONTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcCT_HD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOHD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DSTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.BindingSource bdsHH;
        private DevExpress.XtraGrid.GridControl gcHH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHH;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraGrid.Columns.GridColumn colMALHH;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SpinEdit dONGIASpinEdit;
        private DevExpress.XtraEditors.SpinEdit txtSL;
        private DevExpress.XtraEditors.TextEdit txtMaHH;
        private DevExpress.XtraEditors.TextEdit txtSoHD;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Button btnTT;
    }
}