namespace Res_csharp
{
    partial class Frm_Backup_And_Restore
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TxtBackup = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtRestore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBackup_Path = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRestore_Path = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.Location = new System.Drawing.Point(0, 40);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(511, 159);
            this.TabControl1.TabIndex = 12;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.btnBackup);
            this.TabPage1.Controls.Add(this.btnBackup_Path);
            this.TabPage1.Controls.Add(this.TxtBackup);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Location = new System.Drawing.Point(4, 31);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(503, 124);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "النسخ الإحتياطي ";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtBackup
            // 
            this.TxtBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBackup.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.TxtBackup.Location = new System.Drawing.Point(50, 35);
            this.TxtBackup.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBackup.Name = "TxtBackup";
            this.TxtBackup.Size = new System.Drawing.Size(444, 27);
            this.TxtBackup.TabIndex = 43;
            this.TxtBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tajawal", 11F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(172, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(143, 22);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "تحديد مسار النسخة ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtRestore);
            this.tabPage2.Controls.Add(this.btnRestore);
            this.tabPage2.Controls.Add(this.btnRestore_Path);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(503, 124);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "إستعادة النسخة";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtRestore
            // 
            this.TxtRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRestore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRestore.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.TxtRestore.Location = new System.Drawing.Point(50, 35);
            this.TxtRestore.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRestore.Name = "TxtRestore";
            this.TxtRestore.Size = new System.Drawing.Size(444, 27);
            this.TxtRestore.TabIndex = 41;
            this.TxtRestore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "تحديد مسار النسخة ";
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.White;
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Controls.Add(this.Button3);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(511, 40);
            this.Panel5.TabIndex = 44;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Font = new System.Drawing.Font("Tajawal", 12.25F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(467, 40);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "شاشة النسخ الإحتياطي والإستعادة";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackup.Image = global::Res_csharp.Properties.Resources.database_key;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.Location = new System.Drawing.Point(8, 79);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(486, 34);
            this.btnBackup.TabIndex = 45;
            this.btnBackup.Text = "نسخ إحتياطي";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBackup_Path
            // 
            this.btnBackup_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup_Path.Image = global::Res_csharp.Properties.Resources.folder_add;
            this.btnBackup_Path.Location = new System.Drawing.Point(8, 34);
            this.btnBackup_Path.Name = "btnBackup_Path";
            this.btnBackup_Path.Size = new System.Drawing.Size(35, 28);
            this.btnBackup_Path.TabIndex = 44;
            this.btnBackup_Path.UseVisualStyleBackColor = true;
            this.btnBackup_Path.Click += new System.EventHandler(this.btnBackup_Path_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestore.Image = global::Res_csharp.Properties.Resources.database_go;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.Location = new System.Drawing.Point(8, 79);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(486, 34);
            this.btnRestore.TabIndex = 43;
            this.btnRestore.Text = "استعادة النسخة";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRestore_Path
            // 
            this.btnRestore_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore_Path.Image = global::Res_csharp.Properties.Resources.folder_database2;
            this.btnRestore_Path.Location = new System.Drawing.Point(8, 35);
            this.btnRestore_Path.Name = "btnRestore_Path";
            this.btnRestore_Path.Size = new System.Drawing.Size(35, 27);
            this.btnRestore_Path.TabIndex = 42;
            this.btnRestore_Path.UseVisualStyleBackColor = true;
            this.btnRestore_Path.Click += new System.EventHandler(this.btnRestore_Path_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Black;
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Image = global::Res_csharp.Properties.Resources.process_stop;
            this.Button3.Location = new System.Drawing.Point(467, 0);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(44, 40);
            this.Button3.TabIndex = 5;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Frm_Backup_And_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 199);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel5);
            this.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Backup_And_Restore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة النسخ الإحتياطي والإستعادة";
            this.Load += new System.EventHandler(this.Frm_Backup_And_Restore_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestore_Path;
        private System.Windows.Forms.Button btnBackup_Path;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox TxtRestore;
        private System.Windows.Forms.TextBox TxtBackup;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button Button3;
    }
}