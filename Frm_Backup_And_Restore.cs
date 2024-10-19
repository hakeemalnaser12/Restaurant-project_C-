using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Res_csharp.Model;
using System.Data.SqlClient;
using System.IO;

namespace Res_csharp
{

    public partial class Frm_Backup_And_Restore : Form
    {

        Connection Con;
        string BackPath;
        string InstallPath;
        static string GetBackPath;
        public SqlCommand Cmd2;
        public SqlDataReader rdr2;
        public bool _btnBackup, _btnRestore;


        public Frm_Backup_And_Restore()
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
            Cmd2 = new SqlCommand("Select btnBackup,btnRecovry From Permissions_Tbl where UserAccID ='" + UserAccID + "'", Con.con);
             rdr2 = Cmd2.ExecuteReader();
             rdr2.Read();

            if ((bool)rdr2["btnBackup"] == true)
                _btnBackup = true;
            else _btnBackup = false;

            if ((bool)rdr2["btnRecovry"] == true)
                _btnRestore = true;
            else _btnRestore = false;

            //if (_btnBackup == true)
            //    btnBackup.Enabled = true;
            //else btnBackup.Enabled = false;

            //if (_btnRestore == true)
            //    btnRestore.Enabled = true;
            //else btnRestore.Enabled = false;

        }


        private void Frm_Backup_And_Restore_Load(object sender, EventArgs e)
        {
            BackPath = Properties.Settings.Default.BackupPath;
            InstallPath = Properties.Settings.Default.InstallPath;

            if ((BackPath == ""))
                TxtBackup.Text = "";
            else
                TxtBackup.Text = BackPath;

            btnBackup.Enabled = false;
            btnRestore.Enabled = false;


        }

        private void btnBackup_Path_Click(object sender, EventArgs e)
        {

            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Backup Files (*.bak)|*.bak";
            ofd.FileName = "Res_Pos_DB" + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss");
            if ((BackPath == ""))
                ofd.InitialDirectory = InstallPath;
            else
                ofd.InitialDirectory = BackPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtBackup.Text = ofd.FileName;

                if (_btnBackup == true)
                    btnBackup.Enabled = true;
                else btnBackup.Enabled = false;

                GetBackPath = Path.GetPathRoot(ofd.FileName);
                Properties.Settings.Default.BackupPath = GetBackPath.ToString();
                Properties.Settings.Default.Save();

            }
            else
                return;

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {


            if (TxtBackup.Text == "" && !string.IsNullOrEmpty(TxtBackup.Text))
            {
                MessageBox.Show("من فضلك تأكد من اختيار مسار النسخة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                SqlCommand Cmd = new SqlCommand("Backup Database [Res_Pos_DB] To Disk = N'" + TxtBackup.Text + "' ", Con.con);
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                Cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم عمل النسخة الاحتياطية بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnRestore_Path_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup Files (*.bak)|*.bak";
            if ((BackPath == ""))
                ofd.InitialDirectory = InstallPath;
            else
                ofd.InitialDirectory = BackPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtRestore.Text = ofd.FileName;

                if (_btnRestore == true)
                    btnRestore.Enabled = true;
                else btnRestore.Enabled = false;
            }
            else
                return;

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (TxtRestore.Text == "" && !string.IsNullOrEmpty(TxtRestore.Text))
            {
                MessageBox.Show("من فضلك تأكد من اختيار مسار النسخة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string Str = "USE [master]" + System.Environment.NewLine + "ALTER DATABASE [Res_Pos_DB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + System.Environment.NewLine + "RESTORE DATABASE [Res_Pos_DB] FROM  DISK = N'" + TxtRestore.Text + "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5" + System.Environment.NewLine + "ALTER DATABASE [Res_Pos_DB] SET MULTI_USER";
                SqlCommand Cmd = new SqlCommand(Str, Con.con);
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                Cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم عمل استعادة للنسخة الاحتياطية التي تم اختيارها بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Restart();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Cmd2 = null;
            rdr2.Close();
        }




    }
}
