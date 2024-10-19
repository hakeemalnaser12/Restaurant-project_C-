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
    public partial class Frm_Company : Form
    {
        Connection Con;

        public Frm_Company()
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
            SqlCommand Cmd = new SqlCommand("Select btnSave_Company From Permissions_Tbl where UserAccID ='" + UserAccID + "'", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();
            rdr.Read();

            if ((bool)rdr["btnSave_Company"] == true)
                BtnSave.Enabled = true;
            else BtnSave.Enabled = false;
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    logo.Image = Image.FromFile(OpenFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            logo.Image = Res_csharp.Properties.Resources.logo;
        }



        public void Insert_Company_tbl(string CompanyName, string Phone1, string Phone2, string EmailID, string Fax,string City,string Country,string Address,string Vat_No, PictureBox logo)
        {
            SqlCommand Cmd = new SqlCommand();
            //Cmd.Connection = Con;
            Cmd.Connection = Con.con; // 0
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Insert Into Company_tbl (CompanyName,Phone1,Phone2,EmailID,Fax,City,Country,Address,Vat_No,logo)values(@CompanyName,@Phone1,@Phone2,@EmailID,@Fax,@City,@Country,@Address,@Vat_No,@logo)";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@CompanyName", SqlDbType.VarChar).Value = CompanyName;
            Cmd.Parameters.AddWithValue("@Phone1", SqlDbType.VarChar).Value = Phone1;
            Cmd.Parameters.AddWithValue("@Phone2", SqlDbType.VarChar).Value = Phone2;
            Cmd.Parameters.AddWithValue("@EmailID", SqlDbType.VarChar).Value = EmailID;
            Cmd.Parameters.AddWithValue("@Fax", SqlDbType.VarChar).Value = Fax;
            Cmd.Parameters.AddWithValue("@City", SqlDbType.VarChar).Value = City;
            Cmd.Parameters.AddWithValue("@Country", SqlDbType.VarChar).Value = Country;
            Cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = Address;
            Cmd.Parameters.AddWithValue("@Vat_No", SqlDbType.VarChar).Value = Vat_No;

            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(logo.Image);
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] data = ms.GetBuffer();
            SqlParameter p = new SqlParameter("@logo", SqlDbType.Image);
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
                Con.con.Close(); //  4
                //if (Con.State == ConnectionState.Open)
                //    Con.Close();
            }
        }

       public void Update_Company_tbl(string CompanyName, string Phone1, string Phone2, string EmailID, string Fax,string City,string Country,string Address,string Vat_No, PictureBox logo, int Company_IDW)
        {
            SqlCommand Cmd = new SqlCommand();
            try
            {
                Cmd.Connection = Con.con;
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "Update Company_tbl Set CompanyName = @CompanyName,Phone1 = @Phone1,Phone2 = @Phone2,EmailID = @EmailID,Fax = @Fax,City = @City,Country = @Country,Address = @Address,Vat_No = @Vat_No,logo = @logo Where Company_ID = @Company_ID";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@CompanyName", SqlDbType.VarChar).Value = CompanyName;
                Cmd.Parameters.AddWithValue("@Phone1", SqlDbType.VarChar).Value = Phone1;
                Cmd.Parameters.AddWithValue("@Phone2", SqlDbType.VarChar).Value = Phone2;
                Cmd.Parameters.AddWithValue("@EmailID", SqlDbType.VarChar).Value = EmailID;
                Cmd.Parameters.AddWithValue("@Fax", SqlDbType.VarChar).Value = Fax;
                Cmd.Parameters.AddWithValue("@City", SqlDbType.VarChar).Value = City;
                Cmd.Parameters.AddWithValue("@Country", SqlDbType.VarChar).Value = Country;
                Cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = Address;
                Cmd.Parameters.AddWithValue("@Vat_No", SqlDbType.VarChar).Value = Vat_No;

                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(logo.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();

                SqlParameter p = new SqlParameter("@logo", SqlDbType.Image);
                p.Value = data;
                Cmd.Parameters.Add(p);

                Cmd.Parameters.AddWithValue("@Company_ID", SqlDbType.Int).Value = Company_IDW;


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

       private void BtnSave_Click(object sender, EventArgs e)
       {
           if (Con.con.State == ConnectionState.Open)
           {
               Con.con.Close();
           }
           Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from Company_tbl ", Con.con);
            SqlDataReader rdr = Cmd.ExecuteReader();
            if (rdr.Read())
            {
               if (rdr.HasRows)
               {
                   Update_Company_tbl(TxtCompanyName.Text, TxtPhone1.Text, TxtPhone2.Text, TxtEmailID.Text, TxtFax.Text, TxtCity.Text, TxtCountry.Text, TxtAddress.Text, TxtVat_No.Text, logo, Convert.ToInt32(TxtCompany_ID.Text));
	               Check();
                }
               else 
               {
	               Insert_Company_tbl(TxtCompanyName.Text, TxtPhone1.Text, TxtPhone2.Text, TxtEmailID.Text, TxtFax.Text, TxtCity.Text, TxtCountry.Text, TxtAddress.Text, TxtVat_No.Text, logo);
	               Check();
                }
            }

       }

       public void Check()
       {
           if (Con.con.State == ConnectionState.Open)
           {
               Con.con.Close();
           }
           Con.con.Open();

           SqlCommand Cmd = new SqlCommand("Select * from Company_tbl", Con.con);
           SqlDataReader rdr = Cmd.ExecuteReader();
           rdr.Read();
           if (rdr.HasRows)
           {
               TxtCompany_ID.Text = rdr["Company_ID"].ToString();
               TxtCompanyName.Text = rdr["CompanyName"].ToString();
               TxtPhone1.Text = rdr["Phone1"].ToString();
               TxtPhone2.Text = rdr["Phone2"].ToString();
               TxtEmailID.Text = rdr["EmailID"].ToString();
               TxtFax.Text = rdr["Fax"].ToString();
               TxtCity.Text = rdr["City"].ToString();
               TxtCountry.Text = rdr["Country"].ToString();
               TxtAddress.Text = rdr["Address"].ToString();
               TxtVat_No.Text = rdr["Vat_No"].ToString();

               Byte[] data = (Byte[])rdr["logo"];
               if (data != null && data.Length > 0)
               {
                   using (MemoryStream ms = new MemoryStream(data))
                   {
                       ms.Position = 0;
                       ms.SetLength(data.Length);
                       Image img = Image.FromStream(ms);
                       if (img != null)
                       {
                           logo.Image = img;
                       }
                       else
                       {
                           logo.Image = Res_csharp.Properties.Resources.logo;
                       }
                   }
               }
               else
               {
                   logo.Image = Res_csharp.Properties.Resources.logo;
               }

               
               BtnSave.Text = "تعديل البيانات";
           }
           else
           {
               TxtCompany_ID.Text = "";
               TxtCompanyName.Text = "";
               TxtPhone1.Text = "";
               TxtPhone2.Text = "";
               TxtEmailID.Text = "";
               TxtFax.Text = "";
               TxtCity.Text = "";
               TxtCountry.Text = "";
               TxtAddress.Text = "";
               TxtVat_No.Text = "";
               TxtCompanyName.Focus();
               logo.Image = Res_csharp.Properties.Resources.logo;
               BtnSave.Text = "حفظ البيانات";
           }
           rdr.Close();
           Con.con.Close();
       }

       private void Frm_Company_Load(object sender, EventArgs e)
       {
           Check();
       }

       private void PrdExit_Click(object sender, EventArgs e)
       {
           TxtCompany_ID.Text = "";
           TxtCompanyName.Text = "";
           TxtPhone1.Text = "";
           TxtPhone2.Text = "";
           TxtEmailID.Text = "";
           TxtFax.Text = "";
           TxtCity.Text = "";
           TxtCountry.Text = "";
           TxtAddress.Text = "";
           TxtVat_No.Text = "";
           TxtCompanyName.Focus();
           logo.Image = Res_csharp.Properties.Resources.logo;
       }



    }
}
