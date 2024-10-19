namespace Res_csharp
{
    partial class Frm_UsersManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNewKash = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Dgv_User = new System.Windows.Forms.DataGridView();
            this.UserAccID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccActivate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ck_ShowPaswordUser = new System.Windows.Forms.CheckBox();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.TxtUserPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtUserAccID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtUserAccName = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ChkAccActivate = new System.Windows.Forms.CheckBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Dgv_Kashir = new System.Windows.Forms.DataGridView();
            this.Cashier_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashier_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashier_Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.ck_ShowPaswordCashir = new System.Windows.Forms.CheckBox();
            this.TxtCashier_Pass = new System.Windows.Forms.TextBox();
            this.TxtCashier_UserName = new System.Windows.Forms.TextBox();
            this.TxtCashier_ID = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.BtnEditKash = new System.Windows.Forms.Button();
            this.BtnSaveKash = new System.Windows.Forms.Button();
            this.BtnDeleteKash = new System.Windows.Forms.Button();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Button3 = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_User)).BeginInit();
            this.Panel2.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Kashir)).BeginInit();
            this.Panel4.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNewKash
            // 
            this.BtnNewKash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewKash.BackColor = System.Drawing.Color.White;
            this.BtnNewKash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewKash.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewKash.Image = global::Res_csharp.Properties.Resources.Add_16x16;
            this.BtnNewKash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewKash.Location = new System.Drawing.Point(101, 7);
            this.BtnNewKash.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewKash.Name = "BtnNewKash";
            this.BtnNewKash.Size = new System.Drawing.Size(83, 34);
            this.BtnNewKash.TabIndex = 0;
            this.BtnNewKash.Text = "جديد";
            this.BtnNewKash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewKash.UseVisualStyleBackColor = false;
            this.BtnNewKash.Click += new System.EventHandler(this.BtnNewKash_Click);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.Dgv_User);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(3, 155);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(764, 246);
            this.Panel3.TabIndex = 20;
            // 
            // Dgv_User
            // 
            this.Dgv_User.AllowUserToAddRows = false;
            this.Dgv_User.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.Dgv_User.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_User.ColumnHeadersHeight = 40;
            this.Dgv_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserAccID,
            this.UserAccName,
            this.UserName,
            this.UserPassword,
            this.AccType,
            this.AccActivate});
            this.Dgv_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_User.Location = new System.Drawing.Point(0, 0);
            this.Dgv_User.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_User.Name = "Dgv_User";
            this.Dgv_User.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Dgv_User.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_User.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_User.Size = new System.Drawing.Size(764, 246);
            this.Dgv_User.TabIndex = 17;
            this.Dgv_User.Click += new System.EventHandler(this.Dgv_User_Click);
            // 
            // UserAccID
            // 
            this.UserAccID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserAccID.HeaderText = "رقم المستخدم";
            this.UserAccID.Name = "UserAccID";
            this.UserAccID.ReadOnly = true;
            this.UserAccID.Visible = false;
            // 
            // UserAccName
            // 
            this.UserAccName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserAccName.HeaderText = "اسم الحساب";
            this.UserAccName.Name = "UserAccName";
            this.UserAccName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "اسم المستخدم";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 150;
            // 
            // UserPassword
            // 
            this.UserPassword.HeaderText = "كلمة السر";
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.ReadOnly = true;
            this.UserPassword.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserPassword.Width = 150;
            // 
            // AccType
            // 
            this.AccType.HeaderText = "نوع المستخدم";
            this.AccType.Name = "AccType";
            this.AccType.ReadOnly = true;
            this.AccType.Width = 120;
            // 
            // AccActivate
            // 
            this.AccActivate.HeaderText = "الحالة";
            this.AccActivate.Name = "AccActivate";
            this.AccActivate.ReadOnly = true;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.ck_ShowPaswordUser);
            this.Panel2.Controls.Add(this.cmbAccType);
            this.Panel2.Controls.Add(this.TxtUserPassword);
            this.Panel2.Controls.Add(this.TxtUserName);
            this.Panel2.Controls.Add(this.label9);
            this.Panel2.Controls.Add(this.label8);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.TxtUserAccID);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.BtnEdit);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.TxtUserAccName);
            this.Panel2.Controls.Add(this.BtnSave);
            this.Panel2.Controls.Add(this.ChkAccActivate);
            this.Panel2.Controls.Add(this.BtnDelete);
            this.Panel2.Controls.Add(this.BtnNew);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(3, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(764, 152);
            this.Panel2.TabIndex = 19;
            // 
            // ck_ShowPaswordUser
            // 
            this.ck_ShowPaswordUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ck_ShowPaswordUser.BackColor = System.Drawing.Color.White;
            this.ck_ShowPaswordUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_ShowPaswordUser.Location = new System.Drawing.Point(301, 83);
            this.ck_ShowPaswordUser.Name = "ck_ShowPaswordUser";
            this.ck_ShowPaswordUser.Size = new System.Drawing.Size(17, 24);
            this.ck_ShowPaswordUser.TabIndex = 24;
            this.ck_ShowPaswordUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ck_ShowPaswordUser.UseVisualStyleBackColor = false;
            this.ck_ShowPaswordUser.CheckedChanged += new System.EventHandler(this.ck_ShowPaswordUser_CheckedChanged);
            // 
            // cmbAccType
            // 
            this.cmbAccType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Items.AddRange(new object[] {
            "مدير",
            "مستخدم"});
            this.cmbAccType.Location = new System.Drawing.Point(299, 115);
            this.cmbAccType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbAccType.Size = new System.Drawing.Size(328, 30);
            this.cmbAccType.TabIndex = 23;
            // 
            // TxtUserPassword
            // 
            this.TxtUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserPassword.Location = new System.Drawing.Point(299, 80);
            this.TxtUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserPassword.Name = "TxtUserPassword";
            this.TxtUserPassword.Size = new System.Drawing.Size(328, 30);
            this.TxtUserPassword.TabIndex = 22;
            this.TxtUserPassword.UseSystemPasswordChar = true;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserName.Location = new System.Drawing.Point(299, 44);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(328, 30);
            this.TxtUserName.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(632, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "نوع المستخدم :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(632, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "كلمة السر :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.UseCompatibleTextRendering = true;
            // 
            // Label1
            // 
            this.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(632, 7);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(107, 31);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "اسم الحساب :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label1.UseCompatibleTextRendering = true;
            // 
            // TxtUserAccID
            // 
            this.TxtUserAccID.BackColor = System.Drawing.SystemColors.Window;
            this.TxtUserAccID.Location = new System.Drawing.Point(211, 8);
            this.TxtUserAccID.Name = "TxtUserAccID";
            this.TxtUserAccID.Size = new System.Drawing.Size(81, 30);
            this.TxtUserAccID.TabIndex = 18;
            this.TxtUserAccID.Visible = false;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(632, 44);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(122, 31);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "اسم المستخدم :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label2.UseCompatibleTextRendering = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.BackColor = System.Drawing.Color.White;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Image = global::Res_csharp.Properties.Resources.EditContact_16x16__2_;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(104, 49);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(83, 34);
            this.BtnEdit.TabIndex = 12;
            this.BtnEdit.Text = "تعديل";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(173, 114);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(119, 31);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "حالة المستخدم :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label3.UseCompatibleTextRendering = true;
            // 
            // TxtUserAccName
            // 
            this.TxtUserAccName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUserAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserAccName.Location = new System.Drawing.Point(299, 8);
            this.TxtUserAccName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserAccName.Name = "TxtUserAccName";
            this.TxtUserAccName.Size = new System.Drawing.Size(328, 30);
            this.TxtUserAccName.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::Res_csharp.Properties.Resources.save_as;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(13, 8);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 34);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ChkAccActivate
            // 
            this.ChkAccActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkAccActivate.AutoSize = true;
            this.ChkAccActivate.Checked = true;
            this.ChkAccActivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAccActivate.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAccActivate.Location = new System.Drawing.Point(19, 116);
            this.ChkAccActivate.Margin = new System.Windows.Forms.Padding(4);
            this.ChkAccActivate.Name = "ChkAccActivate";
            this.ChkAccActivate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkAccActivate.Size = new System.Drawing.Size(146, 26);
            this.ChkAccActivate.TabIndex = 3;
            this.ChkAccActivate.Text = "مصرح له بالدخول ";
            this.ChkAccActivate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.White;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Image = global::Res_csharp.Properties.Resources.Delete_16x16;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(13, 49);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(83, 34);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.BackColor = System.Drawing.Color.White;
            this.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNew.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Image = global::Res_csharp.Properties.Resources.Add_16x16;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNew.Location = new System.Drawing.Point(104, 8);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(83, 34);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "جديد";
            this.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.Panel6);
            this.TabPage2.Controls.Add(this.Panel4);
            this.TabPage2.Location = new System.Drawing.Point(4, 31);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(770, 404);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "ادارة الكاشير";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.Dgv_Kashir);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(3, 157);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(764, 244);
            this.Panel6.TabIndex = 24;
            // 
            // Dgv_Kashir
            // 
            this.Dgv_Kashir.AllowUserToAddRows = false;
            this.Dgv_Kashir.AllowUserToDeleteRows = false;
            this.Dgv_Kashir.ColumnHeadersHeight = 40;
            this.Dgv_Kashir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cashier_ID,
            this.FullName,
            this.Cashier_UserName,
            this.Cashier_Pass});
            this.Dgv_Kashir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Kashir.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Kashir.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Kashir.Name = "Dgv_Kashir";
            this.Dgv_Kashir.ReadOnly = true;
            this.Dgv_Kashir.Size = new System.Drawing.Size(764, 244);
            this.Dgv_Kashir.TabIndex = 21;
            this.Dgv_Kashir.Click += new System.EventHandler(this.Dgv_Kashir_Click);
            // 
            // Cashier_ID
            // 
            this.Cashier_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cashier_ID.FillWeight = 317.7944F;
            this.Cashier_ID.HeaderText = "رقم الكاشير";
            this.Cashier_ID.Name = "Cashier_ID";
            this.Cashier_ID.ReadOnly = true;
            this.Cashier_ID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.FillWeight = 18.26404F;
            this.FullName.HeaderText = "اسم الكاشير ";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Cashier_UserName
            // 
            this.Cashier_UserName.FillWeight = 18.26404F;
            this.Cashier_UserName.HeaderText = "اسم المستخدم";
            this.Cashier_UserName.Name = "Cashier_UserName";
            this.Cashier_UserName.ReadOnly = true;
            this.Cashier_UserName.Width = 200;
            // 
            // Cashier_Pass
            // 
            this.Cashier_Pass.HeaderText = "كلمة السر";
            this.Cashier_Pass.Name = "Cashier_Pass";
            this.Cashier_Pass.ReadOnly = true;
            this.Cashier_Pass.Width = 200;
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.ck_ShowPaswordCashir);
            this.Panel4.Controls.Add(this.TxtCashier_Pass);
            this.Panel4.Controls.Add(this.TxtCashier_UserName);
            this.Panel4.Controls.Add(this.TxtCashier_ID);
            this.Panel4.Controls.Add(this.Label4);
            this.Panel4.Controls.Add(this.TxtFullName);
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Controls.Add(this.Label6);
            this.Panel4.Controls.Add(this.BtnEditKash);
            this.Panel4.Controls.Add(this.BtnSaveKash);
            this.Panel4.Controls.Add(this.BtnDeleteKash);
            this.Panel4.Controls.Add(this.BtnNewKash);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel4.Location = new System.Drawing.Point(3, 3);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(764, 154);
            this.Panel4.TabIndex = 23;
            // 
            // ck_ShowPaswordCashir
            // 
            this.ck_ShowPaswordCashir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ck_ShowPaswordCashir.BackColor = System.Drawing.Color.White;
            this.ck_ShowPaswordCashir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_ShowPaswordCashir.Location = new System.Drawing.Point(299, 82);
            this.ck_ShowPaswordCashir.Name = "ck_ShowPaswordCashir";
            this.ck_ShowPaswordCashir.Size = new System.Drawing.Size(16, 24);
            this.ck_ShowPaswordCashir.TabIndex = 31;
            this.ck_ShowPaswordCashir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ck_ShowPaswordCashir.UseVisualStyleBackColor = false;
            this.ck_ShowPaswordCashir.CheckedChanged += new System.EventHandler(this.ck_ShowPaswordCashir_CheckedChanged);
            // 
            // TxtCashier_Pass
            // 
            this.TxtCashier_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCashier_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCashier_Pass.Location = new System.Drawing.Point(293, 79);
            this.TxtCashier_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCashier_Pass.Name = "TxtCashier_Pass";
            this.TxtCashier_Pass.Size = new System.Drawing.Size(334, 30);
            this.TxtCashier_Pass.TabIndex = 25;
            this.TxtCashier_Pass.UseSystemPasswordChar = true;
            // 
            // TxtCashier_UserName
            // 
            this.TxtCashier_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCashier_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCashier_UserName.Location = new System.Drawing.Point(293, 42);
            this.TxtCashier_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCashier_UserName.Name = "TxtCashier_UserName";
            this.TxtCashier_UserName.Size = new System.Drawing.Size(334, 30);
            this.TxtCashier_UserName.TabIndex = 24;
            // 
            // TxtCashier_ID
            // 
            this.TxtCashier_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCashier_ID.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCashier_ID.Location = new System.Drawing.Point(204, 4);
            this.TxtCashier_ID.Name = "TxtCashier_ID";
            this.TxtCashier_ID.Size = new System.Drawing.Size(86, 30);
            this.TxtCashier_ID.TabIndex = 22;
            this.TxtCashier_ID.Visible = false;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.AutoSize = true;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(631, 5);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(102, 31);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "اسم الكاشير :";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label4.UseCompatibleTextRendering = true;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFullName.Location = new System.Drawing.Point(293, 4);
            this.TxtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(334, 30);
            this.TxtFullName.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(631, 42);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(122, 31);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "اسم المستخدم :";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label5.UseCompatibleTextRendering = true;
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.AutoSize = true;
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label6.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(631, 78);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(84, 31);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "كلمة السر :";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label6.UseCompatibleTextRendering = true;
            // 
            // BtnEditKash
            // 
            this.BtnEditKash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditKash.BackColor = System.Drawing.Color.White;
            this.BtnEditKash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditKash.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditKash.Image = global::Res_csharp.Properties.Resources.EditContact_16x16__2_;
            this.BtnEditKash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditKash.Location = new System.Drawing.Point(101, 49);
            this.BtnEditKash.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditKash.Name = "BtnEditKash";
            this.BtnEditKash.Size = new System.Drawing.Size(83, 34);
            this.BtnEditKash.TabIndex = 17;
            this.BtnEditKash.Text = "تعديل";
            this.BtnEditKash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditKash.UseVisualStyleBackColor = false;
            this.BtnEditKash.Click += new System.EventHandler(this.BtnEditKash_Click);
            // 
            // BtnSaveKash
            // 
            this.BtnSaveKash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveKash.BackColor = System.Drawing.Color.White;
            this.BtnSaveKash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveKash.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveKash.Image = global::Res_csharp.Properties.Resources.save_as;
            this.BtnSaveKash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSaveKash.Location = new System.Drawing.Point(10, 7);
            this.BtnSaveKash.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSaveKash.Name = "BtnSaveKash";
            this.BtnSaveKash.Size = new System.Drawing.Size(83, 34);
            this.BtnSaveKash.TabIndex = 4;
            this.BtnSaveKash.Text = "حفظ";
            this.BtnSaveKash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaveKash.UseVisualStyleBackColor = false;
            this.BtnSaveKash.Click += new System.EventHandler(this.BtnSaveKash_Click);
            // 
            // BtnDeleteKash
            // 
            this.BtnDeleteKash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteKash.BackColor = System.Drawing.Color.White;
            this.BtnDeleteKash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteKash.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteKash.Image = global::Res_csharp.Properties.Resources.Delete_16x16;
            this.BtnDeleteKash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeleteKash.Location = new System.Drawing.Point(10, 49);
            this.BtnDeleteKash.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeleteKash.Name = "BtnDeleteKash";
            this.BtnDeleteKash.Size = new System.Drawing.Size(83, 34);
            this.BtnDeleteKash.TabIndex = 19;
            this.BtnDeleteKash.Text = "حذف";
            this.BtnDeleteKash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteKash.UseVisualStyleBackColor = false;
            this.BtnDeleteKash.Click += new System.EventHandler(this.BtnDeleteKash_Click);
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Transparent;
            this.TabPage1.Controls.Add(this.Panel3);
            this.TabPage1.Controls.Add(this.Panel2);
            this.TabPage1.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage1.Location = new System.Drawing.Point(4, 31);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabPage1.Size = new System.Drawing.Size(770, 404);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "ادارة المستخدمين";
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Image = global::Res_csharp.Properties.Resources.process_stop;
            this.Button3.Location = new System.Drawing.Point(734, 0);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(44, 38);
            this.Button3.TabIndex = 5;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(778, 439);
            this.TabControl1.TabIndex = 0;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.White;
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Controls.Add(this.Button3);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(778, 38);
            this.Panel5.TabIndex = 11;
            // 
            // Label7
            // 
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Font = new System.Drawing.Font("Tajawal", 12.25F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.Red;
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(734, 38);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "شاشة ادارة المستخدمين والكاشير";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.TabControl1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 38);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(778, 439);
            this.Panel1.TabIndex = 10;
            // 
            // Frm_UsersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 477);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel5);
            this.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_UsersManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_UsersManager";
            this.Load += new System.EventHandler(this.Frm_UsersManager_Load);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_User)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Kashir)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnNewKash;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DataGridView Dgv_User;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtUserAccID;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtUserAccName;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.CheckBox ChkAccActivate;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.Button BtnNew;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.DataGridView Dgv_Kashir;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.TextBox TxtCashier_ID;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TxtFullName;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button BtnEditKash;
        internal System.Windows.Forms.Button BtnSaveKash;
        internal System.Windows.Forms.Button BtnDeleteKash;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cmbAccType;
        internal System.Windows.Forms.TextBox TxtUserPassword;
        internal System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashier_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashier_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashier_Pass;
        internal System.Windows.Forms.TextBox TxtCashier_Pass;
        internal System.Windows.Forms.TextBox TxtCashier_UserName;
        internal System.Windows.Forms.CheckBox ck_ShowPaswordUser;
        internal System.Windows.Forms.CheckBox ck_ShowPaswordCashir;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAccID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccActivate;
    }
}