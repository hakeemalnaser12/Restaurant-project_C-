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
    public partial class Frm_Order_Type : Form
    {
        Connection Con;
         Frm_pos frm;

         public Frm_Order_Type(Frm_pos frm3)
        {
            InitializeComponent();
            Con = new Connection();
            this.frm = frm3;
        }

        private void BtnOnTable_Click(object sender, EventArgs e)
        {
            Frm_Select_Table frm = new Frm_Select_Table(this.frm);
            Connection._ServiceTotal = 0.0;
            Connection._order_Type = "In_Table";
            frm.Loadall_Table();
            frm.ShowDialog();
            this.Close();
        }

        private void BtnTakeAway_Click(object sender, EventArgs e)
        {
            Frm_Select_Table frm = new Frm_Select_Table(this.frm);
            Connection._ServiceTotal = 0.0;
            Connection._order_Type = "TakeAway";
            frm.Loadall_Table();
            frm.ShowDialog();
            this.Close();
        }

        private void BtnDelevery_Click(object sender, EventArgs e)
        {
            Frm_Select_Table frm = new Frm_Select_Table(this.frm);
            Connection._order_Type = "Delevery";
            frm.Loadall_Table();
            frm.ShowDialog();

            this.Close();

            Frm_Delevery Frm_Delevery = new Frm_Delevery(this.frm);
            Frm_Delevery.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
