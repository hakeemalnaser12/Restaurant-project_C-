namespace Res_csharp
{
    partial class Frm_Paid
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
            this.Button3 = new System.Windows.Forms.Button();
            this.BtnPaidOrder = new System.Windows.Forms.Button();
            this.CmbPaidType = new System.Windows.Forms.ComboBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxtUnPaid = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtPaid = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtDiscount = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtFinalTotal = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.White;
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Controls.Add(this.Button3);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(398, 44);
            this.Panel5.TabIndex = 28;
            // 
            // Label7
            // 
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Font = new System.Drawing.Font("Tajawal", 12.25F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.Red;
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(350, 44);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "شاشة تسديد الفاتورة";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Image = global::Res_csharp.Properties.Resources.process_stop;
            this.Button3.Location = new System.Drawing.Point(350, 0);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(48, 44);
            this.Button3.TabIndex = 5;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // BtnPaidOrder
            // 
            this.BtnPaidOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPaidOrder.BackColor = System.Drawing.Color.Maroon;
            this.BtnPaidOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaidOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPaidOrder.Image = global::Res_csharp.Properties.Resources.money_dollar;
            this.BtnPaidOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPaidOrder.Location = new System.Drawing.Point(17, 496);
            this.BtnPaidOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPaidOrder.Name = "BtnPaidOrder";
            this.BtnPaidOrder.Size = new System.Drawing.Size(368, 42);
            this.BtnPaidOrder.TabIndex = 27;
            this.BtnPaidOrder.Text = "الدفع الان";
            this.BtnPaidOrder.UseVisualStyleBackColor = false;
            this.BtnPaidOrder.Click += new System.EventHandler(this.BtnPaidOrder_Click);
            // 
            // CmbPaidType
            // 
            this.CmbPaidType.FormattingEnabled = true;
            this.CmbPaidType.Items.AddRange(new object[] {
            "نقدي",
            "فيزا"});
            this.CmbPaidType.Location = new System.Drawing.Point(17, 459);
            this.CmbPaidType.Name = "CmbPaidType";
            this.CmbPaidType.Size = new System.Drawing.Size(369, 32);
            this.CmbPaidType.TabIndex = 26;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Font = new System.Drawing.Font("Tajawal", 10.25F, System.Drawing.FontStyle.Bold);
            this.CheckBox1.Location = new System.Drawing.Point(17, 141);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(104, 25);
            this.CheckBox1.TabIndex = 22;
            this.CheckBox1.Text = "اجراء الخصم";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Font = new System.Drawing.Font("Tajawal", 10F, System.Drawing.FontStyle.Bold);
            this.Label5.Location = new System.Drawing.Point(17, 425);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(368, 31);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "طريقة الدفع";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtUnPaid
            // 
            this.TxtUnPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUnPaid.BackColor = System.Drawing.Color.White;
            this.TxtUnPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUnPaid.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Bold);
            this.TxtUnPaid.ForeColor = System.Drawing.Color.Black;
            this.TxtUnPaid.Location = new System.Drawing.Point(17, 377);
            this.TxtUnPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUnPaid.Name = "TxtUnPaid";
            this.TxtUnPaid.Size = new System.Drawing.Size(368, 43);
            this.TxtUnPaid.TabIndex = 25;
            this.TxtUnPaid.Text = "0";
            this.TxtUnPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
//            this.TxtUnPaid.TextChanged += new System.EventHandler(this.TxtUnPaid_TextChanged);
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Font = new System.Drawing.Font("Tajawal", 10F, System.Drawing.FontStyle.Bold);
            this.Label4.Location = new System.Drawing.Point(17, 341);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(368, 31);
            this.Label4.TabIndex = 33;
            this.Label4.Text = "المبلغ المتبقي";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPaid
            // 
            this.TxtPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPaid.BackColor = System.Drawing.Color.White;
            this.TxtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPaid.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Bold);
            this.TxtPaid.ForeColor = System.Drawing.Color.Black;
            this.TxtPaid.Location = new System.Drawing.Point(17, 293);
            this.TxtPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPaid.Name = "TxtPaid";
            this.TxtPaid.Size = new System.Drawing.Size(368, 43);
            this.TxtPaid.TabIndex = 24;
            this.TxtPaid.Text = "0";
            this.TxtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPaid.TextChanged += new System.EventHandler(this.TxtPaid_TextChanged);
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Font = new System.Drawing.Font("Tajawal", 10F, System.Drawing.FontStyle.Bold);
            this.Label3.Location = new System.Drawing.Point(17, 257);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(368, 31);
            this.Label3.TabIndex = 32;
            this.Label3.Text = "المبلغ المدفوع";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDiscount.BackColor = System.Drawing.Color.White;
            this.TxtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDiscount.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Bold);
            this.TxtDiscount.ForeColor = System.Drawing.Color.Black;
            this.TxtDiscount.Location = new System.Drawing.Point(17, 209);
            this.TxtDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Size = new System.Drawing.Size(368, 43);
            this.TxtDiscount.TabIndex = 23;
            this.TxtDiscount.Text = "0.0";
            this.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDiscount.TextChanged += new System.EventHandler(this.TxtDiscount_TextChanged);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Font = new System.Drawing.Font("Tajawal", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.Location = new System.Drawing.Point(17, 173);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(368, 31);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "قيمة الخصم";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtFinalTotal
            // 
            this.TxtFinalTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFinalTotal.BackColor = System.Drawing.Color.White;
            this.TxtFinalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFinalTotal.Enabled = false;
            this.TxtFinalTotal.Font = new System.Drawing.Font("Times New Roman", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFinalTotal.ForeColor = System.Drawing.Color.Black;
            this.TxtFinalTotal.Location = new System.Drawing.Point(17, 90);
            this.TxtFinalTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFinalTotal.Name = "TxtFinalTotal";
            this.TxtFinalTotal.Size = new System.Drawing.Size(368, 43);
            this.TxtFinalTotal.TabIndex = 30;
            this.TxtFinalTotal.Text = "0.0";
            this.TxtFinalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font = new System.Drawing.Font("Tajawal", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(17, 54);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(368, 31);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "المبلغ الاجمالي";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Paid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 542);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.BtnPaidOrder);
            this.Controls.Add(this.CmbPaidType);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TxtUnPaid);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TxtPaid);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtDiscount);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtFinalTotal);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm_Paid";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الدفع";
            this.Load += new System.EventHandler(this.Frm_Paid_Load);
            this.Panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button BtnPaidOrder;
        internal System.Windows.Forms.ComboBox CmbPaidType;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TxtUnPaid;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TxtPaid;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtDiscount;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtFinalTotal;
        internal System.Windows.Forms.Label Label1;
    }
}