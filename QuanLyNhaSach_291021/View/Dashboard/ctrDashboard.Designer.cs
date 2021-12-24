namespace QuanLyNhaSach_291021.View.Dashboard
{
    partial class ctrDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrDashboard));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.pnHeader = new DevExpress.XtraEditors.PanelControl();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gcStock = new DevExpress.XtraGrid.GridControl();
            this.gvStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mmField = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.OrderAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.ImportAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeviantAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImpSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiffStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbField = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dteTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dteFrom = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(214)))), ((int)(((byte)(216)))));
            this.pnHeader.Appearance.Options.UseBackColor = true;
            this.pnHeader.Controls.Add(this.chartStock);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(214)))), ((int)(((byte)(216)))));
            this.pnHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnHeader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(993, 287);
            this.pnHeader.TabIndex = 0;
            // 
            // chartStock
            // 
            this.chartStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.chartStock.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartStock.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea1);
            this.chartStock.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartStock.Legends.Add(legend1);
            this.chartStock.Location = new System.Drawing.Point(2, 2);
            this.chartStock.Name = "chartStock";
            this.chartStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.MidnightBlue;
            series1.Font = new System.Drawing.Font("Segoe UI", 10F);
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            series1.Legend = "Legend1";
            series1.Name = "Số Lượng Bán";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.IndianRed;
            series2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            series2.Legend = "Legend1";
            series2.Name = "Số Lượng Nhập";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.SeaGreen;
            series3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            series3.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            series3.Legend = "Legend1";
            series3.Name = "Số Lượng Tồn";
            this.chartStock.Series.Add(series1);
            this.chartStock.Series.Add(series2);
            this.chartStock.Series.Add(series3);
            this.chartStock.Size = new System.Drawing.Size(989, 283);
            this.chartStock.TabIndex = 1;
            this.chartStock.Text = "chart2";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            title1.Name = "ChartTitle";
            title1.Text = "Biểu Đồ Thống Kê Hàng Tồn Trong 6 Tháng Gần Nhất";
            this.chartStock.Titles.Add(title1);
            // 
            // gcStock
            // 
            this.gcStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStock.Location = new System.Drawing.Point(169, 287);
            this.gcStock.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(214)))), ((int)(((byte)(216)))));
            this.gcStock.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcStock.MainView = this.gvStock;
            this.gcStock.Name = "gcStock";
            this.gcStock.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.mmField,
            this.btnDelete,
            this.spAmount,
            this.repositoryItemSpinEdit1});
            this.gcStock.Size = new System.Drawing.Size(824, 204);
            this.gcStock.TabIndex = 47;
            this.gcStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStock});
            this.gcStock.Load += new System.EventHandler(this.gcStock_Load);
            // 
            // gvStock
            // 
            this.gvStock.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvStock.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvStock.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvStock.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.gvStock.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvStock.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvStock.Appearance.FocusedRow.Options.UseFont = true;
            this.gvStock.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gvStock.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gvStock.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvStock.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gvStock.Appearance.FooterPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvStock.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gvStock.Appearance.FooterPanel.Options.UseFont = true;
            this.gvStock.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvStock.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvStock.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gvStock.Appearance.GroupFooter.Options.UseFont = true;
            this.gvStock.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvStock.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(153)))));
            this.gvStock.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvStock.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gvStock.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvStock.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvStock.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvStock.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvStock.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvStock.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.gvStock.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvStock.Appearance.OddRow.Options.UseBackColor = true;
            this.gvStock.Appearance.OddRow.Options.UseFont = true;
            this.gvStock.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvStock.Appearance.Row.Options.UseFont = true;
            this.gvStock.Appearance.Row.Options.UseTextOptions = true;
            this.gvStock.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvStock.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.gvStock.AppearancePrint.OddRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvStock.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gvStock.AppearancePrint.OddRow.Options.UseFont = true;
            this.gvStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NO,
            this.Product,
            this.OrderAmount,
            this.ImportAmount,
            this.StockAmount,
            this.DeviantAmount,
            this.ImpSKU,
            this.DiffStock});
            this.gvStock.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvStock.GridControl = this.gcStock;
            this.gvStock.HorzScrollStep = 1;
            this.gvStock.Name = "gvStock";
            this.gvStock.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvStock.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvStock.OptionsCustomization.AllowColumnMoving = false;
            this.gvStock.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvStock.OptionsView.EnableAppearanceOddRow = true;
            this.gvStock.OptionsView.ShowFooter = true;
            this.gvStock.OptionsView.ShowGroupPanel = false;
            this.gvStock.OptionsView.ShowIndicator = false;
            this.gvStock.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvStock_CustomDrawCell);
            this.gvStock.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvStock_RowCellStyle);
            this.gvStock.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvStock_CustomDrawEmptyForeground);
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
            this.NO.MaxWidth = 60;
            this.NO.MinWidth = 60;
            this.NO.Name = "NO";
            this.NO.OptionsColumn.AllowEdit = false;
            this.NO.OptionsColumn.AllowFocus = false;
            this.NO.OptionsColumn.AllowMove = false;
            this.NO.OptionsColumn.AllowSize = false;
            this.NO.Visible = true;
            this.NO.VisibleIndex = 0;
            this.NO.Width = 60;
            // 
            // Product
            // 
            this.Product.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Product.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Product.AppearanceCell.Options.UseFont = true;
            this.Product.AppearanceCell.Options.UseForeColor = true;
            this.Product.AppearanceCell.Options.UseTextOptions = true;
            this.Product.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Product.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Product.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Product.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Product.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Product.AppearanceHeader.Options.UseFont = true;
            this.Product.AppearanceHeader.Options.UseForeColor = true;
            this.Product.AppearanceHeader.Options.UseTextOptions = true;
            this.Product.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Product.Caption = "Sản Phẩm";
            this.Product.ColumnEdit = this.mmField;
            this.Product.FieldName = "TenSP";
            this.Product.MinWidth = 190;
            this.Product.Name = "Product";
            this.Product.OptionsColumn.AllowEdit = false;
            this.Product.OptionsColumn.AllowFocus = false;
            this.Product.OptionsColumn.AllowMove = false;
            this.Product.OptionsColumn.AllowSize = false;
            this.Product.Visible = true;
            this.Product.VisibleIndex = 1;
            this.Product.Width = 250;
            // 
            // mmField
            // 
            this.mmField.Name = "mmField";
            // 
            // OrderAmount
            // 
            this.OrderAmount.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OrderAmount.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.OrderAmount.AppearanceCell.Options.UseFont = true;
            this.OrderAmount.AppearanceCell.Options.UseForeColor = true;
            this.OrderAmount.AppearanceCell.Options.UseTextOptions = true;
            this.OrderAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.OrderAmount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.OrderAmount.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.OrderAmount.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.OrderAmount.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.OrderAmount.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.OrderAmount.AppearanceHeader.Options.UseFont = true;
            this.OrderAmount.AppearanceHeader.Options.UseForeColor = true;
            this.OrderAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.OrderAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.OrderAmount.Caption = "Số Lượng Bán";
            this.OrderAmount.ColumnEdit = this.spAmount;
            this.OrderAmount.DisplayFormat.FormatString = "N00";
            this.OrderAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.OrderAmount.FieldName = "SoLuongBan";
            this.OrderAmount.MinWidth = 150;
            this.OrderAmount.Name = "OrderAmount";
            this.OrderAmount.OptionsColumn.AllowEdit = false;
            this.OrderAmount.OptionsColumn.AllowFocus = false;
            this.OrderAmount.OptionsColumn.AllowMove = false;
            this.OrderAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongBan", "SUM={0:N00}")});
            this.OrderAmount.Visible = true;
            this.OrderAmount.VisibleIndex = 2;
            this.OrderAmount.Width = 150;
            // 
            // spAmount
            // 
            this.spAmount.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spAmount.Appearance.Options.UseFont = true;
            this.spAmount.Appearance.Options.UseTextOptions = true;
            this.spAmount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.spAmount.AppearanceFocused.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spAmount.AppearanceFocused.Options.UseFont = true;
            this.spAmount.AppearanceFocused.Options.UseTextOptions = true;
            this.spAmount.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.spAmount.AppearanceReadOnly.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spAmount.AppearanceReadOnly.Options.UseFont = true;
            this.spAmount.AppearanceReadOnly.Options.UseTextOptions = true;
            this.spAmount.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.spAmount.AutoHeight = false;
            this.spAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spAmount.IsFloatValue = false;
            this.spAmount.Mask.EditMask = "N00";
            this.spAmount.Mask.UseMaskAsDisplayFormat = true;
            this.spAmount.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.spAmount.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spAmount.Name = "spAmount";
            // 
            // ImportAmount
            // 
            this.ImportAmount.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ImportAmount.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ImportAmount.AppearanceCell.Options.UseFont = true;
            this.ImportAmount.AppearanceCell.Options.UseForeColor = true;
            this.ImportAmount.AppearanceCell.Options.UseTextOptions = true;
            this.ImportAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ImportAmount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ImportAmount.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ImportAmount.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ImportAmount.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ImportAmount.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ImportAmount.AppearanceHeader.Options.UseFont = true;
            this.ImportAmount.AppearanceHeader.Options.UseForeColor = true;
            this.ImportAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.ImportAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ImportAmount.Caption = "Số Lượng Nhập";
            this.ImportAmount.ColumnEdit = this.spAmount;
            this.ImportAmount.DisplayFormat.FormatString = "N00";
            this.ImportAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ImportAmount.FieldName = "SoLuongNhap";
            this.ImportAmount.MinWidth = 150;
            this.ImportAmount.Name = "ImportAmount";
            this.ImportAmount.OptionsColumn.AllowEdit = false;
            this.ImportAmount.OptionsColumn.AllowFocus = false;
            this.ImportAmount.OptionsColumn.AllowMove = false;
            this.ImportAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongNhap", "SUM={0:N00}")});
            this.ImportAmount.Visible = true;
            this.ImportAmount.VisibleIndex = 3;
            this.ImportAmount.Width = 150;
            // 
            // StockAmount
            // 
            this.StockAmount.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StockAmount.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.StockAmount.AppearanceCell.Options.UseFont = true;
            this.StockAmount.AppearanceCell.Options.UseForeColor = true;
            this.StockAmount.AppearanceCell.Options.UseTextOptions = true;
            this.StockAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.StockAmount.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.StockAmount.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.StockAmount.AppearanceHeader.Options.UseFont = true;
            this.StockAmount.Caption = "Số Lượng Tồn";
            this.StockAmount.ColumnEdit = this.spAmount;
            this.StockAmount.DisplayFormat.FormatString = "N00";
            this.StockAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.StockAmount.FieldName = "SoLuongTon";
            this.StockAmount.MinWidth = 150;
            this.StockAmount.Name = "StockAmount";
            this.StockAmount.OptionsColumn.AllowEdit = false;
            this.StockAmount.OptionsColumn.AllowFocus = false;
            this.StockAmount.OptionsColumn.AllowMove = false;
            this.StockAmount.OptionsColumn.AllowSize = false;
            this.StockAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongTon", "SUM={0:N00}")});
            this.StockAmount.Visible = true;
            this.StockAmount.VisibleIndex = 4;
            this.StockAmount.Width = 150;
            // 
            // DeviantAmount
            // 
            this.DeviantAmount.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeviantAmount.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.DeviantAmount.AppearanceCell.Options.UseFont = true;
            this.DeviantAmount.AppearanceCell.Options.UseForeColor = true;
            this.DeviantAmount.AppearanceCell.Options.UseTextOptions = true;
            this.DeviantAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.DeviantAmount.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DeviantAmount.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeviantAmount.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.DeviantAmount.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.DeviantAmount.AppearanceHeader.Options.UseFont = true;
            this.DeviantAmount.AppearanceHeader.Options.UseForeColor = true;
            this.DeviantAmount.Caption = "Chênh Lệch Thực Tế";
            this.DeviantAmount.ColumnEdit = this.spAmount;
            this.DeviantAmount.FieldName = "SoLuongChenhLech";
            this.DeviantAmount.MinWidth = 120;
            this.DeviantAmount.Name = "DeviantAmount";
            this.DeviantAmount.OptionsColumn.AllowEdit = false;
            this.DeviantAmount.OptionsColumn.AllowFocus = false;
            this.DeviantAmount.OptionsColumn.AllowMove = false;
            this.DeviantAmount.OptionsColumn.AllowSize = false;
            this.DeviantAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongChenhLech", "SUM={0:0.##}")});
            this.DeviantAmount.Visible = true;
            this.DeviantAmount.VisibleIndex = 5;
            this.DeviantAmount.Width = 120;
            // 
            // ImpSKU
            // 
            this.ImpSKU.Caption = "SKU";
            this.ImpSKU.FieldName = "SKU";
            this.ImpSKU.MinWidth = 37;
            this.ImpSKU.Name = "ImpSKU";
            this.ImpSKU.OptionsColumn.AllowEdit = false;
            this.ImpSKU.OptionsColumn.AllowFocus = false;
            this.ImpSKU.Width = 37;
            // 
            // DiffStock
            // 
            this.DiffStock.FieldName = "HieuSoTon";
            this.DiffStock.Name = "DiffStock";
            this.DiffStock.OptionsColumn.AllowEdit = false;
            this.DiffStock.OptionsColumn.AllowFocus = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Mask.EditMask = "n0";
            this.repositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(213)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.cbbField);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dteTo);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dteFrom);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 287);
            this.panelControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(169, 204);
            this.panelControl1.TabIndex = 48;
            // 
            // cbbField
            // 
            this.cbbField.EditValue = "Tất Cả Sản Phẩm";
            this.cbbField.Location = new System.Drawing.Point(12, 11);
            this.cbbField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbField.Name = "cbbField";
            this.cbbField.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.cbbField.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbField.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbField.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbField.Properties.Appearance.Options.UseBackColor = true;
            this.cbbField.Properties.Appearance.Options.UseBorderColor = true;
            this.cbbField.Properties.Appearance.Options.UseFont = true;
            this.cbbField.Properties.Appearance.Options.UseForeColor = true;
            this.cbbField.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbField.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbField.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbbField.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.cbbField.Properties.AppearanceFocused.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbField.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbField.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbField.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.cbbField.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbField.Properties.AppearanceItemHighlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbField.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.cbbField.Properties.AppearanceItemHighlight.Options.UseForeColor = true;
            this.cbbField.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbField.Properties.AppearanceItemSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbField.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.cbbField.Properties.AppearanceItemSelected.Options.UseForeColor = true;
            this.cbbField.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.cbbField.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbField.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbField.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbField.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.cbbField.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.cbbField.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbbField.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.cbbField.Properties.AutoHeight = false;
            this.cbbField.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cbbField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbField.Properties.Items.AddRange(new object[] {
            "Tất Cả Sản Phẩm",
            "Sản Phẩm Cần Nhập",
            "Top 10 Tồn Nhiều Nhất",
            "Top 10 Bán Nhiều Nhất",
            "Top 10 Bán Ít Nhất"});
            this.cbbField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbField.Size = new System.Drawing.Size(145, 30);
            this.cbbField.TabIndex = 60;
            this.cbbField.SelectedIndexChanged += new System.EventHandler(this.cbbField_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(51, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 36);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Lọc";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 114);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 19);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "Đến Ngày";
            // 
            // dteTo
            // 
            this.dteTo.EditValue = null;
            this.dteTo.Location = new System.Drawing.Point(12, 141);
            this.dteTo.Name = "dteTo";
            this.dteTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dteTo.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.dteTo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dteTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.dteTo.Properties.Appearance.Options.UseBackColor = true;
            this.dteTo.Properties.Appearance.Options.UseBorderColor = true;
            this.dteTo.Properties.Appearance.Options.UseFont = true;
            this.dteTo.Properties.Appearance.Options.UseForeColor = true;
            this.dteTo.Properties.AutoHeight = false;
            this.dteTo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dteTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTo.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteTo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteTo.Size = new System.Drawing.Size(149, 33);
            this.dteTo.TabIndex = 63;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 19);
            this.labelControl2.TabIndex = 62;
            this.labelControl2.Text = "Từ Ngày";
            // 
            // dteFrom
            // 
            this.dteFrom.EditValue = null;
            this.dteFrom.Location = new System.Drawing.Point(12, 75);
            this.dteFrom.Name = "dteFrom";
            this.dteFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dteFrom.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.dteFrom.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dteFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.dteFrom.Properties.Appearance.Options.UseBackColor = true;
            this.dteFrom.Properties.Appearance.Options.UseBorderColor = true;
            this.dteFrom.Properties.Appearance.Options.UseFont = true;
            this.dteFrom.Properties.Appearance.Options.UseForeColor = true;
            this.dteFrom.Properties.AutoHeight = false;
            this.dteFrom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dteFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFrom.Properties.CalendarTimeProperties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dteFrom.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteFrom.Size = new System.Drawing.Size(149, 33);
            this.dteFrom.TabIndex = 61;
            this.dteFrom.EditValueChanged += new System.EventHandler(this.dteFrom_EditValueChanged);
            // 
            // ctrDashboard
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.gcStock);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ctrDashboard";
            this.Size = new System.Drawing.Size(993, 491);
            this.Load += new System.EventHandler(this.ctrDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).EndInit();
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFrom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnHeader;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private DevExpress.XtraGrid.GridControl gcStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStock;
        private DevExpress.XtraGrid.Columns.GridColumn NO;
        private DevExpress.XtraGrid.Columns.GridColumn Product;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit mmField;
        private DevExpress.XtraGrid.Columns.GridColumn OrderAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spAmount;
        private DevExpress.XtraGrid.Columns.GridColumn ImportAmount;
        private DevExpress.XtraGrid.Columns.GridColumn StockAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ImpSKU;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn DeviantAmount;
        private DevExpress.XtraGrid.Columns.GridColumn DiffStock;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbbField;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dteTo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dteFrom;
    }
}
