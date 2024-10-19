using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Res_csharp.Model;

namespace Res_csharp
{
    public partial class Frm_Settings_Varibles : Form
    {
        SqlConnection sqlConn = new SqlConnection();
        public string sqlConnSrt = null;



        public Frm_Settings_Varibles()
        {
            InitializeComponent();
        }


        private void Frm_Settings_Varibles_Load(object sender, EventArgs e)
        {
            // ---------------------------- Con server
            LoadInstalledServers(CombServers);
            FillCombByDataBases(this.CombServers, this.ComboDBs);
            ShowSavedSettings();

        }


        // ----------------------------------------------------- Tab 3 -----------------------------------------------

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
                    connectionString = "Data Source=" + combServer.Text.Trim() + ";Initial Catalog=master;Integrated Security=True";

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

        private void BtnScan_Click(object sender, EventArgs e)
        {
            TestSQLServerConnection();
        }

        private void BtnSave_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtInstallPath.Text) && string.IsNullOrEmpty(TxtBackupPath.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة الحقول بالبيانات اولاً ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            Res_csharp.Properties.Settings.Default.InstallPath = TxtInstallPath.Text.Trim();
            Res_csharp.Properties.Settings.Default.BackupPath = TxtBackupPath.Text.Trim();
            Res_csharp.Properties.Settings.Default.Save();
            MessageBox.Show(" تم الحفظ بنجاح ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        

        }

        private void button2_Click(object sender, EventArgs e)
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
