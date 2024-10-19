using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Res_csharp.Model;

namespace Res_csharp
{
    public partial class Frm_Add_Update_prd : Form
    {
        Connection Con;
        public SqlCommand Cmd2;
        public SqlDataReader rdr2;

        public Frm_Add_Update_prd()
        {
            InitializeComponent();
            Con = new Connection();
            //CheckPremitonforms(Connection._UserID);
        }


        //public void CheckPremitonforms(string UserAccID)
        //{
        //    if (Con.con.State == System.Data.ConnectionState.Open)
        //    {
        //        Con.con.Close();
               
        //    }
        //    Con.con.Open();
        //     Cmd2 = new SqlCommand("Select * From Permissions_Tbl where UserAccID ='" + UserAccID + "'", Con.con);
        //     rdr2 = Cmd2.ExecuteReader();
        //     rdr2.Read();

        //     if ((bool)rdr2["btnSave_Product1"] == true)
        //        BtnSave.Enabled = true;
        //    else BtnSave.Enabled = false;

        //     if ((bool)rdr2["btnEdit_Product1"] == true)
        //        BtnEdit.Enabled = true;
        //    else BtnEdit.Enabled = false;

        //}



        public void ClearItems()
        {
            TxtPrdName.Text = "";
            TxtPrd_Barcode.Text = "";
            TxtPrdPrice.Text = "";
            CmbCat.Text = "";
            TxtPrd_Barcode.Focus();
            Prd_Image.Image = Res_csharp.Properties.Resources.pro;

            //BtnSave.Enabled = true;

            if (Connection._btnSave_Product1 == true)
                BtnSave.Enabled = true;
            else BtnSave.Enabled = false;

            BtnEdit.Enabled = false;

        }

        public void Insert_Prd_tbl(string Prd_Barcode, string PrdName, int Cat_ID, double PrdPrice, bool prd_Status, PictureBox Prd_Image)
        {
            SqlCommand Cmd = new SqlCommand();
            //Cmd.Connection = Con;
            Cmd.Connection = Con.con; // 0
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Insert Into Prd_tbl (Prd_Barcode,PrdName,Cat_ID,PrdPrice,prd_Status,Prd_Image) values(@Prd_Barcode,@PrdName,@Cat_ID,@PrdPrice,@prd_Status,@Prd_Image)";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@Prd_Barcode", SqlDbType.VarChar).Value = Prd_Barcode;
            Cmd.Parameters.AddWithValue("@PrdName", SqlDbType.VarChar).Value = PrdName;
            Cmd.Parameters.AddWithValue("@Cat_ID", SqlDbType.Int).Value = Cat_ID;
            Cmd.Parameters.AddWithValue("@PrdPrice", SqlDbType.Decimal).Value = PrdPrice;
            Cmd.Parameters.AddWithValue("@prd_Status", SqlDbType.Bit).Value = prd_Status;

            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(Prd_Image.Image);
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] data = ms.GetBuffer();
            SqlParameter p = new SqlParameter("@Prd_Image", SqlDbType.Image);
            p.Value = data;
            Cmd.Parameters.Add(p);

            try
            {
                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();

                Cmd.ExecuteNonQuery();

                Con.con.Close(); // 2
                //Con.Close(); 
                MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cmd = null;
            }
            catch (Exception ex)
            {
                Con.con.Close(); // 3
                //Con.Close();
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

        private void PrdExit_Click(object sender, EventArgs e)
        {
            ClearItems();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            //Frm_Manage_Product.Lode_Prd();
            //Frm_Manage_Product.BtnAllPrd.PerformClick();
            this.Close();
            //Cmd2 = null;
            //rdr2.Close();

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog1.Filter = "Choose Image (*.PNG; *.JPG; *.GIF; *.JPEG; *.bmp)|*.PNG;*.JPG;*.GIF;*.JPEG;*.bmp|All Files (*.*)|*.*";
                OpenFileDialog1.FilterIndex = 4;

                OpenFileDialog1.FileName = "";
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Prd_Image.Image = Image.FromFile(OpenFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            Prd_Image.Image = Res_csharp.Properties.Resources.pro;
        }

        public void Load_Cat_Tbl()
        {

            DataTable dt = new DataTable();
            CmbCat.DataSource = null;
            CmbCat.Items.Clear();
            CmbCat.Text = string.Empty;
            dt.Clear();
            SqlCommand Cmd = new SqlCommand("Select Cat_ID, CatName From Cat_tbl", Con.con);
            try
            {
                if (Con.con.State == ConnectionState.Closed)
                    Con.con.Open();
                dt.Load(Cmd.ExecuteReader());

             
                Con.con.Close();
                Cmd = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.con.Close();
                Cmd = null;
            }

            if (dt.Rows.Count != 0)
            {
                CmbCat.DataSource = dt;
                CmbCat.DisplayMember = "CatName";
                CmbCat.ValueMember = "Cat_ID";
            }

            if (CmbCat.Items.Count > 0)
                CmbCat.SelectedIndex = -1;


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPrd_Barcode.Text) || string.IsNullOrEmpty(TxtPrdName.Text) || string.IsNullOrEmpty(CmbCat.Text) || string.IsNullOrEmpty(TxtPrdPrice.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            // - لحل مشكلة تكرار ادخال الباركود 
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from Prd_tbl Where Prd_Barcode=@Prd_Barcode", Con.con);
            Cmd.Parameters.AddWithValue("@Prd_Barcode", TxtPrd_Barcode.Text);
            SqlDataReader rdr = Cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("الباركود المراد ادخاله مدخل مسبقا ", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                TxtPrd_Barcode.Text = "";
                TxtPrd_Barcode.Focus();
            }
            else
            {
                try
                {
                    //Insert_Prd_tbl(TxtPrd_Barcode.Text, TxtPrdName.Text, CmbCat.SelectedValue, TxtPrdPrice.Text, CheckStatus.CheckState, Prd_Image);
                    Insert_Prd_tbl(TxtPrd_Barcode.Text, TxtPrdName.Text, Convert.ToInt32(CmbCat.SelectedValue), Convert.ToDouble(TxtPrdPrice.Text), Convert.ToBoolean(CheckStatus.CheckState), Prd_Image);
                    ClearItems();
                    this.Close();

                    //Frm_Manage_Product.BtnAllPrd.PerformClick();
                    //Frm_Manage_Product.Lode_Prd();
                }
                catch
                {
                    MessageBox.Show("خطأ في حقل سعر المنتج ! يجب أن يكون السعر رقم", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            rdr.Close();
            Con.con.Close();
            //Frm_Manage_Product.BtnAllPrd.PerformClick();
            //Frm_Manage_Product.Lode_Prd();

        }

        public void Update_Prd_tbl(string Prd_Barcode, string PrdName, int Cat_ID, double PrdPrice, bool prd_Status, PictureBox Prd_Image, int Prd_IDW)
        {
            SqlCommand Cmd = new SqlCommand();
            try
            {
                Cmd.Connection = Con.con;
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "Update Prd_tbl Set Prd_Barcode = @Prd_Barcode, PrdName = @PrdName, Cat_ID = @Cat_ID, PrdPrice = @PrdPrice, prd_Status = @prd_Status, Prd_Image = @Prd_Image Where Prd_ID = @Prd_ID";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Prd_Barcode", SqlDbType.VarChar).Value = Prd_Barcode;
                Cmd.Parameters.AddWithValue("@PrdName", SqlDbType.VarChar).Value = PrdName;
                Cmd.Parameters.AddWithValue("@Cat_ID", SqlDbType.Int).Value = Cat_ID;
                Cmd.Parameters.AddWithValue("@PrdPrice", SqlDbType.Decimal).Value = PrdPrice;
                Cmd.Parameters.AddWithValue("@prd_Status", SqlDbType.Bit).Value = prd_Status;

                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(Prd_Image.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();

                SqlParameter p = new SqlParameter("@Prd_Image", SqlDbType.Image);
                p.Value = data;
                Cmd.Parameters.Add(p);

                Cmd.Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = Prd_IDW;

                if (Con.con.State == ConnectionState.Open)
                {
                    Con.con.Close();
                }
                Con.con.Open();

                Cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم تعديل السجل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Con.con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtPrd_Barcode.Text) || string.IsNullOrEmpty(TxtPrdName.Text) || string.IsNullOrEmpty(CmbCat.Text) || string.IsNullOrEmpty(TxtPrdPrice.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            Update_Prd_tbl(TxtPrd_Barcode.Text, TxtPrdName.Text, Convert.ToInt32(CmbCat.SelectedValue), Convert.ToDouble(TxtPrdPrice.Text), Convert.ToBoolean(CheckStatus.CheckState), Prd_Image, Convert.ToInt32(TxtPrd_ID.Text));
            ClearItems();

            {
                //Frm_Manage_Product.BtnAllPrd.PerformClick();
                //Frm_Manage_Product.Load_Prd()();
            }
            this.Close();
        }

   

        private void Frm_Add_Update_prd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Frm_Manage_Product frm_Manage_Product = new Frm_Manage_Product();
            //frm_Manage_Product.BtnAllPrd.PerformClick();
            //frm_Manage_Product.Panel3.Refresh();         
            //frm_Manage_Product.Load_Prd();
        }

        private void Frm_Add_Update_prd_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Frm_Add_Update_prd_Load(object sender, EventArgs e)
        {
            
        }

      





    }




}


