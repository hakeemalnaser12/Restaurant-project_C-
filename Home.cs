using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Res_csharp.Model;

namespace Res_csharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            label1.Text = Connection._UserName;
        }

        public void SendFromToPanel(object Sform)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.RemoveAt(0);
            }
            Form frm = Sform as Form;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(frm);
            MainPanel.Tag = frm;
            frm.Show();
        }


        
        private void btnCat_Dep_Click(object sender, EventArgs e)
        {
            //Frm_Cat_Dep.Show()
            SendFromToPanel(new Frm_Cat_Dep());
        }

        private void BtnProdect_Click(object sender, EventArgs e)
        {
            //    Frm_Manage_Product.Show()
            SendFromToPanel(new Frm_Manage_Product());
        }

        private void BtnTables_Click(object sender, EventArgs e)
        {
            //    Frm_Tabels.Show()
            SendFromToPanel(new Frm_Tabels());
        }

        private void BtnPos_Click(object sender, EventArgs e)
        {
            Frm_pos Frm_pos = new Frm_pos();
            Frm_pos.ShowDialog();
            //SendFromToPanel(new Frm_pos());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SendFromToPanel(new Frm_Settings());
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            SendFromToPanel(new Frm_Company());
        }

        private void btnDelevery_Click(object sender, EventArgs e)
        {
            Frm_pos Frm_pos = new Frm_pos();
            SendFromToPanel(new Frm_Delevery(Frm_pos));
        }

        private void btnSalseHistory_Click(object sender, EventArgs e)
        {
            SendFromToPanel(new Frm_Salse_History());
        }


        private void btnBackup_Restore_Click(object sender, EventArgs e)
        {
            SendFromToPanel(new Frm_Backup_And_Restore());
            
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            SendFromToPanel(new Frm_UsersManager());
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {

        }

        private void btnRoleUser_Click(object sender, EventArgs e)
        {
            Frm_User_Permissions Frm_User_Permissions = new Frm_User_Permissions();
            Frm_User_Permissions.ShowDialog();
            
        }

      

       

        
      

       

       

       
      

    }
}
