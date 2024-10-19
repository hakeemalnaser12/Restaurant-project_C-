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
    public partial class FrmQty : Form
    {

        Connection Con;
        Frm_pos Frm_pos;

        public FrmQty(Frm_pos Frm_pos1)
        {
            InitializeComponent();
            Con = new Connection();
            this.Frm_pos = Frm_pos1;
        }

        private void FrmQty_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtQty_KeyDown(object sender, KeyEventArgs e)
        {
            // في حاله الضغط على زر الانتر 
            if (e.KeyCode == Keys.Enter)
    {
         //  في حال كان الرقم المدخل في حقل الكمية لايساوي الصفر او ليس فارغ
       if (!string.IsNullOrEmpty(TxtQty.Text) && int.Parse(TxtQty.Text) > 0)
        {
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();

            // Execute a SQL query to select data from the Prd_tbl table based on a product ID
            SqlCommand cmd = new SqlCommand("Select * From Prd_tbl Where Prd_ID=@Prd_ID", Con.con);
            cmd.Parameters.AddWithValue("@Prd_ID", Connection._ID);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows)
            {
                Connection._ID = Convert.ToInt32(rdr["Prd_ID"].ToString());
                Connection._PrdName = rdr["PrdName"].ToString();
                Connection._SalePrice = Convert.ToDouble(rdr["PrdPrice"].ToString());
            }
            rdr.Close();
            Con.con.Close();

            //********************************* Ensert Into Table Order ****************************************
            // Insert or update the order record in the Order_tbl table
            if (!Check_Prd(Frm_pos.TxtOrder_No.Text, Connection._ID))
            {
                  //في حاله لم يرجع ترو اي لايوجد هذا الصنف في الداتا جريد فيو 
                  //   نقوم بعمل الاضافة على قاعدة البيانات والداتا جريد فيو 
                // If the product is not already in the Order_tbl table, insert a new record
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                cmd = new SqlCommand("Insert Into Order_tbl (Order_No,Order_Date,Prd_ID,SalePrice,Qty,Total,TableName,Status,UserName)values(@Order_No,@Order_Date,@Prd_ID,@SalePrice,@Qty,@Total,@TableName,@Status,@UserName)", Con.con);
                cmd.Parameters.AddWithValue("@Order_No", Frm_pos.TxtOrder_No.Text);
                cmd.Parameters.AddWithValue("@Order_Date", Frm_pos.OrderDate.Value);
                cmd.Parameters.AddWithValue("@Prd_ID", Connection._ID);
                cmd.Parameters.AddWithValue("@SalePrice", Connection._SalePrice);
                cmd.Parameters.AddWithValue("@Qty", TxtQty.Text);
                double MyTotal = Connection._SalePrice * int.Parse(TxtQty.Text);
                cmd.Parameters.AddWithValue("@Total", MyTotal);
                cmd.Parameters.AddWithValue("@TableName", Frm_pos.TxtTableName.Text);
                cmd.Parameters.AddWithValue("@Status", "Open");
                cmd.Parameters.AddWithValue("@UserName", Connection._Cashier_UserName); // _UserName ' "Admin"
                cmd.ExecuteNonQuery();
                Con.con.Close();
            }
            else
            {
                 //  في حاله لم يرجع فولس اي يوجد هذا الصنف في الداتا جريد فيو 
                 //    نقوم بعمل تعديل الكمية على قاعدة البيانات والداتا جريد فيو
                // If the product is already in the Order_tbl table, update the quantity
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                cmd = new SqlCommand("Update Order_tbl Set Qty=Qty+@Qty Where Order_No=@Order_No And Prd_ID=@Prd_ID ", Con.con);
                cmd.Parameters.AddWithValue("@Qty", int.Parse(TxtQty.Text));
                cmd.Parameters.AddWithValue("@Order_No", Frm_pos.TxtOrder_No.Text);
                cmd.Parameters.AddWithValue("@Prd_ID", Connection._ID);
                cmd.ExecuteNonQuery();
                Con.con.Close();

                 //  ************************************************************
                 //    تعديل الاجمالي 
                // Update the total price of the order
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                cmd = new SqlCommand("Update Order_tbl Set Total = SalePrice * Qty Where Order_No=@Order_No And Prd_ID=@Prd_ID ", Con.con);
                cmd.Parameters.AddWithValue("@Order_No", Frm_pos.TxtOrder_No.Text);
                cmd.Parameters.AddWithValue("@Prd_ID", Connection._ID);
                cmd.ExecuteNonQuery();
                Con.con.Close();
            }

            // Display a message box to confirm successful insertion or update
            //MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the text box and close the form
            TxtQty.Text = "";
            this.Close();

            // Reload the data grid view on another form named Frm_pos
            //using (Frm_pos frm = new Frm_pos())
            //{
            Frm_pos.Load_Order();
            Frm_pos.Order_Table();
            Frm_pos.Dgv.FirstDisplayedScrollingRowIndex = Frm_pos.Dgv.RowCount - 1;
            Frm_pos.Dgv.Rows[Frm_pos.Dgv.RowCount - 1].Selected = true;
            //}
        }
        else
        {
            // في حال كان الرقم المدخل في حقل الكمية يساوي الصفر
            // Display an error message if the quantity is invalid
            MessageBox.Show("عفواً ، قم بإدخال كمية أكبر من الصفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

            
        }



        public bool Check_Prd(string Order_No, int Prd_ID)
        {
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) From Order_tbl Where Order_No=@Order_No And Prd_ID=@Prd_ID", Con.con);
            cmd.Parameters.AddWithValue("@Order_No", Order_No);
            cmd.Parameters.AddWithValue("@Prd_ID", Prd_ID);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            return i > 0;
        }

      







    }
}
