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
using System.IO;

namespace Res_csharp
{
    public partial class Frm_Taslem : Form
    {
        Connection Con;

       
        public Frm_Taslem()
        {
            InitializeComponent();
            Con = new Connection();
        
        }

        public void Get_Start_Balance()
        {
            if (Con.con.State == ConnectionState.Open)
                Con.con.Close();

            Con.con.Open();

            SqlCommand Cmd = new SqlCommand("SELECT Cashier_ID, Start_Balance FROM Cashier_tbl WHERE Cashier_ID = @Cashier_ID ", Con.con);
            Cmd.Parameters.AddWithValue("@Cashier_ID", Connection._Cashier_ID);
            SqlDataReader rdr = Cmd.ExecuteReader();
            if (rdr.Read() && rdr.HasRows)
            {
                TxtStart_Balance.Text = rdr["Start_Balance"].ToString();
            }
            Con.con.Close();
        }


        public void Get_Cash()
        {
            if (Con.con.State == ConnectionState.Open)
                Con.con.Close();

            Con.con.Open();

           SqlCommand Cmd = new SqlCommand("SELECT Cashier_ID, SUM(FinalTotal) AS F_Total, Move_Type AS Paid FROM Move_Cashier_tbl WHERE Cashier_ID = @Cashier_ID AND Move_Type = 'Cash' AND MoveDate = @MoveDate GROUP BY Cashier_ID, Move_Type", Con.con);
           Cmd.Parameters.AddWithValue("@Cashier_ID", Connection._Cashier_ID);
                Cmd.Parameters.AddWithValue("@MoveDate", DateTime.Today);
           SqlDataReader rdr = Cmd.ExecuteReader();
                    if (rdr.Read() && rdr.HasRows)
                    {
                        TxtTotalCash.Text = rdr["F_Total"].ToString();
                    }
            Con.con.Close();
        }

        public void Get_Visa()
        {
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();

            SqlCommand Cmd = new SqlCommand("Select Cashier_ID, Sum(FinalTotal) As F_Total, Move_Type As Paid FROM Move_Cashier_tbl Where Cashier_ID = @CashierID And Move_Type = 'Visa' And MoveDate = @MoveDate group by Cashier_ID, Move_Type", Con.con);
            Cmd.Parameters.AddWithValue("@CashierID", Connection._Cashier_ID);
            Cmd.Parameters.AddWithValue("@MoveDate", DateTime.Today);
            SqlDataReader rdr = Cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (rdr.HasRows)
                {
                    TxtTotalVisa.Text = rdr["F_Total"].ToString();
                }
            }
            rdr.Close();
            Con.con.Close();
        }

        //   داله اضافه بيانات مبالغ الصندوق عند تسليم الصندوق

        public void Insert_Get_Cash_tbl()
        {
            if (Con.con.State == ConnectionState.Open)
                Con.con.Close();
            Con.con.Open();

        SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con.con;
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "INSERT INTO Get_Cash_tbl (Cashier_ID, Start_Balance, CashMoney, Visa, GetDate) VALUES (@Cashier_ID, @Start_Balance, @CashMoney, @Visa, @GetDate)";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Cashier_ID", Connection._Cashier_ID);
                Cmd.Parameters.AddWithValue("@Start_Balance", SqlDbType.Decimal).Value = Convert.ToDecimal(TxtStart_Balance.Text);
                Cmd.Parameters.AddWithValue("@CashMoney", SqlDbType.Decimal).Value = Convert.ToDecimal(TxtTotalCash.Text);
                Cmd.Parameters.AddWithValue("@Visa", SqlDbType.Decimal).Value = Convert.ToDecimal(TxtTotalVisa.Text);
                Cmd.Parameters.AddWithValue("@GetDate", SqlDbType.Date).Value = DateTime.Today;
                Cmd.ExecuteNonQuery();

            Con.con.Close();

            MessageBox.Show("تم تسليم الصندوق بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        //  داله التعديل على جدول الكاشير بعد تسليم الصندوق لتعديل بياناته بعد التسليم
        public void Update_Cashier_tbl()
        {
            SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con.con;
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "UPDATE Cashier_tbl SET Start_Balance = @Start_Balance, Cashier_Balance = @Cashier_Balance, Cashier_Status = @Cashier_Status WHERE Cashier_ID = @Cashier_ID";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Start_Balance", SqlDbType.Decimal).Value = 0.0;
                Cmd.Parameters.AddWithValue("@Cashier_Balance", SqlDbType.Decimal).Value = 0.0;
                Cmd.Parameters.AddWithValue("@Cashier_Status", SqlDbType.Bit).Value = false; // استخدام SqlDbType.Bit للحقل المنطقي
                Cmd.Parameters.AddWithValue("@Cashier_ID", SqlDbType.Int).Value = Connection._Cashier_ID;

                if (Con.con.State == ConnectionState.Open)
                    Con.con.Close();

                Con.con.Open();
                Cmd.ExecuteNonQuery();
                Con.con.Close();
            // MessageBox.Show("تم تعديل السجل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnIstlam_Click(object sender, EventArgs e)
        {
            // استدعاء دالة إضافة بيانات مبالغ الصندوق عند تسليم الصندوق
            Insert_Get_Cash_tbl();

            // استدعاء دالة التعديل على جدول الكاشير بعد تسليم الصندوق لتعديل بياناته بعد التسليم
            Update_Cashier_tbl();

            // إنهاء التطبيق
            Application.Exit();
        }

     
      
           
        

        
    }
}
