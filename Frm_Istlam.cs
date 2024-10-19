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
    public partial class Frm_Istlam : Form
    {

        Connection Con;
        Frm_pos Frm_pos ;

        public Frm_Istlam(Frm_pos Frm_pos2)
        {
            InitializeComponent();
            Con = new Connection();
            this.Frm_pos = Frm_pos2;
        }

        private void BtnIstlam_Click(object sender, EventArgs e)
        {

            if (Con.con.State == ConnectionState.Open)
                Con.con.Close();
            Con.con.Open();

            
            SqlCommand Cmd = new SqlCommand("Update Cashier_tbl Set Cashier_Balance=Cashier_Balance + @Cashier_Balance , Start_Balance = @Start_Balance , Cashier_Status='True' Where Cashier_ID=@Cashier_ID", Con.con);
            Cmd.Parameters.AddWithValue("@Cashier_Balance", 0.0);
            Cmd.Parameters.AddWithValue("@Start_Balance", Convert.ToDouble(TxtTotal.Text));
            Cmd.Parameters.AddWithValue("@Cashier_ID", Connection._Cashier_ID);
            Cmd.ExecuteNonQuery();
    
            Con.con.Close();

            MessageBox.Show("تم استلام الصندوق بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            this.Close(); // close form istlam  

                //----------------- Frm_pos 
                this.Frm_pos.loadall_cat(); // تحميل التصنيفات
                this.Frm_pos.Load_Items();  // تحميل المنتجات على شكل صور 
                //frm.loadall_Item_Button(); // تحميل المنتجات على شكل ازرار

                this.Frm_pos.BtnNew.Enabled = true;
                this.Frm_pos.btnPaid.Enabled = true;
                this.Frm_pos.BtnIstlam.Enabled = false;
                this.Frm_pos.BtnTaslem.Enabled = true;
              
             
            }

           
             
        


    }
}
