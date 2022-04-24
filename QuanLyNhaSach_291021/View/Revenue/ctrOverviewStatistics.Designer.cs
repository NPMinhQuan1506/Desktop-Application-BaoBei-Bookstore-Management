namespace QuanLyNhaSach_291021.View.Revenue
{
    partial class ctrOverviewStatistics
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnContainer = new DevExpress.XtraEditors.PanelControl();
            this.chartOverview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDateTo = new System.Windows.Forms.Label();
            this.lbDateFrom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnContainer)).BeginInit();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
            this.pnContainer.Appearance.Options.UseBackColor = true;
            this.pnContainer.Controls.Add(this.chartOverview);
            this.pnContainer.Controls.Add(this.panelControl1);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnContainer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(993, 655);
            this.pnContainer.TabIndex = 0;
            // 
            // chartOverview
            // 
            this.chartOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
            this.chartOverview.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chartOverview.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.chartOverview.ChartAreas.Add(chartArea1);
            this.chartOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartOverview.Legends.Add(legend1);
            this.chartOverview.Location = new System.Drawing.Point(2, 43);
            this.chartOverview.Name = "chartOverview";
            this.chartOverview.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.MidnightBlue;
            series1.Font = new System.Drawing.Font("Segoe UI", 10F);
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Maroon;
            series2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            series2.Legend = "Legend1";
            series2.Name = "Vốn";
            this.chartOverview.Series.Add(series1);
            this.chartOverview.Series.Add(series2);
            this.chartOverview.Size = new System.Drawing.Size(989, 610);
            this.chartOverview.TabIndex = 2;
            this.chartOverview.Text = "chart2";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            title1.Name = "ChartTitle";
            title1.Text = "Biểu Đồ Thống Kê Doanh Thu Theo Thời Gian";
            this.chartOverview.Titles.Add(title1);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.lbDateTo);
            this.panelControl1.Controls.Add(this.lbDateFrom);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(989, 41);
            this.panelControl1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(177, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ:";
            // 
            // lbDateTo
            // 
            this.lbDateTo.BackColor = System.Drawing.Color.Transparent;
            this.lbDateTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbDateTo.Location = new System.Drawing.Point(226, 7);
            this.lbDateTo.Name = "lbDateTo";
            this.lbDateTo.Size = new System.Drawing.Size(142, 25);
            this.lbDateTo.TabIndex = 1;
            this.lbDateTo.Text = "label1";
            // 
            // lbDateFrom
            // 
            this.lbDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.lbDateFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbDateFrom.Location = new System.Drawing.Point(51, 7);
            this.lbDateFrom.Name = "lbDateFrom";
            this.lbDateFrom.Size = new System.Drawing.Size(122, 25);
            this.lbDateFrom.TabIndex = 0;
            this.lbDateFrom.Text = "label1";
            // 
            // ctrOverviewStatistics
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.pnContainer);
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ctrOverviewStatistics";
            this.Size = new System.Drawing.Size(993, 655);
            this.Load += new System.EventHandler(this.ctrOverviewStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnContainer)).EndInit();
            this.pnContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOverview;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDateTo;
        private System.Windows.Forms.Label lbDateFrom;
    }
}
