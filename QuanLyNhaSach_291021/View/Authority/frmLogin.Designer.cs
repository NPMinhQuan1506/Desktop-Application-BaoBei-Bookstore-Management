namespace QuanLyNhaSach_291021.View.Authority
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnHeader = new DevExpress.XtraEditors.PanelControl();
            this.tgLoginMode = new DevExpress.XtraEditors.ToggleSwitch();
            this.lbTitle = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbClose = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccount = new DevExpress.XtraEditors.TextEdit();
            this.vali = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgLoginMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.pnHeader.Appearance.Options.UseBackColor = true;
            this.pnHeader.Controls.Add(this.tgLoginMode);
            this.pnHeader.Controls.Add(this.lbTitle);
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.labelControl1);
            this.pnHeader.Controls.Add(this.lbClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.pnHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(407, 257);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
            // 
            // tgLoginMode
            // 
            this.tgLoginMode.Location = new System.Drawing.Point(0, 8);
            this.tgLoginMode.Name = "tgLoginMode";
            this.tgLoginMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tgLoginMode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgLoginMode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.tgLoginMode.Properties.Appearance.Options.UseBackColor = true;
            this.tgLoginMode.Properties.Appearance.Options.UseFont = true;
            this.tgLoginMode.Properties.Appearance.Options.UseForeColor = true;
            this.tgLoginMode.Properties.AutoHeight = false;
            this.tgLoginMode.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.HotPink;
            this.tgLoginMode.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tgLoginMode.Properties.OffText = "USER";
            this.tgLoginMode.Properties.OnText = "ADMIN";
            this.tgLoginMode.Size = new System.Drawing.Size(135, 30);
            this.tgLoginMode.TabIndex = 7;
            this.tgLoginMode.Toggled += new System.EventHandler(this.tgLoginMode_Toggled);
            // 
            // lbTitle
            // 
            this.lbTitle.Appearance.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lbTitle.Appearance.Options.UseFont = true;
            this.lbTitle.Appearance.Options.UseForeColor = true;
            this.lbTitle.Appearance.Options.UseTextOptions = true;
            this.lbTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbTitle.AppearanceHovered.Options.UseTextOptions = true;
            this.lbTitle.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbTitle.AppearancePressed.Options.UseTextOptions = true;
            this.lbTitle.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbTitle.Location = new System.Drawing.Point(161, 217);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(89, 25);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLyNhaSach_291021.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(125, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 153);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(93, 28);
            this.labelControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.labelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(205, 196);
            this.labelControl1.TabIndex = 1;
            // 
            // lbClose
            // 
            this.lbClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbClose.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.lbClose.Appearance.Options.UseFont = true;
            this.lbClose.Appearance.Options.UseForeColor = true;
            this.lbClose.Appearance.Options.UseTextOptions = true;
            this.lbClose.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbClose.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbClose.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbClose.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbClose.ImageOptions.Image")));
            this.lbClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbClose.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.lbClose.Location = new System.Drawing.Point(352, 12);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(30, 30);
            this.lbClose.TabIndex = 0;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.btnLogin.Location = new System.Drawing.Point(135, 471);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 45);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 361);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật Khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 282);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 21);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tên Tài Khoản";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(29, 309);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtAccount.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAccount.Properties.Appearance.Options.UseBackColor = true;
            this.txtAccount.Properties.Appearance.Options.UseFont = true;
            this.txtAccount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAccount.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.txtAccount.Properties.AutoHeight = false;
            this.txtAccount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtAccount.Size = new System.Drawing.Size(355, 38);
            this.txtAccount.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(29, 401);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPassword.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.txtPassword.Properties.AutoHeight = false;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(355, 38);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 528);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Thể Loại";
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.Resize += new System.EventHandler(this.frmLogin_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).EndInit();
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tgLoginMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnHeader;
        private DevExpress.XtraEditors.LabelControl lbClose;
        private System.Windows.Forms.Button btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAccount;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vali;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.ToggleSwitch tgLoginMode;
        private DevExpress.XtraEditors.LabelControl lbTitle;
    }
}