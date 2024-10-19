namespace Res_csharp
{
    partial class Frm_Settings
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
            this.Label3 = new System.Windows.Forms.Label();
            this.btnSavePrinters = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbPrinter = new System.Windows.Forms.ComboBox();
            this.CheckSale8Cm = new System.Windows.Forms.CheckBox();
            this.CheckSaleA4 = new System.Windows.Forms.CheckBox();
            this.btnSaveSaleReport = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TxtTax_ID = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtTax_Value = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnSave_Status = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.CheckTax = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBackupPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtInstallPath = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboDBs = new System.Windows.Forms.ComboBox();
            this.Btndelete = new System.Windows.Forms.Button();
            this.BtnScan = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.CombServers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(53, 27);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(343, 22);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "اختر طابعة لكي تكون هي الطابعة الرئيسية للبرنامج";
            // 
            // btnSavePrinters
            // 
            this.btnSavePrinters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePrinters.BackColor = System.Drawing.Color.Black;
            this.btnSavePrinters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrinters.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrinters.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSavePrinters.Image = global::Res_csharp.Properties.Resources.save_as;
            this.btnSavePrinters.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSavePrinters.Location = new System.Drawing.Point(18, 99);
            this.btnSavePrinters.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePrinters.Name = "btnSavePrinters";
            this.btnSavePrinters.Size = new System.Drawing.Size(404, 34);
            this.btnSavePrinters.TabIndex = 1;
            this.btnSavePrinters.Text = "حفظ";
            this.btnSavePrinters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePrinters.UseVisualStyleBackColor = false;
            this.btnSavePrinters.Click += new System.EventHandler(this.btnSavePrinters_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.cmbPrinter);
            this.GroupBox3.Controls.Add(this.btnSavePrinters);
            this.GroupBox3.Location = new System.Drawing.Point(595, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(429, 152);
            this.GroupBox3.TabIndex = 16;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الطابعة الإفتراضية للبرنامج";
            // 
            // cmbPrinter
            // 
            this.cmbPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrinter.FormattingEnabled = true;
            this.cmbPrinter.Location = new System.Drawing.Point(18, 58);
            this.cmbPrinter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrinter.Name = "cmbPrinter";
            this.cmbPrinter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPrinter.Size = new System.Drawing.Size(404, 30);
            this.cmbPrinter.TabIndex = 0;
            // 
            // CheckSale8Cm
            // 
            this.CheckSale8Cm.AutoSize = true;
            this.CheckSale8Cm.Location = new System.Drawing.Point(103, 71);
            this.CheckSale8Cm.Name = "CheckSale8Cm";
            this.CheckSale8Cm.Size = new System.Drawing.Size(295, 26);
            this.CheckSale8Cm.TabIndex = 1;
            this.CheckSale8Cm.Text = "الطباعة بواسطة الكريستال ريبورت CM 8";
            this.CheckSale8Cm.UseVisualStyleBackColor = true;
            this.CheckSale8Cm.CheckedChanged += new System.EventHandler(this.CheckSale8Cm_CheckedChanged);
            // 
            // CheckSaleA4
            // 
            this.CheckSaleA4.AutoSize = true;
            this.CheckSaleA4.Location = new System.Drawing.Point(120, 39);
            this.CheckSaleA4.Name = "CheckSaleA4";
            this.CheckSaleA4.Size = new System.Drawing.Size(278, 26);
            this.CheckSaleA4.TabIndex = 0;
            this.CheckSaleA4.Text = "الطباعة بواسطة الكريستال ريبورت A4";
            this.CheckSaleA4.UseVisualStyleBackColor = true;
            this.CheckSaleA4.CheckedChanged += new System.EventHandler(this.CheckSaleA4_CheckedChanged);
            // 
            // btnSaveSaleReport
            // 
            this.btnSaveSaleReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSaleReport.BackColor = System.Drawing.Color.Black;
            this.btnSaveSaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSaleReport.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSaleReport.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveSaleReport.Image = global::Res_csharp.Properties.Resources.save_as;
            this.btnSaveSaleReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSaleReport.Location = new System.Drawing.Point(18, 113);
            this.btnSaveSaleReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSaleReport.Name = "btnSaveSaleReport";
            this.btnSaveSaleReport.Size = new System.Drawing.Size(404, 34);
            this.btnSaveSaleReport.TabIndex = 2;
            this.btnSaveSaleReport.Text = "حفظ";
            this.btnSaveSaleReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSaleReport.UseVisualStyleBackColor = false;
            this.btnSaveSaleReport.Click += new System.EventHandler(this.btnSaveSaleReport_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox4.Controls.Add(this.CheckSale8Cm);
            this.GroupBox4.Controls.Add(this.CheckSaleA4);
            this.GroupBox4.Controls.Add(this.btnSaveSaleReport);
            this.GroupBox4.Location = new System.Drawing.Point(595, 181);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(429, 172);
            this.GroupBox4.TabIndex = 17;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "فاتورة المبيعات";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Controls.Add(this.GroupBox3);
            this.TabPage2.Location = new System.Drawing.Point(4, 31);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1030, 395);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "اعدادات الطباعة";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtTax_ID
            // 
            this.TxtTax_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTax_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTax_ID.Location = new System.Drawing.Point(470, 21);
            this.TxtTax_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTax_ID.Name = "TxtTax_ID";
            this.TxtTax_ID.Size = new System.Drawing.Size(65, 30);
            this.TxtTax_ID.TabIndex = 12;
            this.TxtTax_ID.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.Black;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnSave.Image = global::Res_csharp.Properties.Resources.save_as;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(14, 68);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(404, 34);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtTax_Value
            // 
            this.TxtTax_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTax_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTax_Value.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.TxtTax_Value.Location = new System.Drawing.Point(15, 33);
            this.TxtTax_Value.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTax_Value.Name = "TxtTax_Value";
            this.TxtTax_Value.Size = new System.Drawing.Size(300, 27);
            this.TxtTax_Value.TabIndex = 0;
            this.TxtTax_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(317, 33);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 22);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "قيمة الضريبة :";
            // 
            // btnSave_Status
            // 
            this.btnSave_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave_Status.BackColor = System.Drawing.Color.Black;
            this.btnSave_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_Status.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_Status.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave_Status.Image = global::Res_csharp.Properties.Resources.save_as;
            this.btnSave_Status.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave_Status.Location = new System.Drawing.Point(15, 57);
            this.btnSave_Status.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave_Status.Name = "btnSave_Status";
            this.btnSave_Status.Size = new System.Drawing.Size(402, 34);
            this.btnSave_Status.TabIndex = 1;
            this.btnSave_Status.Text = "حفظ";
            this.btnSave_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave_Status.UseVisualStyleBackColor = false;
            this.btnSave_Status.Click += new System.EventHandler(this.btnSave_Status_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(317, 26);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(104, 22);
            this.Label2.TabIndex = 13;
            this.Label2.Text = " حالة الضريبة :";
            // 
            // CheckTax
            // 
            this.CheckTax.AutoSize = true;
            this.CheckTax.Location = new System.Drawing.Point(243, 26);
            this.CheckTax.Name = "CheckTax";
            this.CheckTax.Size = new System.Drawing.Size(72, 26);
            this.CheckTax.TabIndex = 0;
            this.CheckTax.Text = "مفعلة";
            this.CheckTax.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.btnSave_Status);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.CheckTax);
            this.GroupBox2.Location = new System.Drawing.Point(595, 135);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(429, 108);
            this.GroupBox2.TabIndex = 16;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "تفعيل أو الغاء الضريبة";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.Location = new System.Drawing.Point(0, 40);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1038, 430);
            this.TabControl1.TabIndex = 11;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.TxtTax_ID);
            this.TabPage1.Location = new System.Drawing.Point(4, 31);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1030, 395);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "اعدادات الضريبة";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.BtnSave);
            this.GroupBox1.Controls.Add(this.TxtTax_Value);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(595, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(429, 123);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "ادخال قيمة الضريبة";
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.button4);
            this.TabPage3.Controls.Add(this.button2);
            this.TabPage3.Controls.Add(this.label8);
            this.TabPage3.Controls.Add(this.label4);
            this.TabPage3.Controls.Add(this.TxtBackupPath);
            this.TabPage3.Controls.Add(this.label5);
            this.TabPage3.Controls.Add(this.TxtInstallPath);
            this.TabPage3.Controls.Add(this.groupBox5);
            this.TabPage3.Location = new System.Drawing.Point(4, 31);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1030, 395);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "اعدادات الاتصال بقاعدة البيانات";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Res_csharp.Properties.Resources.save_as;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(523, 292);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(498, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "حفظ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(586, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "متغيرات النظام : ----------------------------------------------------------------" +
    "---------------------------------------------------";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 31);
            this.label4.TabIndex = 29;
            this.label4.Text = "مسار النسخ الإحتياطي الافتراضي :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // TxtBackupPath
            // 
            this.TxtBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBackupPath.Location = new System.Drawing.Point(432, 254);
            this.TxtBackupPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBackupPath.Name = "TxtBackupPath";
            this.TxtBackupPath.Size = new System.Drawing.Size(332, 30);
            this.TxtBackupPath.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(816, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 31);
            this.label5.TabIndex = 27;
            this.label5.Text = "مسار البرنامج الافتراضي :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // TxtInstallPath
            // 
            this.TxtInstallPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInstallPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInstallPath.Location = new System.Drawing.Point(432, 214);
            this.TxtInstallPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtInstallPath.Name = "TxtInstallPath";
            this.TxtInstallPath.Size = new System.Drawing.Size(332, 30);
            this.TxtInstallPath.TabIndex = 26;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.ComboDBs);
            this.groupBox5.Controls.Add(this.Btndelete);
            this.groupBox5.Controls.Add(this.BtnScan);
            this.groupBox5.Controls.Add(this.Label9);
            this.groupBox5.Controls.Add(this.CombServers);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(432, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(590, 149);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "اعدادات الاتصال بقاعدة البيانات";
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
            this.button1.Location = new System.Drawing.Point(144, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "حفظ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ComboDBs
            // 
            this.ComboDBs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboDBs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboDBs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboDBs.BackColor = System.Drawing.SystemColors.Control;
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
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.CombServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CombServers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CombServers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CombServers.BackColor = System.Drawing.SystemColors.Control;
            this.CombServers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CombServers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombServers.FormattingEnabled = true;
            this.CombServers.Location = new System.Drawing.Point(12, 31);
            this.CombServers.Name = "CombServers";
            this.CombServers.Size = new System.Drawing.Size(414, 26);
            this.CombServers.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(468, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "اسم السرفر :";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Font = new System.Drawing.Font("Tajawal", 12.25F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(994, 40);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "شاشة إعدادات البرنامج";
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
            this.Button3.Location = new System.Drawing.Point(994, 0);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(44, 40);
            this.Button3.TabIndex = 5;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.White;
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Controls.Add(this.Button3);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(1038, 40);
            this.Panel5.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Res_csharp.Properties.Resources.Delete_16x16;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(432, 292);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 34);
            this.button4.TabIndex = 24;
            this.button4.Text = "حذف ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 470);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel5);
            this.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الاعدادت";
            this.Load += new System.EventHandler(this.Frm_Settings_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnSavePrinters;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.ComboBox cmbPrinter;
        internal System.Windows.Forms.CheckBox CheckSale8Cm;
        internal System.Windows.Forms.CheckBox CheckSaleA4;
        internal System.Windows.Forms.Button btnSaveSaleReport;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox TxtTax_ID;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.TextBox TxtTax_Value;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnSave_Status;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.CheckBox CheckTax;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox TxtBackupPath;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox TxtInstallPath;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.ComboBox ComboDBs;
        internal System.Windows.Forms.Button Btndelete;
        internal System.Windows.Forms.Button BtnScan;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox CombServers;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button button4;
    }
}