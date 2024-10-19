using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Res_csharp.Model;

namespace Res_csharp
{
    public partial class Frm_Select_Table : Form
    {
        Connection Con;

        Button btnTable = new Button();

        Frm_pos frm;

        public Frm_Select_Table(Frm_pos frm2)
        {
            
            InitializeComponent();
            Con = new Connection();
            this.frm = frm2;
        }

        public void Go_Table_Click(object sender, EventArgs e)
        {


            string tableName = ((Button)sender).Tag.ToString();
            
            frm.TxtTableName.Text = tableName;
            //frm.OrderDate.Value = DateTime.Today;
            //frm.TxtOrder_No.Text = frm.Get_Order_No();
            frm.GetOrder();
            frm.TxtServices.Text = Convert.ToString(Connection._ServiceTotal);
            frm.Load_Order();
            frm.Order_Table();

            if (Connection._order_Type == "In_Table")
            {
                frm.BtnSelectDelevery.Visible = false;
            }
            else if (Connection._order_Type == "TakeAway")
            {
                frm.BtnSelectDelevery.Visible = false;
            }
            else if (Connection._order_Type == "Delevery")
            {
                frm.BtnSelectDelevery.Visible = true;
            }

            this.Close();
        }


        public void Loadall_Table()
        {
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Controls.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * From View_Table", Con.con);
            SqlDataAdapter adp = new SqlDataAdapter(Cmd);
            SqlDataReader rdr = Cmd.ExecuteReader();

            while (rdr.Read())
            {
                Button btnTable = new Button();
                btnTable.Width = 170;
                btnTable.Height = 50;

                btnTable.Tag = rdr["TableName"].ToString();
                if (Convert.ToDouble(rdr["Bill"]) > 0)
                {
                    // هذه الطاولة محجوزة و عليها حساب 
                    btnTable.Text = rdr["TableName"].ToString() + "\r\n" + (rdr["Bill"].ToString() + Convert.ToString(Connection._TaxTotal) + Convert.ToString(Connection._ServiceTotal));
                    btnTable.BackColor = Color.Red;
                }
                else
                {
                    btnTable.Text = rdr["TableName"].ToString();
                    btnTable.BackColor = Color.FromArgb(45, 45, 45);
                }
                btnTable.FlatStyle = FlatStyle.Flat;
                btnTable.FlatAppearance.BorderSize = 0;
                btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnTable.ForeColor = Color.White;
                btnTable.Cursor = Cursors.Hand;
                btnTable.Font = new Font("Tajawal", 10.0f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
                btnTable.TextAlign = ContentAlignment.MiddleCenter;
                btnTable.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);

                FlowLayoutPanel1.Controls.Add(btnTable);

                btnTable.Click += new EventHandler(Go_Table_Click);
            }

            rdr.Close();
            Con.con.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
