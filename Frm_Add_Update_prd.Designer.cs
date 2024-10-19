namespace Res_csharp
{
    partial class Frm_Add_Update_prd
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
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TxtPrd_ID = new System.Windows.Forms.TextBox();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.PrdExit = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.CheckStatus = new System.Windows.Forms.CheckBox();
            this.CmbCat = new System.Windows.Forms.ComboBox();
            this.TxtPrdPrice = new System.Windows.Forms.TextBox();
            this.TxtPrdName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.TxtPrd_Barcode = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Prd_Image = new System.Windows.Forms.PictureBox();
            this.Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prd_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // TxtPrd_ID
            // 
            this.TxtPrd_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrd_ID.Location = new System.Drawing.Point(284, 231);
            this.TxtPrd_ID.Name = "TxtPrd_ID";
            this.TxtPrd_ID.Size = new System.Drawing.Size(105, 30);
            this.TxtPrd_ID.TabIndex = 203;
            this.TxtPrd_ID.Visible = false;
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteImage.BackColor = System.Drawing.Color.Red;
            this.btnDeleteImage.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImage.Image = global::Res_csharp.Properties.Resources.Delete_16x16;
            this.btnDeleteImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteImage.Location = new System.Drawing.Point(16, 319);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(157, 34);
            this.btnDeleteImage.TabIndex = 198;
            this.btnDeleteImage.Text = "حذف الصورة ";
            this.btnDeleteImage.UseVisualStyleBackColor = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // PrdExit
            // 
            this.PrdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrdExit.BackColor = System.Drawing.Color.Gray;
            this.PrdExit.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrdExit.Image = global::Res_csharp.Properties.Resources.broom;
            this.PrdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrdExit.Location = new System.Drawing.Point(190, 281);
            this.PrdExit.Name = "PrdExit";
            this.PrdExit.Size = new System.Drawing.Size(105, 34);
            this.PrdExit.TabIndex = 202;
            this.PrdExit.Text = "الغاء";
            this.PrdExit.UseVisualStyleBackColor = false;
            this.PrdExit.Click += new System.EventHandler(this.PrdExit_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnEdit.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Image = global::Res_csharp.Properties.Resources.EditContact_16x16__2_;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(306, 281);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(157, 34);
            this.BtnEdit.TabIndex = 200;
            this.BtnEdit.Text = "تعديل البيانات";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSave.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::Res_csharp.Properties.Resources.save_as;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(474, 281);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(157, 34);
            this.BtnSave.TabIndex = 199;
            this.BtnSave.Text = "حفظ البيانات";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnBrowse.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.Image = global::Res_csharp.Properties.Resources.Open2_16x16;
            this.BtnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBrowse.Location = new System.Drawing.Point(16, 281);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(157, 34);
            this.BtnBrowse.TabIndex = 197;
            this.BtnBrowse.Text = "اختيار الصورة";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // CheckStatus
            // 
            this.CheckStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckStatus.AutoSize = true;
            this.CheckStatus.Checked = true;
            this.CheckStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckStatus.Location = new System.Drawing.Point(445, 233);
            this.CheckStatus.Name = "CheckStatus";
            this.CheckStatus.Size = new System.Drawing.Size(66, 26);
            this.CheckStatus.TabIndex = 191;
            this.CheckStatus.Text = "متوفر";
            this.CheckStatus.UseVisualStyleBackColor = true;
            // 
            // CmbCat
            // 
            this.CmbCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCat.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.CmbCat.FormattingEnabled = true;
            this.CmbCat.Location = new System.Drawing.Point(196, 189);
            this.CmbCat.Name = "CmbCat";
            this.CmbCat.Size = new System.Drawing.Size(317, 27);
            this.CmbCat.TabIndex = 189;
            // 
            // TxtPrdPrice
            // 
            this.TxtPrdPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrdPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrdPrice.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.TxtPrdPrice.Location = new System.Drawing.Point(196, 147);
            this.TxtPrdPrice.Name = "TxtPrdPrice";
            this.TxtPrdPrice.Size = new System.Drawing.Size(317, 27);
            this.TxtPrdPrice.TabIndex = 187;
            // 
            // TxtPrdName
            // 
            this.TxtPrdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrdName.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.TxtPrdName.Location = new System.Drawing.Point(196, 104);
            this.TxtPrdName.Name = "TxtPrdName";
            this.TxtPrdName.Size = new System.Drawing.Size(317, 27);
            this.TxtPrdName.TabIndex = 184;
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label7.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(49, 57);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(98, 32);
            this.Label7.TabIndex = 196;
            this.Label7.Text = "صورة المنتج";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label7.UseCompatibleTextRendering = true;
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.AutoSize = true;
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label6.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(522, 229);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(96, 32);
            this.Label6.TabIndex = 195;
            this.Label6.Text = "حالة المنتج :";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label6.UseCompatibleTextRendering = true;
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(522, 186);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(119, 32);
            this.Label5.TabIndex = 194;
            this.Label5.Text = "تصنيف المنتج :";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label5.UseCompatibleTextRendering = true;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.AutoSize = true;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(522, 144);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(90, 32);
            this.Label4.TabIndex = 193;
            this.Label4.Text = "سعر البيع :";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label4.UseCompatibleTextRendering = true;
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(522, 102);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 32);
            this.Label3.TabIndex = 204;
            this.Label3.Text = "أسم المنتج :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label3.UseCompatibleTextRendering = true;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(522, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 32);
            this.Label2.TabIndex = 192;
            this.Label2.Text = "باركود المنتج :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label2.UseCompatibleTextRendering = true;
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Tajawal", 12.25F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(606, 37);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "شاشة اضافة منتج جديد ";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.White;
            this.Panel5.Controls.Add(this.Label1);
            this.Panel5.Controls.Add(this.btnClose);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Location = new System.Drawing.Point(10, 10);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(642, 37);
            this.Panel5.TabIndex = 190;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Res_csharp.Properties.Resources.process_stop;
            this.btnClose.Location = new System.Drawing.Point(606, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel4.Location = new System.Drawing.Point(0, 10);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(10, 345);
            this.Panel4.TabIndex = 188;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel3.Location = new System.Drawing.Point(652, 10);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(10, 345);
            this.Panel3.TabIndex = 186;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 355);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(662, 10);
            this.Panel2.TabIndex = 185;
            // 
            // TxtPrd_Barcode
            // 
            this.TxtPrd_Barcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrd_Barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrd_Barcode.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.TxtPrd_Barcode.Location = new System.Drawing.Point(196, 64);
            this.TxtPrd_Barcode.Name = "TxtPrd_Barcode";
            this.TxtPrd_Barcode.Size = new System.Drawing.Size(317, 27);
            this.TxtPrd_Barcode.TabIndex = 182;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(662, 10);
            this.Panel1.TabIndex = 183;
            // 
            // Prd_Image
            // 
            this.Prd_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Prd_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Prd_Image.Image = global::Res_csharp.Properties.Resources.pro;
            this.Prd_Image.Location = new System.Drawing.Point(16, 93);
            this.Prd_Image.Name = "Prd_Image";
            this.Prd_Image.Size = new System.Drawing.Size(165, 177);
            this.Prd_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Prd_Image.TabIndex = 201;
            this.Prd_Image.TabStop = false;
            // 
            // Frm_Add_Update_prd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 365);
            this.Controls.Add(this.TxtPrd_ID);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.PrdExit);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.Prd_Image);
            this.Controls.Add(this.CheckStatus);
            this.Controls.Add(this.CmbCat);
            this.Controls.Add(this.TxtPrdPrice);
            this.Controls.Add(this.TxtPrdName);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.TxtPrd_Barcode);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Frm_Add_Update_prd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Add_Update_prd_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Add_Update_prd_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Add_Update_prd_Load);
            this.Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Prd_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.TextBox TxtPrd_ID;
        internal System.Windows.Forms.Button btnDeleteImage;
        internal System.Windows.Forms.Button PrdExit;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnBrowse;
        internal System.Windows.Forms.PictureBox Prd_Image;
        internal System.Windows.Forms.CheckBox CheckStatus;
        internal System.Windows.Forms.ComboBox CmbCat;
        internal System.Windows.Forms.TextBox TxtPrdPrice;
        internal System.Windows.Forms.TextBox TxtPrdName;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox TxtPrd_Barcode;
        internal System.Windows.Forms.Panel Panel1;
    }
}

