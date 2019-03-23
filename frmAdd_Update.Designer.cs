namespace PRN292_Group1_QLSvien
{
    partial class frmAdd_Update
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaKhoa = new MetroFramework.Controls.MetroTextBox();
            this.txtTen = new MetroFramework.Controls.MetroTextBox();
            this.txtHo = new MetroFramework.Controls.MetroTextBox();
            this.txtMaSV = new MetroFramework.Controls.MetroTextBox();
            this.lbGioiTinh = new MetroFramework.Controls.MetroLabel();
            this.lbMaKhoa = new MetroFramework.Controls.MetroLabel();
            this.lbTen = new MetroFramework.Controls.MetroLabel();
            this.lbNgaySinh = new MetroFramework.Controls.MetroLabel();
            this.lbMaSV = new MetroFramework.Controls.MetroLabel();
            this.lbHo = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.btnCheck = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.rdFemale);
            this.metroPanel1.Controls.Add(this.rdMale);
            this.metroPanel1.Controls.Add(this.txtNgaySinh);
            this.metroPanel1.Controls.Add(this.txtMaKhoa);
            this.metroPanel1.Controls.Add(this.txtTen);
            this.metroPanel1.Controls.Add(this.txtHo);
            this.metroPanel1.Controls.Add(this.txtMaSV);
            this.metroPanel1.Controls.Add(this.lbGioiTinh);
            this.metroPanel1.Controls.Add(this.lbMaKhoa);
            this.metroPanel1.Controls.Add(this.lbTen);
            this.metroPanel1.Controls.Add(this.lbNgaySinh);
            this.metroPanel1.Controls.Add(this.lbMaSV);
            this.metroPanel1.Controls.Add(this.lbHo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(21, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(338, 244);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(232, 174);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(59, 17);
            this.rdFemale.TabIndex = 13;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(101, 174);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 12;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaySinh.Location = new System.Drawing.Point(85, 135);
            this.txtNgaySinh.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.txtNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(232, 20);
            this.txtNgaySinh.TabIndex = 11;
            // 
            // txtMaKhoa
            // 
            // 
            // 
            // 
            this.txtMaKhoa.CustomButton.Image = null;
            this.txtMaKhoa.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtMaKhoa.CustomButton.Name = "";
            this.txtMaKhoa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaKhoa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaKhoa.CustomButton.TabIndex = 1;
            this.txtMaKhoa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaKhoa.CustomButton.UseSelectable = true;
            this.txtMaKhoa.CustomButton.Visible = false;
            this.txtMaKhoa.Lines = new string[0];
            this.txtMaKhoa.Location = new System.Drawing.Point(85, 209);
            this.txtMaKhoa.MaxLength = 32767;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.PasswordChar = '\0';
            this.txtMaKhoa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaKhoa.SelectedText = "";
            this.txtMaKhoa.SelectionLength = 0;
            this.txtMaKhoa.SelectionStart = 0;
            this.txtMaKhoa.ShortcutsEnabled = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(232, 23);
            this.txtMaKhoa.TabIndex = 11;
            this.txtMaKhoa.UseSelectable = true;
            this.txtMaKhoa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaKhoa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.CustomButton.Image = null;
            this.txtTen.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtTen.CustomButton.Name = "";
            this.txtTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTen.CustomButton.TabIndex = 1;
            this.txtTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTen.CustomButton.UseSelectable = true;
            this.txtTen.CustomButton.Visible = false;
            this.txtTen.Lines = new string[0];
            this.txtTen.Location = new System.Drawing.Point(85, 98);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTen.SelectedText = "";
            this.txtTen.SelectionLength = 0;
            this.txtTen.SelectionStart = 0;
            this.txtTen.ShortcutsEnabled = true;
            this.txtTen.Size = new System.Drawing.Size(232, 23);
            this.txtTen.TabIndex = 8;
            this.txtTen.UseSelectable = true;
            this.txtTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHo
            // 
            // 
            // 
            // 
            this.txtHo.CustomButton.Image = null;
            this.txtHo.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtHo.CustomButton.Name = "";
            this.txtHo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHo.CustomButton.TabIndex = 1;
            this.txtHo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHo.CustomButton.UseSelectable = true;
            this.txtHo.CustomButton.Visible = false;
            this.txtHo.Lines = new string[0];
            this.txtHo.Location = new System.Drawing.Point(85, 56);
            this.txtHo.MaxLength = 32767;
            this.txtHo.Name = "txtHo";
            this.txtHo.PasswordChar = '\0';
            this.txtHo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHo.SelectedText = "";
            this.txtHo.SelectionLength = 0;
            this.txtHo.SelectionStart = 0;
            this.txtHo.ShortcutsEnabled = true;
            this.txtHo.Size = new System.Drawing.Size(232, 23);
            this.txtHo.TabIndex = 7;
            this.txtHo.UseSelectable = true;
            this.txtHo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMaSV
            // 
            // 
            // 
            // 
            this.txtMaSV.CustomButton.Image = null;
            this.txtMaSV.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtMaSV.CustomButton.Name = "";
            this.txtMaSV.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaSV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaSV.CustomButton.TabIndex = 1;
            this.txtMaSV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaSV.CustomButton.UseSelectable = true;
            this.txtMaSV.CustomButton.Visible = false;
            this.txtMaSV.Lines = new string[0];
            this.txtMaSV.Location = new System.Drawing.Point(101, 14);
            this.txtMaSV.MaxLength = 32767;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.PasswordChar = '\0';
            this.txtMaSV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaSV.SelectedText = "";
            this.txtMaSV.SelectionLength = 0;
            this.txtMaSV.SelectionStart = 0;
            this.txtMaSV.ShortcutsEnabled = true;
            this.txtMaSV.Size = new System.Drawing.Size(216, 23);
            this.txtMaSV.TabIndex = 6;
            this.txtMaSV.UseSelectable = true;
            this.txtMaSV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaSV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(13, 172);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(67, 19);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Giới Tính: ";
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Location = new System.Drawing.Point(11, 209);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(68, 19);
            this.lbMaKhoa.TabIndex = 5;
            this.lbMaKhoa.Text = "Mã Khoa: ";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(11, 102);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(31, 19);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Tên:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(11, 135);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(75, 19);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "Ngày Sinh: ";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(13, 16);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(92, 19);
            this.lbMaSV.TabIndex = 0;
            this.lbMaSV.Text = "Mã Sinh Viên: ";
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(13, 56);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(33, 19);
            this.lbHo.TabIndex = 1;
            this.lbHo.Text = "Họ: ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "OK";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(287, 339);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 28);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Cancel";
            this.btnReturn.UseSelectable = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(24, 339);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 28);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseSelectable = true;
            // 
            // frmAdd_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 385);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmAdd_Update";
            this.Text = "Update Form";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtMaKhoa;
        private MetroFramework.Controls.MetroTextBox txtTen;
        private MetroFramework.Controls.MetroTextBox txtHo;
        private MetroFramework.Controls.MetroTextBox txtMaSV;
        private MetroFramework.Controls.MetroLabel lbGioiTinh;
        private MetroFramework.Controls.MetroLabel lbMaKhoa;
        private MetroFramework.Controls.MetroLabel lbTen;
        private MetroFramework.Controls.MetroLabel lbNgaySinh;
        private MetroFramework.Controls.MetroLabel lbMaSV;
        private MetroFramework.Controls.MetroLabel lbHo;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnReturn;
        private MetroFramework.Controls.MetroButton btnCheck;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
    }
}