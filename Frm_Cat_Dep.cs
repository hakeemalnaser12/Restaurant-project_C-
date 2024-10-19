using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Res_csharp.Model;



namespace Res_csharp
{



    public partial class Frm_Cat_Dep : Form

    {
        
        Connection Con;
        public SqlCommand Cmd2;
        public SqlDataReader rdr2;
        public bool _newDep, _saveDep, _editDep, _deleteDep, _newCat, _saveCat, _eidtCat, _deleteCat;

        public Frm_Cat_Dep()
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

            

            if ((bool)rdr2["btnNew_Dep"] == true)
                _newDep = true;
            else _newDep = false;

            if ((bool)rdr2["btnSave_Dep"] == true)
                _saveDep = true;
            else _saveDep = false;

            if ((bool)rdr2["btnEdit_Dep"] == true)
                _editDep = true;
            else _editDep = false;

            if ((bool)rdr2["btnDelete_Dep"] == true)
                _deleteDep = true;
            else _deleteDep = false;

            if ((bool)rdr2["btnNew_Cat"] == true)
                _newCat = true;
            else _newCat = false;

            if ((bool)rdr2["btnSave_Cat"] == true)
                _saveCat = true;
            else _saveCat = false;

            if ((bool)rdr2["btnEdit_Cat"] == true)
                _eidtCat = true;
            else _eidtCat = false;

            if ((bool)rdr2["btnDelete_Cat"] == true)
                _deleteCat = true;
            else _deleteCat = false;


            //if (_newDep == true)
            //    BtnNew.Enabled = true;
            //else BtnNew.Enabled = false;

            //if (_saveDep == true)
            //    BtnSave.Enabled = true;
            //else BtnSave.Enabled = false;

            //if (_editDep == true)
            //    BtnEdit.Enabled = true;
            //else BtnEdit.Enabled = false;

            //if (_deleteDep == true)
            //    BtnDelete.Enabled = true;
            //else BtnDelete.Enabled = false;

            //if (_newCat == true)
            //    BtnNewCat.Enabled = true;
            //else BtnNewCat.Enabled = false;

            //if (_saveCat == true)
            //    BtnSaveCat.Enabled = true;
            //else BtnSaveCat.Enabled = false;

            //if (_eidtCat == true)
            //    BtnEditCat.Enabled = true;
            //else BtnEditCat.Enabled = false;

            //if (_deleteCat == true)
            //    BtnDeleteCat.Enabled = true;
            //else BtnDeleteCat.Enabled = false;

           

           

        }

        private void Frm_Cat_Dep_Load(object sender, EventArgs e)
        {

            // استدعاء الدالة Load_Dep
            Load_Dep();

            ClearTextAfterDeleteAndUpdateAndSaveOrOpenForm();
            ClearCat_aftre_DeleteAndUpdateAndSave_Or_OpenForm();
            // استدعاء الدالة Load_Dep_Tbl
            Load_Dep_Tbl();

            // استدعاء الدالة Lode_Data_Cat
            Lode_Data_Cat();

        }

        private void PrintersCombo()
        {
            try
            {
                // مسح العناصر الموجودة في ComboBox
                cmbPrinter.Items.Clear();

                // الحصول على قائمة الطابعات المثبتة
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    // إضافة كل طابعة إلى ComboBox
                    cmbPrinter.Items.Add(printer);
                }
            }
            catch (Exception ex)
            {
                // عرض رسالة خطأ في حالة حدوث استثناء
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void ClearTextAfterDeleteAndUpdateAndSaveOrOpenForm()
        {
            TxtDepName.Enabled = false;
            cmbPrinter.Enabled = false;
            TxtDepName.Text = "";
            cmbPrinter.Text = "";
            cmbPrinter.SelectedIndex = -1;

            BtnSave.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            //BtnNew.Enabled = true;

            if (_newDep == true)
                BtnNew.Enabled = true;
            else BtnNew.Enabled = false;


            
        }


        public void ClearText()
        {
            TxtDepName.Enabled = true;
            cmbPrinter.Enabled = true;
            TxtDepName.Text = "";
            cmbPrinter.Text = "";
            TxtDepName.Focus();



        
            if (_saveDep == true)
                BtnSave.Enabled = true;
            else BtnSave.Enabled = false;


            //BtnSave.Enabled = true;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnNew.Enabled = false;

            // استدعاء الدالة PrintersCombo
            PrintersCombo();

            cmbPrinter.SelectedIndex = -1;
        }

        public void Load_Dep()
        {
            Dgv_Dep.Rows.Clear();
            if (Con.con.State == System.Data.ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * From Dep_tbl", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();
            while (rdr.Read())
            {
                string MY_Stauts = "";
                if (rdr["Stauts"] != DBNull.Value && (bool)rdr["Stauts"] == true)
                {
                    MY_Stauts = "فعال";
                }
                else
                {
                    MY_Stauts = "غير فعال";
                }
                Dgv_Dep.Rows.Add(rdr["Dep_ID"].ToString(), rdr["Dep_Name"].ToString(), rdr["PrinterName"].ToString(), MY_Stauts);
            }
            rdr.Close();
            Con.con.Close();
        }

        public void Insert_Dep_tbl()
        {

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con.con;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Insert Into Dep_tbl (Dep_Name, PrinterName, Stauts) values (@Dep_Name, @PrinterName, @Stauts)";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Dep_Name", SqlDbType.VarChar).Value = TxtDepName.Text;
            Cmd.Parameters.AddWithValue("@PrinterName", SqlDbType.VarChar).Value = cmbPrinter.Text;
            Cmd.Parameters.AddWithValue("@Stauts", SqlDbType.Bit).Value = ChkStauts.CheckState;

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
      
       
        public void Update_Dep_tbl()
        {
            SqlCommand Cmd = new SqlCommand
            {
                Connection = Con.con,
                CommandType = CommandType.Text,
                CommandText = "Update Dep_tbl Set Dep_Name = @Dep_Name, PrinterName = @PrinterName, Stauts = @Stauts Where Dep_ID = @Dep_ID"
            };

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Dep_Name", SqlDbType.VarChar).Value = TxtDepName.Text;
            Cmd.Parameters.AddWithValue("@PrinterName", SqlDbType.VarChar).Value = cmbPrinter.Text;
            Cmd.Parameters.AddWithValue("@Stauts", SqlDbType.Bit).Value = ChkStauts.Checked;
            Cmd.Parameters.AddWithValue("@Dep_ID", SqlDbType.Int).Value = Convert.ToInt32(Txt_ID.Text);

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

       
        public void Delete_Dep_tbl(DataGridView dgv_Dep_tbl)
        {
            int Position = dgv_Dep_tbl.CurrentRow.Index;
            int ID_Position = Convert.ToInt32(dgv_Dep_tbl.Rows[Position].Cells[0].Value);

            SqlCommand Cmd = new SqlCommand
            {
                Connection = Con.con,
                CommandType = CommandType.Text,
                CommandText = "Delete From Dep_tbl Where Dep_ID = @Dep_ID"
            };

            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Dep_ID", SqlDbType.Int).Value = ID_Position;

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


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDepName.Text) || string.IsNullOrEmpty(cmbPrinter.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            Insert_Dep_tbl();
            ClearTextAfterDeleteAndUpdateAndSaveOrOpenForm();
            Load_Dep();
            Load_Dep_Tbl();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDepName.Text) || string.IsNullOrEmpty(cmbPrinter.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            Update_Dep_tbl();
            ClearTextAfterDeleteAndUpdateAndSaveOrOpenForm(); 
            Load_Dep();
            Load_Dep_Tbl();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                Delete_Dep_tbl(Dgv_Dep);
            }

            ClearTextAfterDeleteAndUpdateAndSaveOrOpenForm(); 
            Load_Dep();
            Load_Dep_Tbl();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void Dgv_Dep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Dgv_Dep_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_ID.Text = Dgv_Dep.CurrentRow.Cells[0].Value.ToString();
                TxtDepName.Text = Dgv_Dep.CurrentRow.Cells[1].Value.ToString();
                cmbPrinter.Text = Dgv_Dep.CurrentRow.Cells[2].Value.ToString();

                if (Dgv_Dep.CurrentRow.Cells[3].Value.ToString() == "فعال")
                {
                    ChkStauts.Checked = true;
                }
                else
                {
                    ChkStauts.Checked = false;
                }

                TxtDepName.Enabled = true;
                cmbPrinter.Enabled = true;

                BtnSave.Enabled = false;
                //BtnEdit.Enabled = true;
                //BtnDelete.Enabled = true;
                //BtnNew.Enabled = true;

                if (_newDep == true)
                    BtnNew.Enabled = true;
                else BtnNew.Enabled = false;

                if (_editDep == true)
                    BtnEdit.Enabled = true;
                else BtnEdit.Enabled = false;

                if (_deleteDep == true)
                    BtnDelete.Enabled = true;
                else BtnDelete.Enabled = false;
             
            } 
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //....................................Cat............................................

        public void Load_Dep_Tbl()
        {
            DataTable dt = new DataTable();
            CmbDep.DataSource = null;
            CmbDep.Items.Clear();
            CmbDep.Text = string.Empty;
            dt.Clear();

            SqlCommand cmd = new SqlCommand("Select Dep_ID, Dep_Name From Dep_tbl", Con.con);
            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();

                dt.Load(cmd.ExecuteReader());
                Con.con.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.con.Close();
            }

            if (dt.Rows.Count > 0)
            {
                CmbDep.DataSource = dt;
                CmbDep.DisplayMember = "Dep_Name";
                CmbDep.ValueMember = "Dep_ID";
            }
            if (CmbDep.Items.Count > 0)
            {
                CmbDep.SelectedIndex = -1;
            }
        }


        public void Insert_Cat_tbl()
        {
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = Con.con;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = "Insert Into Cat_tbl (CatName,Color,Dep_ID) values(@CatName,@Color,@Dep_ID)";
            cmdInsert.Parameters.Clear();

            cmdInsert.Parameters.AddWithValue("@CatName", SqlDbType.VarChar).Value = TxtCatName.Text;
            cmdInsert.Parameters.AddWithValue("@Color", SqlDbType.Int).Value = btnSelectColor.BackColor.ToArgb();
            cmdInsert.Parameters.AddWithValue("@Dep_ID", SqlDbType.Int).Value = CmbDep.SelectedValue;

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                cmdInsert.ExecuteNonQuery();
                Con.con.Close();

                MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void ClearCat_aftre_DeleteAndUpdateAndSave_Or_OpenForm()
        {
            TxtCatName.Enabled = false;
            CmbDep.Enabled = false;

            BtnSaveCat.Enabled = false;
            BtnEditCat.Enabled = false;
            BtnDeleteCat.Enabled = false;
            //BtnNewCat.Enabled = true;
          
            if (_newCat == true)
                BtnNewCat.Enabled = true;
            else BtnNewCat.Enabled = false;
        
             TxtCatName.Text = "";
             CmbDep.SelectedIndex = -1;
        }
        public void ClearCat()
        {
            TxtCatName.Enabled = true;
            CmbDep.Enabled = true;
            TxtCatName.Text = string.Empty;
            CmbDep.SelectedIndex = -1;
            TxtCatName.Focus();

            if (_saveCat == true)
                BtnSaveCat.Enabled = true;
            else BtnSaveCat.Enabled = false;

            //BtnSaveCat.Enabled = true;
            BtnEditCat.Enabled = false;
            BtnDeleteCat.Enabled = false;
            BtnNewCat.Enabled = false;
        }
        public void Lode_Data_Cat()
        {
            DgvCat.Rows.Clear();

            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();

            SqlCommand cmd = new SqlCommand("Select * From View_Cat", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                DgvCat.Rows.Add(rdr["Cat_ID"].ToString(), rdr["CatName"].ToString(), rdr["Dep_Name"].ToString());
            }

            rdr.Close();
            Con.con.Close();
        }


        public void Update_Cat_tbl()
        {
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = Con.con;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = "Update Cat_tbl Set CatName = @CatName, Color = @Color, Dep_ID = @Dep_ID Where Cat_ID = @Cat_ID";
            cmdUpdate.Parameters.Clear();

            cmdUpdate.Parameters.AddWithValue("@CatName", SqlDbType.VarChar).Value = TxtCatName.Text;
            cmdUpdate.Parameters.AddWithValue("@Color", SqlDbType.Int).Value = btnColor.BackColor.ToArgb();
            cmdUpdate.Parameters.AddWithValue("@Dep_ID", SqlDbType.Int).Value = CmbDep.SelectedValue;
            cmdUpdate.Parameters.AddWithValue("@Cat_ID", SqlDbType.Int).Value = TxtCat_ID.Text;

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                cmdUpdate.ExecuteNonQuery();
                Con.con.Close();

                MessageBox.Show("تم تعديل السجل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmdUpdate.Dispose();
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
        public void Delete_Cat_tbl(DataGridView dgv_Cat_tbl2)
        {
            int Position = dgv_Cat_tbl2.CurrentRow.Index;
            int ID_Position = Convert.ToInt32(dgv_Cat_tbl2.Rows[Position].Cells[0].Value);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete From Cat_tbl Where Cat_ID = @Cat_ID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Cat_ID", SqlDbType.Int).Value = ID_Position;

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                cmd.ExecuteNonQuery();
                Con.con.Close();

                MessageBox.Show("تم حذف السجل.", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Dispose();
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

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            try
            {
                // Show the color dialog
                DialogResult result = ColorDialog1.ShowDialog();
                // See if user pressed OK
                if (result == DialogResult.OK)
                {
                    // Set Button BackColor to the selected color
                    btnColor.BackColor = ColorDialog1.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewCat_Click(object sender, EventArgs e)
        {
            ClearCat();
        }

        private void BtnSaveCat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCatName.Text) || string.IsNullOrEmpty(CmbDep.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            Insert_Cat_tbl();
            ClearCat_aftre_DeleteAndUpdateAndSave_Or_OpenForm();
            Lode_Data_Cat();
        }

        private void BtnEditCat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCatName.Text) || string.IsNullOrEmpty(CmbDep.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            Update_Cat_tbl();
            ClearCat_aftre_DeleteAndUpdateAndSave_Or_OpenForm();
            Lode_Data_Cat();
        }

        private void BtnDeleteCat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                Delete_Cat_tbl(DgvCat);
            }

            ClearCat_aftre_DeleteAndUpdateAndSave_Or_OpenForm();
            Lode_Data_Cat();
        }

        private void DgvCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvCat_Click(object sender, EventArgs e)
        {

            try
            {
                TxtCat_ID.Text = DgvCat.CurrentRow.Cells[0].Value.ToString();
                TxtCatName.Text = DgvCat.CurrentRow.Cells[1].Value.ToString();
                CmbDep.Text = DgvCat.CurrentRow.Cells[2].Value.ToString();

                TxtCatName.Enabled = true;
                CmbDep.Enabled = true;

                BtnSaveCat.Enabled = false;
                //BtnEditCat.Enabled = true;
                //BtnDeleteCat.Enabled = true;
                //BtnNewCat.Enabled = true;

                if (_newCat == true)
                    BtnNewCat.Enabled = true;
                else BtnNewCat.Enabled = false;

                if (_eidtCat == true)
                    BtnEditCat.Enabled = true;
                else BtnEditCat.Enabled = false;

                if (_deleteCat == true)
                    BtnDeleteCat.Enabled = true;
                else BtnDeleteCat.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Cmd2 = null;
            rdr2.Close();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

      

      

     
    }
}






