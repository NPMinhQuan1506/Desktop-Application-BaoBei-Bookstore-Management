namespace QuanLyNhaSach_291021.View.Revenue
{
    partial class ctrDetailStatistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrDetailStatistics));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.CapitalOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscountOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RevenueOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRevenue = new DevExpress.XtraGrid.GridControl();
            this.gvRevenue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dteDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.TotalSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Capital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Revenue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Profit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProfitPercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.pnHeader = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExport = new DevExpress.XtraEditors.ButtonEdit();
            this.btnPrint = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDateFrom = new System.Windows.Forms.Label();
            this.lbDateTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDetail
            // 
            this.gvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrderID,
            this.TotalOrder,
            this.CapitalOrder,
            this.DiscountOrder,
            this.RevenueOrder,
            this.colOrderDate});
            this.gvDetail.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvDetail.GridControl = this.gcRevenue;
            this.gvDetail.HorzScrollStep = 1;
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvDetail.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvDetail.OptionsView.EnableAppearanceOddRow = true;
            this.gvDetail.OptionsView.RowAutoHeight = true;
            this.gvDetail.OptionsView.ShowGroupPanel = false;
            this.gvDetail.OptionsView.ShowIndicator = false;
            this.gvDetail.ViewCaption = "Chi Tiết";
            // 
            // OrderID
            // 
            this.OrderID.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OrderID.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.OrderID.AppearanceCell.Options.UseFont = true;
            this.OrderID.AppearanceCell.Options.UseForeColor = true;
            this.OrderID.AppearanceCell.Options.UseTextOptions = true;
            this.OrderID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.OrderID.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.OrderID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.OrderID.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.OrderID.AppearanceHeader.Options.UseFont = true;
            this.OrderID.AppearanceHeader.Options.UseForeColor = true;
            this.OrderID.AppearanceHeader.Options.UseTextOptions = true;
            this.OrderID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.OrderID.Caption = "Mã Hóa Đơn";
            this.OrderID.FieldName = "MaHD";
            this.OrderID.MinWidth = 250;
            this.OrderID.Name = "OrderID";
            this.OrderID.OptionsColumn.AllowEdit = false;
            this.OrderID.OptionsColumn.AllowFocus = false;
            this.OrderID.OptionsColumn.AllowMove = false;
            this.OrderID.OptionsColumn.AllowSize = false;
            this.OrderID.Visible = true;
            this.OrderID.VisibleIndex = 0;
            this.OrderID.Width = 250;
            // 
            // TotalOrder
            // 
            this.TotalOrder.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TotalOrder.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.TotalOrder.AppearanceCell.Options.UseFont = true;
            this.TotalOrder.AppearanceCell.Options.UseForeColor = true;
            this.TotalOrder.AppearanceCell.Options.UseTextOptions = true;
            this.TotalOrder.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TotalOrder.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TotalOrder.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TotalOrder.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.TotalOrder.AppearanceHeader.Options.UseFont = true;
            this.TotalOrder.AppearanceHeader.Options.UseForeColor = true;
            this.TotalOrder.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalOrder.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TotalOrder.Caption = "Tổng Tiền";
            this.TotalOrder.ColumnEdit = this.repositoryItemSpinEdit1;
            this.TotalOrder.FieldName = "TongTien";
            this.TotalOrder.MinWidth = 150;
            this.TotalOrder.Name = "TotalOrder";
            this.TotalOrder.OptionsColumn.AllowEdit = false;
            this.TotalOrder.OptionsColumn.AllowFocus = false;
            this.TotalOrder.OptionsColumn.AllowMove = false;
            this.TotalOrder.OptionsColumn.AllowSize = false;
            this.TotalOrder.Visible = true;
            this.TotalOrder.VisibleIndex = 1;
            this.TotalOrder.Width = 150;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "n0";
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Mask.EditMask = "n0";
            this.repositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // CapitalOrder
            // 
            this.CapitalOrder.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CapitalOrder.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.CapitalOrder.AppearanceCell.Options.UseFont = true;
            this.CapitalOrder.AppearanceCell.Options.UseForeColor = true;
            this.CapitalOrder.AppearanceCell.Options.UseTextOptions = true;
            this.CapitalOrder.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CapitalOrder.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CapitalOrder.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.CapitalOrder.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.CapitalOrder.AppearanceHeader.Options.UseFont = true;
            this.CapitalOrder.AppearanceHeader.Options.UseForeColor = true;
            this.CapitalOrder.AppearanceHeader.Options.UseTextOptions = true;
            this.CapitalOrder.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CapitalOrder.Caption = "Vốn";
            this.CapitalOrder.ColumnEdit = this.repositoryItemSpinEdit1;
            this.CapitalOrder.FieldName = "Von";
            this.CapitalOrder.MinWidth = 180;
            this.CapitalOrder.Name = "CapitalOrder";
            this.CapitalOrder.OptionsColumn.AllowEdit = false;
            this.CapitalOrder.OptionsColumn.AllowFocus = false;
            this.CapitalOrder.OptionsColumn.AllowMove = false;
            this.CapitalOrder.OptionsColumn.AllowSize = false;
            this.CapitalOrder.Visible = true;
            this.CapitalOrder.VisibleIndex = 2;
            this.CapitalOrder.Width = 180;
            // 
            // DiscountOrder
            // 
            this.DiscountOrder.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DiscountOrder.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.DiscountOrder.AppearanceCell.Options.UseFont = true;
            this.DiscountOrder.AppearanceCell.Options.UseForeColor = true;
            this.DiscountOrder.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DiscountOrder.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.DiscountOrder.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.DiscountOrder.AppearanceHeader.Options.UseFont = true;
            this.DiscountOrder.AppearanceHeader.Options.UseForeColor = true;
            this.DiscountOrder.AppearanceHeader.Options.UseTextOptions = true;
            this.DiscountOrder.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DiscountOrder.Caption = "Giảm Giá";
            this.DiscountOrder.ColumnEdit = this.repositoryItemSpinEdit1;
            this.DiscountOrder.FieldName = "GiamGia";
            this.DiscountOrder.MinWidth = 180;
            this.DiscountOrder.Name = "DiscountOrder";
            this.DiscountOrder.OptionsColumn.AllowEdit = false;
            this.DiscountOrder.OptionsColumn.AllowFocus = false;
            this.DiscountOrder.OptionsColumn.AllowMove = false;
            this.DiscountOrder.OptionsColumn.AllowSize = false;
            this.DiscountOrder.Visible = true;
            this.DiscountOrder.VisibleIndex = 3;
            this.DiscountOrder.Width = 180;
            // 
            // RevenueOrder
            // 
            this.RevenueOrder.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RevenueOrder.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.RevenueOrder.AppearanceCell.Options.UseFont = true;
            this.RevenueOrder.AppearanceCell.Options.UseForeColor = true;
            this.RevenueOrder.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RevenueOrder.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.RevenueOrder.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.RevenueOrder.AppearanceHeader.Options.UseFont = true;
            this.RevenueOrder.AppearanceHeader.Options.UseForeColor = true;
            this.RevenueOrder.AppearanceHeader.Options.UseTextOptions = true;
            this.RevenueOrder.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RevenueOrder.Caption = "Lợi Nhuận (VNĐ)";
            this.RevenueOrder.ColumnEdit = this.repositoryItemSpinEdit1;
            this.RevenueOrder.FieldName = "LoiNhuan";
            this.RevenueOrder.MinWidth = 150;
            this.RevenueOrder.Name = "RevenueOrder";
            this.RevenueOrder.OptionsColumn.AllowEdit = false;
            this.RevenueOrder.OptionsColumn.AllowFocus = false;
            this.RevenueOrder.OptionsColumn.AllowMove = false;
            this.RevenueOrder.OptionsColumn.AllowSize = false;
            this.RevenueOrder.Visible = true;
            this.RevenueOrder.VisibleIndex = 4;
            this.RevenueOrder.Width = 150;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "NgayBan";
            this.colOrderDate.FieldName = "NgayBan";
            this.colOrderDate.Name = "colOrderDate";
            // 
            // gcRevenue
            // 
            this.gcRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gvDetail;
            gridLevelNode1.RelationName = "Detail";
            this.gcRevenue.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcRevenue.Location = new System.Drawing.Point(0, 53);
            this.gcRevenue.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.gcRevenue.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcRevenue.MainView = this.gvRevenue;
            this.gcRevenue.Name = "gcRevenue";
            this.gcRevenue.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dteDate,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2});
            this.gcRevenue.Size = new System.Drawing.Size(963, 481);
            this.gcRevenue.TabIndex = 1;
            this.gcRevenue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRevenue,
            this.gvDetail});
            this.gcRevenue.Load += new System.EventHandler(this.gcRevenue_Load);
            // 
            // gvRevenue
            // 
            this.gvRevenue.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.gvRevenue.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvRevenue.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvRevenue.Appearance.FocusedCell.Options.UseFont = true;
            this.gvRevenue.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvRevenue.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvRevenue.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvRevenue.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.gvRevenue.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvRevenue.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRevenue.Appearance.FocusedRow.Options.UseFont = true;
            this.gvRevenue.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gvRevenue.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvRevenue.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvRevenue.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(153)))));
            this.gvRevenue.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvRevenue.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gvRevenue.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvRevenue.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvRevenue.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvRevenue.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvRevenue.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvRevenue.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.gvRevenue.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvRevenue.Appearance.OddRow.Options.UseBackColor = true;
            this.gvRevenue.Appearance.OddRow.Options.UseFont = true;
            this.gvRevenue.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvRevenue.Appearance.Row.Options.UseFont = true;
            this.gvRevenue.Appearance.Row.Options.UseTextOptions = true;
            this.gvRevenue.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvRevenue.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.gvRevenue.AppearancePrint.OddRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvRevenue.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gvRevenue.AppearancePrint.OddRow.Options.UseFont = true;
            this.gvRevenue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NO,
            this.OrderDate,
            this.TotalSell,
            this.Capital,
            this.Revenue,
            this.Profit,
            this.ProfitPercentage});
            this.gvRevenue.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvRevenue.GridControl = this.gcRevenue;
            this.gvRevenue.HorzScrollStep = 1;
            this.gvRevenue.Name = "gvRevenue";
            this.gvRevenue.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvRevenue.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvRevenue.OptionsCustomization.AllowColumnMoving = false;
            this.gvRevenue.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvRevenue.OptionsView.EnableAppearanceOddRow = true;
            this.gvRevenue.OptionsView.RowAutoHeight = true;
            this.gvRevenue.OptionsView.ShowGroupPanel = false;
            this.gvRevenue.OptionsView.ShowIndicator = false;
            this.gvRevenue.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvRevenue_CustomDrawCell);
            this.gvRevenue.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvRevenue_RowCellStyle);
            this.gvRevenue.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvRevenue_MasterRowEmpty);
            this.gvRevenue.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvRevenue_MasterRowGetChildList);
            this.gvRevenue.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvRevenue_MasterRowGetRelationName);
            this.gvRevenue.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvRevenue_MasterRowGetRelationCount);
            this.gvRevenue.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvRevenue_CustomDrawEmptyForeground);
            // 
            // NO
            // 
            this.NO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NO.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.NO.AppearanceCell.Options.UseFont = true;
            this.NO.AppearanceCell.Options.UseForeColor = true;
            this.NO.AppearanceCell.Options.UseTextOptions = true;
            this.NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NO.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.NO.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NO.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.NO.AppearanceHeader.Options.UseFont = true;
            this.NO.AppearanceHeader.Options.UseForeColor = true;
            this.NO.AppearanceHeader.Options.UseTextOptions = true;
            this.NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.NO.Caption = "STT";
            this.NO.MaxWidth = 50;
            this.NO.MinWidth = 50;
            this.NO.Name = "NO";
            this.NO.OptionsColumn.AllowEdit = false;
            this.NO.OptionsColumn.AllowMove = false;
            this.NO.OptionsColumn.AllowSize = false;
            this.NO.Visible = true;
            this.NO.VisibleIndex = 0;
            this.NO.Width = 50;
            // 
            // OrderDate
            // 
            this.OrderDate.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OrderDate.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.OrderDate.AppearanceCell.Options.UseFont = true;
            this.OrderDate.AppearanceCell.Options.UseForeColor = true;
            this.OrderDate.AppearanceCell.Options.UseTextOptions = true;
            this.OrderDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.OrderDate.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.OrderDate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.OrderDate.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.OrderDate.AppearanceHeader.Options.UseFont = true;
            this.OrderDate.AppearanceHeader.Options.UseForeColor = true;
            this.OrderDate.AppearanceHeader.Options.UseTextOptions = true;
            this.OrderDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.OrderDate.Caption = "Ngày";
            this.OrderDate.ColumnEdit = this.dteDate;
            this.OrderDate.FieldName = "NgayBan";
            this.OrderDate.MinWidth = 160;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.OptionsColumn.AllowEdit = false;
            this.OrderDate.OptionsColumn.AllowFocus = false;
            this.OrderDate.OptionsColumn.AllowMove = false;
            this.OrderDate.OptionsColumn.AllowSize = false;
            this.OrderDate.Visible = true;
            this.OrderDate.VisibleIndex = 1;
            this.OrderDate.Width = 180;
            // 
            // dteDate
            // 
            this.dteDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDate.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDate.Mask.EditMask = "dd/MM/yyyy";
            this.dteDate.Mask.UseMaskAsDisplayFormat = true;
            this.dteDate.Name = "dteDate";
            // 
            // TotalSell
            // 
            this.TotalSell.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TotalSell.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.TotalSell.AppearanceCell.Options.UseFont = true;
            this.TotalSell.AppearanceCell.Options.UseForeColor = true;
            this.TotalSell.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TotalSell.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TotalSell.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.TotalSell.AppearanceHeader.Options.UseFont = true;
            this.TotalSell.AppearanceHeader.Options.UseForeColor = true;
            this.TotalSell.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalSell.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TotalSell.Caption = "Bán Hàng (VNĐ)";
            this.TotalSell.ColumnEdit = this.repositoryItemSpinEdit1;
            this.TotalSell.DisplayFormat.FormatString = "n0";
            this.TotalSell.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalSell.FieldName = "BanHang";
            this.TotalSell.MinWidth = 150;
            this.TotalSell.Name = "TotalSell";
            this.TotalSell.OptionsColumn.AllowEdit = false;
            this.TotalSell.OptionsColumn.AllowFocus = false;
            this.TotalSell.OptionsColumn.AllowMove = false;
            this.TotalSell.OptionsColumn.AllowSize = false;
            this.TotalSell.Visible = true;
            this.TotalSell.VisibleIndex = 2;
            this.TotalSell.Width = 150;
            // 
            // Capital
            // 
            this.Capital.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Capital.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Capital.AppearanceCell.Options.UseFont = true;
            this.Capital.AppearanceCell.Options.UseForeColor = true;
            this.Capital.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Capital.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Capital.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Capital.AppearanceHeader.Options.UseFont = true;
            this.Capital.AppearanceHeader.Options.UseForeColor = true;
            this.Capital.AppearanceHeader.Options.UseTextOptions = true;
            this.Capital.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Capital.Caption = "Vốn (VNĐ)";
            this.Capital.ColumnEdit = this.repositoryItemSpinEdit1;
            this.Capital.FieldName = "Von";
            this.Capital.MinWidth = 150;
            this.Capital.Name = "Capital";
            this.Capital.OptionsColumn.AllowEdit = false;
            this.Capital.OptionsColumn.AllowFocus = false;
            this.Capital.OptionsColumn.AllowMove = false;
            this.Capital.OptionsColumn.AllowSize = false;
            this.Capital.Visible = true;
            this.Capital.VisibleIndex = 3;
            this.Capital.Width = 180;
            // 
            // Revenue
            // 
            this.Revenue.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Revenue.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Revenue.AppearanceCell.Options.UseFont = true;
            this.Revenue.AppearanceCell.Options.UseForeColor = true;
            this.Revenue.AppearanceCell.Options.UseTextOptions = true;
            this.Revenue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Revenue.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Revenue.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Revenue.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Revenue.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Revenue.AppearanceHeader.Options.UseFont = true;
            this.Revenue.AppearanceHeader.Options.UseForeColor = true;
            this.Revenue.AppearanceHeader.Options.UseTextOptions = true;
            this.Revenue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Revenue.Caption = "Doanh Thu (VNĐ)";
            this.Revenue.ColumnEdit = this.repositoryItemSpinEdit1;
            this.Revenue.FieldName = "DoanhThu";
            this.Revenue.MinWidth = 150;
            this.Revenue.Name = "Revenue";
            this.Revenue.OptionsColumn.AllowEdit = false;
            this.Revenue.OptionsColumn.AllowFocus = false;
            this.Revenue.OptionsColumn.AllowMove = false;
            this.Revenue.OptionsColumn.AllowSize = false;
            this.Revenue.Visible = true;
            this.Revenue.VisibleIndex = 4;
            this.Revenue.Width = 200;
            // 
            // Profit
            // 
            this.Profit.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Profit.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Profit.AppearanceCell.Options.UseFont = true;
            this.Profit.AppearanceCell.Options.UseForeColor = true;
            this.Profit.AppearanceCell.Options.UseTextOptions = true;
            this.Profit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Profit.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Profit.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Profit.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Profit.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Profit.AppearanceHeader.Options.UseFont = true;
            this.Profit.AppearanceHeader.Options.UseForeColor = true;
            this.Profit.AppearanceHeader.Options.UseTextOptions = true;
            this.Profit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Profit.Caption = "Lơi Nhuận (VNĐ)";
            this.Profit.ColumnEdit = this.repositoryItemSpinEdit1;
            this.Profit.FieldName = "LoiNhuan";
            this.Profit.MinWidth = 150;
            this.Profit.Name = "Profit";
            this.Profit.OptionsColumn.AllowEdit = false;
            this.Profit.OptionsColumn.AllowFocus = false;
            this.Profit.OptionsColumn.AllowMove = false;
            this.Profit.Visible = true;
            this.Profit.VisibleIndex = 5;
            this.Profit.Width = 150;
            // 
            // ProfitPercentage
            // 
            this.ProfitPercentage.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProfitPercentage.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ProfitPercentage.AppearanceCell.Options.UseFont = true;
            this.ProfitPercentage.AppearanceCell.Options.UseForeColor = true;
            this.ProfitPercentage.AppearanceCell.Options.UseTextOptions = true;
            this.ProfitPercentage.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ProfitPercentage.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ProfitPercentage.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ProfitPercentage.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ProfitPercentage.AppearanceHeader.Options.UseFont = true;
            this.ProfitPercentage.AppearanceHeader.Options.UseForeColor = true;
            this.ProfitPercentage.AppearanceHeader.Options.UseTextOptions = true;
            this.ProfitPercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ProfitPercentage.Caption = "Lợi Nhuận (%)";
            this.ProfitPercentage.ColumnEdit = this.repositoryItemSpinEdit2;
            this.ProfitPercentage.DisplayFormat.FormatString = "P2";
            this.ProfitPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ProfitPercentage.FieldName = "PhanTramLoiNhuan";
            this.ProfitPercentage.MinWidth = 150;
            this.ProfitPercentage.Name = "ProfitPercentage";
            this.ProfitPercentage.OptionsColumn.AllowEdit = false;
            this.ProfitPercentage.OptionsColumn.AllowFocus = false;
            this.ProfitPercentage.OptionsColumn.AllowMove = false;
            this.ProfitPercentage.OptionsColumn.AllowSize = false;
            this.ProfitPercentage.Visible = true;
            this.ProfitPercentage.VisibleIndex = 6;
            this.ProfitPercentage.Width = 150;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.EditFormat.FormatString = "P2";
            this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.Mask.EditMask = "P2";
            this.repositoryItemSpinEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // pnHeader
            // 
            this.pnHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.pnHeader.Appearance.Options.UseBackColor = true;
            this.pnHeader.Controls.Add(this.label2);
            this.pnHeader.Controls.Add(this.panelControl1);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.lbDateFrom);
            this.pnHeader.Controls.Add(this.lbDateTo);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.pnHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnHeader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(963, 53);
            this.pnHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(180, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến:";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(648, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(313, 49);
            this.panelControl1.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.EditValue = "Xuất Excel";
            this.btnExport.Location = new System.Drawing.Point(13, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.btnExport.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnExport.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExport.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnExport.Properties.Appearance.Options.UseBackColor = true;
            this.btnExport.Properties.Appearance.Options.UseBorderColor = true;
            this.btnExport.Properties.Appearance.Options.UseFont = true;
            this.btnExport.Properties.Appearance.Options.UseForeColor = true;
            this.btnExport.Properties.AutoHeight = false;
            this.btnExport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnExport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnExport.Properties.ReadOnly = true;
            this.btnExport.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnExport.Properties.UseReadOnlyAppearance = false;
            this.btnExport.Size = new System.Drawing.Size(136, 35);
            this.btnExport.TabIndex = 4;
            this.btnExport.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.EditValue = "In Báo Cáo";
            this.btnPrint.Location = new System.Drawing.Point(155, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.btnPrint.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnPrint.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnPrint.Properties.Appearance.Options.UseBackColor = true;
            this.btnPrint.Properties.Appearance.Options.UseBorderColor = true;
            this.btnPrint.Properties.Appearance.Options.UseFont = true;
            this.btnPrint.Properties.Appearance.Options.UseForeColor = true;
            this.btnPrint.Properties.AutoHeight = false;
            this.btnPrint.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.btnPrint.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnPrint.Properties.ReadOnly = true;
            this.btnPrint.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnPrint.Properties.UseReadOnlyAppearance = false;
            this.btnPrint.Size = new System.Drawing.Size(142, 35);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ:";
            // 
            // lbDateFrom
            // 
            this.lbDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.lbDateFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbDateFrom.Location = new System.Drawing.Point(54, 15);
            this.lbDateFrom.Name = "lbDateFrom";
            this.lbDateFrom.Size = new System.Drawing.Size(122, 25);
            this.lbDateFrom.TabIndex = 4;
            this.lbDateFrom.Text = "label1";
            // 
            // lbDateTo
            // 
            this.lbDateTo.BackColor = System.Drawing.Color.Transparent;
            this.lbDateTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbDateTo.Location = new System.Drawing.Point(229, 15);
            this.lbDateTo.Name = "lbDateTo";
            this.lbDateTo.Size = new System.Drawing.Size(142, 25);
            this.lbDateTo.TabIndex = 5;
            this.lbDateTo.Text = "label1";
            // 
            // ctrDetailStatistics
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.gcRevenue);
            this.Controls.Add(this.pnHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ctrDetailStatistics";
            this.Size = new System.Drawing.Size(963, 534);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).EndInit();
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnHeader;
        private DevExpress.XtraGrid.GridControl gcRevenue;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRevenue;
        private DevExpress.XtraGrid.Columns.GridColumn NO;
        private DevExpress.XtraGrid.Columns.GridColumn Revenue;
        private DevExpress.XtraGrid.Columns.GridColumn ProfitPercentage;
        private DevExpress.XtraGrid.Columns.GridColumn OrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn TotalSell;
        private DevExpress.XtraGrid.Columns.GridColumn Profit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dteDate;
        private DevExpress.XtraEditors.ButtonEdit btnPrint;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ButtonEdit btnExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetail;
        private DevExpress.XtraGrid.Columns.GridColumn OrderID;
        private DevExpress.XtraGrid.Columns.GridColumn CapitalOrder;
        private DevExpress.XtraGrid.Columns.GridColumn TotalOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn Capital;
        private DevExpress.XtraGrid.Columns.GridColumn DiscountOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDateFrom;
        private System.Windows.Forms.Label lbDateTo;
        private DevExpress.XtraGrid.Columns.GridColumn RevenueOrder;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
    }
}
