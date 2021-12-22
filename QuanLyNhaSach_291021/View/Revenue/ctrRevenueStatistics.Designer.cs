namespace QuanLyNhaSach_291021.View.Revenue
{
    partial class ctrRevenueStatistics
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
            this.pnContainer = new DevExpress.XtraEditors.PanelControl();
            this.tbRevenue = new System.Windows.Forms.TabControl();
            this.tpOverview = new System.Windows.Forms.TabPage();
            this.tpDetail = new System.Windows.Forms.TabPage();
            this.dteFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dteTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbbCondition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pnHeader = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnContainer)).BeginInit();
            this.pnContainer.SuspendLayout();
            this.tbRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCondition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
            this.pnContainer.Appearance.Options.UseBackColor = true;
            this.pnContainer.Controls.Add(this.tbRevenue);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 147);
            this.pnContainer.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnContainer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(993, 508);
            this.pnContainer.TabIndex = 0;
            // 
            // tbRevenue
            // 
            this.tbRevenue.Controls.Add(this.tpOverview);
            this.tbRevenue.Controls.Add(this.tpDetail);
            this.tbRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRevenue.Location = new System.Drawing.Point(2, 2);
            this.tbRevenue.Name = "tbRevenue";
            this.tbRevenue.SelectedIndex = 0;
            this.tbRevenue.Size = new System.Drawing.Size(989, 504);
            this.tbRevenue.TabIndex = 0;
            this.tbRevenue.SelectedIndexChanged += new System.EventHandler(this.tbRevenue_SelectedIndexChanged);
            // 
            // tpOverview
            // 
            this.tpOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
            this.tpOverview.Location = new System.Drawing.Point(4, 34);
            this.tpOverview.Name = "tpOverview";
            this.tpOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverview.Size = new System.Drawing.Size(981, 466);
            this.tpOverview.TabIndex = 0;
            this.tpOverview.Text = "Tổng Quan";
            // 
            // tpDetail
            // 
            this.tpDetail.Location = new System.Drawing.Point(4, 34);
            this.tpDetail.Name = "tpDetail";
            this.tpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetail.Size = new System.Drawing.Size(981, 466);
            this.tpDetail.TabIndex = 1;
            this.tpDetail.Text = "Chi Tiết";
            this.tpDetail.UseVisualStyleBackColor = true;
            // 
            // dteFrom
            // 
            this.dteFrom.EditValue = new System.DateTime(2021, 12, 21, 23, 36, 10, 155);
            this.dteFrom.Location = new System.Drawing.Point(121, 56);
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
            this.dteFrom.Size = new System.Drawing.Size(304, 33);
            this.dteFrom.TabIndex = 61;
            this.dteFrom.EditValueChanged += new System.EventHandler(this.dteFrom_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 19);
            this.labelControl2.TabIndex = 62;
            this.labelControl2.Text = "Từ Ngày";
            // 
            // dteTo
            // 
            this.dteTo.EditValue = new System.DateTime(2021, 12, 21, 23, 36, 26, 228);
            this.dteTo.Location = new System.Drawing.Point(585, 56);
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
            this.dteTo.Size = new System.Drawing.Size(287, 33);
            this.dteTo.TabIndex = 63;
            this.dteTo.EditValueChanged += new System.EventHandler(this.dteTo_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(475, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 19);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "Đến Ngày";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnFilter.Location = new System.Drawing.Point(21, 98);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(66, 36);
            this.btnFilter.TabIndex = 59;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbbCondition
            // 
            this.cbbCondition.EditValue = "Báo Cáo Theo Ngày";
            this.cbbCondition.Location = new System.Drawing.Point(121, 11);
            this.cbbCondition.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbCondition.Name = "cbbCondition";
            this.cbbCondition.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.cbbCondition.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbCondition.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbCondition.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbCondition.Properties.Appearance.Options.UseBackColor = true;
            this.cbbCondition.Properties.Appearance.Options.UseBorderColor = true;
            this.cbbCondition.Properties.Appearance.Options.UseFont = true;
            this.cbbCondition.Properties.Appearance.Options.UseForeColor = true;
            this.cbbCondition.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbCondition.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbCondition.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbbCondition.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.cbbCondition.Properties.AppearanceFocused.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCondition.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbCondition.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbCondition.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.cbbCondition.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCondition.Properties.AppearanceItemHighlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbCondition.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.cbbCondition.Properties.AppearanceItemHighlight.Options.UseForeColor = true;
            this.cbbCondition.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbCondition.Properties.AppearanceItemSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbCondition.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.cbbCondition.Properties.AppearanceItemSelected.Options.UseForeColor = true;
            this.cbbCondition.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.cbbCondition.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbCondition.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbCondition.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.cbbCondition.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.cbbCondition.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.cbbCondition.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbbCondition.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.cbbCondition.Properties.AutoHeight = false;
            this.cbbCondition.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cbbCondition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbCondition.Properties.Items.AddRange(new object[] {
            "Báo Cáo Theo Ngày",
            "Báo Cáo Theo Tháng"});
            this.cbbCondition.Properties.ReadOnly = true;
            this.cbbCondition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbCondition.Size = new System.Drawing.Size(304, 35);
            this.cbbCondition.TabIndex = 60;
            this.cbbCondition.SelectedIndexChanged += new System.EventHandler(this.cbbCondition_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 19);
            this.labelControl3.TabIndex = 65;
            this.labelControl3.Text = "Loại Thời Gian";
            // 
            // pnHeader
            // 
            this.pnHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pnHeader.Appearance.Options.UseBackColor = true;
            this.pnHeader.Controls.Add(this.labelControl3);
            this.pnHeader.Controls.Add(this.cbbCondition);
            this.pnHeader.Controls.Add(this.btnFilter);
            this.pnHeader.Controls.Add(this.labelControl1);
            this.pnHeader.Controls.Add(this.dteTo);
            this.pnHeader.Controls.Add(this.labelControl2);
            this.pnHeader.Controls.Add(this.dteFrom);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
            this.pnHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(993, 147);
            this.pnHeader.TabIndex = 48;
            // 
            // ctrRevenueStatistics
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.pnHeader);
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ctrRevenueStatistics";
            this.Size = new System.Drawing.Size(993, 655);
            this.Load += new System.EventHandler(this.ctrRevenueStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnContainer)).EndInit();
            this.pnContainer.ResumeLayout(false);
            this.tbRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCondition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnContainer;
        private DevExpress.XtraEditors.DateEdit dteFrom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dteTo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnFilter;
        private DevExpress.XtraEditors.ComboBoxEdit cbbCondition;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl pnHeader;
        private System.Windows.Forms.TabControl tbRevenue;
        private System.Windows.Forms.TabPage tpOverview;
        private System.Windows.Forms.TabPage tpDetail;
    }
}
