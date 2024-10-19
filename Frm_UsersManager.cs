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

namespace Res_csharp
{
     

    public partial class Frm_UsersManager : Form
    {

        Connection Con;
        public SqlCommand Cmd2;
        public SqlDataReader rdr2;
        public bool _newUser, _saveUser, _editUser, _deleteUser, _newKachir, _saveKachir, _eidtKachir, _deleteKachir;



        public Frm_UsersManager()
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
            Cmd2 = new SqlCommand("Select * From Permissions_Tbl where UserAccID ='" + UserAccID + "'", Con.con);
            rdr2 = Cmd2.ExecuteReader();
            rdr2.Read();

            if ((bool)rdr2["btnNew_User"] == true)
                _newUser = true;
            else _newUser = false;

            if ((bool)rdr2["btnSave_User"] == true)
                _saveUser = true;
            else _saveUser = false;

            if ((bool)rdr2["btnEdit_User"] == true)
                _editUser = true;
            else _editUser = false;

            if ((bool)rdr2["btnDelete_User"] == true)
                _deleteUser = true;
            else _deleteUser = false;

            if ((bool)rdr2["btnNew_Kachir"] == true)
                _newKachir = true;
            else _newKachir = false;

            if ((bool)rdr2["btnSave_Kachir"] == true)
                _saveKachir = true;
            else _saveKachir = false;

            if ((bool)rdr2["btnEdit_Kachir"] == true)
                _eidtKachir = true;
            else _eidtKachir = false;

            if ((bool)rdr2["btnDelete_Kachir"] == true)
                _deleteKachir = true;
            else _deleteKachir = false;




            //if (_newUser == true)
            //    BtnNew.Enabled = true;
            //else BtnNew.Enabled = false;

            //if (_saveUser == true)
            //    BtnSave.Enabled = true;
            //else BtnSave.Enabled = false;

            //if (_editUser == true)
            //    BtnEdit.Enabled = true;
            //else BtnEdit.Enabled = false;

            //if (_deleteUser == true)
            //    BtnDelete.Enabled = true;
            //else BtnDelete.Enabled = false;

            //if (_newKachir == true)
            //    BtnNewKash.Enabled = true;
            //else BtnNewKash.Enabled = false;

            //if (_saveKachir == true)
            //    BtnSaveKash.Enabled = true;
            //else BtnSaveKash.Enabled = false;

            //if (_eidtKachir == true)
            //    BtnEditKash.Enabled = true;
            //else BtnEditKash.Enabled = false;

            //if (_deleteKachir == true)
            //    BtnDeleteKash.Enabled = true;
            //else BtnDeleteKash.Enabled = false;


        } 



        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Cmd2 = null;
            rdr2.Close();

        }




        private void Frm_UsersManager_Load(object sender, EventArgs e)
        {

            ClearTextAfterDeleteAndUpdateAndSaveOrOpenForm();
            Load_User();

            ClearKashir_AfterDeleteAndUpdateAndSaveOrOpenForm();
            Load_Kashir();
        }





        public void ClearTextAfterDeleteAndUpdateAndSaveOrOpenForm()
        {
            TxtUserAccName.Enabled = false;
            TxtUserName.Enabled = false;
            TxtUserPassword.Enabled = false;
            cmbAccType.Enabled = false;
            ChkAccActivate.Enabled = false;

            ck_ShowPaswordUser.Enabled = false;

            TxtUserAccName.Text = "";
            TxtUserName.Text = "";
            TxtUserPassword.Text = "";
            cmbAccType.Text = "";
            cmbAccType.SelectedIndex = -1;

            BtnSave.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            //BtnNew.Enabled = true;
            if (_newUser == true)
                BtnNew.Enabled = true;
            else BtnNew.Enabled = false;


            

        }


        public void ClearText()
        {
            TxtUserAccName.Enabled = true;
            TxtUserName.Enabled = true;
            TxtUserPassword.Enabled = true;
            cmbAccType.Enabled = true;
            ChkAccActivate.Enabled = true;

            ck_ShowPaswordUser.Enabled = true;

            TxtUserAccName.Text = "";
            TxtUserName.Text = "";
            TxtUserPassword.Text = "";
            cmbAccType.Text = "";
            cmbAccType.SelectedIndex = -1;

            TxtUserAccName.Focus();

            if (_saveUser == true)
                BtnSave.Enabled = true;
            else BtnSave.Enabled = false;
            
            //BtnSave.Enabled = true;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnNew.Enabled = false;


        }

       
        public void Load_User()
        {
            Dgv_User.Rows.Clear();
            if (Con.con.State == System.Data.ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * From UserAcount_tbl", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();
            while (rdr.Read())
            {
                string MY_AccActivate = "";
                if (rdr["AccActivate"] != DBNull.Value && (bool)rdr["AccActivate"] == true)
                {
                    MY_AccActivate = "مصرح";
                }
                else
                {
                    MY_AccActivate = "غير مصرح";
                }
                string MY_AccType = "";
                if (rdr["AccType"] != DBNull.Value && (bool)rdr["AccType"] == true)
                {
                    MY_AccType = "مدير";
                }
                else
                {
                    MY_AccType = "مستخدم";
                }
                Dgv_User.Rows.Add(rdr["UserAccID"].ToString(), rdr["UserAccName"].ToString(), rdr["UserName"].ToString(), rdr["UserPassword"].ToString(), MY_AccType, MY_AccActivate);
            }
            rdr.Close();
            Con.con.Close();
        }

        public void Insert_UserAcount_tbl()
        {

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con.con;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Insert Into UserAcount_tbl (UserAccName, UserName, UserPassword, AccType, AccActivate) values (@UserAccName, @UserName, @UserPassword, @AccType, @AccActivate)";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@UserAccName", SqlDbType.NVarChar).Value = TxtUserAccName.Text;
            Cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = TxtUserName.Text;
            Cmd.Parameters.AddWithValue("@UserPassword", SqlDbType.NVarChar).Value = TxtUserPassword.Text;
            Cmd.Parameters.AddWithValue("@AccType", SqlDbType.Bit).Value = cmbAccType.SelectedIndex;
            Cmd.Parameters.AddWithValue("@AccActivate", SqlDbType.Bit).Value = ChkAccActivate.CheckState;

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();

                Cmd.ExecuteNonQuery();
                Con.con.Close();

                MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void Update_UserAcount_tbl()
        {
            SqlCommand Cmd = new SqlCommand
            {
                Connection = Con.con,
                CommandType = CommandType.Text,
                CommandText = "Update UserAcount_tbl Set UserAccName = @UserAccName, UserName = @UserName, UserPassword = @UserPassword , AccType = @AccType , AccActivate = @AccActivate Where UserAccID = @UserAccID"
            };

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@UserAccName", SqlDbType.NVarChar).Value = TxtUserAccName.Text;
            Cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = TxtUserName.Text;
            Cmd.Parameters.AddWithValue("@UserPassword", SqlDbType.NVarChar).Value = TxtUserPassword.Text;
            Cmd.Parameters.AddWithValue("@AccType", SqlDbType.Bit).Value = cmbAccType.SelectedIndex;
            Cmd.Parameters.AddWithValue("@AccActivate", SqlDbType.Bit).Value = ChkAccActivate.CheckState;
            Cmd.Parameters.AddWithValue("@UserAccID", SqlDbType.Int).Value = Convert.ToInt32(TxtUserAccID.Text);

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                Cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم تعديل السجل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void Delete_UserAcount_tbl(DataGridView Dgv_User)
        {
            int Position = Dgv_User.CurrentRow.Index;
            int ID_Position = Convert.ToInt32(Dgv_User.Rows[Position].Cells[0].Value);

            SqlCommand Cmd = new SqlCommand
            {
                Connection = Con.con,
                CommandType = CommandType.Text,
                CommandText = "Delete From UserAcount_tbl Where UserAccID = @UserAccID"
            };

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@UserAccID", SqlDbType.Int).Value = ID_Position;

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                Cmd.ExecuteNonQuery();
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


        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserAccName.Text) || string.IsNullOrEmpty(TxtUserName.Text) || string.IsNullOrEmpty(TxtUserPassword.Text) || string.IsNullOrEmpty(cmbAccType.Text) )
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            Insert_UserAcount_tbl();
            ClearTextAfterDeleteAndUpdateAndSaveOrOpenForm();
            Load_User();
           
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserAccName.Text) || string.IsNullOrEmpty(TxtUserName.Text) || string.IsNullOrEmpty(TxtUserPassword.Text) || string.IsNullOrEmpty(cmbAccType.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            Update_UserAcount_tbl();
            ClearTextAfterDeleteAndUpdateAndSaveOrOpenForm();
            Load_User();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                Delete_UserAcount_tbl(Dgv_User);
            }

            
            ClearTextAfterDeleteAndUpdateAndSaveOrOpenForm();
            Load_User();
        }

        private void Dgv_User_Click(object sender, EventArgs e)
        {
            try
            {
                TxtUserAccID.Text = Dgv_User.CurrentRow.Cells[0].Value.ToString();
                TxtUserAccName.Text = Dgv_User.CurrentRow.Cells[1].Value.ToString();
                TxtUserName.Text = Dgv_User.CurrentRow.Cells[2].Value.ToString();
                TxtUserPassword.Text = Dgv_User.CurrentRow.Cells[3].Value.ToString();

                if (Dgv_User.CurrentRow.Cells[4].Value.ToString() == "مدير")
                {
                    cmbAccType.SelectedIndex = 0;
                }
                else
                {
                    cmbAccType.SelectedIndex = 1;
                }

                if (Dgv_User.CurrentRow.Cells[5].Value.ToString() == "مصرح")
                {
                    ChkAccActivate.Checked = true;
                }
                else
                {
                    ChkAccActivate.Checked = false;
                }

                TxtUserAccName.Enabled = true;
                TxtUserName.Enabled = true;
                TxtUserPassword.Enabled = true;
                cmbAccType.Enabled = true;
                ChkAccActivate.Enabled = true;

                ck_ShowPaswordUser.Enabled = true;

                BtnSave.Enabled = false;
                //BtnEdit.Enabled = true;
                //BtnDelete.Enabled = true;
                //BtnNew.Enabled = true;

                if (_newUser == true)
                    BtnNew.Enabled = true;
                else BtnNew.Enabled = false;               

                if (_editUser == true)
                    BtnEdit.Enabled = true;
                else BtnEdit.Enabled = false;

                if (_deleteUser == true)
                    BtnDelete.Enabled = true;
                else BtnDelete.Enabled = false;


                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ck_ShowPaswordUser_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_ShowPaswordUser.Checked == true)
                TxtUserPassword.UseSystemPasswordChar = false;
            else
                TxtUserPassword.UseSystemPasswordChar = true;
        }




        //............................................Kashir............................................




        public void ClearKashir_AfterDeleteAndUpdateAndSaveOrOpenForm()
        {
            TxtFullName.Enabled = false;
            TxtCashier_UserName.Enabled = false;
            TxtCashier_Pass.Enabled = false;
            //cmbAccType.Enabled = false;
            //ChkAccActivate.Enabled = false;

            ck_ShowPaswordCashir.Enabled = false;
            

            TxtFullName.Text = "";
            TxtCashier_UserName.Text = "";
            TxtCashier_Pass.Text = "";
            //cmbAccType.Text = "";
            //cmbAccType.SelectedIndex = -1;

            BtnSaveKash.Enabled = false;
            BtnEditKash.Enabled = false;
            BtnDeleteKash.Enabled = false;
            //BtnNewKash.Enabled = true;
         
            if (_newKachir == true)
                BtnNewKash.Enabled = true;
            else BtnNewKash.Enabled = false;

        }


        public void ClearKashir()
        {
            TxtFullName.Enabled = true;
            TxtCashier_UserName.Enabled = true;
            TxtCashier_Pass.Enabled = true;
            //cmbAccType.Enabled = true;
            //ChkAccActivate.Enabled = true;

            ck_ShowPaswordCashir.Enabled = true;
           

            TxtFullName.Text = "";
            TxtCashier_UserName.Text = "";
            TxtCashier_Pass.Text = "";
            //cmbAccType.Text = "";
            //cmbAccType.SelectedIndex = -1;

            TxtUserAccName.Focus();
           
            if (_saveKachir == true)
                BtnSaveKash.Enabled = true;
            else BtnSaveKash.Enabled = false;

            //BtnSaveKash.Enabled = true;
            BtnEditKash.Enabled = false;
            BtnDeleteKash.Enabled = false;
            BtnNewKash.Enabled = false;


        }


        public void Load_Kashir()
        {
            Dgv_Kashir.Rows.Clear();
            if (Con.con.State == System.Data.ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * From Cashier_tbl", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();
            while (rdr.Read())
            {
                //string MY_AccActivate = "";
                //if (rdr["AccActivate"] != DBNull.Value && (bool)rdr["AccActivate"] == true)
                //{
                //    MY_AccActivate = "مصرح";
                //}
                //else
                //{
                //    MY_AccActivate = "غير مصرح";
                //}
                //string MY_AccType = "";
                //if (rdr["AccType"] != DBNull.Value && (bool)rdr["AccType"] == true)
                //{
                //    MY_AccType = "مدير";
                //}
                //else
                //{
                //    MY_AccType = "مستخدم";
                //}
                //Dgv_User.Rows.Add(rdr["UserAccID"].ToString(), rdr["UserAccName"].ToString(), rdr["UserName"].ToString(), rdr["UserPassword"].ToString(), MY_AccType, MY_AccActivate);
                Dgv_Kashir.Rows.Add(rdr["Cashier_ID"].ToString(), rdr["FullName"].ToString(), rdr["Cashier_UserName"].ToString(), rdr["Cashier_Pass"].ToString());
            }
            rdr.Close();
            Con.con.Close();
        }

        public void Insert_Cashier_tbl()
        {

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con.con;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Insert Into Cashier_tbl (Cashier_UserName, Cashier_Pass, FullName, Start_Balance, Cashier_Balance, Cashier_Status) values (@Cashier_UserName, @Cashier_Pass, @FullName, @Start_Balance, @Cashier_Balance, @Cashier_Status)";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Cashier_UserName", SqlDbType.NVarChar).Value = TxtCashier_UserName.Text;
            Cmd.Parameters.AddWithValue("@Cashier_Pass", SqlDbType.NVarChar).Value = TxtCashier_Pass.Text;
            Cmd.Parameters.AddWithValue("@FullName", SqlDbType.NVarChar).Value = TxtFullName.Text;
            Cmd.Parameters.AddWithValue("@Start_Balance", SqlDbType.Decimal).Value = 0.0;
            Cmd.Parameters.AddWithValue("@Cashier_Balance", SqlDbType.Decimal).Value = 0.0;
            Cmd.Parameters.AddWithValue("@Cashier_Status", SqlDbType.Bit).Value = false;

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();

                Cmd.ExecuteNonQuery();
                Con.con.Close();

                MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void Update_Cashier_tbl()
        {
            SqlCommand Cmd = new SqlCommand
            {
                Connection = Con.con,
                CommandType = CommandType.Text,
                CommandText = "Update Cashier_tbl Set Cashier_UserName = @Cashier_UserName, Cashier_Pass = @Cashier_Pass, FullName = @FullName , Cashier_Balance = @Cashier_Balance , Cashier_Status = @Cashier_Status Where Cashier_ID = @Cashier_ID"
            };

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Cashier_UserName", SqlDbType.NVarChar).Value = TxtCashier_UserName.Text;
            Cmd.Parameters.AddWithValue("@Cashier_Pass", SqlDbType.NVarChar).Value = TxtCashier_Pass.Text;
            Cmd.Parameters.AddWithValue("@FullName", SqlDbType.NVarChar).Value = TxtFullName.Text;
            Cmd.Parameters.AddWithValue("@Start_Balance", SqlDbType.Decimal).Value = 0.0;
            Cmd.Parameters.AddWithValue("@Cashier_Balance", SqlDbType.Decimal).Value = 0.0;
            Cmd.Parameters.AddWithValue("@Cashier_Status", SqlDbType.Bit).Value = false;
            Cmd.Parameters.AddWithValue("@Cashier_ID", SqlDbType.Int).Value = Convert.ToInt32(TxtCashier_ID.Text);

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                Cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم تعديل السجل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void Delete_Cashier_tbl(DataGridView Dgv_Kashir)
        {
            int Position = Dgv_Kashir.CurrentRow.Index;
            int ID_Position = Convert.ToInt32(Dgv_Kashir.Rows[Position].Cells[0].Value);

            SqlCommand Cmd = new SqlCommand
            {
                Connection = Con.con,
                CommandType = CommandType.Text,
                CommandText = "Delete From Cashier_tbl Where Cashier_ID = @Cashier_ID"
            };

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Cashier_ID", SqlDbType.Int).Value = ID_Position;

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                Cmd.ExecuteNonQuery();
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

        private void BtnNewKash_Click(object sender, EventArgs e)
        {
            ClearKashir();
        }

        private void BtnSaveKash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFullName.Text) || string.IsNullOrEmpty(TxtCashier_UserName.Text) || string.IsNullOrEmpty(TxtCashier_Pass.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            Insert_Cashier_tbl();
            ClearKashir_AfterDeleteAndUpdateAndSaveOrOpenForm();
            Load_Kashir();
        }

        private void BtnEditKash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFullName.Text) || string.IsNullOrEmpty(TxtCashier_UserName.Text) || string.IsNullOrEmpty(TxtCashier_Pass.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            Update_Cashier_tbl();
            ClearKashir_AfterDeleteAndUpdateAndSaveOrOpenForm();
            Load_Kashir();
        }

        private void BtnDeleteKash_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                Delete_Cashier_tbl(Dgv_Kashir);
            }


            ClearKashir_AfterDeleteAndUpdateAndSaveOrOpenForm();
            Load_Kashir();
        }

        private void Dgv_Kashir_Click(object sender, EventArgs e)
        {

            try
            {
                TxtCashier_ID.Text = Dgv_Kashir.CurrentRow.Cells[0].Value.ToString();
                TxtFullName.Text = Dgv_Kashir.CurrentRow.Cells[1].Value.ToString();
                TxtCashier_UserName.Text = Dgv_Kashir.CurrentRow.Cells[2].Value.ToString();
                TxtCashier_Pass.Text = Dgv_Kashir.CurrentRow.Cells[3].Value.ToString();

                //if (Dgv_User.CurrentRow.Cells[4].Value.ToString() == "مدير")
                //{
                //    cmbAccType.SelectedIndex = 0;
                //}
                //else
                //{
                //    cmbAccType.SelectedIndex = 1;
                //}

                //if (Dgv_User.CurrentRow.Cells[5].Value.ToString() == "مصرح")
                //{
                //    ChkAccActivate.Checked = true;
                //}
                //else
                //{
                //    ChkAccActivate.Checked = false;
                //}

                TxtFullName.Enabled = true;
                TxtCashier_UserName.Enabled = true;
                TxtCashier_Pass.Enabled = true;
                //cmbAccType.Enabled = true;
                //ChkAccActivate.Enabled = true;

                ck_ShowPaswordCashir.Enabled = true;

                BtnSaveKash.Enabled = false;
                //BtnEditKash.Enabled = true;
                //BtnDeleteKash.Enabled = true;
                //BtnNewKash.Enabled = true;

                if (_newKachir == true)
                    BtnNewKash.Enabled = true;
                else BtnNewKash.Enabled = false;

                if (_eidtKachir == true)
                    BtnEditKash.Enabled = true;
                else BtnEditKash.Enabled = false;

                if (_deleteKachir == true)
                    BtnDeleteKash.Enabled = true;
                else BtnDeleteKash.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ck_ShowPaswordCashir_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_ShowPaswordCashir.Checked == true)
                TxtCashier_Pass.UseSystemPasswordChar = false;
            else
                TxtCashier_Pass.UseSystemPasswordChar = true;
        }




    }
}
