namespace QuanLyNhaSach_291021.View.ThemeSetting
{
    partial class ctrThemeSetting
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
            this.tgThemeMode = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnHeader = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnContainer)).BeginInit();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgThemeMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.tgThemeMode);
            this.pnContainer.Controls.Add(this.labelControl2);
            this.pnContainer.Controls.Add(this.pnHeader);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(595, 525);
            this.pnContainer.TabIndex = 0;
            // 
            // tgThemeMode
            // 
            this.tgThemeMode.Location = new System.Drawing.Point(59, 150);
            this.tgThemeMode.Name = "tgThemeMode";
            this.tgThemeMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tgThemeMode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgThemeMode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.tgThemeMode.Properties.Appearance.Options.UseBackColor = true;
            this.tgThemeMode.Properties.Appearance.Options.UseFont = true;
            this.tgThemeMode.Properties.Appearance.Options.UseForeColor = true;
            this.tgThemeMode.Properties.AutoHeight = false;
            this.tgThemeMode.Properties.OffText = "Light";
            this.tgThemeMode.Properties.OnText = "Dark";
            this.tgThemeMode.Size = new System.Drawing.Size(135, 30);
            this.tgThemeMode.TabIndex = 8;
            this.tgThemeMode.Toggled += new System.EventHandler(this.tgThemeMode_Toggled);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(59, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(374, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tùy Chỉnh Giao Diện Của BaoBei Trên Thiết Bị Của Bạn";
            // 
            // pnHeader
            // 
            this.pnHeader.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.pnHeader.Appearance.Options.UseBorderColor = true;
            this.pnHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.pnHeader.Controls.Add(this.labelControl1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(2, 2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(591, 73);
            this.pnHeader.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(162, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thay Đổi Giao Diện";
            // 
            // ctrThemeSetting
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.pnContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ctrThemeSetting";
            this.Size = new System.Drawing.Size(595, 525);
            ((System.ComponentModel.ISupportInitialize)(this.pnContainer)).EndInit();
            this.pnContainer.ResumeLayout(false);
            this.pnContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgThemeMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnContainer;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl pnHeader;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch tgThemeMode;
    }
}
