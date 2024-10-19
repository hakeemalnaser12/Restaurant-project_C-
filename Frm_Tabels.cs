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
    public partial class Frm_Tabels : Form
    {
        //
        Connection Con;
        public SqlCommand Cmd2;
        public SqlDataReader rdr2;
        public bool _newTabel, _saveTabel, _editTabel, _deleteTabel;


        public Frm_Tabels()
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
            Cmd2 = new SqlCommand("Select btnNew_Tabel,btnSave_Tabel,btnEdit_Tabel,btnDelete_Tabel From Permissions_Tbl where UserAccID ='" + UserAccID + "'", Con.con);
            rdr2 = Cmd2.ExecuteReader();
            rdr2.Read();

            if ((bool)rdr2["btnNew_Tabel"] == true)
                _newTabel = true;
            else _newTabel = false;

            if ((bool)rdr2["btnSave_Tabel"] == true)
                _saveTabel = true;
            else _saveTabel = false;

            if ((bool)rdr2["btnEdit_Tabel"] == true)
                _editTabel = true;
            else _editTabel = false;

            if ((bool)rdr2["btnDelete_Tabel"] == true)
                _deleteTabel = true;
            else _deleteTabel = false;



            //if (_newTabel == true)
            //    BtnNew.Enabled = true;
            //else BtnNew.Enabled = false;

            //if (_saveTabel == true)
            //    BtnSave.Enabled = true;
            //else BtnSave.Enabled = false;

            //if (_editTabel == true)
            //    BtnEdit.Enabled = true;
            //else BtnEdit.Enabled = false;

            //if (_deleteTabel == true)
            //    BtnDelete.Enabled = true;
            //else BtnDelete.Enabled = false;

        }


        private void Frm_Tabels_Load(object sender, EventArgs e)
        {
            ClearText_aftre_DeleteAndUpdateAndSave_Or_OpenForm();
            Load_Table();
        }
        public void Load_Table()
        {
            dgvTable.Rows.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Table_tbl", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dgvTable.Rows.Add(rdr["Table_ID"].ToString(), rdr["TableName"].ToString());
            }
            rdr.Close();
            Con.con.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Cmd2 = null;
            rdr2.Close();
        }
        public void Insert_Table_tbl()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert Into Table_tbl (TableName) values (@TableName)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.VarChar).Value = TxtTableName.Text;

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd = null;
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
        public void Update_Table_tbl()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Table_tbl Set TableName = @TableName Where Table_ID = @Table_ID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.VarChar).Value = TxtTableName.Text;
            cmd.Parameters.AddWithValue("@Table_ID", SqlDbType.Int).Value = int.Parse(TxtTable_ID.Text);

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم تعديل السجل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd = null;
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
        public void ClearText_aftre_DeleteAndUpdateAndSave_Or_OpenForm()
        {
            TxtTable_ID.Enabled = false;
            TxtTableName.Enabled = false;
            TxtTableName.Text = "";
            BtnSave.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            //BtnNew.Enabled = true;

            if (_newTabel == true)
                BtnNew.Enabled = true;
            else BtnNew.Enabled = false;


        }
        public void ClearText_aftre_Enter_New()
        {
            TxtTable_ID.Enabled = true;
            TxtTableName.Enabled = true;
            TxtTable_ID.Text = "";
            TxtTableName.Text = "";
            TxtTableName.Focus();


            if (_saveTabel == true)
                BtnSave.Enabled = true;
            else BtnSave.Enabled = false;

            //BtnSave.Enabled = true;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnNew.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           
                if (string.IsNullOrEmpty(TxtTableName.Text))
                {
                    MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Insert_Table_tbl();
                Load_Table();
                ClearText_aftre_DeleteAndUpdateAndSave_Or_OpenForm();
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(TxtTableName.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Update_Table_tbl();
            Load_Table();
            ClearText_aftre_DeleteAndUpdateAndSave_Or_OpenForm();
            
        }
        public void Delete_Table_tbl(DataGridView dgv_Table_tbl)
        {
            int position = dgv_Table_tbl.CurrentCell.RowIndex;
            int ID_Position = Convert.ToInt32(dgv_Table_tbl.Rows[position].Cells[0].Value);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete From Table_tbl Where Table_ID = @Table_ID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Table_ID", SqlDbType.Int).Value = ID_Position;

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم حذف السجل", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                Delete_Table_tbl(dgvTable);
            }

            Load_Table();
            ClearText_aftre_DeleteAndUpdateAndSave_Or_OpenForm();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearText_aftre_Enter_New();
        }

        private void DgvTable_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                this.TxtTable_ID.Text = dgvTable.CurrentRow.Cells[0].Value.ToString();
                this.TxtTableName.Text = dgvTable.CurrentRow.Cells[1].Value.ToString();
                TxtTable_ID.Enabled = true;
                TxtTableName.Enabled = true;
                BtnSave.Enabled = false;
                //BtnEdit.Enabled = true;
                //BtnDelete.Enabled = true;
                //BtnNew.Enabled = true;

                if (_newTabel == true)
                    BtnNew.Enabled = true;
                else BtnNew.Enabled = false;

                if (_editTabel == true)
                    BtnEdit.Enabled = true;
                else BtnEdit.Enabled = false;

                if (_deleteTabel == true)
                    BtnDelete.Enabled = true;
                else BtnDelete.Enabled = false;

            }

        }
    }
}
