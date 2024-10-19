namespace Res_csharp
{
    partial class Frm_Order_Type
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
            this.Panel6 = new System.Windows.Forms.Panel();
            this.BtnTakeAway = new System.Windows.Forms.Button();
            this.BtnDelevery = new System.Windows.Forms.Button();
            this.BtnOnTable = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel5.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Goldenrod;
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Controls.Add(this.btnClose);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(667, 40);
            this.Panel5.TabIndex = 16;
            // 
            // Label7
            // 
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(628, 40);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "شاشة اختيار نوع الفاتورة ";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Res_csharp.Properties.Resources.process_stop;
            this.btnClose.Location = new System.Drawing.Point(628, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.BtnTakeAway);
            this.Panel6.Controls.Add(this.BtnDelevery);
            this.Panel6.Controls.Add(this.BtnOnTable);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(18, 40);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(631, 169);
            this.Panel6.TabIndex = 20;
            // 
            // BtnTakeAway
            // 
            this.BtnTakeAway.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTakeAway.BackColor = System.Drawing.Color.White;
            this.BtnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTakeAway.Image = global::Res_csharp.Properties.Resources.takaway;
            this.BtnTakeAway.Location = new System.Drawing.Point(219, 8);
            this.BtnTakeAway.Name = "BtnTakeAway";
            this.BtnTakeAway.Size = new System.Drawing.Size(193, 153);
            this.BtnTakeAway.TabIndex = 1;
            this.BtnTakeAway.Text = "سفري";
            this.BtnTakeAway.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTakeAway.UseVisualStyleBackColor = false;
            this.BtnTakeAway.Click += new System.EventHandler(this.BtnTakeAway_Click);
            // 
            // BtnDelevery
            // 
            this.BtnDelevery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelevery.BackColor = System.Drawing.Color.White;
            this.BtnDelevery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelevery.Image = global::Res_csharp.Properties.Resources.delivery_truck__1_;
            this.BtnDelevery.Location = new System.Drawing.Point(6, 8);
            this.BtnDelevery.Name = "BtnDelevery";
            this.BtnDelevery.Size = new System.Drawing.Size(183, 153);
            this.BtnDelevery.TabIndex = 2;
            this.BtnDelevery.Text = "خدمة توصيل";
            this.BtnDelevery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDelevery.UseVisualStyleBackColor = false;
            this.BtnDelevery.Click += new System.EventHandler(this.BtnDelevery_Click);
            // 
            // BtnOnTable
            // 
            this.BtnOnTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOnTable.BackColor = System.Drawing.Color.White;
            this.BtnOnTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOnTable.Image = global::Res_csharp.Properties.Resources.table__1_;
            this.BtnOnTable.Location = new System.Drawing.Point(442, 8);
            this.BtnOnTable.Name = "BtnOnTable";
            this.BtnOnTable.Size = new System.Drawing.Size(183, 153);
            this.BtnOnTable.TabIndex = 0;
            this.BtnOnTable.Text = "طاولة";
            this.BtnOnTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOnTable.UseVisualStyleBackColor = false;
            this.BtnOnTable.Click += new System.EventHandler(this.BtnOnTable_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel3.Location = new System.Drawing.Point(0, 40);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(18, 169);
            this.Panel3.TabIndex = 18;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel2.Location = new System.Drawing.Point(649, 40);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(18, 169);
            this.Panel2.TabIndex = 17;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Goldenrod;
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel4.Location = new System.Drawing.Point(0, 209);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(667, 16);
            this.Panel4.TabIndex = 19;
            // 
            // Frm_Order_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 225);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel5);
            this.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Order_Type";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Order_Type";
            this.Panel5.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnOnTable;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.Button BtnTakeAway;
        internal System.Windows.Forms.Button BtnDelevery;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel4;
    }
}