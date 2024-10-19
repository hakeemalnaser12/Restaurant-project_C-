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
    public partial class Frm_Login_Cashier : Form
    {
        Connection Con;

       


        public Frm_Login_Cashier()
        {
            InitializeComponent();
            Con = new Connection();
        }


        public void CheckPremitonforms(string UserAccID, Home frmHome1)
        {
            if (Con.con.State == System.Data.ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * From Permissions_Tbl where UserAccID ='" + UserAccID + "'", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();
            rdr.Read();


            frmHome1.BtnPos.Enabled = false;


            if ((bool)rdr["Frm_Salse_History"] == true)
                frmHome1.btnSalseHistory.Enabled = true;
            else frmHome1.btnSalseHistory.Enabled = false;

            if ((bool)rdr["Frm_Company"] == true)
                frmHome1.btnCompany.Enabled = true;
            else frmHome1.btnCompany.Enabled = false;

            ////if ((bool)rdr["btnSave_Company"] == true)
            ////    Frm_Company.BtnSave.Enabled = true;
            ////else Frm_Company.BtnSave.Enabled = false;

            if ((bool)rdr["Frm_Settings"] == true)
                frmHome1.btnSettings.Enabled = true;
            else frmHome1.btnSettings.Enabled = false;

            ////if ((bool)rdr["btnSaveValueTax"] == true)
            ////    ckbtnSaveValueTax.Checked = true;
            ////else ckbtnSaveValueTax.Checked = false;

            ////if ((bool)rdr["btnSaveStatusTax"] == true)
            ////    ckbtnSaveStatusTax.Checked = true;
            ////else ckbtnSaveStatusTax.Checked = false;

            ////if ((bool)rdr["btnSavePrintDef"] == true)
            ////    ckbtnSavePrintDef.Checked = true;
            ////else ckbtnSavePrintDef.Checked = false;

            ////if ((bool)rdr["btnSaveReportDef"] == true)
            ////    ckbtnSaveReportDef.Checked = true;
            ////else ckbtnSaveReportDef.Checked = false;

            if ((bool)rdr["Frm_Manage_Product"] == true)
                frmHome1.BtnProdect.Enabled = true;
            else frmHome1.BtnProdect.Enabled = false;

            ////if ((bool)rdr["btnshowAll_Product"] == true)
            ////    ckbtnshowAll_Product.Checked = true;
            ////else ckbtnshowAll_Product.Checked = false;

            ////if ((bool)rdr["Add_Product"] == true)
            ////    ckAdd_Product.Checked = true;
            ////else ckAdd_Product.Checked = false;

            ////if ((bool)rdr["btnEdit_Product"] == true)
            ////    ckbtnEdit_Product.Checked = true;
            ////else ckbtnEdit_Product.Checked = false;

            ////if ((bool)rdr["btnDelete_Product"] == true)
            ////    ckbtnDelete_Product.Checked = true;
            ////else ckbtnDelete_Product.Checked = false;

            ////if ((bool)rdr["Frm_Add_Product"] == true)
            ////    ckFrm_Add_Product.Checked = true;
            ////else ckFrm_Add_Product.Checked = false;

            ////if ((bool)rdr["btnSave_Product1"] == true)
            ////    ckbtnSave_Product1.Checked = true;
            ////else ckbtnSave_Product1.Checked = false;

            ////if ((bool)rdr["btnEdit_Product1"] == true)
            ////    ckbtnEdit_Product1.Checked = true;
            ////else ckbtnEdit_Product1.Checked = false;

            if ((bool)rdr["Frm_Backup_And_Restore"] == true)
                frmHome1.btnBackup_Restore.Enabled = true;
            else frmHome1.btnBackup_Restore.Enabled = false;

            ////if ((bool)rdr["btnBackup"] == true)
            ////    ckbtnBackup.Checked = true;
            ////else ckbtnBackup.Checked = false;

            ////if ((bool)rdr["btnRecovry"] == true)
            ////    ckbtnRecovry.Checked = true;
            ////else ckbtnRecovry.Checked = false;

            if ((bool)rdr["Frm_Connection"] == true)
                frmHome1.btnVariables.Enabled = true;
            else frmHome1.btnVariables.Enabled = false;

            ////if ((bool)rdr["btnSave"] == true)
            ////    Connection._btnSaveFrm_Settings_Varibles = true;
            ////else Connection._btnSaveFrm_Settings_Varibles = false;


            if ((bool)rdr["Frm_Cat_Dep"] == true)
                frmHome1.btnCat_Dep.Enabled = true;
            else frmHome1.btnCat_Dep.Enabled = false;

            ////if ((bool)rdr["btnNew_Dep"] == true)
            ////    ckbtnNew_Dep.Checked = true;
            ////else ckbtnNew_Dep.Checked = false;

            ////if ((bool)rdr["btnSave_Dep"] == true)
            ////    ckbtnSave_Dep.Checked = true;
            ////else ckbtnSave_Dep.Checked = false;

            ////if ((bool)rdr["btnEdit_Dep"] == true)
            ////    ckbtnEdit_Dep.Checked = true;
            ////else ckbtnEdit_Dep.Checked = false;

            ////if ((bool)rdr["btnDelete_Dep"] == true)
            ////    ckbtnDelete_Dep.Checked = true;
            ////else ckbtnDelete_Dep.Checked = false;

            ////if ((bool)rdr["btnNew_Cat"] == true)
            ////    ckbtnNew_Cat.Checked = true;
            ////else ckbtnNew_Cat.Checked = false;

            ////if ((bool)rdr["btnSave_Cat"] == true)
            ////    ckbtnSave_Cat.Checked = true;
            ////else ckbtnSave_Cat.Checked = false;

            ////if ((bool)rdr["btnEdit_Cat"] == true)
            ////    ckbtnEdit_Cat.Checked = true;
            ////else ckbtnEdit_Cat.Checked = false;

            ////if ((bool)rdr["btnDelete_Cat"] == true)
            ////    ckbtnDelete_Cat.Checked = true;
            ////else ckbtnDelete_Cat.Checked = false;

            if ((bool)rdr["Frm_Tabels"] == true)
                frmHome1.BtnTables.Enabled = true;
            else frmHome1.BtnTables.Enabled = false;

            ////if ((bool)rdr["btnNew_Tabel"] == true)
            ////    ckbtnNew_Tabel.Checked = true;
            ////else ckbtnNew_Tabel.Checked = false;

            ////if ((bool)rdr["btnSave_Tabel"] == true)
            ////    ckbtnSave_Tabel.Checked = true;
            ////else ckbtnSave_Tabel.Checked = false;

            ////if ((bool)rdr["btnEdit_Tabel"] == true)
            ////    ckbtnEdit_Tabel.Checked = true;
            ////else ckbtnEdit_Tabel.Checked = false;

            ////if ((bool)rdr["btnDelete_Tabel"] == true)
            ////    ckbtnDelete_Tabel.Checked = true;
            ////else ckbtnDelete_Tabel.Checked = false;

            if ((bool)rdr["Frm_Delevery"] == true)
                frmHome1.btnDelevery.Enabled = true;
            else frmHome1.btnDelevery.Enabled = false;

            ////if ((bool)rdr["btnNew_Area"] == true)
            ////    ckbtnNew_Area.Checked = true;
            ////else ckbtnNew_Area.Checked = false;

            ////if ((bool)rdr["btnSave_Area"] == true)
            ////    ckbtnSave_Area.Checked = true;
            ////else ckbtnSave_Area.Checked = false;

            ////if ((bool)rdr["btnEdit_Area"] == true)
            ////    ckbtnEdit_Area.Checked = true;
            ////else ckbtnEdit_Area.Checked = false;

            ////if ((bool)rdr["btnDelete_Area"] == true)
            ////    ckbtnDelete_Area.Checked = true;
            ////else ckbtnDelete_Area.Checked = false;

            ////if ((bool)rdr["btnNew_Emp"] == true)
            ////    ckbtnNew_Emp.Checked = true;
            ////else ckbtnNew_Emp.Checked = false;

            ////if ((bool)rdr["btnSave_Emp"] == true)
            ////    ckbtnSave_Emp.Checked = true;
            ////else ckbtnSave_Emp.Checked = false;

            ////if ((bool)rdr["btnEdit_Emp"] == true)
            ////    ckbtnEdit_Emp.Checked = true;
            ////else ckbtnEdit_Emp.Checked = false;

            ////if ((bool)rdr["btnDelete_Emp"] == true)
            ////    ckbtnDelete_Emp.Checked = true;
            ////else ckbtnDelete_Emp.Checked = false;

            ////if ((bool)rdr["btnNew_Customer"] == true)
            ////    ckbtnNew_Customer.Checked = true;
            ////else ckbtnNew_Customer.Checked = false;

            ////if ((bool)rdr["btnSave_Customer"] == true)
            ////    ckbtnSave_Customer.Checked = true;
            ////else ckbtnSave_Customer.Checked = false;

            ////if ((bool)rdr["btnEdit_Customer"] == true)
            ////    ckbtnEdit_Customer.Checked = true;
            ////else ckbtnEdit_Customer.Checked = false;

            ////if ((bool)rdr["btnDelete_Customer"] == true)
            ////    ckbtnDelete_Customer.Checked = true;
            ////else ckbtnDelete_Customer.Checked = false;

            if ((bool)rdr["Frm_UsersManager"] == true)
                frmHome1.btnUserManage.Enabled = true;
            else frmHome1.btnUserManage.Enabled = false;

            ////if ((bool)rdr["btnNew_User"] == true)
            ////    ckbtnNew_User.Checked = true;
            ////else ckbtnNew_User.Checked = false;

            ////if ((bool)rdr["btnSave_User"] == true)
            ////    ckbtnSave_User.Checked = true;
            ////else ckbtnSave_User.Checked = false;

            ////if ((bool)rdr["btnEdit_User"] == true)
            ////    ckbtnEdit_User.Checked = true;
            ////else ckbtnEdit_User.Checked = false;

            ////if ((bool)rdr["btnDelete_User"] == true)
            ////    ckbtnDelete_User.Checked = true;
            ////else ckbtnDelete_User.Checked = false;

            ////if ((bool)rdr["btnNew_Kachir"] == true)
            ////    ckbtnNew_Kachir.Checked = true;
            ////else ckbtnNew_Kachir.Checked = false;

            ////if ((bool)rdr["btnSave_Kachir"] == true)
            ////    ckbtnSave_Kachir.Checked = true;
            ////else ckbtnSave_Kachir.Checked = false;

            ////if ((bool)rdr["btnEdit_Kachir"] == true)
            ////    ckbtnEdit_Kachir.Checked = true;
            ////else ckbtnEdit_Kachir.Checked = false;

            ////if ((bool)rdr["btnDelete_Kachir"] == true)
            ////    ckbtnDelete_Kachir.Checked = true;
            ////else ckbtnDelete_Kachir.Checked = false;

            if ((bool)rdr["Frm_User_Permissions"] == true)
                frmHome1.btnRoleUser.Enabled = true;
            else frmHome1.btnRoleUser.Enabled = false;

            ////if ((bool)rdr["New_Permissions"] == true)
            ////    ckNew_Permissions.Checked = true;
            ////else ckNew_Permissions.Checked = false;

            ////if ((bool)rdr["Save_Permissions"] == true)
            ////    ckSave_Permissions.Checked = true;
            ////else ckSave_Permissions.Checked = false;

            ////if ((bool)rdr["Edit_Permissions"] == true)
            ////    ckEdit_Permissions.Checked = true;
            ////else ckEdit_Permissions.Checked = false;

            ////if ((bool)rdr["Delete_Permissions"] == true)
            ////    ckDelete_Permissions.Checked = true;
            ////else ckDelete_Permissions.Checked = false;

            rdr.Close();
            Con.con.Close();


        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            TxtUserName.Text = "";
            TxtPassword.Text = "";
        }

        private void ckShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShow.Checked == true)
                TxtPassword.UseSystemPasswordChar = false;
            else
                TxtPassword.UseSystemPasswordChar = true;
    
        }

        private void ck_Kasher_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Kasher.Checked == true)
            {
                
                btn_LoginCkasher.Visible = true;
                btn_LoginUser.Visible = false;
            }
            else
            {
                
                btn_LoginCkasher.Visible = false;
                btn_LoginUser.Visible = true;
            }
        }

        private void btn_LoginCkasher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserName.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            

           try
           {
               if (Con.con.State == ConnectionState.Open)
                Con.con.Close();

                 Con.con.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Cashier_tbl WHERE Cashier_UserName = N'" + TxtUserName.Text + "' AND Cashier_Pass = N'" + TxtPassword.Text + "' ", Con.con);
            

            SqlDataReader rdr = Cmd.ExecuteReader();
            if (rdr.Read() && rdr.HasRows)
            {
                Connection._Cashier_ID = Convert.ToInt32(rdr["Cashier_ID"]); // تحويل القيمة النصية إلى عدد صحيح
                Connection._Cashier_UserName = rdr["Cashier_UserName"].ToString();
                Connection._FullName = rdr["FullName"].ToString();
                Connection._Cashier_Balance = Convert.ToDouble(rdr["Cashier_Balance"]);
                //bool cashierStatus = Convert.ToBoolean(rdr["Cashier_Status"]);



                if (bool.Parse(rdr["Cashier_Status"].ToString()) == true)
                {
                    // هذه الحالة انه مستلم الصندوق
                    Connection._Cashier_Status = true;
                    

                    Frm_pos frmPos = new Frm_pos();
                    frmPos.BtnIstlam.Enabled = false;
                    frmPos.BtnTaslem.Enabled = true;
                    frmPos.BtnNew.Enabled = true;
                    frmPos.btnPaid.Enabled = true;
                    frmPos.label6.Text = " الكاشير " + Connection._Cashier_UserName;

                    frmPos.loadall_cat(); // تحميل التصنيفات
                    frmPos.Load_Items(); // تحميل المنتجات على شكل صور
                    //frmPos.loadall_Item_Button(); // تحميل المنتجات على شكل ازرار
                    frmPos.ShowDialog();

                    TxtUserName.Text = "";
                    TxtPassword.Text = "";
                    this.Close();
                }
                else
                {
                    // هذه الحالة انه غير مستلم الصندوق
                    Connection._Cashier_Status = false;
                  

                    Frm_pos frmPos = new Frm_pos();
                    frmPos.BtnIstlam.Enabled = true;
                    frmPos.BtnTaslem.Enabled = false;
                    frmPos.BtnNew.Enabled = false;
                    frmPos.btnPaid.Enabled = false;
                    frmPos.label6.Text = " الكاشير " + Connection._Cashier_UserName;
                    frmPos.ShowDialog();

                    TxtUserName.Text = "";
                    TxtPassword.Text = "";
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيح", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                TxtUserName.Text = "";
                TxtPassword.Text = "";
            }

            Con.con.Close();

           }
            catch(Exception ex)
           {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.con.Close();
            }
          
        }

        private void btn_LoginUser_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtUserName.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            try
            {
                if (Con.con.State == ConnectionState.Open)
                    Con.con.Close();

                Con.con.Open();

                SqlCommand Cmd1 = new SqlCommand("SELECT UserAccID,UserAccName,AccType,AccActivate from UserAcount_tbl  WHERE  UserName = N'" + TxtUserName.Text + "' AND UserPassword = N'" + TxtPassword.Text + "'", Con.con);
               

                SqlDataReader rdr1 = Cmd1.ExecuteReader();
                if (rdr1.Read() && rdr1.HasRows)
                {
                    Connection._UserID = rdr1["UserAccID"].ToString();
                    Connection._UserName = rdr1["UserAccName"].ToString();


                    if (bool.Parse(rdr1["AccActivate"].ToString()) == true)
                    {
                        // هذه الحالة انه المستخدم فعال اي يمكنه الدخول للنظام 

                        // هنا فحص نوع المستخدم 
                        if (bool.Parse(rdr1["AccType"].ToString()) == true)
                        {
                            MessageBox.Show(" اهلا بالمدير " + rdr1["UserAccName"].ToString());
                            // هنا فحص  الصلاحيات 
                            Home frmHome = new Home();
                            CheckPremitonforms(Connection._UserID, frmHome);
                            frmHome.label1.Text = " المستخدم " + Connection._UserName;
                            frmHome.ShowDialog();

                        }
                      
                        else
                        {
                            MessageBox.Show(" اهلا بالمستخدم " + rdr1["UserAccName"].ToString());
                            // هنا فحص  الصلاحيات 
                            Home frmHome = new Home();
                            CheckPremitonforms(Connection._UserID, frmHome);
                            frmHome.label1.Text = " المستخدم " + Connection._UserName;
                            frmHome.ShowDialog();

                        }



                        TxtUserName.Text = "";
                        TxtPassword.Text = "";
                        this.Close();

                    }
                    else
                    {
                        // هذه الحالة انه المستخدم غير فعال اي لا يمكنه الدخول للنظام 

                        MessageBox.Show("عذرا " + Connection._UserName + "ليس لديك صلاحية بالدخول للنظام يرجى متابعة مدير النظام ", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        TxtUserName.Text = "";
                        TxtPassword.Text = "";
                    }


                }
                else
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيح", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    TxtUserName.Text = "";
                    TxtPassword.Text = "";
                }



                Con.con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.con.Close();

            }
        }


        // btn Con DataBase
        private void button3_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "root" && TxtPassword.Text == "123")
            {
                Frm_Settings_Varibles source = new Frm_Settings_Varibles();
                source.ShowDialog();

            }
            else
                MessageBox.Show(" غير مصرح لك بالدخول ");
        }

        
        
        

        
    }
}
