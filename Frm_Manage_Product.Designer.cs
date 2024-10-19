namespace Res_csharp
{
    partial class Frm_Manage_Product
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
            this.DgvPrd = new System.Windows.Forms.DataGridView();
            this.num_Dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_Dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenter_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.CmbCat = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnAllPrd = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnNewPrd = new System.Windows.Forms.Button();
            this.DataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrd)).BeginInit();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPrd
            // 
            this.DgvPrd.AllowUserToAddRows = false;
            this.DgvPrd.AllowUserToDeleteRows = false;
            this.DgvPrd.ColumnHeadersHeight = 35;
            this.DgvPrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Dep,
            this.name_Dep,
            this.Prenter_Name,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5});
            this.DgvPrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPrd.Location = new System.Drawing.Point(0, 0);
            this.DgvPrd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvPrd.Name = "DgvPrd";
            this.DgvPrd.ReadOnly = true;
            this.DgvPrd.RowHeadersWidth = 5;
            this.DgvPrd.Size = new System.Drawing.Size(1007, 359);
            this.DgvPrd.TabIndex = 19;
            this.DgvPrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrd_CellContentClick);
            this.DgvPrd.MouseHover += new System.EventHandler(this.DgvPrd_MouseHover);
            // 
            // num_Dep
            // 
            this.num_Dep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.num_Dep.HeaderText = "رقم المنتج";
            this.num_Dep.Name = "num_Dep";
            this.num_Dep.ReadOnly = true;
            this.num_Dep.Visible = false;
            // 
            // name_Dep
            // 
            this.name_Dep.HeaderText = "باركود المنتج";
            this.name_Dep.Name = "name_Dep";
            this.name_Dep.ReadOnly = true;
            this.name_Dep.Width = 130;
            // 
            // Prenter_Name
            // 
            this.Prenter_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prenter_Name.HeaderText = "أسم المنتج ";
            this.Prenter_Name.MinimumWidth = 20;
            this.Prenter_Name.Name = "Prenter_Name";
            this.Prenter_Name.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "سعر المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "تصنيف المنتج";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "حالة المنتج";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "تعديل";
            this.Column4.Image = global::Res_csharp.Properties.Resources.EditContact_16x16__2_;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "حذف";
            this.Column5.Image = global::Res_csharp.Properties.Resources.Delete_16x16;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.DgvPrd);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(0, 143);
            this.Panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1007, 359);
            this.Panel3.TabIndex = 26;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Font = new System.Drawing.Font("Tajawal", 12.25F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.Red;
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(963, 41);
            this.Label7.TabIndex = 20;
            this.Label7.Text = "شاشة ادارة المنتجات";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Button3);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1007, 41);
            this.Panel2.TabIndex = 25;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Image = global::Res_csharp.Properties.Resources.process_stop;
            this.Button3.Location = new System.Drawing.Point(963, 0);
            this.Button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(44, 41);
            this.Button3.TabIndex = 0;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label1.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Image = global::Res_csharp.Properties.Resources.Zoom_16x16__3_;
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label1.Location = new System.Drawing.Point(720, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(268, 26);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "البحث بواسطة الباركود / الاسم         ";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label5.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Image = global::Res_csharp.Properties.Resources.Zoom_16x16__3_;
            this.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label5.Location = new System.Drawing.Point(415, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(256, 26);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "فرز المنتجات حسب التصنيفات        ";
            // 
            // CmbCat
            // 
            this.CmbCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCat.FormattingEnabled = true;
            this.CmbCat.Location = new System.Drawing.Point(401, 49);
            this.CmbCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbCat.Name = "CmbCat";
            this.CmbCat.Size = new System.Drawing.Size(280, 30);
            this.CmbCat.TabIndex = 3;
            this.CmbCat.SelectedIndexChanged += new System.EventHandler(this.CmbCat_SelectedIndexChanged);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Location = new System.Drawing.Point(712, 49);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(287, 30);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnAllPrd
            // 
            this.BtnAllPrd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAllPrd.BackColor = System.Drawing.Color.White;
            this.BtnAllPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllPrd.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAllPrd.Image = global::Res_csharp.Properties.Resources.Text_preview;
            this.BtnAllPrd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAllPrd.Location = new System.Drawing.Point(20, 45);
            this.BtnAllPrd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAllPrd.Name = "BtnAllPrd";
            this.BtnAllPrd.Size = new System.Drawing.Size(185, 36);
            this.BtnAllPrd.TabIndex = 1;
            this.BtnAllPrd.Text = "عرض جميع المنتجات";
            this.BtnAllPrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAllPrd.UseVisualStyleBackColor = false;
            this.BtnAllPrd.Click += new System.EventHandler(this.BtnAllPrd_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.CmbCat);
            this.Panel1.Controls.Add(this.TxtSearch);
            this.Panel1.Controls.Add(this.BtnAllPrd);
            this.Panel1.Controls.Add(this.BtnNewPrd);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 41);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1007, 102);
            this.Panel1.TabIndex = 24;
            // 
            // BtnNewPrd
            // 
            this.BtnNewPrd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewPrd.BackColor = System.Drawing.Color.White;
            this.BtnNewPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewPrd.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewPrd.Image = global::Res_csharp.Properties.Resources.AddFile_1616;
            this.BtnNewPrd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewPrd.Location = new System.Drawing.Point(231, 45);
            this.BtnNewPrd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNewPrd.Name = "BtnNewPrd";
            this.BtnNewPrd.Size = new System.Drawing.Size(145, 36);
            this.BtnNewPrd.TabIndex = 0;
            this.BtnNewPrd.Text = "إضافة منتج ";
            this.BtnNewPrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewPrd.UseVisualStyleBackColor = false;
            this.BtnNewPrd.Click += new System.EventHandler(this.BtnNewPrd_Click);
            // 
            // DataGridViewImageColumn2
            // 
            this.DataGridViewImageColumn2.HeaderText = "حذف";
            this.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2";
            // 
            // DataGridViewImageColumn1
            // 
            this.DataGridViewImageColumn1.HeaderText = "تعديل";
            this.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1";
            // 
            // Frm_Manage_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 502);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Manage_Product";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة إدارة المنتجات";
            this.Load += new System.EventHandler(this.Frm_Manage_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrd)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DgvPrd;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox CmbCat;
        internal System.Windows.Forms.TextBox TxtSearch;
        internal System.Windows.Forms.Button BtnAllPrd;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button BtnNewPrd;
        internal System.Windows.Forms.DataGridViewImageColumn DataGridViewImageColumn2;
        internal System.Windows.Forms.DataGridViewImageColumn DataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenter_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
    }
}