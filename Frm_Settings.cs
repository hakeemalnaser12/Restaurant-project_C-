using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;
using Res_csharp.Model;
using Microsoft.Win32;

namespace Res_csharp
{
    public partial class Frm_Settings : Form
    {
       
       public string sqlConnSrt = null;
       SqlConnection sqlConn = new SqlConnection();

       Connection Con;
       public SqlCommand Cmd2;
       public SqlDataReader rdr2;

        public Frm_Settings()
        {
            InitializeComponent();

            Con = new Connection();
            CheckPremitonforms(Connection._UserID);
        }


        public void CheckPremitonforms(string UserAccID)
        {
            if (Con.con.State == System.Data.ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            Cmd2 = new SqlCommand("Select btnSaveValueTax,btnSaveStatusTax,btnSavePrintDef,btnSaveReportDef,btnSave From Permissions_Tbl where UserAccID ='" + UserAccID + "'", Con.con);
            rdr2 = Cmd2.ExecuteReader();
            rdr2.Read();

            if ((bool)rdr2["btnSaveValueTax"] == true)
                BtnSave.Enabled = true;
            else BtnSave.Enabled = false;

            if ((bool)rdr2["btnSaveStatusTax"] == true)
                btnSave_Status.Enabled = true;
            else btnSave_Status.Enabled = false;

            if ((bool)rdr2["btnSavePrintDef"] == true)
                btnSavePrinters.Enabled = true;
            else btnSavePrinters.Enabled = false;

            if ((bool)rdr2["btnSaveReportDef"] == true)
                btnSaveSaleReport.Enabled = true;
            else btnSaveSaleReport.Enabled = false;

            //  فحص الصلاحية لزر الحفظ لاعدادات السيرفر والقاعدة
            if ((bool)rdr2["btnSave"] == true)
            {
                button1.Enabled = true;
                button2.Enabled = true;

            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }

        }



        // متغير يستخدم في داله تحميل الطابعات 
        string printerName = string.Empty; 

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();

            SqlCommand Cmd = new SqlCommand("Select * from Tax_tbl", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                //في حال كانت هناك ضريبة سابقة يعمل تعديل عليها 
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();

                Cmd = new SqlCommand("Update Tax_tbl Set Tax_Value = @Tax_Value Where Tax_ID=@Tax_ID", Con.con);
                Cmd.Parameters.AddWithValue("@Tax_Value", Convert.ToDouble(TxtTax_Value.Text));
                Cmd.Parameters.AddWithValue("@Tax_ID", Convert.ToInt32(TxtTax_ID.Text));
                Cmd.ExecuteNonQuery();
                Con.con.Close();

                MessageBox.Show("تم تعديل بيانات الضريبة بنجاح ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //  في حال كانت لاتوجد ضريبة سابقة يعمل اضافة جديدة  
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();

                Cmd = new SqlCommand("insert into Tax_tbl ( Tax_Value ) values (@Tax_Value) ", Con.con);
                Cmd.Parameters.AddWithValue("@Tax_Value", Convert.ToDouble(TxtTax_Value.Text));
                Cmd.ExecuteNonQuery();
                Con.con.Close();

                MessageBox.Show("تم تعديل اضافة الضريبة بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            rdr.Close();
            Con.con.Close();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Cmd2 = null;
            rdr2.Close();
        }

        private void btnSave_Status_Click(object sender, EventArgs e)
        {
            if (CheckTax.Checked)
            {
                Properties.Settings.Default.Tax_Status = true;
                Properties.Settings.Default.Save();
                MessageBox.Show("تم تفعيل الضريبة بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Properties.Settings.Default.Tax_Status = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("تم الغاء تفعيل الضريبة بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_Settings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Tax_Status)
            {
                CheckTax.Checked = true;
            }
            else
            {
                CheckTax.Checked = false;
            }

             Get_Tax();

             ShowPrinters(); // تحميل الطابعات

        // شك بوكس خاص بخيارات مقاس تقرير المبيعات

             if (Properties.Settings.Default.SalePrint == "A4")
             {
                 CheckSaleA4.Checked = true;
                 CheckSale8Cm.Checked = false;
             }
             else if (Properties.Settings.Default.SalePrint == "8Cm")
             {
                 CheckSale8Cm.Checked = true;
                 CheckSaleA4.Checked = false;
             }


            // ---------------------------- Con server
             LoadInstalledServers(CombServers);
             FillCombByDataBases(this.CombServers, this.ComboDBs);
             ShowSavedSettings();
        }

        public void Get_Tax()
        {
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("select * from Tax_tbl", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows)
            {
                // في حال وجود بيانات حملها للحقول 
                TxtTax_ID.Text = rdr["Tax_ID"].ToString();
                TxtTax_Value.Text = rdr["Tax_Value"].ToString();
            }
            else
            {
                // وفي حال لايوجد اجعلها فارغة 
                TxtTax_ID.Text = "";
                TxtTax_Value.Text = "";
            }
            rdr.Close();
            Con.con.Close();
        }

        // *********************************************  tab page of Printer settings  ***********************************************************

        private void ShowPrinters()
        {
            try
            {
                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    string PrinterName = PrinterSettings.InstalledPrinters[i];
                    cmbPrinter.Items.Add(PrinterName);
                }
                if (Properties.Settings.Default.PrinterName == "")
                    cmbPrinter.SelectedIndex = 0;
                else
                    cmbPrinter.SelectedItem = Properties.Settings.Default.PrinterName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePrinters_Click(object sender, EventArgs e)
        {
            if (cmbPrinter.Text == "")
            {
                MessageBox.Show("من فضلك تأكد من بيانات الطابعة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Properties.Settings.Default.PrinterName = cmbPrinter.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show(" تم الحفظ بنجاح ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveSaleReport_Click(object sender, EventArgs e)
        {
            if (CheckSaleA4.Checked)
            {
                Properties.Settings.Default.SalePrint = "A4";
                Properties.Settings.Default.Save();
            }
            else if (CheckSale8Cm.Checked)
            {
                Properties.Settings.Default.SalePrint = "8Cm";
                Properties.Settings.Default.Save();
            }
            MessageBox.Show("تم الحفظ البيانات بنجاح", "شاشة البيع", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckSaleA4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSaleA4.Checked)
            {
                CheckSale8Cm.Checked = false;
            }
        }

        private void CheckSale8Cm_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSale8Cm.Checked)
            {
                CheckSaleA4.Checked = false;
            }
        }


        // ----------------------------------------------------- Tab 3 Connection Server -----------------------------------------------

        public void TestSQLServerConnection()
        {
            if (string.IsNullOrEmpty(CombServers.Text) && string.IsNullOrEmpty(ComboDBs.Text))
            {
                MessageBox.Show("عفواً ، قم باختيار السرفر وقاعدة البيانات اولاً ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            

            sqlConnSrt = "Data Source ='" + CombServers.Text.Trim() + "';Initial Catalog = '" + ComboDBs.Text.Trim() + "';Integrated Security=True ";

            sqlConn.ConnectionString = sqlConnSrt;

            if (sqlConn.State == ConnectionState.Closed)
            {
                try
                {
                    MessageBox.Show("تمت عملية الاتصال بنجاح", "فحص الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    sqlConn.Close();
                    MessageBox.Show("فشل الاتصال بالسيرفر" + Environment.NewLine + ex.Message, "فحص الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            sqlConn.Close();
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            TestSQLServerConnection();
        }


        public void Save_Conection_Settings()
        {
            if (MessageBox.Show("هل تود حفظ إعدادات الاتصال بالسيرفر", "رساله تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(CombServers.Text) && string.IsNullOrEmpty(ComboDBs.Text))
                {
                    MessageBox.Show("عفواً ، قم باختيار السرفر وقاعدة البيانات اولاً ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    return;
                }

                Res_csharp.Properties.Settings.Default.SarverName = CombServers.Text;
                Res_csharp.Properties.Settings.Default.DataBaseName = ComboDBs.Text;
                Res_csharp.Properties.Settings.Default.Save();
                MessageBox.Show("تم حفظ إعدادات الاتصال بالسيرفر بنجاح ...", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                   
            }
        }

        private void btnSaveCon_Click(object sender, EventArgs e)
        {
            Save_Conection_Settings();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("انت على وشك إلغاء إعدادات الاتصال بالسيرفر ?" + Environment.NewLine + "هل تود الإستمرار ?", "رساله تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                Res_csharp.Properties.Settings.Default.SarverName = null;
                Res_csharp.Properties.Settings.Default.DataBaseName = null;
                Res_csharp.Properties.Settings.Default.Save();

                MessageBox.Show("تم إلغاء إعدادات الاتصال بالسيرفر بنجاح ...", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CombServers.Text = "";
            ComboDBs.Text = "";
        }

        // Load Installed Server Names
        public void LoadInstalledServers(ComboBox combo)
        {
            try
            {
                using (var regKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                {
                    var subRegKey = regKey.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server"); //  or SOFTWARE\\WOW6432Node\\Microsoft\\Microsoft SQL Server
                    var instances = (string[])subRegKey.GetValue("InstalledInstances");

                    if (instances.Length > 0)
                    {
                        foreach (var instance in instances)
                        {
                            if (instance == "MSSQLSERVER")
                            {
                                combo.Items.Add(Environment.MachineName);
                            }
                            else
                            {
                                combo.Items.Add(Environment.MachineName + "\\" + instance);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        public void FillCombByDataBases(ComboBox combServer, ComboBox comboDBs)
        {
            try
            {
                if (!string.IsNullOrEmpty(combServer.Text)) // Check if the combo box is not empty
                {
                    comboDBs.Items.Clear(); // Clear the combo box to avoid duplicates

                    string connectionString = null;
                    connectionString = "Data Source='" + combServer.Text.Trim() + "';Initial Catalog=master;Integrated Security=True";

                    using (SqlConnection cn = new SqlConnection(connectionString)) // Create a new SQL connection with the connection string
                    {
                        // Retrieve a list of databases from the master database
                        SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases", cn);
                        DataTable dt = new DataTable();
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            comboDBs.Items.Add(reader["name"].ToString());
                        }
                        reader.Close();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ShowSavedSettings()
        {
            CombServers.Text = Res_csharp.Properties.Settings.Default.SarverName;
            ComboDBs.Text = Res_csharp.Properties.Settings.Default.DataBaseName;
            TxtInstallPath.Text = Res_csharp.Properties.Settings.Default.InstallPath;
            TxtBackupPath.Text = Res_csharp.Properties.Settings.Default.BackupPath;
        }

        private void CombServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillCombByDataBases(this.CombServers, this.ComboDBs);
            }
            catch 
            {
                return;
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtInstallPath.Text) && string.IsNullOrEmpty(TxtBackupPath.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة الحقول بالبيانات اولاً ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            Res_csharp.Properties.Settings.Default.InstallPath = TxtInstallPath.Text.Trim();
            Res_csharp.Properties.Settings.Default.BackupPath = TxtBackupPath.Text.Trim();
            Res_csharp.Properties.Settings.Default.Save();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("انت على وشك حذف متغيرات النظام  ?" + Environment.NewLine + "هل تود الإستمرار ?", "رساله تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Res_csharp.Properties.Settings.Default.InstallPath = null;
                Res_csharp.Properties.Settings.Default.BackupPath = null;
                Res_csharp.Properties.Settings.Default.Save();

                MessageBox.Show(" تم حذف المتغيرات بنجاح ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            TxtInstallPath.Text = "";
            TxtBackupPath.Text = "";
        }



    }
}
