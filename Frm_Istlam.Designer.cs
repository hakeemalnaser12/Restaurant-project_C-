namespace Res_csharp
{
    partial class Frm_Istlam
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
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnIstlam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tajawal", 11F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(17, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(118, 22);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "الرصيد الافتتاحي";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotal.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.TxtTotal.Location = new System.Drawing.Point(141, 11);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(282, 27);
            this.TxtTotal.TabIndex = 28;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnIstlam
            // 
            this.BtnIstlam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIstlam.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnIstlam.FlatAppearance.BorderSize = 0;
            this.BtnIstlam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIstlam.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIstlam.ForeColor = System.Drawing.Color.White;
            this.BtnIstlam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIstlam.Location = new System.Drawing.Point(141, 49);
            this.BtnIstlam.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIstlam.Name = "BtnIstlam";
            this.BtnIstlam.Size = new System.Drawing.Size(282, 34);
            this.BtnIstlam.TabIndex = 30;
            this.BtnIstlam.Text = "إٍستلام الصندوق";
            this.BtnIstlam.UseVisualStyleBackColor = false;
            this.BtnIstlam.Click += new System.EventHandler(this.BtnIstlam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Res_csharp.Properties.Resources.pod;
            this.pictureBox1.InitialImage = global::Res_csharp.Properties.Resources.pod;
            this.pictureBox1.Location = new System.Drawing.Point(383, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Istlam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 94);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnIstlam);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtTotal);
            this.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Istlam";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة استلام الصندوق";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnIstlam;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}