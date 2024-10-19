namespace Res_csharp
{
    partial class Frm_Company
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.PrdExit = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtCompany_ID = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TxtVat_No = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label8 = new System.Windows.Forms.Label();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxtFax = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtEmailID = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtPhone2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtPhone1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.BtnSave);
            this.GroupBox1.Controls.Add(this.btnDeleteImage);
            this.GroupBox1.Controls.Add(this.logo);
            this.GroupBox1.Controls.Add(this.PrdExit);
            this.GroupBox1.Controls.Add(this.BtnBrowse);
            this.GroupBox1.Location = new System.Drawing.Point(34, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(221, 396);
            this.GroupBox1.TabIndex = 29;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "شعار المطعم";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSave.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::Res_csharp.Properties.Resources.save_as;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(35, 311);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 44);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "حفظ البيانات";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteImage.BackColor = System.Drawing.Color.Red;
            this.btnDeleteImage.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImage.Image = global::Res_csharp.Properties.Resources.Delete_16x16;
            this.btnDeleteImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteImage.Location = new System.Drawing.Point(35, 246);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(150, 44);
            this.btnDeleteImage.TabIndex = 1;
            this.btnDeleteImage.Text = "حذف الصورة ";
            this.btnDeleteImage.UseVisualStyleBackColor = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Image = global::Res_csharp.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(18, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(184, 176);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 32;
            this.logo.TabStop = false;
            // 
            // PrdExit
            // 
            this.PrdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrdExit.BackColor = System.Drawing.Color.Gray;
            this.PrdExit.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrdExit.Image = global::Res_csharp.Properties.Resources.broom;
            this.PrdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrdExit.Location = new System.Drawing.Point(35, 346);
            this.PrdExit.Name = "PrdExit";
            this.PrdExit.Size = new System.Drawing.Size(150, 44);
            this.PrdExit.TabIndex = 3;
            this.PrdExit.Text = "الغاء";
            this.PrdExit.UseVisualStyleBackColor = false;
            this.PrdExit.Click += new System.EventHandler(this.PrdExit_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnBrowse.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.Image = global::Res_csharp.Properties.Resources.Open2_16x16;
            this.BtnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBrowse.Location = new System.Drawing.Point(35, 210);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(150, 44);
            this.BtnBrowse.TabIndex = 0;
            this.BtnBrowse.Text = "اختيار الصورة";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtCompany_ID
            // 
            this.TxtCompany_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCompany_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TxtCompany_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompany_ID.Location = new System.Drawing.Point(651, 323);
            this.TxtCompany_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCompany_ID.Name = "TxtCompany_ID";
            this.TxtCompany_ID.Size = new System.Drawing.Size(94, 30);
            this.TxtCompany_ID.TabIndex = 28;
            this.TxtCompany_ID.Visible = false;
            // 
            // Label10
            // 
            this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label10.AutoSize = true;
            this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(648, 368);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(110, 31);
            this.Label10.TabIndex = 26;
            this.Label10.Text = "الرقم الضريبي :";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label10.UseCompatibleTextRendering = true;
            // 
            // TxtVat_No
            // 
            this.TxtVat_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtVat_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVat_No.Location = new System.Drawing.Point(283, 369);
            this.TxtVat_No.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVat_No.Name = "TxtVat_No";
            this.TxtVat_No.Size = new System.Drawing.Size(357, 30);
            this.TxtVat_No.TabIndex = 8;
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label9.AutoSize = true;
            this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(648, 279);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(66, 31);
            this.Label9.TabIndex = 24;
            this.Label9.Text = "العنوان :";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label9.UseCompatibleTextRendering = true;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddress.Location = new System.Drawing.Point(283, 279);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(357, 83);
            this.TxtAddress.TabIndex = 7;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Controls.Add(this.TxtCompany_ID);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.TxtVat_No);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.TxtAddress);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.TxtCountry);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.TxtCity);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.TxtFax);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.TxtEmailID);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.TxtPhone2);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.TxtPhone1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.TxtCompanyName);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 38);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(767, 431);
            this.Panel1.TabIndex = 11;
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label8.AutoSize = true;
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label8.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(648, 241);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(55, 31);
            this.Label8.TabIndex = 22;
            this.Label8.Text = "الدولة :";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label8.UseCompatibleTextRendering = true;
            // 
            // TxtCountry
            // 
            this.TxtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCountry.Location = new System.Drawing.Point(283, 241);
            this.TxtCountry.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(357, 30);
            this.TxtCountry.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.AutoSize = true;
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label6.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(648, 203);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(64, 31);
            this.Label6.TabIndex = 20;
            this.Label6.Text = "المدينة :";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label6.UseCompatibleTextRendering = true;
            // 
            // TxtCity
            // 
            this.TxtCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCity.Location = new System.Drawing.Point(283, 203);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(357, 30);
            this.TxtCity.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(648, 165);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 31);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "الفاكس :";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label5.UseCompatibleTextRendering = true;
            // 
            // TxtFax
            // 
            this.TxtFax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFax.Location = new System.Drawing.Point(283, 165);
            this.TxtFax.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(357, 30);
            this.TxtFax.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.AutoSize = true;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(648, 127);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 31);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "الايميل :";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label4.UseCompatibleTextRendering = true;
            // 
            // TxtEmailID
            // 
            this.TxtEmailID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmailID.Location = new System.Drawing.Point(283, 127);
            this.TxtEmailID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmailID.Name = "TxtEmailID";
            this.TxtEmailID.Size = new System.Drawing.Size(357, 30);
            this.TxtEmailID.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(648, 89);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 31);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "رقم هاتف 2 : ";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label3.UseCompatibleTextRendering = true;
            // 
            // TxtPhone2
            // 
            this.TxtPhone2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPhone2.Location = new System.Drawing.Point(283, 89);
            this.TxtPhone2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPhone2.Name = "TxtPhone2";
            this.TxtPhone2.Size = new System.Drawing.Size(357, 30);
            this.TxtPhone2.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(648, 51);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(90, 31);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "رقم هاتف 1 :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label2.UseCompatibleTextRendering = true;
            // 
            // TxtPhone1
            // 
            this.TxtPhone1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPhone1.Location = new System.Drawing.Point(283, 51);
            this.TxtPhone1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPhone1.Name = "TxtPhone1";
            this.TxtPhone1.Size = new System.Drawing.Size(357, 30);
            this.TxtPhone1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(648, 13);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(99, 31);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "اسم الشركة :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label1.UseCompatibleTextRendering = true;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanyName.Location = new System.Drawing.Point(283, 13);
            this.TxtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(357, 30);
            this.TxtCompanyName.TabIndex = 0;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.White;
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Controls.Add(this.Button3);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(767, 38);
            this.Panel5.TabIndex = 10;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Font = new System.Drawing.Font("Tajawal", 12.25F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(718, 38);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "شاشة بيانات المطعم";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Black;
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Image = global::Res_csharp.Properties.Resources.process_stop;
            this.Button3.Location = new System.Drawing.Point(718, 0);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(49, 38);
            this.Button3.TabIndex = 0;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Frm_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 469);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel5);
            this.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Company";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Company";
            this.Load += new System.EventHandler(this.Frm_Company_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnDeleteImage;
        internal System.Windows.Forms.PictureBox logo;
        internal System.Windows.Forms.Button PrdExit;
        internal System.Windows.Forms.Button BtnBrowse;
        internal System.Windows.Forms.TextBox TxtCompany_ID;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TxtVat_No;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox TxtAddress;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox TxtCountry;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TxtCity;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TxtFax;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TxtEmailID;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtPhone2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtPhone1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtCompanyName;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button Button3;
        public System.Windows.Forms.Button BtnSave;
    }
}