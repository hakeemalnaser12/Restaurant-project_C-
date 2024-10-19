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
using Res_csharp.Model;

namespace Res_csharp
{
    public partial class Frm_Manage_Product : Form
    {

        Connection Con;
        public SqlCommand Cmd2;
        public SqlDataReader rdr2;

        public Frm_Manage_Product()
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
            Cmd2 = new SqlCommand("Select btnshowAll_Product,Add_Product,btnEdit_Product,btnDelete_Product,btnSave_Product1,btnEdit_Product1 From Permissions_Tbl where UserAccID ='" + UserAccID + "'", Con.con);
            rdr2 = Cmd2.ExecuteReader();
            rdr2.Read();

            // this for Form Frm_Manage_Product 
            if ((bool)rdr2["btnshowAll_Product"] == true)
                BtnAllPrd.Enabled = true;
            else BtnAllPrd.Enabled = false;

            if ((bool)rdr2["Add_Product"] == true)
                BtnNewPrd.Enabled = true;
            else BtnNewPrd.Enabled = false;

            //if ((bool)rdr2["btnEdit_Product"] == true)
            //    ckbtnEdit_Product.Checked = true;
            //else ckbtnEdit_Product.Checked = false;

            //if ((bool)rdr2["btnDelete_Product"] == true)
            //    ckbtnDelete_Product.Checked = true;
            //else ckbtnDelete_Product.Checked = false;


            // this for Form Frm_Add_Update_prd 

            if ((bool)rdr2["btnSave_Product1"] == true)
                Connection._btnSave_Product1 = true;
            else Connection._btnSave_Product1 = false;

            if ((bool)rdr2["btnEdit_Product1"] == true)
                Connection._btnEdit_Product1 = true;
            else Connection._btnEdit_Product1 = false;

        }


        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Cmd2 = null;
            rdr2.Close();
        }

        private void Frm_Manage_Product_Load(object sender, EventArgs e)
        {
              Load_Cat_Tbl();
              Load_Prd();

        }

        public void Load_Prd()
        {
            DgvPrd.Rows.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * From View_Prd", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string myStatus = "";
                if ((bool)rdr["prd_Status"])
                {
                    myStatus = "متوفر";
                }
                else
                {
                    myStatus = "غير متوفر";
                }
                DgvPrd.Rows.Add(rdr["Prd_ID"].ToString(), rdr["Prd_Barcode"].ToString(), rdr["PrdName"].ToString(), rdr["PrdPrice"].ToString(), rdr["CatName"].ToString(), myStatus);
            }
            rdr.Close();
           Con.con.Close();
        }

        private void BtnNewPrd_Click(object sender, EventArgs e)
        {
         
            try
            {
                Frm_Add_Update_prd frm = new Frm_Add_Update_prd();
                frm.Label1.Text = "شاشة اضافة منتج جديد";
                frm.ClearItems();
                frm.Load_Cat_Tbl();

                if (Connection._btnSave_Product1 == true)
                    frm.BtnSave.Enabled = true;
                else frm.BtnSave.Enabled = false;
                //if (Connection._btnEdit_Product1 == true)
                //   frm.BtnEdit.Enabled = true;
                //else frm.BtnEdit.Enabled = false;

                //frm.Show(); ////تعمل على اظهار الشاشة  
                frm.ShowDialog(); // تعمل على اظهار الشاشة في الاعلى فوق الشاشات
               

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Load_Cat_Tbl()
        {
            DataTable dt = new DataTable();
            CmbCat.DataSource = null;
            CmbCat.Items.Clear();
            CmbCat.Text = string.Empty;
            dt.Clear();
            SqlCommand cmd = new SqlCommand("Select Cat_ID, CatName From Cat_tbl", Con.con);
            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();

                dt.Load(cmd.ExecuteReader());
               Con.con.Close();
               cmd = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Con.con.Close();
            }

            if (dt.Rows.Count > 0)
            {
                CmbCat.DataSource = dt;
                CmbCat.DisplayMember = "CatName";
                CmbCat.ValueMember = "Cat_ID";
            }
            if (CmbCat.Items.Count > 0)
            {
                CmbCat.SelectedIndex = -1;
            }
        }

        private void DgvPrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckPremitonforms(Connection._UserID);
            //كود التعديل عند الضغط على الداتا جريد فيو  

            if (e.ColumnIndex == 6)
            {
                try
                {
                    if ((bool)rdr2["btnEdit_Product"] == true)
                    {
                        Frm_Add_Update_prd frm = new Frm_Add_Update_prd();
                        frm.Load_Cat_Tbl();
                        if (Con.con.State == ConnectionState.Open)
                        {
                            Con.con.Close();
                        }
                        Con.con.Open();


                        SqlCommand Cmd = new SqlCommand("Select * from Prd_tbl Where Prd_ID=@Prd_ID", Con.con);
                        Cmd.Parameters.AddWithValue("@Prd_ID", DgvPrd.CurrentRow.Cells[0].Value);
                        SqlDataReader rdr = Cmd.ExecuteReader();
                        rdr.Read();
                        if (rdr.HasRows)
                        {
                            frm.TxtPrd_ID.Text = rdr["Prd_ID"].ToString();
                            frm.TxtPrd_Barcode.Text = rdr["Prd_Barcode"].ToString();
                            frm.TxtPrdName.Text = rdr["PrdName"].ToString();
                            frm.TxtPrdPrice.Text = rdr["PrdPrice"].ToString();
                            frm.CmbCat.SelectedValue = rdr["Cat_ID"].ToString();
                            byte[] data = (byte[])rdr["Prd_Image"];
                            MemoryStream ms = new MemoryStream(data);
                            Bitmap bitamp = new Bitmap(ms);
                            frm.Prd_Image.Image = bitamp;
                            if ((bool)rdr["prd_Status"])
                            {
                                frm.CheckStatus.Checked = true;
                            }
                            else
                            {
                                frm.CheckStatus.Checked = false;
                            }
                            rdr.Close();
                            Con.con.Close();
                            frm.Label1.ForeColor = Color.FromArgb(0, 255, 120);
                            frm.Label1.Text = "تعديل بيانات المنتج " + DgvPrd.CurrentRow.Cells[2].Value;
                            frm.BtnSave.Enabled = false;
                            frm.BtnEdit.Enabled = true;
                            // frm.Show() ////تعمل على اظهار الشاشة  
                            frm.ShowDialog(); // تعمل على اظهار الشاشة في الاعلى فوق الشاشات
                        }
                        else MessageBox.Show("ليس لديك صلاحية للتعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } // end  if ((bool)rdr2["btnEdit_Product"] == true)

                } // end try 
                catch
                {
                    MessageBox.Show("ليس لديك صلاحية للتعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } // end if (e.ColumnIndex == 6)

            else if (e.ColumnIndex == 7)
            {

                try
                {
                    if ((bool)rdr2["btnDelete_Product"] == true)
                    {
                        if (MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            Delete_Prd_tbl(DgvPrd);
                        }
                        Load_Prd();
                    }

                    else MessageBox.Show("ليس لديك صلاحية للحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } // end try 
                catch
                {
                    MessageBox.Show("ليس لديك صلاحية للحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } // end else if (e.ColumnIndex == 7)

        } // end DgvPrd_CellContentClick


        //كود الحذف 
        public void Delete_Prd_tbl(DataGridView dgv_Prd_tbl)
        {
            int position = dgv_Prd_tbl.CurrentRow.Index;
            int ID_Position = Convert.ToInt32(dgv_Prd_tbl.Rows[position].Cells[0].Value);
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con.con;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Delete From Prd_tbl Where Prd_ID = @Prd_ID";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Prd_ID", ID_Position);

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();
                Cmd.ExecuteNonQuery();
               Con.con.Close();
                MessageBox.Show("تم حذف السجل", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cmd.Dispose();
            }
            catch (Exception ex)
            {
               Con.con.Close();
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               Con.con.Close();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //كود البحث بحدث التكست تشنج 
            DgvPrd.Rows.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * From View_Prd Where Prd_Barcode LIKE '%" + TxtSearch.Text + "%' Or PrdName LIKE '%" + TxtSearch.Text + "%'", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();

            while (rdr.Read())
            {
                string MY_Status = "";
                if ((bool)rdr["prd_Status"])
                {
                    MY_Status = "متوفر";
                }
                else
                {
                    MY_Status = "غير متوفر";
                }
                DgvPrd.Rows.Add(rdr["Prd_ID"].ToString(), rdr["Prd_Barcode"].ToString(), rdr["PrdName"].ToString(), rdr["PrdPrice"].ToString(), rdr["CatName"].ToString(), MY_Status);
            }

            rdr.Close();
           Con.con.Close();

        }

        private void CmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //فرز المنتجات حسب التصنيفات 

            DgvPrd.Rows.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * From View_Prd Where CatName LIKE '" + CmbCat.Text + "'", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();

            while (rdr.Read())
            {
                string MY_Status = "";
                if ((bool)rdr["prd_Status"])
                {
                    MY_Status = "متوفر";
                }
                else
                {
                    MY_Status = "غير متوفر";
                }
                DgvPrd.Rows.Add(rdr["Prd_ID"].ToString(), rdr["Prd_Barcode"].ToString(), rdr["PrdName"].ToString(), rdr["PrdPrice"].ToString(), rdr["CatName"].ToString(), MY_Status);
            }

            rdr.Close();
           Con.con.Close();
        }

        private void BtnAllPrd_Click(object sender, EventArgs e)
        {
            CmbCat.Text = string.Empty;
            TxtSearch.Text = string.Empty;
            Load_Prd();
        }

        private void DgvPrd_MouseHover(object sender, EventArgs e)
        {
            Load_Prd();
        }






    }
}
