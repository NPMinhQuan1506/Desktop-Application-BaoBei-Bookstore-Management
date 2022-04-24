namespace QuanLyNhaSach_291021.View.Supplier
{
    partial class frmSupplierDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierDetail));
            this.pnHeader = new DevExpress.XtraEditors.PanelControl();
            this.lbClear = new DevExpress.XtraEditors.LabelControl();
            this.lbClose = new DevExpress.XtraEditors.LabelControl();
            this.pnFooter = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSupplierID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSupplierName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.mmeAddress = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.mmeNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaxCode = new DevExpress.XtraEditors.TextEdit();
            this.vali = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnFooter)).BeginInit();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vali)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lbClear);
            this.pnHeader.Controls.Add(this.lbClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.pnHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(499, 59);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
            // 
            // lbClear
            // 
            this.lbClear.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbClear.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.lbClear.Appearance.Options.UseFont = true;
            this.lbClear.Appearance.Options.UseForeColor = true;
            this.lbClear.Appearance.Options.UseTextOptions = true;
            this.lbClear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbClear.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbClear.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbClear.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbClear.ImageOptions.Image")));
            this.lbClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbClear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.lbClear.Location = new System.Drawing.Point(416, 12);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(30, 30);
            this.lbClear.TabIndex = 1;
            this.lbClear.Click += new System.EventHandler(this.lbClear_Click);
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
            this.lbClose.Location = new System.Drawing.Point(452, 12);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(30, 30);
            this.lbClose.TabIndex = 0;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btnCancel);
            this.pnFooter.Controls.Add(this.btnSave);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 501);
            this.pnFooter.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.pnFooter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(499, 83);
            this.pnFooter.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(336, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(69, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(16, 100);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplierID.Properties.Appearance.Options.UseFont = true;
            this.txtSupplierID.Properties.AutoHeight = false;
            this.txtSupplierID.Size = new System.Drawing.Size(253, 38);
            this.txtSupplierID.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mã NCC";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 21);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tên NCC";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(12, 175);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplierName.Properties.Appearance.Options.UseFont = true;
            this.txtSupplierName.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSupplierName.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.txtSupplierName.Properties.AutoHeight = false;
            this.txtSupplierName.Size = new System.Drawing.Size(470, 38);
            this.txtSupplierName.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(280, 218);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 21);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Điện Thoại";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(280, 247);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.AutoHeight = false;
            this.txtPhone.Properties.Mask.EditMask = "\\(\\d{3}\\)[0-9]{3}[0-9]{4}";
            this.txtPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPhone.Size = new System.Drawing.Size(202, 38);
            this.txtPhone.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 218);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 21);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEmail.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.txtEmail.Properties.AutoHeight = false;
            this.txtEmail.Properties.Mask.EditMask = "((((\\w+-*)|(-*\\w+))+\\.*((\\w+-*)|(-*\\w+))+)|(((\\w+-*)|(-*\\w+))+))+@((((\\w+-*)|(-*\\" +
    "w+))+\\.*((\\w+-*)|(-*\\w+))+)|(((\\w+-*)|(-*\\w+))+))+\\.[A-Za-z]+";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Size = new System.Drawing.Size(244, 38);
            this.txtEmail.TabIndex = 8;
            // 
            // mmeAddress
            // 
            this.mmeAddress.Location = new System.Drawing.Point(16, 326);
            this.mmeAddress.Name = "mmeAddress";
            this.mmeAddress.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mmeAddress.Properties.Appearance.Options.UseFont = true;
            this.mmeAddress.Size = new System.Drawing.Size(466, 57);
            this.mmeAddress.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(16, 299);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 21);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Địa Chỉ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(17, 395);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 21);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Ghi Chú";
            // 
            // mmeNote
            // 
            this.mmeNote.Location = new System.Drawing.Point(17, 422);
            this.mmeNote.Name = "mmeNote";
            this.mmeNote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mmeNote.Properties.Appearance.Options.UseFont = true;
            this.mmeNote.Size = new System.Drawing.Size(465, 60);
            this.mmeNote.TabIndex = 12;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(280, 73);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(89, 21);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Mã Số Thuế";
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(280, 100);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTaxCode.Properties.Appearance.Options.UseFont = true;
            this.txtTaxCode.Properties.AutoHeight = false;
            this.txtTaxCode.Size = new System.Drawing.Size(202, 38);
            this.txtTaxCode.TabIndex = 14;
            // 
            // frmSupplierDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 584);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtTaxCode);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.mmeNote);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.mmeAddress);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmSupplierDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Nhà Cung Cấp";
            this.Shown += new System.EventHandler(this.frmSupplierDetail_Shown);
            this.Resize += new System.EventHandler(this.frmSupplierDetail_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pnHeader)).EndInit();
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnFooter)).EndInit();
            this.pnFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnHeader;
        private DevExpress.XtraEditors.PanelControl pnFooter;
        private DevExpress.XtraEditors.LabelControl lbClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraEditors.LabelControl lbClear;
        private DevExpress.XtraEditors.TextEdit txtSupplierID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSupplierName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.MemoEdit mmeAddress;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit mmeNote;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtTaxCode;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vali;
    }
}