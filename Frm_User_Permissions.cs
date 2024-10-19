using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Res_csharp.Model;

namespace Res_csharp
{
    public partial class Frm_User_Permissions : Form
    {
        Connection Con;

        public SqlCommand Cmd2;
        public SqlDataReader rdr2;
        public bool _save, _new, _delete;

        public Frm_User_Permissions()
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
            Cmd2 = new SqlCommand("Select New_Permissions,Save_Permissions,Edit_Permissions,Delete_Permissions From Permissions_Tbl where UserAccID ='" + UserAccID + "'", Con.con);
            rdr2 = Cmd2.ExecuteReader();
            rdr2.Read();

            if ((bool)rdr2["New_Permissions"] == true)
                _new  = true;
            else _new  = false;

            if ((bool)rdr2["Save_Permissions"] == true)
               _save = true;
            else _save = false;

            //if ((bool)rdr2["Edit_Permissions"] == true)
            //    ckEdit_Permissions.Enabled = true;
            //else ckEdit_Permissions.Enabled = false;

            if ((bool)rdr2["Delete_Permissions"] == true)
                _delete = true;
            else _delete = false;
           

        }


        private void load_User_tbl()
        {
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select UserAccID, UserAccName From UserAcount_tbl", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    Dgv_User.Rows.Add(rdr["UserAccID"].ToString(), rdr["UserAccName"].ToString());
                }
                rdr.Close();
                Con.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.con.Close();
            }
        }

        private void load_Permissions_tbl()
        {
            Dgv_Permissions.Rows.Clear();
            
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select No_Permissions, UserAccID , UserAccName From View_Premissions", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    Dgv_Permissions.Rows.Add(rdr["No_Permissions"].ToString(), rdr["UserAccID"].ToString(), rdr["UserAccName"].ToString());
                }
                rdr.Close();
                Con.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.con.Close();
            }
        }


        private void Frm_User_Permissions_Load(object sender, EventArgs e)
        {
            
            load_User_tbl();
            load_Permissions_tbl();

            if (_new == true)
                btnNew.Enabled = true;
            else btnNew.Enabled = false;
        

            //btnNew.Enabled = true;
            btnSave.Enabled = false;
            ////btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

       


        public void insert_Table()
        {

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = Con.con;

            cmdInsert.CommandText = "Insert Into Permissions_Tbl (UserAccID,Frm_Salse_History,Frm_Company,btnSave_Company,Frm_Settings,btnSaveValueTax,btnSaveStatusTax,btnSavePrintDef,btnSaveReportDef,Frm_Manage_Product,btnshowAll_Product," +
                "Add_Product,btnEdit_Product,btnDelete_Product,Frm_Add_Product,btnSave_Product1,btnEdit_Product1,Frm_Backup_And_Restore,btnBackup,btnRecovry,Frm_Connection,btnSave,Frm_Cat_Dep,btnNew_Dep,btnSave_Dep,btnEdit_Dep,btnDelete_Dep,btnNew_Cat,btnSave_Cat," +
                "btnEdit_Cat,btnDelete_Cat,Frm_Tabels,btnNew_Tabel,btnSave_Tabel,btnEdit_Tabel,btnDelete_Tabel,Frm_Delevery,btnNew_Area,btnSave_Area,btnEdit_Area,btnDelete_Area,btnNew_Emp,btnSave_Emp,btnEdit_Emp,btnDelete_Emp,btnNew_Customer,btnSave_Customer,btnEdit_Customer,btnDelete_Customer,Frm_UsersManager" +
                ",btnNew_User,btnSave_User,btnEdit_User,btnDelete_User,btnNew_Kachir,btnSave_Kachir,btnEdit_Kachir,btnDelete_Kachir,Frm_User_Permissions,New_Permissions,Save_Permissions,Edit_Permissions,Delete_Permissions)" +
                " values (@UserAccID,@Frm_Salse_History,@Frm_Company,@btnSave_Company,@Frm_Settings,@btnSaveValueTax,@btnSaveStatusTax,@btnSavePrintDef,@btnSaveReportDef,@Frm_Manage_Product,@btnshowAll_Product," +
                "@Add_Product,@btnEdit_Product,@btnDelete_Product,@Frm_Add_Product,@btnSave_Product1,@btnEdit_Product1,@Frm_Backup_And_Restore,@btnBackup,@btnRecovry,@Frm_Connection,@btnSave,@Frm_Cat_Dep,@btnNew_Dep,@btnSave_Dep,@btnEdit_Dep,@btnDelete_Dep,@btnNew_Cat,@btnSave_Cat," +
                "@btnEdit_Cat,@btnDelete_Cat,@Frm_Tabels,@btnNew_Tabel,@btnSave_Tabel,@btnEdit_Tabel,@btnDelete_Tabel,@Frm_Delevery,@btnNew_Area,@btnSave_Area,@btnEdit_Area,@btnDelete_Area,@btnNew_Emp,@btnSave_Emp,@btnEdit_Emp,@btnDelete_Emp,@btnNew_Customer,@btnSave_Customer,@btnEdit_Customer,@btnDelete_Customer,@Frm_UsersManager" +
                ",@btnNew_User,@btnSave_User,@btnEdit_User,@btnDelete_User,@btnNew_Kachir,@btnSave_Kachir,@btnEdit_Kachir,@btnDelete_Kachir,@Frm_User_Permissions,@New_Permissions,@Save_Permissions,@Edit_Permissions,@Delete_Permissions)";

            cmdInsert.Parameters.Clear();

            cmdInsert.Parameters.AddWithValue("@Frm_Salse_History", SqlDbType.Bit).Value = ckFrm_Salse_History.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_Company", SqlDbType.Bit).Value = ckFrm_Company.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave_Company", SqlDbType.Bit).Value = ckbtnSave_Company.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_Settings", SqlDbType.Bit).Value = ckFrm_Settings.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSaveValueTax", SqlDbType.Bit).Value = ckbtnSaveValueTax.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSaveStatusTax", SqlDbType.Bit).Value = ckbtnSaveStatusTax.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSavePrintDef", SqlDbType.Bit).Value = ckbtnSavePrintDef.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSaveReportDef", SqlDbType.Bit).Value = ckbtnSaveReportDef.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_Manage_Product", SqlDbType.Bit).Value = ckFrm_Manage_Product.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnshowAll_Product", SqlDbType.Bit).Value = ckbtnshowAll_Product.CheckState;
            cmdInsert.Parameters.AddWithValue("@Add_Product", SqlDbType.Bit).Value = ckAdd_Product.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnEdit_Product", SqlDbType.Bit).Value = ckbtnEdit_Product.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnDelete_Product", SqlDbType.Bit).Value = ckbtnDelete_Product.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_Add_Product", SqlDbType.Bit).Value = ckFrm_Add_Product.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave_Product1", SqlDbType.Bit).Value = ckbtnSave_Product1.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnEdit_Product1", SqlDbType.Bit).Value = ckbtnEdit_Product1.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_Backup_And_Restore", SqlDbType.Bit).Value = ckFrm_Backup_And_Restore.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnBackup", SqlDbType.Bit).Value = ckbtnBackup.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnRecovry", SqlDbType.Bit).Value = ckbtnRecovry.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_Connection", SqlDbType.Bit).Value = ckFrm_Connection.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave", SqlDbType.Bit).Value = ckbtnSave.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_Cat_Dep", SqlDbType.Bit).Value = ckFrm_Cat_Dep.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnNew_Dep", SqlDbType.Bit).Value = ckbtnNew_Dep.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave_Dep", SqlDbType.Bit).Value = ckbtnSave_Dep.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnEdit_Dep", SqlDbType.Bit).Value = ckbtnEdit_Dep.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnDelete_Dep", SqlDbType.Bit).Value = ckbtnDelete_Dep.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnNew_Cat", SqlDbType.Bit).Value = ckbtnNew_Cat.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave_Cat", SqlDbType.Bit).Value = ckbtnSave_Cat.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnEdit_Cat", SqlDbType.Bit).Value = ckbtnEdit_Cat.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnDelete_Cat", SqlDbType.Bit).Value = ckbtnDelete_Cat.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_Tabels", SqlDbType.Bit).Value = ckFrm_Tabels.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnNew_Tabel", SqlDbType.Bit).Value = ckbtnNew_Tabel.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave_Tabel", SqlDbType.Bit).Value = ckbtnSave_Tabel.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnEdit_Tabel", SqlDbType.Bit).Value = ckbtnEdit_Tabel.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnDelete_Tabel", SqlDbType.Bit).Value = ckbtnDelete_Tabel.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_Delevery", SqlDbType.Bit).Value = ckFrm_Delevery.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnNew_Area", SqlDbType.Bit).Value = ckbtnNew_Area.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave_Area", SqlDbType.Bit).Value = ckbtnSave_Area.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnEdit_Area", SqlDbType.Bit).Value = ckbtnEdit_Area.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnDelete_Area", SqlDbType.Bit).Value = ckbtnDelete_Area.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnNew_Emp", SqlDbType.Bit).Value = ckbtnNew_Emp.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave_Emp", SqlDbType.Bit).Value = ckbtnSave_Emp.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnEdit_Emp", SqlDbType.Bit).Value = ckbtnEdit_Emp.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnDelete_Emp", SqlDbType.Bit).Value = ckbtnDelete_Emp.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnNew_Customer", SqlDbType.Bit).Value = ckbtnNew_Customer.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave_Customer", SqlDbType.Bit).Value = ckbtnSave_Customer.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnEdit_Customer", SqlDbType.Bit).Value = ckbtnEdit_Customer.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnDelete_Customer", SqlDbType.Bit).Value = ckbtnDelete_Customer.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_UsersManager", SqlDbType.Bit).Value = ckFrm_UsersManager.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnNew_User", SqlDbType.Bit).Value = ckbtnNew_User.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave_User", SqlDbType.Bit).Value = ckbtnSave_User.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnEdit_User", SqlDbType.Bit).Value = ckbtnEdit_User.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnDelete_User", SqlDbType.Bit).Value = ckbtnDelete_User.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnNew_Kachir", SqlDbType.Bit).Value = ckbtnNew_Kachir.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnSave_Kachir", SqlDbType.Bit).Value = ckbtnSave_Kachir.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnEdit_Kachir", SqlDbType.Bit).Value = ckbtnEdit_Kachir.CheckState;
            cmdInsert.Parameters.AddWithValue("@btnDelete_Kachir", SqlDbType.Bit).Value = ckbtnDelete_Kachir.CheckState;
            cmdInsert.Parameters.AddWithValue("@Frm_User_Permissions", SqlDbType.Bit).Value = ckFrm_User_Permissions.CheckState;
            cmdInsert.Parameters.AddWithValue("@New_Permissions", SqlDbType.Bit).Value = ckNew_Permissions.CheckState;
            cmdInsert.Parameters.AddWithValue("@Save_Permissions", SqlDbType.Bit).Value = ckSave_Permissions.CheckState;
            cmdInsert.Parameters.AddWithValue("@Edit_Permissions", SqlDbType.Bit).Value = ckEdit_Permissions.CheckState;
            cmdInsert.Parameters.AddWithValue("@Delete_Permissions", SqlDbType.Bit).Value = ckDelete_Permissions.CheckState;

            // cmdInsert.Parameters.AddWithValue("@No_Permissions", SqlDbType.Int).Value = TxtNumber_User.Text;
            cmdInsert.Parameters.AddWithValue("@UserAccID", SqlDbType.Int).Value = Convert.ToInt32(TxtNumber_User.Text);


            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                cmdInsert.ExecuteNonQuery();
                Con.con.Close();

                MessageBox.Show("تم اضافة الصلاحية بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmdInsert.Dispose();
            }
            catch (Exception ex)
            {
                Con.con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
            }


        }

        public void Update_Parmission_tbl()
        {
            SqlCommand Cmd = new SqlCommand
            {
                Connection = Con.con,
                CommandType = CommandType.Text,
                CommandText = "Update Permissions_Tbl Set Frm_Salse_History=@Frm_Salse_History,Frm_Company=@Frm_Company,btnSave_Company=@btnSave_Company,Frm_Settings=@Frm_Settings,btnSaveValueTax=@btnSaveValueTax,btnSaveStatusTax=@btnSaveStatusTax," +
                "btnSavePrintDef=@btnSavePrintDef,btnSaveReportDef=@btnSaveReportDef,Frm_Manage_Product=@Frm_Manage_Product,btnshowAll_Product=@btnshowAll_Product," +
                "Add_Product=@Add_Product,btnEdit_Product=@btnEdit_Product,btnDelete_Product=@btnDelete_Product,Frm_Add_Product=@Frm_Add_Product,btnSave_Product1=@btnSave_Product1,btnEdit_Product1=@btnEdit_Product1,Frm_Backup_And_Restore=@Frm_Backup_And_Restore,btnBackup=@btnBackup,btnRecovry=@btnRecovry," +
                "Frm_Connection=@Frm_Connection,btnSave=@btnSave,Frm_Cat_Dep=@Frm_Cat_Dep,btnNew_Dep=@btnNew_Dep,btnSave_Dep=@btnSave_Dep,btnEdit_Dep=@btnEdit_Dep,btnDelete_Dep=@btnDelete_Dep,btnNew_Cat=@btnNew_Cat,btnSave_Cat=@btnSave_Cat," +
                "btnEdit_Cat=@btnEdit_Cat,btnDelete_Cat=@btnDelete_Cat,Frm_Tabels=@Frm_Tabels,btnNew_Tabel=@btnNew_Tabel,btnSave_Tabel=@btnSave_Tabel,btnEdit_Tabel=@btnEdit_Tabel,btnDelete_Tabel=@btnDelete_Tabel,Frm_Delevery=@Frm_Delevery,btnNew_Area=@btnNew_Area,btnSave_Area=@btnSave_Area,btnEdit_Area=@btnEdit_Area,btnDelete_Area=@btnDelete_Area," +
                "btnNew_Emp=@btnNew_Emp,btnSave_Emp=@btnSave_Emp,btnEdit_Emp=@btnEdit_Emp,btnDelete_Emp=@btnDelete_Emp,btnNew_Customer=@btnNew_Customer,btnSave_Customer=@btnSave_Customer,btnEdit_Customer=@btnEdit_Customer,btnDelete_Customer=@btnDelete_Customer,Frm_UsersManager=@Frm_UsersManager," +
                "btnNew_User=@btnNew_User,btnSave_User=@btnSave_User,btnEdit_User=@btnEdit_User,btnDelete_User=@btnDelete_User,btnNew_Kachir=@btnNew_Kachir,btnSave_Kachir=@btnSave_Kachir,btnEdit_Kachir=@btnEdit_Kachir,btnDelete_Kachir=@btnDelete_Kachir,Frm_User_Permissions=@Frm_User_Permissions," +
                "New_Permissions=@New_Permissions,Save_Permissions=@Save_Permissions,Edit_Permissions=@Edit_Permissions,Delete_Permissions=@Delete_Permissions   Where UserAccID=@UserAccID And No_Permissions=@No_Permissions "
            };


            Cmd.Parameters.Clear();

            Cmd.Parameters.AddWithValue("@Frm_Salse_History", SqlDbType.Bit).Value = ckFrm_Salse_History.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_Company", SqlDbType.Bit).Value = ckFrm_Company.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave_Company", SqlDbType.Bit).Value = ckbtnSave_Company.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_Settings", SqlDbType.Bit).Value = ckFrm_Settings.CheckState;
            Cmd.Parameters.AddWithValue("@btnSaveValueTax", SqlDbType.Bit).Value = ckbtnSaveValueTax.CheckState;
            Cmd.Parameters.AddWithValue("@btnSaveStatusTax", SqlDbType.Bit).Value = ckbtnSaveStatusTax.CheckState;
            Cmd.Parameters.AddWithValue("@btnSavePrintDef", SqlDbType.Bit).Value = ckbtnSavePrintDef.CheckState;
            Cmd.Parameters.AddWithValue("@btnSaveReportDef", SqlDbType.Bit).Value = ckbtnSaveReportDef.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_Manage_Product", SqlDbType.Bit).Value = ckFrm_Manage_Product.CheckState;
            Cmd.Parameters.AddWithValue("@btnshowAll_Product", SqlDbType.Bit).Value = ckbtnshowAll_Product.CheckState;
            Cmd.Parameters.AddWithValue("@Add_Product", SqlDbType.Bit).Value = ckAdd_Product.CheckState;
            Cmd.Parameters.AddWithValue("@btnEdit_Product", SqlDbType.Bit).Value = ckbtnEdit_Product.CheckState;
            Cmd.Parameters.AddWithValue("@btnDelete_Product", SqlDbType.Bit).Value = ckbtnDelete_Product.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_Add_Product", SqlDbType.Bit).Value = ckFrm_Add_Product.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave_Product1", SqlDbType.Bit).Value = ckbtnSave_Product1.CheckState;
            Cmd.Parameters.AddWithValue("@btnEdit_Product1", SqlDbType.Bit).Value = ckbtnEdit_Product1.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_Backup_And_Restore", SqlDbType.Bit).Value = ckFrm_Backup_And_Restore.CheckState;
            Cmd.Parameters.AddWithValue("@btnBackup", SqlDbType.Bit).Value = ckbtnBackup.CheckState;
            Cmd.Parameters.AddWithValue("@btnRecovry", SqlDbType.Bit).Value = ckbtnRecovry.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_Connection", SqlDbType.Bit).Value = ckFrm_Connection.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave", SqlDbType.Bit).Value = ckbtnSave.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_Cat_Dep", SqlDbType.Bit).Value = ckFrm_Cat_Dep.CheckState;
            Cmd.Parameters.AddWithValue("@btnNew_Dep", SqlDbType.Bit).Value = ckbtnNew_Dep.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave_Dep", SqlDbType.Bit).Value = ckbtnSave_Dep.CheckState;
            Cmd.Parameters.AddWithValue("@btnEdit_Dep", SqlDbType.Bit).Value = ckbtnEdit_Dep.CheckState;
            Cmd.Parameters.AddWithValue("@btnDelete_Dep", SqlDbType.Bit).Value = ckbtnDelete_Dep.CheckState;
            Cmd.Parameters.AddWithValue("@btnNew_Cat", SqlDbType.Bit).Value = ckbtnNew_Cat.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave_Cat", SqlDbType.Bit).Value = ckbtnSave_Cat.CheckState;
            Cmd.Parameters.AddWithValue("@btnEdit_Cat", SqlDbType.Bit).Value = ckbtnEdit_Cat.CheckState;
            Cmd.Parameters.AddWithValue("@btnDelete_Cat", SqlDbType.Bit).Value = ckbtnDelete_Cat.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_Tabels", SqlDbType.Bit).Value = ckFrm_Tabels.CheckState;
            Cmd.Parameters.AddWithValue("@btnNew_Tabel", SqlDbType.Bit).Value = ckbtnNew_Tabel.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave_Tabel", SqlDbType.Bit).Value = ckbtnSave_Tabel.CheckState;
            Cmd.Parameters.AddWithValue("@btnEdit_Tabel", SqlDbType.Bit).Value = ckbtnEdit_Tabel.CheckState;
            Cmd.Parameters.AddWithValue("@btnDelete_Tabel", SqlDbType.Bit).Value = ckbtnDelete_Tabel.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_Delevery", SqlDbType.Bit).Value = ckFrm_Delevery.CheckState;
            Cmd.Parameters.AddWithValue("@btnNew_Area", SqlDbType.Bit).Value = ckbtnNew_Area.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave_Area", SqlDbType.Bit).Value = ckbtnSave_Area.CheckState;
            Cmd.Parameters.AddWithValue("@btnEdit_Area", SqlDbType.Bit).Value = ckbtnEdit_Area.CheckState;
            Cmd.Parameters.AddWithValue("@btnDelete_Area", SqlDbType.Bit).Value = ckbtnDelete_Area.CheckState;
            Cmd.Parameters.AddWithValue("@btnNew_Emp", SqlDbType.Bit).Value = ckbtnNew_Emp.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave_Emp", SqlDbType.Bit).Value = ckbtnSave_Emp.CheckState;
            Cmd.Parameters.AddWithValue("@btnEdit_Emp", SqlDbType.Bit).Value = ckbtnEdit_Emp.CheckState;
            Cmd.Parameters.AddWithValue("@btnDelete_Emp", SqlDbType.Bit).Value = ckbtnDelete_Emp.CheckState;
            Cmd.Parameters.AddWithValue("@btnNew_Customer", SqlDbType.Bit).Value = ckbtnNew_Customer.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave_Customer", SqlDbType.Bit).Value = ckbtnSave_Customer.CheckState;
            Cmd.Parameters.AddWithValue("@btnEdit_Customer", SqlDbType.Bit).Value = ckbtnEdit_Customer.CheckState;
            Cmd.Parameters.AddWithValue("@btnDelete_Customer", SqlDbType.Bit).Value = ckbtnDelete_Customer.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_UsersManager", SqlDbType.Bit).Value = ckFrm_UsersManager.CheckState;
            Cmd.Parameters.AddWithValue("@btnNew_User", SqlDbType.Bit).Value = ckbtnNew_User.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave_User", SqlDbType.Bit).Value = ckbtnSave_User.CheckState;
            Cmd.Parameters.AddWithValue("@btnEdit_User", SqlDbType.Bit).Value = ckbtnEdit_User.CheckState;
            Cmd.Parameters.AddWithValue("@btnDelete_User", SqlDbType.Bit).Value = ckbtnDelete_User.CheckState;
            Cmd.Parameters.AddWithValue("@btnNew_Kachir", SqlDbType.Bit).Value = ckbtnNew_Kachir.CheckState;
            Cmd.Parameters.AddWithValue("@btnSave_Kachir", SqlDbType.Bit).Value = ckbtnSave_Kachir.CheckState;
            Cmd.Parameters.AddWithValue("@btnEdit_Kachir", SqlDbType.Bit).Value = ckbtnEdit_Kachir.CheckState;
            Cmd.Parameters.AddWithValue("@btnDelete_Kachir", SqlDbType.Bit).Value = ckbtnDelete_Kachir.CheckState;
            Cmd.Parameters.AddWithValue("@Frm_User_Permissions", SqlDbType.Bit).Value = ckFrm_User_Permissions.CheckState;
            Cmd.Parameters.AddWithValue("@New_Permissions", SqlDbType.Bit).Value = ckNew_Permissions.CheckState;
            Cmd.Parameters.AddWithValue("@Save_Permissions", SqlDbType.Bit).Value = ckSave_Permissions.CheckState;
            Cmd.Parameters.AddWithValue("@Edit_Permissions", SqlDbType.Bit).Value = ckEdit_Permissions.CheckState;
            Cmd.Parameters.AddWithValue("@Delete_Permissions", SqlDbType.Bit).Value = ckDelete_Permissions.CheckState;
           
            Cmd.Parameters.AddWithValue("@UserAccID", SqlDbType.Int).Value = Convert.ToInt32(TxtNumber_User.Text);
            Cmd.Parameters.AddWithValue("@No_Permissions", SqlDbType.Int).Value = Convert.ToInt32(txt_PerId.Text);

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                Cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم تعديل الصلاحيات بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cmd = null;
            }
            catch (Exception ex)
            {
                Con.con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
            }
        }

      

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Cmd2 = null;
            rdr2.Close();
        }



        private void Parm_All_CheckedChanged(object sender, EventArgs e)
        {



            if (Parm_All.Checked == true)
            {

                ckFrm_Company.Checked = true;
                ckbtnSave_Company.Checked = true;

                ckFrm_Settings.Checked = true;
                ckbtnSaveValueTax.Checked = true;
                ckbtnSaveStatusTax.Checked = true;
                ckbtnSavePrintDef.Checked = true;
                ckbtnSaveReportDef.Checked = true;

                ckFrm_Backup_And_Restore.Checked = true;
                ckbtnBackup.Checked = true;
                ckbtnRecovry.Checked = true;

                ckFrm_Connection.Checked = true;
                ckbtnSave.Checked = true;


                ckFrm_UsersManager.Checked = true;
                ckbtnNew_User.Checked = true;
                ckbtnSave_User.Checked = true;
                ckbtnEdit_User.Checked = true;
                ckbtnDelete_User.Checked = true;

                ckbtnNew_Kachir.Checked = true;
                ckbtnSave_Kachir.Checked = true;
                ckbtnEdit_Kachir.Checked = true;
                ckbtnDelete_Kachir.Checked = true;

                ckFrm_User_Permissions.Checked = true;
                ckNew_Permissions.Checked = true;
                ckSave_Permissions.Checked = true;
                ckEdit_Permissions.Checked = true;
                ckDelete_Permissions.Checked = true;


                ckFrm_Tabels.Checked = true;
                ckbtnNew_Tabel.Checked = true;
                ckbtnSave_Tabel.Checked = true;
                ckbtnEdit_Tabel.Checked = true;
                ckbtnDelete_Tabel.Checked = true;


                ckFrm_Manage_Product.Checked = true;
                ckbtnshowAll_Product.Checked = true;
                ckAdd_Product.Checked = true;
                ckbtnEdit_Product.Checked = true;
                ckbtnDelete_Product.Checked = true;

                ckFrm_Add_Product.Checked = true;
                ckbtnEdit_Product1.Checked = true;
                ckbtnSave_Product1.Checked = true;

                ckFrm_Salse_History.Checked = true;


                ckFrm_Delevery.Checked = true;
                ckbtnNew_Area.Checked = true;
                ckbtnSave_Area.Checked = true;
                ckbtnEdit_Area.Checked = true;
                ckbtnDelete_Area.Checked = true;

                ckbtnNew_Emp.Checked = true;
                ckbtnSave_Emp.Checked = true;
                ckbtnEdit_Emp.Checked = true;
                ckbtnDelete_Emp.Checked = true;

                ckbtnNew_Customer.Checked = true;
                ckbtnSave_Customer.Checked = true;
                ckbtnEdit_Customer.Checked = true;
                ckbtnDelete_Customer.Checked = true;


                ckFrm_Cat_Dep.Checked = true;
                ckbtnNew_Dep.Checked = true;
                ckbtnSave_Dep.Checked = true;
                ckbtnEdit_Dep.Checked = true;
                ckbtnDelete_Dep.Checked = true;
                ckbtnNew_Cat.Checked = true;
                ckbtnSave_Cat.Checked = true;
                ckbtnEdit_Cat.Checked = true;
                ckbtnDelete_Cat.Checked = true;



            }
            else
            {
                ckFrm_Company.Checked = false;
                ckbtnSave_Company.Checked = false;

                ckFrm_Settings.Checked = false;
                ckbtnSaveValueTax.Checked = false;
                ckbtnSaveStatusTax.Checked = false;
                ckbtnSavePrintDef.Checked = false;
                ckbtnSaveReportDef.Checked = false;

                ckFrm_Backup_And_Restore.Checked = false;
                ckbtnBackup.Checked = false;
                ckbtnRecovry.Checked = false;

                ckFrm_Connection.Checked = false;
                ckbtnSave.Checked = false;


                ckFrm_UsersManager.Checked = false;
                ckbtnNew_User.Checked = false;
                ckbtnSave_User.Checked = false;
                ckbtnEdit_User.Checked = false;
                ckbtnDelete_User.Checked = false;

                ckbtnNew_Kachir.Checked = false;
                ckbtnSave_Kachir.Checked = false;
                ckbtnEdit_Kachir.Checked = false;
                ckbtnDelete_Kachir.Checked = false;

                ckFrm_User_Permissions.Checked = false;
                ckNew_Permissions.Checked = false;
                ckSave_Permissions.Checked = false;
                ckEdit_Permissions.Checked = false;
                ckDelete_Permissions.Checked = false;


                ckFrm_Tabels.Checked = false;
                ckbtnNew_Tabel.Checked = false;
                ckbtnSave_Tabel.Checked = false;
                ckbtnEdit_Tabel.Checked = false;
                ckbtnDelete_Tabel.Checked = false;


                ckFrm_Manage_Product.Checked = false;
                ckbtnshowAll_Product.Checked = false;
                ckAdd_Product.Checked = false;
                ckbtnEdit_Product.Checked = false;
                ckbtnDelete_Product.Checked = false;

                ckFrm_Add_Product.Checked = false;
                ckbtnEdit_Product1.Checked = false;
                ckbtnSave_Product1.Checked = false;

                ckFrm_Salse_History.Checked = false;


                ckFrm_Delevery.Checked = false;
                ckbtnNew_Area.Checked = false;
                ckbtnSave_Area.Checked = false;
                ckbtnEdit_Area.Checked = false;
                ckbtnDelete_Area.Checked = false;

                ckbtnNew_Emp.Checked = false;
                ckbtnSave_Emp.Checked = false;
                ckbtnEdit_Emp.Checked = false;
                ckbtnDelete_Emp.Checked = false;

                ckbtnNew_Customer.Checked = false;
                ckbtnSave_Customer.Checked = false;
                ckbtnEdit_Customer.Checked = false;
                ckbtnDelete_Customer.Checked = false;


                ckFrm_Cat_Dep.Checked = false;
                ckbtnNew_Dep.Checked = false;
                ckbtnSave_Dep.Checked = false;
                ckbtnEdit_Dep.Checked = false;
                ckbtnDelete_Dep.Checked = false;
                ckbtnNew_Cat.Checked = false;
                ckbtnSave_Cat.Checked = false;
                ckbtnEdit_Cat.Checked = false;
                ckbtnDelete_Cat.Checked = false;
            }
        }



        private void ckFrm_Salse_History_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_Salse_History.Checked == true)
            {
                ckFrm_Salse_History.Checked = true;
            }
            else
            {
                ckFrm_Salse_History.Checked = false;
            }
        }



        private void ckFrm_Backup_And_Restore_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_Backup_And_Restore.Checked == true)
            {
                ckbtnRecovry.Checked = true;
                ckbtnBackup.Checked = true;
            }
            else
            {
                ckbtnRecovry.Checked = false;
                ckbtnBackup.Checked = false;

            }
        }



        private void ckFrm_Settings_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_Settings.Checked == true)
            {
                ckbtnSaveStatusTax.Checked = true;
                ckbtnSaveValueTax.Checked = true;
                ckbtnSavePrintDef.Checked = true;
                ckbtnSaveReportDef.Checked = true;
            }
            else
            {
                ckbtnSaveStatusTax.Checked = false;
                ckbtnSaveValueTax.Checked = false;
                ckbtnSavePrintDef.Checked = false;
                ckbtnSaveReportDef.Checked = false;
            }
        }

       


        private void ckFrm_Cat_Dep_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_Cat_Dep.Checked == true)
            {
                ckbtnNew_Dep.Checked = true;
                ckbtnSave_Dep.Checked = true;
                ckbtnEdit_Dep.Checked = true;
                ckbtnDelete_Dep.Checked = true;
                ckbtnNew_Cat.Checked = true;
                ckbtnSave_Cat.Checked = true;
                ckbtnEdit_Cat.Checked = true;
                ckbtnDelete_Cat.Checked = true;
            }
            else
            {
                ckbtnNew_Dep.Checked = false;
                ckbtnSave_Dep.Checked = false;
                ckbtnEdit_Dep.Checked = false;
                ckbtnDelete_Dep.Checked = false;
                ckbtnNew_Cat.Checked = false;
                ckbtnSave_Cat.Checked = false;
                ckbtnEdit_Cat.Checked = false;
                ckbtnDelete_Cat.Checked = false;
            }
        }

        private void ckFrm_Tabels_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_Tabels.Checked == true)
            {
                ckbtnNew_Tabel.Checked = true;
                ckbtnSave_Tabel.Checked = true;
                ckbtnEdit_Tabel.Checked = true;
                ckbtnDelete_Tabel.Checked = true;
            }
            else
            {
                ckbtnNew_Tabel.Checked = false;
                ckbtnSave_Tabel.Checked = false;
                ckbtnEdit_Tabel.Checked = false;
                ckbtnDelete_Tabel.Checked = false;
            }
        }

        private void ckFrm_Delevery_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_Delevery.Checked == true)
            {
                ckbtnNew_Area.Checked = true;
                ckbtnSave_Area.Checked = true;
                ckbtnEdit_Area.Checked = true;
                ckbtnDelete_Area.Checked = true;

                ckbtnNew_Emp.Checked = true;
                ckbtnSave_Emp.Checked = true;
                ckbtnEdit_Emp.Checked = true;
                ckbtnDelete_Emp.Checked = true;

                ckbtnNew_Customer.Checked = true;
                ckbtnSave_Customer.Checked = true;
                ckbtnEdit_Customer.Checked = true;
                ckbtnDelete_Customer.Checked = true;
            }
            else
            {
                ckbtnNew_Area.Checked = false;
                ckbtnSave_Area.Checked = false;
                ckbtnEdit_Area.Checked = false;
                ckbtnDelete_Area.Checked = false;

                ckbtnNew_Emp.Checked = false;
                ckbtnSave_Emp.Checked = false;
                ckbtnEdit_Emp.Checked = false;
                ckbtnDelete_Emp.Checked = false;

                ckbtnNew_Customer.Checked = false;
                ckbtnSave_Customer.Checked = false;
                ckbtnEdit_Customer.Checked = false;
                ckbtnDelete_Customer.Checked = false;


            }
        }

        private void ckFrm_Manage_Product_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_Manage_Product.Checked == true)
            {

                ckbtnshowAll_Product.Checked = true;
                ckAdd_Product.Checked = true;
                ckbtnEdit_Product.Checked = true;
                ckbtnDelete_Product.Checked = true;
            }
            else
            {

                ckbtnshowAll_Product.Checked = false;
                ckAdd_Product.Checked = false;
                ckbtnEdit_Product.Checked = false;
                ckbtnDelete_Product.Checked = false;
            }
        }

        private void ckFrm_Add_Product_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_Add_Product.Checked == true)
            {

                ckbtnSave_Product1.Checked = true;
                ckbtnEdit_Product1.Checked = true;

            }
            else
            {
                ckbtnSave_Product1.Checked = false;
                ckbtnEdit_Product1.Checked = false;


            }
        }

     

        private void CkFrm_Connection_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_Connection.Checked == true)
            {
                ckbtnSave.Checked = true;
            }
            else
            {
                ckbtnSave.Checked = false;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtName_User.Text = "";
            TxtNumber_User.Text = "";
            btnNew.Enabled = false;

            if (_save == true)
                btnSave.Enabled = true;
            else btnSave.Enabled = false;

            //btnSave.Enabled = true;
            ////btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            ckFrm_Company.Checked = false;
            ckbtnSave_Company.Checked = false;

            ckFrm_Settings.Checked = false;
            ckbtnSaveValueTax.Checked = false;
            ckbtnSaveStatusTax.Checked = false;
            ckbtnSavePrintDef.Checked = false;
            ckbtnSaveReportDef.Checked = false;

            ckFrm_Backup_And_Restore.Checked = false;
            ckbtnBackup.Checked = false;
            ckbtnRecovry.Checked = false;

            ckFrm_Connection.Checked = false;
            ckbtnSave.Checked = false;


            ckFrm_UsersManager.Checked = false;
            ckbtnNew_User.Checked = false;
            ckbtnSave_User.Checked = false;
            ckbtnEdit_User.Checked = false;
            ckbtnDelete_User.Checked = false;

            ckbtnNew_Kachir.Checked = false;
            ckbtnSave_Kachir.Checked = false;
            ckbtnEdit_Kachir.Checked = false;
            ckbtnDelete_Kachir.Checked = false;

            ckFrm_User_Permissions.Checked = false;
            ckNew_Permissions.Checked = false;
            ckSave_Permissions.Checked = false;
            ckEdit_Permissions.Checked = false;
            ckDelete_Permissions.Checked = false;


            ckFrm_Tabels.Checked = false;
            ckbtnNew_Tabel.Checked = false;
            ckbtnSave_Tabel.Checked = false;
            ckbtnEdit_Tabel.Checked = false;
            ckbtnDelete_Tabel.Checked = false;


            ckFrm_Manage_Product.Checked = false;
            ckbtnshowAll_Product.Checked = false;
            ckAdd_Product.Checked = false;
            ckbtnEdit_Product.Checked = false;
            ckbtnDelete_Product.Checked = false;

            ckFrm_Add_Product.Checked = false;
            ckbtnEdit_Product1.Checked = false;
            ckbtnSave_Product1.Checked = false;

            ckFrm_Salse_History.Checked = false;


            ckFrm_Delevery.Checked = false;
            ckbtnNew_Area.Checked = false;
            ckbtnSave_Area.Checked = false;
            ckbtnEdit_Area.Checked = false;
            ckbtnDelete_Area.Checked = false;

            ckbtnNew_Emp.Checked = false;
            ckbtnSave_Emp.Checked = false;
            ckbtnEdit_Emp.Checked = false;
            ckbtnDelete_Emp.Checked = false;

            ckbtnNew_Customer.Checked = false;
            ckbtnSave_Customer.Checked = false;
            ckbtnEdit_Customer.Checked = false;
            ckbtnDelete_Customer.Checked = false;


            ckFrm_Cat_Dep.Checked = false;
            ckbtnNew_Dep.Checked = false;
            ckbtnSave_Dep.Checked = false;
            ckbtnEdit_Dep.Checked = false;
            ckbtnDelete_Dep.Checked = false;
            ckbtnNew_Cat.Checked = false;
            ckbtnSave_Cat.Checked = false;
            ckbtnEdit_Cat.Checked = false;
            ckbtnDelete_Cat.Checked = false;
            TxtName_User.Text = null;
        }

        

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                Delete_Permission_tbl(Dgv_Permissions);

                if (_new == true)
                    btnNew.Enabled = true;
                else btnNew.Enabled = false;             

                //btnNew.Enabled = true;
                btnSave.Enabled = false;
                //btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }


        }

        public void Delete_Permission_tbl(DataGridView Dgv_Permi)
        {

            int Position = Dgv_Permissions.CurrentRow.Index;
            int ID_Position = Convert.ToInt32(Dgv_Permissions.Rows[Position].Cells[0].Value);

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con.con;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Delete From Permissions_Tbl Where No_Permissions = @No_Permissions";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@No_Permissions", SqlDbType.Int).Value = ID_Position;
            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                Cmd.ExecuteNonQuery();
                Dgv_Permissions.Rows.Clear();

                Con.con.Close();
                MessageBox.Show("تم حذف السجل.", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cmd = null;
            }
            catch (Exception ex)
            {
                Con.con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
            }

        }

      

        private void BtnSave_Click(object sender, EventArgs e)
        {

            try
            {
                
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                SqlCommand Cmd = new SqlCommand("Select * From Permissions_Tbl where UserAccID ='" + TxtNumber_User.Text + "' And No_Permissions ='" + txt_PerId.Text + "'", Con.con);
                SqlDataReader rdr = Cmd.ExecuteReader();
               
                    if (rdr.HasRows)
                    {
                        Update_Parmission_tbl();

                        if (_new == true)
                            btnNew.Enabled = true;
                        else btnNew.Enabled = false;                       

                        //btnNew.Enabled = true;
                        btnSave.Enabled = false;
                        ////btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        load_Permissions_tbl();
                    }
                    else
                    {
                        insert_Table();

                        if (_new == true)
                            btnNew.Enabled = true;
                        else btnNew.Enabled = false;

                        //btnNew.Enabled = true;
                        btnSave.Enabled = false;
                        //btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        load_Permissions_tbl();
                    }
               
                
            }
            catch(Exception ex){
                Con.con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }


      

        private void CkFrm_Company_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_Company.Checked == true)
            {
                ckbtnSave_Company.Checked = true;
            }
            else
            {
                ckbtnSave_Company.Checked = false;

            }
        }

        private void CkFrm_UsersManager_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_UsersManager.Checked == true)
            {
                ckbtnNew_User.Checked = true;
                ckbtnSave_User.Checked = true;
                ckbtnEdit_User.Checked = true;
                ckbtnDelete_User.Checked = true;

                ckbtnNew_Kachir.Checked = true;
                ckbtnSave_Kachir.Checked = true;
                ckbtnEdit_Kachir.Checked = true;
                ckbtnDelete_Kachir.Checked = true;
            }
            else
            {
                ckbtnNew_User.Checked = false;
                ckbtnSave_User.Checked = false;
                ckbtnEdit_User.Checked = false;
                ckbtnDelete_User.Checked = false;

                ckbtnNew_Kachir.Checked = false;
                ckbtnSave_Kachir.Checked = false;
                ckbtnEdit_Kachir.Checked = false;
                ckbtnDelete_Kachir.Checked = false;
            }
        }

        private void CkFrm_User_Permissions_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFrm_User_Permissions.Checked == true)
            {
                ckNew_Permissions.Checked = true;
                ckSave_Permissions.Checked = true;
                ckEdit_Permissions.Checked = true;
                ckDelete_Permissions.Checked = true;
            }
            else
            {
                ckNew_Permissions.Checked = false;
                ckSave_Permissions.Checked = false;
                ckEdit_Permissions.Checked = false;
                ckDelete_Permissions.Checked = false;
            }
        }

        private void Dgv_Permissions_Click(object sender, EventArgs e)
        {
            
            if (Dgv_Permissions.CurrentRow != null)
            {
                txt_PerId.Text = Dgv_Permissions.CurrentRow.Cells[0].Value.ToString();
                TxtNumber_User.Text = Dgv_Permissions.CurrentRow.Cells[1].Value.ToString();
                TxtName_User.Text = Dgv_Permissions.CurrentRow.Cells[2].Value.ToString();

                if (_new == true)
                    btnNew.Enabled = true;
                else btnNew.Enabled = false;

                if (_save == true)
                    btnSave.Enabled = true;
                else btnSave.Enabled = false;

                if (_delete == true)
                    btnDelete.Enabled = true;
                else btnDelete.Enabled = false;

                //btnNew.Enabled = true;
                //btnSave.Enabled = true;
                ////btnEdit.Enabled = true;
                //btnDelete.Enabled = true;

                if (Con.con.State == System.Data.ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                SqlCommand Cmd = new SqlCommand("Select * From Permissions_Tbl where UserAccID ='" + TxtNumber_User.Text + "' And No_Permissions ='" + txt_PerId.Text + "'", Con.con);
                SqlDataReader rdr = Cmd.ExecuteReader();
                rdr.Read();

                if ((bool)rdr["Frm_Salse_History"] == true)
                    ckFrm_Salse_History.Checked = true;
                else ckFrm_Salse_History.Checked = false;

                if ((bool)rdr["Frm_Company"] == true)
                    ckFrm_Company.Checked = true;
                else ckFrm_Company.Checked = false;

                if ((bool)rdr["btnSave_Company"] == true)
                    ckbtnSave_Company.Checked = true;
                else ckbtnSave_Company.Checked = false;

                if ((bool)rdr["Frm_Settings"] == true)
                    ckFrm_Settings.Checked = true;
                else ckFrm_Settings.Checked = false;

                if ((bool)rdr["btnSaveValueTax"] == true)
                    ckbtnSaveValueTax.Checked = true;
                else ckbtnSaveValueTax.Checked = false;

                if ((bool)rdr["btnSaveStatusTax"] == true)
                    ckbtnSaveStatusTax.Checked = true;
                else ckbtnSaveStatusTax.Checked = false;

                if ((bool)rdr["btnSavePrintDef"] == true)
                    ckbtnSavePrintDef.Checked = true;
                else ckbtnSavePrintDef.Checked = false;

                if ((bool)rdr["btnSaveReportDef"] == true)
                    ckbtnSaveReportDef.Checked = true;
                else ckbtnSaveReportDef.Checked = false;

                if ((bool)rdr["Frm_Manage_Product"] == true)
                    ckFrm_Manage_Product.Checked = true;
                else ckFrm_Manage_Product.Checked = false;

                if ((bool)rdr["btnshowAll_Product"] == true)
                    ckbtnshowAll_Product.Checked = true;
                else ckbtnshowAll_Product.Checked = false;

                if ((bool)rdr["Add_Product"] == true)
                    ckAdd_Product.Checked = true;
                else ckAdd_Product.Checked = false;

                if ((bool)rdr["btnEdit_Product"] == true)
                    ckbtnEdit_Product.Checked = true;
                else ckbtnEdit_Product.Checked = false;

                if ((bool)rdr["btnDelete_Product"] == true)
                    ckbtnDelete_Product.Checked = true;
                else ckbtnDelete_Product.Checked = false;

                if ((bool)rdr["Frm_Add_Product"] == true)
                    ckFrm_Add_Product.Checked = true;
                else ckFrm_Add_Product.Checked = false;

                if ((bool)rdr["btnSave_Product1"] == true)
                    ckbtnSave_Product1.Checked = true;
                else ckbtnSave_Product1.Checked = false;

                if ((bool)rdr["btnEdit_Product1"] == true)
                    ckbtnEdit_Product1.Checked = true;
                else ckbtnEdit_Product1.Checked = false;

                if ((bool)rdr["Frm_Backup_And_Restore"] == true)
                    ckFrm_Backup_And_Restore.Checked = true;
                else ckFrm_Backup_And_Restore.Checked = false;

                if ((bool)rdr["btnBackup"] == true)
                    ckbtnBackup.Checked = true;
                else ckbtnBackup.Checked = false;

                if ((bool)rdr["btnRecovry"] == true)
                    ckbtnRecovry.Checked = true;
                else ckbtnRecovry.Checked = false;

                if ((bool)rdr["Frm_Connection"] == true)
                    ckFrm_Connection.Checked = true;
                else ckFrm_Connection.Checked = false;

                if ((bool)rdr["btnSave"] == true)
                    ckbtnSave.Checked = true;
                else ckFrm_Cat_Dep.Checked = false;

                if ((bool)rdr["Frm_Cat_Dep"] == true)
                    ckFrm_Cat_Dep.Checked = true;
                else ckbtnNew_Dep.Checked = false;

                if ((bool)rdr["btnNew_Dep"] == true)
                    ckbtnNew_Dep.Checked = true;
                else ckbtnNew_Dep.Checked = false;

                if ((bool)rdr["btnSave_Dep"] == true)
                    ckbtnSave_Dep.Checked = true;
                else ckbtnSave_Dep.Checked = false;

                if ((bool)rdr["btnEdit_Dep"] == true)
                    ckbtnEdit_Dep.Checked = true;
                else ckbtnEdit_Dep.Checked = false;

                if ((bool)rdr["btnDelete_Dep"] == true)
                    ckbtnDelete_Dep.Checked = true;
                else ckbtnDelete_Dep.Checked = false;

                if ((bool)rdr["btnNew_Cat"] == true)
                    ckbtnNew_Cat.Checked = true;
                else ckbtnNew_Cat.Checked = false;

                if ((bool)rdr["btnSave_Cat"] == true)
                    ckbtnSave_Cat.Checked = true;
                else ckbtnSave_Cat.Checked = false;

                if ((bool)rdr["btnEdit_Cat"] == true)
                    ckbtnEdit_Cat.Checked = true;
                else ckbtnEdit_Cat.Checked = false;

                if ((bool)rdr["btnDelete_Cat"] == true)
                    ckbtnDelete_Cat.Checked = true;
                else ckbtnDelete_Cat.Checked = false;

                if ((bool)rdr["Frm_Tabels"] == true)
                    ckFrm_Tabels.Checked = true;
                else ckFrm_Tabels.Checked = false;

                if ((bool)rdr["btnNew_Tabel"] == true)
                    ckbtnNew_Tabel.Checked = true;
                else ckbtnNew_Tabel.Checked = false;

                if ((bool)rdr["btnSave_Tabel"] == true)
                    ckbtnSave_Tabel.Checked = true;
                else ckbtnSave_Tabel.Checked = false;

                if ((bool)rdr["btnEdit_Tabel"] == true)
                    ckbtnEdit_Tabel.Checked = true;
                else ckbtnEdit_Tabel.Checked = false;

                if ((bool)rdr["btnDelete_Tabel"] == true)
                    ckbtnDelete_Tabel.Checked = true;
                else ckbtnDelete_Tabel.Checked = false;

                if ((bool)rdr["Frm_Delevery"] == true)
                    ckFrm_Delevery.Checked = true;
                else ckFrm_Delevery.Checked = false;

                if ((bool)rdr["btnNew_Area"] == true)
                    ckbtnNew_Area.Checked = true;
                else ckbtnNew_Area.Checked = false;

                if ((bool)rdr["btnSave_Area"] == true)
                    ckbtnSave_Area.Checked = true;
                else ckbtnSave_Area.Checked = false;

                if ((bool)rdr["btnEdit_Area"] == true)
                    ckbtnEdit_Area.Checked = true;
                else ckbtnEdit_Area.Checked = false;

                if ((bool)rdr["btnDelete_Area"] == true)
                    ckbtnDelete_Area.Checked = true;
                else ckbtnDelete_Area.Checked = false;

                if ((bool)rdr["btnNew_Emp"] == true)
                    ckbtnNew_Emp.Checked = true;
                else ckbtnNew_Emp.Checked = false;

                if ((bool)rdr["btnSave_Emp"] == true)
                    ckbtnSave_Emp.Checked = true;
                else ckbtnSave_Emp.Checked = false;

                if ((bool)rdr["btnEdit_Emp"] == true)
                    ckbtnEdit_Emp.Checked = true;
                else ckbtnEdit_Emp.Checked = false;

                if ((bool)rdr["btnDelete_Emp"] == true)
                    ckbtnDelete_Emp.Checked = true;
                else ckbtnDelete_Emp.Checked = false;

                if ((bool)rdr["btnNew_Customer"] == true)
                    ckbtnNew_Customer.Checked = true;
                else ckbtnNew_Customer.Checked = false;

                if ((bool)rdr["btnSave_Customer"] == true)
                    ckbtnSave_Customer.Checked = true;
                else ckbtnSave_Customer.Checked = false;

                if ((bool)rdr["btnEdit_Customer"] == true)
                    ckbtnEdit_Customer.Checked = true;
                else ckbtnEdit_Customer.Checked = false;

                if ((bool)rdr["btnDelete_Customer"] == true)
                    ckbtnDelete_Customer.Checked = true;
                else ckbtnDelete_Customer.Checked = false;

                if ((bool)rdr["Frm_UsersManager"] == true)
                    ckFrm_UsersManager.Checked = true;
                else ckFrm_UsersManager.Checked = false;

                if ((bool)rdr["btnNew_User"] == true)
                    ckbtnNew_User.Checked = true;
                else ckbtnNew_User.Checked = false;

                if ((bool)rdr["btnSave_User"] == true)
                    ckbtnSave_User.Checked = true;
                else ckbtnSave_User.Checked = false;

                if ((bool)rdr["btnEdit_User"] == true)
                    ckbtnEdit_User.Checked = true;
                else ckbtnEdit_User.Checked = false;

                if ((bool)rdr["btnDelete_User"] == true)
                    ckbtnDelete_User.Checked = true;
                else ckbtnDelete_User.Checked = false;

                if ((bool)rdr["btnNew_Kachir"] == true)
                    ckbtnNew_Kachir.Checked = true;
                else ckbtnNew_Kachir.Checked = false;

                if ((bool)rdr["btnSave_Kachir"] == true)
                    ckbtnSave_Kachir.Checked = true;
                else ckbtnSave_Kachir.Checked = false;

                if ((bool)rdr["btnEdit_Kachir"] == true)
                    ckbtnEdit_Kachir.Checked = true;
                else ckbtnEdit_Kachir.Checked = false;

                if ((bool)rdr["btnDelete_Kachir"] == true)
                    ckbtnDelete_Kachir.Checked = true;
                else ckbtnDelete_Kachir.Checked = false;

                if ((bool)rdr["Frm_User_Permissions"] == true)
                    ckFrm_User_Permissions.Checked = true;
                else ckFrm_User_Permissions.Checked = false;

                if ((bool)rdr["New_Permissions"] == true)
                    ckNew_Permissions.Checked = true;
                else ckNew_Permissions.Checked = false;

                if ((bool)rdr["Save_Permissions"] == true)
                    ckSave_Permissions.Checked = true;
                else ckSave_Permissions.Checked = false;

                if ((bool)rdr["Edit_Permissions"] == true)
                    ckEdit_Permissions.Checked = true;
                else ckEdit_Permissions.Checked = false;

                if ((bool)rdr["Delete_Permissions"] == true)
                    ckDelete_Permissions.Checked = true;
                else ckDelete_Permissions.Checked = false;

                rdr.Close();
                Con.con.Close();



            }
            else
            {
                MessageBox.Show("لايوجد صف محدد في الجدول ");
            }

            
        }

        private void Dgv_User_Click(object sender, EventArgs e)
        {
            if (Dgv_User.CurrentRow != null)
            {
                btnNew.PerformClick();


                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();

                string User = Dgv_User.CurrentRow.Cells[0].Value.ToString();
                SqlCommand Cmd1 = new SqlCommand("Select * From Permissions_Tbl where UserAccID ='" + User + "'", Con.con);
                SqlDataReader rdr1 = Cmd1.ExecuteReader();
                if (rdr1.HasRows)
                {
                    MessageBox.Show("لا يمكن عمل صلاحية لهذا المستخدم لانه لديه صلاحية سابقة , اذا اردت تعديلها" + Environment.NewLine + "                     قم باختياره من المستخدمين الذين تم تطبيق صلاحية لهم");
                    return;
                }
                else
                {
                    TxtNumber_User.Text = Dgv_User.CurrentRow.Cells[0].Value.ToString();
                    TxtName_User.Text = Dgv_User.CurrentRow.Cells[1].Value.ToString();
                }


                if (_new == true)
                    btnNew.Enabled = true;
                else btnNew.Enabled = false;

                if (_save == true)
                    btnSave.Enabled = true;
                else btnSave.Enabled = false;   

                //btnNew.Enabled = true;
                //btnSave.Enabled = true;
                ////btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("لايوجد صف محدد في الجدول ");
            }

           
        }

       
       

       

        

       

        
    }
}
