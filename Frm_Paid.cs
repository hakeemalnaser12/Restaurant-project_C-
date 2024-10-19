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
using Res_csharp.Reports;
using System.IO;


namespace Res_csharp
{
    public partial class Frm_Paid : Form
    {
        Connection Con;

        QrCode Qr ;
        Frm_pos Frm_pos;
        Frm_Print frm_Print = new Frm_Print();



        public Frm_Paid(Frm_pos Frm_pos2)
        {
            InitializeComponent();
            Con = new Connection();
            Qr = new QrCode(Frm_pos2);
            this.Frm_pos = Frm_pos2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPaid_TextChanged(object sender, EventArgs e)
        {
            TxtUnPaid.Text = (Convert.ToDecimal(TxtPaid.Text) - Convert.ToDecimal(TxtFinalTotal.Text)).ToString();
        }

        private void BtnPaidOrder_Click(object sender, EventArgs e)
        {
            TxtUnPaid.Text = (Convert.ToDecimal(TxtPaid.Text) - Convert.ToDecimal(TxtFinalTotal.Text)).ToString();

            if (string.IsNullOrEmpty(CmbPaidType.Text))
            {
                MessageBox.Show("المبلغ المدفوع أقل من قيمة الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            // هذا الكود خاص بالفاتورة الالكترونية
            string Field1 = "";
            Field1 = Qr.ConvertToHex("01", Connection._CompanyName);
            string Field2 = "";
            Field2 = Qr.ConvertToHex("02", Connection._vat_No);
            string Field3 = "";
            string myDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssZ");
            Field3 = Qr.ConvertToHex("03", myDate);
            string Field4 = "";
            Field4 = Qr.ConvertToHex("04", TxtFinalTotal.Text);
            string Field5 = "";
            Field5 = Qr.ConvertToHex("05", Connection._TaxTotal.ToString());
            string All_Field = Field1 + Field2 + Field3 + Field4 + Field5;
            this.Frm_pos.TxtHexToBase64.Text = Res_csharp.Model.QrCode.HexToBase64(All_Field);
            var _Result = Qr.Base64ToHex(this.Frm_pos.TxtHexToBase64.Text);
            Qr.Get_QrCode();
            //********************************************
            if (Convert.ToDouble(TxtPaid.Text) < Convert.ToDouble(TxtFinalTotal.Text))
            {
                MessageBox.Show("المبلغ المدفوع أقل من قيمة الفاتورة");
                return;
            }


            if (Convert.ToDouble(TxtPaid.Text) > Convert.ToDouble(TxtFinalTotal.Text))
            {
                MessageBox.Show("المبلغ المدفوع أكبر من قيمة الفاتورة");
                return;
            }


            Insert_Sale(); // عمل ادخال البيانات الى جدول المبيعات

            if (Connection._order_Type == "Delevery")
            {
                Insert_Delevery(); // عمل ادخال البيانات الى جدول التوصيل
                //Frm_pos.BtnSelectDelevery.Visible = false;
            }

            // اذا طريقة الدفع نقدي نحتاج ان يحفظ المبلغ في صندوق الكاشير
            if (CmbPaidType.Text == "نقدي")
            {
                Update_Cashier_Balance();
            }

            Insert_Cashier_Move(); // عمل ادخال البيانات الى جدول التوصيل

            // تعديل حالة الطاولة الى مغلق 
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Update Order_tbl Set Status = 'Close' Where Order_No=@Order_No", Con.con);
            Cmd.Parameters.AddWithValue("@Order_No", Connection._Order_No);
            Cmd.ExecuteNonQuery();
            Con.con.Close();
            //****************************************************************************************

            if (MessageBox.Show("هل تريد طباعة الفاتورة قبل الخروج", "الطباعة", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                this.Close();
                //Frm_pos frmPos = new Frm_pos();
                Frm_pos.TxtOrder_No.Text = "";
                Frm_pos.OrderDate.Value = DateTime.Today;
                Frm_pos.TxtFinalTotal.Text = "0";
                Frm_pos.TxtCount.Text = "0";
                Frm_pos.TxtTotal.Text = "0";
                Frm_pos.TxtTableName.Text = "";
                Frm_pos.LblTax.Text = "0.0";
                Frm_pos.Dgv.Rows.Clear();
                Frm_pos.TxtServices.Text = "0.0";
                Frm_pos.dgv_Print.DataSource = null;
                // هنا حق الفاتورة الالكترونية
                Frm_pos.TxtBase64ToHex.Text = "";
                Frm_pos.TxtHexToBase64.Text = "";
                Frm_pos.QrCode_Pic.Image = null;

            }

            else
            {
                if (Res_csharp.Properties.Settings.Default.SalePrint == "A4")
                {
                    if (Connection._order_Type == "Delevery")
                    {
                        // الطباعة كورقة ايفور ولكن يطبع تقرير فاتورة التوصيل
                        Print_Delevery_Invoice_A4();
                        Print_By_Dep(); // Print_By_Kitchen
                        this.Close();
                        //Frm_pos frmPos = new Frm_pos();
                        Frm_pos.TxtOrder_No.Text = "";
                        Frm_pos.OrderDate.Value = DateTime.Today;
                        Frm_pos.TxtFinalTotal.Text = "0";
                        Frm_pos.TxtCount.Text = "0";
                        Frm_pos.TxtTotal.Text = "0";
                        Frm_pos.TxtTableName.Text = "";
                        Frm_pos.LblTax.Text = "0.0";
                        Frm_pos.Dgv.Rows.Clear();
                        Frm_pos.TxtServices.Text = "0.0";
                        Frm_pos.dgv_Print.DataSource = null;
                        // هنا حق الفاتورة الالكترونية
                        Frm_pos.TxtBase64ToHex.Text = "";
                        Frm_pos.TxtHexToBase64.Text = "";
                        Frm_pos.QrCode_Pic.Image = null;
                    }
                    else
                    {
                        // الطباعة كورقة ايفور ولكن يطبع تقرير فاتورة البيع العادية
                        PrintInvoice_A4();
                        Print_By_Dep(); // Print_By_Kitchen
                        this.Close();
                        //Frm_pos frmPos = new Frm_pos();
                        Frm_pos.TxtOrder_No.Text = "";
                        Frm_pos.OrderDate.Value = DateTime.Today;
                        Frm_pos.TxtFinalTotal.Text = "0";
                        Frm_pos.TxtCount.Text = "0";
                        Frm_pos.TxtTotal.Text = "0";
                        Frm_pos.TxtTableName.Text = "";
                        Frm_pos.LblTax.Text = "0.0";
                        Frm_pos.Dgv.Rows.Clear();
                        Frm_pos.TxtServices.Text = "0.0";
                        Frm_pos.dgv_Print.DataSource = null;
                        // هنا حق الفاتورة الالكترونية
                        Frm_pos.TxtBase64ToHex.Text = "";
                        Frm_pos.TxtHexToBase64.Text = "";
                        Frm_pos.QrCode_Pic.Image = null;
                    }

                }
                else if (Res_csharp.Properties.Settings.Default.SalePrint == "8Cm")
                {
                    PrintInvoice_8CM();
                    Print_By_Dep(); // Print_By_Kitchen
                    this.Close();
                    //Frm_pos frmPos = new Frm_pos();
                    Frm_pos.TxtOrder_No.Text = "";
                    Frm_pos.OrderDate.Value = DateTime.Today;
                    Frm_pos.TxtFinalTotal.Text = "0";
                    Frm_pos.TxtCount.Text = "0";
                    Frm_pos.TxtTotal.Text = "0";
                    Frm_pos.TxtTableName.Text = "";
                    Frm_pos.LblTax.Text = "0.0";
                    Frm_pos.Dgv.Rows.Clear();
                    Frm_pos.TxtServices.Text = "0.0";
                    Frm_pos.dgv_Print.DataSource = null;
                    // هنا حق الفاتورة الالكترونية
                    Frm_pos.TxtBase64ToHex.Text = "";
                    Frm_pos.TxtHexToBase64.Text = "";
                    Frm_pos.QrCode_Pic.Image = null;
                }



            }
        }
        public void Insert_Delevery()
        {
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();

            using (SqlCommand cmd = new SqlCommand("Insert Into Order_Delevery_tbl (Order_ID, DeleveryMan_ID, Customer_ID) values (@Order_ID, @DeleveryMan_ID, @Customer_ID)", Con.con))
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Order_ID", SqlDbType.VarChar).Value = Connection._Order_No;
                cmd.Parameters.AddWithValue("@DeleveryMan_ID", SqlDbType.Int).Value = Connection._DeleveryMan_ID;
                cmd.Parameters.AddWithValue("@Customer_ID", SqlDbType.Int).Value = Connection._Customer_ID;

                cmd.ExecuteNonQuery();
            }

            Con.con.Close();
            // MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Insert_Sale()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Con.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert Into Sale_tbl (Order_No, Order_Date, Order_Type, Total, Tax_Value, TaxTotal, Discount_Total, FinalTotal, PaidType, UserName, QrCode_Pic) values (@Order_No, @Order_Date, @Order_Type, @Total, @Tax_Value, @TaxTotal, @Discount_Total, @FinalTotal, @PaidType, @UserName, @QrCode_Pic)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Order_No", SqlDbType.VarChar).Value = Connection._Order_No;
                cmd.Parameters.AddWithValue("@Order_Date", SqlDbType.Date).Value = DateTime.Today;
                cmd.Parameters.AddWithValue("@Order_Type", SqlDbType.VarChar).Value = Connection._order_Type;
                cmd.Parameters.AddWithValue("@Total", SqlDbType.Decimal).Value = Connection._Order_Total;
                cmd.Parameters.AddWithValue("@Tax_Value", SqlDbType.Decimal).Value = Connection._Tax_Value;
                cmd.Parameters.AddWithValue("@TaxTotal", SqlDbType.Decimal).Value = Connection._TaxTotal;
                cmd.Parameters.AddWithValue("@Discount_Total", SqlDbType.Decimal).Value = Convert.ToDecimal(TxtDiscount.Text);
                cmd.Parameters.AddWithValue("@FinalTotal", SqlDbType.Decimal).Value = Convert.ToDecimal(TxtFinalTotal.Text);
                cmd.Parameters.AddWithValue("@PaidType", SqlDbType.VarChar).Value = CmbPaidType.Text;
                cmd.Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = Connection._Cashier_UserName; // _UserName '  "Admin"

                 //الباراميتر الاخير خاص باضافة صورة الكيوار كود لجدول المبيعات تابع شغل الفاتورة الالكترونية

                //if (this.Frm_pos.QrCode_Pic.Image == null)
                //    MessageBox.Show("لاتوجد صورة للباركود");

                using (MemoryStream ms = new MemoryStream())
                { 

                    Bitmap bmpImage = new Bitmap(this.Frm_pos.QrCode_Pic.Image);
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data = ms.GetBuffer();
                    SqlParameter p = new SqlParameter("@QrCode_Pic", SqlDbType.Image)
                    {
                        Value = data
                    };
                    cmd.Parameters.Add(p);
                }


                if (Con.con.State == ConnectionState.Open) Con.con.Close();
                Con.con.Open();
                cmd.ExecuteNonQuery();
                Con.con.Close();
            }

            MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDiscount.Text) || Convert.ToDouble(TxtDiscount.Text) == 0)
            {
                TxtFinalTotal.Text = Connection._FinalTotal.ToString();
            }
            else
            {
                double discount = Convert.ToDouble(TxtDiscount.Text);
                TxtFinalTotal.Text = (Connection._FinalTotal - discount).ToString();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                TxtDiscount.Enabled = true;
            }
            else
            {
                TxtDiscount.Enabled = false;
                TxtDiscount.Text = "0.0";
            }
        }

        private void Frm_Paid_Load(object sender, EventArgs e)
        {
            TxtDiscount.Enabled = false;
        }


        public void PrintInvoice_8CM()
        {
            Res_csharp.DataSet.DataSet1 ds = new Res_csharp.DataSet.DataSet1();

            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();

            // Select data from Sale_tbl
            SqlCommand cmd = new SqlCommand("Select * FROM Sale_tbl Where Order_No=@Order_No", Con.con);
            cmd.Parameters.AddWithValue("@Order_No", Connection._Order_No);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "Sale_tbl");

            // Select data from View_Order_Print
            SqlCommand cmd2 = new SqlCommand("Select * FROM View_Order_Print Where Order_No=@Order_No", Con.con);
            cmd2.Parameters.AddWithValue("@Order_No", Connection._Order_No);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(ds, "View_Order_Print");

            // Select data from Company_tbl
            SqlCommand cmd3 = new SqlCommand("Select * FROM Company_tbl", Con.con);
            SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
            adp3.Fill(ds, "Company_tbl");

            // Create and set up the report
            Invoic_8cm rpt = new Invoic_8cm();
            rpt.SetDataSource(ds);

            // Set the report source and print
            frm_Print.crystalReportViewer1.ReportSource = rpt;
            rpt.PrintOptions.PrinterName = Res_csharp.Properties.Settings.Default.PrinterName;
            rpt.PrintToPrinter(1, false, 0, 0);

            Con.con.Close();
        }
        public void PrintInvoice_A4()
        {
            Res_csharp.DataSet.DataSet1 ds = new Res_csharp.DataSet.DataSet1();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();


            //**********************************************************
            SqlCommand cmd = new SqlCommand("Select * FROM Sale_tbl Where Order_No=@Order_No", Con.con);
            cmd.Parameters.AddWithValue("@Order_No", Connection._Order_No);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "Sale_tbl");

            //**********************************************************
            SqlCommand cmd2 = new SqlCommand("Select * FROM View_Order_Print Where Order_No=@Order_No", Con.con);
            cmd2.Parameters.AddWithValue("@Order_No", Connection._Order_No);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(ds, "View_Order_Print");

            //**********************************************************
            SqlCommand cmd3 = new SqlCommand("Select * FROM Company_tbl", Con.con);
            SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
            adp3.Fill(ds, "Company_tbl");

            //**********************************************************
            //Frm_Print.Show();
            //Frm_Print.WindowState = FormWindowState.Maximized;
            //Invoiv_A4 rpt = new Invoiv_A4();
            //rpt.SetDataSource(ds);
            //Frm_Print.CrystalReportViewer1.ReportSource = rpt;
            //Frm_Print.CrystalReportViewer1.Refresh();
            //Con.Close();

            Invoiv_A4 rpt = new Invoiv_A4();
            rpt.SetDataSource(ds);
            frm_Print.crystalReportViewer1.ReportSource = rpt;

            System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
            rpt.PrintOptions.PrinterName = Res_csharp.Properties.Settings.Default.PrinterName;
            rpt.PrintToPrinter(1, false, 0, 0);

            Con.con.Close();
        }
        public void Print_By_Dep()
        {
            // Print_By_Kitchen
            for (int i = 0; i < Frm_pos.dgv_Print.Rows.Count; i++)
            {
                if ((bool)Frm_pos.dgv_Print.Rows[i].Cells[3].Value)
                {
                    Res_csharp.DataSet.DataSet1 ds = new Res_csharp.DataSet.DataSet1();
                    if (Con.con.State == ConnectionState.Open) Con.con.Close();
                    Con.con.Open();

                    SqlCommand cmd = new SqlCommand("Select * FROM View_ByDep Where Dep_ID=@Dep_ID And Order_No=@Order_No", Con.con);
                    cmd.Parameters.AddWithValue("@Dep_ID", Frm_pos.dgv_Print.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@Order_No", Connection._Order_No);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds, "View_ByDep");

                    //**********************************************************
                    Print_Dep rpt1 = new Print_Dep();
                    rpt1.SetDataSource(ds);
                    frm_Print.crystalReportViewer1.ReportSource = rpt1;
                    System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
                    rpt1.PrintOptions.PrinterName = Frm_pos.dgv_Print.Rows[i].Cells[2].Value.ToString();
                    rpt1.PrintToPrinter(1, false, 0, 0);
                    Con.con.Close();
                }
            }
        }
        public void Print_Delevery_Invoice_A4()
        {
            Res_csharp.DataSet.DataSet1 ds = new Res_csharp.DataSet.DataSet1();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();


            // Select data from Sale_tbl
            SqlCommand cmd = new SqlCommand("Select * FROM Sale_tbl Where Order_No=@Order_No", Con.con);
            cmd.Parameters.AddWithValue("@Order_No", Frm_pos.TxtOrder_No.Text);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "Sale_tbl");

            // Select data from View_Order_Print
            SqlCommand cmd1 = new SqlCommand("Select * FROM View_Order_Print Where Order_No=@Order_No", Con.con);
            cmd1.Parameters.AddWithValue("@Order_No", Frm_pos.TxtOrder_No.Text);
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
            adp1.Fill(ds, "View_Order_Print");

            // Select data from Company_tbl
            SqlCommand cmd2 = new SqlCommand("Select * FROM Company_tbl", Con.con);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(ds, "Company_tbl");

            // Select data from View_Order_Delevery
            SqlCommand cmd3 = new SqlCommand("Select * FROM View_Order_Delevery Where Order_ID=@Order_ID", Con.con);
            cmd3.Parameters.AddWithValue("@Order_ID", Frm_pos.TxtOrder_No.Text);
            SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
            adp3.Fill(ds, "View_Order_Delevery");

            // Create and set Crystal Report data source
            DeleveryInvoice_A4 rpt = new DeleveryInvoice_A4();
            rpt.SetDataSource(ds);
            frm_Print.crystalReportViewer1.ReportSource = rpt;

            // Print the report
            rpt.PrintOptions.PrinterName = Res_csharp.Properties.Settings.Default.PrinterName;
            rpt.PrintToPrinter(1, false, 0, 0);

            Con.con.Close();
        }
        public void Update_Cashier_Balance()
        {
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();

            using (SqlCommand cmd = new SqlCommand("UPDATE Cashier_tbl SET Cashier_Balance = Cashier_Balance + @Cashier_Balance WHERE Cashier_ID = @Cashier_ID", Con.con))
            {
                cmd.Parameters.AddWithValue("@Cashier_Balance", Convert.ToDouble(TxtPaid.Text));
                cmd.Parameters.AddWithValue("@Cashier_ID", Connection._Cashier_ID);

                cmd.ExecuteNonQuery();
            }

            Con.con.Close();
        }
        public void Insert_Cashier_Move()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Con.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Move_Cashier_tbl (Cashier_ID, Order_No, FinalTotal, Move_Type, MoveDate) VALUES (@Cashier_ID, @Order_No, @FinalTotal, @Move_Type, @MoveDate)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cashier_ID", Connection._Cashier_ID);
                cmd.Parameters.AddWithValue("@Order_No", Connection._Order_No);
                cmd.Parameters.AddWithValue("@FinalTotal", Convert.ToDouble(TxtFinalTotal.Text));

                if (CmbPaidType.Text == "نقدي")
                {
                    cmd.Parameters.AddWithValue("@Move_Type", "Cash");
                }
                else if (CmbPaidType.Text == "فيزا")
                {
                    cmd.Parameters.AddWithValue("@Move_Type", "Visa");
                }

                cmd.Parameters.AddWithValue("@MoveDate", DateTime.Today);

                if (Con.con.State == ConnectionState.Open) Con.con.Close();
                Con.con.Open();
                cmd.ExecuteNonQuery();
                Con.con.Close();
            }

            // MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       


    }
}
