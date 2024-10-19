namespace Res_csharp
{
    partial class Frm_Settings_Varibles
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
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ComboDBs = new System.Windows.Forms.ComboBox();
            this.Btndelete = new System.Windows.Forms.Button();
            this.BtnScan = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.CombServers = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtInstallPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBackupPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Panel5.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Controls.Add(this.btnClose);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(612, 40);
            this.Panel5.TabIndex = 19;
            // 
            // Label7
            // 
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(573, 40);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "شاشة متغيرات النظام ";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Res_csharp.Properties.Resources.process_stop;
            this.btnClose.Location = new System.Drawing.Point(573, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.BtnSave);
            this.GroupBox1.Controls.Add(this.ComboDBs);
            this.GroupBox1.Controls.Add(this.Btndelete);
            this.GroupBox1.Controls.Add(this.BtnScan);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.CombServers);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(11, 47);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox1.Size = new System.Drawing.Size(590, 149);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "اعدادات الاتصال بقاعدة البيانات";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.Black;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Image = global::Res_csharp.Properties.Resources.save_as;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(144, 106);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 34);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ComboDBs
            // 
            this.ComboDBs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboDBs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboDBs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboDBs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDBs.FormattingEnabled = true;
            this.ComboDBs.Location = new System.Drawing.Point(12, 66);
            this.ComboDBs.Name = "ComboDBs";
            this.ComboDBs.Size = new System.Drawing.Size(414, 26);
            this.ComboDBs.TabIndex = 3;
            // 
            // Btndelete
            // 
            this.Btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btndelete.BackColor = System.Drawing.Color.Black;
            this.Btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btndelete.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndelete.ForeColor = System.Drawing.Color.White;
            this.Btndelete.Image = global::Res_csharp.Properties.Resources.Delete_16x16;
            this.Btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btndelete.Location = new System.Drawing.Point(12, 106);
            this.Btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(83, 34);
            this.Btndelete.TabIndex = 21;
            this.Btndelete.Text = "حذف ";
            this.Btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btndelete.UseVisualStyleBackColor = false;
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // BtnScan
            // 
            this.BtnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnScan.BackColor = System.Drawing.Color.Black;
            this.BtnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScan.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScan.ForeColor = System.Drawing.Color.White;
            this.BtnScan.Image = global::Res_csharp.Properties.Resources.page_white_database;
            this.BtnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnScan.Location = new System.Drawing.Point(271, 106);
            this.BtnScan.Margin = new System.Windows.Forms.Padding(4);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Size = new System.Drawing.Size(155, 34);
            this.BtnScan.TabIndex = 23;
            this.BtnScan.Text = "فحص الاتصال";
            this.BtnScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScan.UseVisualStyleBackColor = false;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(439, 68);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(144, 22);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "اسم قاعدة البيانات :";
            // 
            // CombServers
            // 
            this.CombServers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CombServers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CombServers.BackColor = System.Drawing.Color.White;
            this.CombServers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CombServers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombServers.FormattingEnabled = true;
            this.CombServers.Location = new System.Drawing.Point(12, 28);
            this.CombServers.Name = "CombServers";
            this.CombServers.Size = new System.Drawing.Size(414, 26);
            this.CombServers.TabIndex = 0;
            this.CombServers.SelectedIndexChanged += new System.EventHandler(this.CombServers_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(468, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(98, 22);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "اسم السرفر :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "مسار البرنامج الافتراضي :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // TxtInstallPath
            // 
            this.TxtInstallPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInstallPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInstallPath.Location = new System.Drawing.Point(259, 252);
            this.TxtInstallPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtInstallPath.Name = "TxtInstallPath";
            this.TxtInstallPath.Size = new System.Drawing.Size(332, 30);
            this.TxtInstallPath.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "مسار النسخ الإحتياطي الافتراضي :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // TxtBackupPath
            // 
            this.TxtBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBackupPath.Location = new System.Drawing.Point(259, 295);
            this.TxtBackupPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBackupPath.Name = "TxtBackupPath";
            this.TxtBackupPath.Size = new System.Drawing.Size(332, 30);
            this.TxtBackupPath.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(582, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "متغيرات النظام : ----------------------------------------------------------------" +
    "--------------------------------------------------";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Res_csharp.Properties.Resources.save_as;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(10, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(485, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "حفظ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Res_csharp.Properties.Resources.Delete_16x16;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(506, 333);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "حذف ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_Settings_Varibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBackupPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtInstallPath);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel5);
            this.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Settings_Varibles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة متغيرات النظام ";
            this.Load += new System.EventHandler(this.Frm_Settings_Varibles_Load);
            this.Panel5.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox ComboDBs;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox CombServers;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button Btndelete;
        internal System.Windows.Forms.Button BtnScan;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox TxtInstallPath;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox TxtBackupPath;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button2;
    }
}