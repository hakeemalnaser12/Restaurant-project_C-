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
    public partial class Frm_Salse_History : Form
    {
        Connection Con;

     
        public Frm_Salse_History()
        {
            InitializeComponent();
            Con = new Connection();

        }

        public void Get_Totals()
        {
            double total1 = 0, total2 = 0, total3 = 0, total4 = 0;
            for (int i = 0; i < DgvSale.Rows.Count; i++)
            {
                total1 += Convert.ToDouble(DgvSale.Rows[i].Cells[4].Value);
                total2 += Convert.ToDouble(DgvSale.Rows[i].Cells[5].Value);
                total3 += Convert.ToDouble(DgvSale.Rows[i].Cells[6].Value);
                total4 += Convert.ToDouble(DgvSale.Rows[i].Cells[7].Value);
            }
            LblTotal.Text = total1.ToString();
            lblTax.Text = total2.ToString();
            LblDiscount.Text = total3.ToString();
            lblFinalTotal.Text = total4.ToString();
        }

        public void Load_All_Sales()
        {
            DgvSale.Rows.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from Sale_tbl", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();
            while (rdr.Read())
            {
                DgvSale.Rows.Add(rdr["Sale_ID"].ToString(), rdr["Order_No"].ToString(), Convert.ToDateTime(rdr["Order_Date"]).ToString("yyyy/MM/dd"), rdr["Order_Type"].ToString(), rdr["Total"].ToString(), rdr["TaxTotal"].ToString(), rdr["Discount_Total"].ToString(), rdr["FinalTotal"].ToString(), rdr["PaidType"].ToString(), rdr["UserName"].ToString());
            }
            rdr.Close();
            Con.con.Close();
            Get_Totals();
        }


        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Salse_History_Load(object sender, EventArgs e)
        {
            Load_All_Sales();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvSale.Rows.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from Sale_tbl Where Order_No Like '%" + TxtSearch.Text + "%'", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();
            while (rdr.Read())
            {
                DgvSale.Rows.Add(rdr["Sale_ID"].ToString(), rdr["Order_No"].ToString(), Convert.ToDateTime(rdr["Order_Date"]).ToString("yyyy/MM/dd"), rdr["Order_Type"].ToString(), rdr["Total"].ToString(), rdr["TaxTotal"].ToString(), rdr["Discount_Total"].ToString(), rdr["FinalTotal"].ToString(), rdr["PaidType"].ToString(), rdr["UserName"].ToString());
            }
            rdr.Close();
            Con.con.Close();
            Get_Totals();
        }


        public void Search2Date(DateTime Order_Date, DateTime Order_Date2)
        {
            try
            {
                DgvSale.Rows.Clear();
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                SqlCommand Cmd = new SqlCommand("Select * from Sale_tbl Where Order_Date >= @Order_Date And Order_Date <= @Order_Date2", Con.con);
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Order_Date", SqlDbType.DateTime).Value = Order_Date;
                Cmd.Parameters.AddWithValue("@Order_Date2", SqlDbType.DateTime).Value = Order_Date2;
                SqlDataReader rdr = Cmd.ExecuteReader();
                while (rdr.Read())
                {
                    DgvSale.Rows.Add(rdr["Sale_ID"].ToString(), rdr["Order_No"].ToString(), Convert.ToDateTime(rdr["Order_Date"]).ToString("yyyy/MM/dd"), rdr["Order_Type"].ToString(), rdr["Total"].ToString(), rdr["TaxTotal"].ToString(), rdr["Discount_Total"].ToString(), rdr["FinalTotal"].ToString(), rdr["PaidType"].ToString(), rdr["UserName"].ToString());
                }
                rdr.Close();
                Con.con.Close();

                Get_Totals();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //rdr.Close();
                Con.con.Close();

            }
        }

        private void BtnSearchDate_Click(object sender, EventArgs e)
        {
            Search2Date(StartDate.Value, EndDate.Value);
        }

        private void TxtSearchUserName_TextChanged(object sender, EventArgs e)
        {
            DgvSale.Rows.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from Sale_tbl Where UserName LIKE '%' + @searchText + '%'", Con.con);
            Cmd.Parameters.AddWithValue("@searchText", TxtSearchUserName.Text);
            SqlDataReader rdr = Cmd.ExecuteReader();
            while (rdr.Read())
            {
                DgvSale.Rows.Add(rdr["Sale_ID"].ToString(), rdr["Order_No"].ToString(), Convert.ToDateTime(rdr["Order_Date"]).ToString("yyyy/MM/dd"), rdr["Order_Type"].ToString(), rdr["Total"].ToString(), rdr["TaxTotal"].ToString(), rdr["Discount_Total"].ToString(), rdr["FinalTotal"].ToString(), rdr["PaidType"].ToString(), rdr["UserName"].ToString());
            }
            rdr.Close();
            Con.con.Close();

            Get_Totals();
        }

        private void TxtSearchOrderType_TextChanged(object sender, EventArgs e)
        {
            DgvSale.Rows.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from Sale_tbl Where Order_Type LIKE '%' + @searchOrderType + '%'", Con.con);
            Cmd.Parameters.AddWithValue("@searchOrderType", TxtSearchOrderType.Text);
            SqlDataReader rdr = Cmd.ExecuteReader();
            while (rdr.Read())
            {
                DgvSale.Rows.Add(rdr["Sale_ID"].ToString(), rdr["Order_No"].ToString(), Convert.ToDateTime(rdr["Order_Date"]).ToString("yyyy/MM/dd"), rdr["Order_Type"].ToString(), rdr["Total"].ToString(), rdr["TaxTotal"].ToString(), rdr["Discount_Total"].ToString(), rdr["FinalTotal"].ToString(), rdr["PaidType"].ToString(), rdr["UserName"].ToString());
            }
            rdr.Close();
            Con.con.Close();

            Get_Totals();
        }

        private void TxtSearchPaidType_TextChanged(object sender, EventArgs e)
        {
            DgvSale.Rows.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from Sale_tbl Where PaidType LIKE N'%' + @searchPaidType + '%'", Con.con);
            Cmd.Parameters.AddWithValue("@searchPaidType", TxtSearchPaidType.Text);
            SqlDataReader rdr = Cmd.ExecuteReader();
            while (rdr.Read())
            {
                DgvSale.Rows.Add(rdr["Sale_ID"].ToString(), rdr["Order_No"].ToString(), Convert.ToDateTime(rdr["Order_Date"]).ToString("yyyy/MM/dd"), rdr["Order_Type"].ToString(), rdr["Total"].ToString(), rdr["TaxTotal"].ToString(), rdr["Discount_Total"].ToString(), rdr["FinalTotal"].ToString(), rdr["PaidType"].ToString(), rdr["UserName"].ToString());
            }
            rdr.Close();
            Con.con.Close();

            Get_Totals();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }




     
    }
}
