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
    public partial class Frm_Delevery : Form
    {
        Frm_pos Frm_pos ;
        Connection Con;
        public SqlCommand Cmd2;
        public SqlDataReader rdr2;
        public bool _newArea, _saveArea, _editArea, _deleteArea, _newCust, _saveCust, _eidtCust, _deleteCust, _newdev, _savedev, _eidtdev, _deletedev;


        public Frm_Delevery(Frm_pos Frm_pos2)
        {
            InitializeComponent();
            Con = new Connection();
            this.Frm_pos = Frm_pos2;
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

            if ((bool)rdr2["btnNew_Area"] == true)
                _newArea = true;
            else _newArea = false;

            if ((bool)rdr2["btnSave_Area"] == true)
                _saveArea = true;
            else _saveArea = false;

            if ((bool)rdr2["btnEdit_Area"] == true)
                _editArea = true;
            else _editArea = false;

            if ((bool)rdr2["btnDelete_Area"] == true)
                _deleteArea = true;
            else _deleteArea = false;

            if ((bool)rdr2["btnNew_Emp"] == true)
                _newdev = true;
            else _newdev = false;

            if ((bool)rdr2["btnSave_Emp"] == true)
               _savedev = true;
            else _savedev = false;

            if ((bool)rdr2["btnEdit_Emp"] == true)
               _eidtdev = true;
            else _eidtdev = false;

            if ((bool)rdr2["btnDelete_Emp"] == true)
                _deletedev = true;
            else _deletedev = false;

            if ((bool)rdr2["btnNew_Customer"] == true)
                _newCust = true;
            else _newCust = false;

            if ((bool)rdr2["btnSave_Customer"] == true)
                _saveCust = true;
            else _saveCust = false;

            if ((bool)rdr2["btnEdit_Customer"] == true)
                _eidtCust = true;
            else _eidtCust = false;

            if ((bool)rdr2["btnDelete_Customer"] == true)
                _deleteCust = true;
            else _deleteCust = false;


            //if (_newArea == true)
            //    BtnNew2.Enabled = true;
            //else BtnNew2.Enabled = false;

            //if (_saveArea == true)
            //    BtnSave2.Enabled = true;
            //else BtnSave2.Enabled = false;

            //if (_editArea == true)
            //    BtnEdit2.Enabled = true;
            //else BtnEdit2.Enabled = false;

            //if (_deleteArea == true)
            //    BtnDelete2.Enabled = true;
            //else BtnDelete2.Enabled = false;

            //if (_newdev == true)
            //    BtnNew1.Enabled = true;
            //else BtnNew1.Enabled = false;

            //if (_savedev == true)
            //    BtnSave1.Enabled = true;
            //else BtnSave1.Enabled = false;

            //if (_eidtdev == true)
            //    BtnEdit1.Enabled = true;
            //else BtnEdit1.Enabled = false;

            //if (_deletedev == true)
            //    BtnDelete1.Enabled = true;
            //else BtnDelete1.Enabled = false;

            //if (_newCust == true)
            //    BtnNew.Enabled = true;
            //else BtnNew.Enabled = false;

            //if (_saveCust == true)
            //    BtnSave.Enabled = true;
            //else BtnSave.Enabled = false;

            //if (_eidtCust == true)
            //    BtnEdit.Enabled = true;
            //else BtnEdit.Enabled = false;

            //if (_deleteCust == true)
            //    BtnDelete.Enabled = true;
            //else BtnDelete.Enabled = false;
           

        }



        //********************************************* Area ***************************************************************
         private void Frm_Delevery_Load_1(object sender, EventArgs e)
        {
            ClearArea_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Area();
            Load_Area_Tbl();
            ClearCustomer_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Customer();
            Clear_Delivery_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Delevry();
        }

        public void ClearArea()
        {
            TxtArea_ID.Text = Con.Max_ID("Area_Tbl", "Area_ID").ToString();
            TxtAreaName.Text = "";
            TxtAreaPrice.Text = "0.0";

            TxtAreaName.Enabled = true;
            TxtAreaPrice.Enabled = true;
            TxtAreaName.Focus();

            BtnNew2.Enabled = false;
            //BtnSave2.Enabled = true;

            if (_saveArea == true)
                BtnSave2.Enabled = true;
            else BtnSave2.Enabled = false;

            BtnEdit2.Enabled = false;
            BtnDelete2.Enabled = false;
        }

        public void ClearArea_After_Delete_And_Update_And_Save_Or_Open_Form()
        {
            TxtArea_ID.Text = string.Empty;
            TxtAreaName.Text = string.Empty;
            TxtAreaPrice.Text = string.Empty;

            TxtArea_ID.Enabled = false;
            TxtAreaName.Enabled = false;
            TxtAreaPrice.Enabled = false;

            if (_newArea == true)
                BtnNew2.Enabled = true;
            else BtnNew2.Enabled = false;

            //BtnNew2.Enabled = true;
            BtnSave2.Enabled = false;
            BtnEdit2.Enabled = false;
            BtnDelete2.Enabled = false;
        }

         public void Insert_Area()
        {
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO Area_Tbl (Area_ID, AreaName, AreaPrice) VALUES (@Area_ID, @AreaName, @AreaPrice)", Con.con))
            {
                cmd.Parameters.AddWithValue("@Area_ID", Convert.ToInt32(TxtArea_ID.Text));
                cmd.Parameters.AddWithValue("@AreaName", TxtAreaName.Text);
                cmd.Parameters.AddWithValue("@AreaPrice", Convert.ToDouble(TxtAreaPrice.Text));
                cmd.ExecuteNonQuery();
            }

            Con.con.Close();
            MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Update_Area()
        {
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();

            using (SqlCommand cmd = new SqlCommand("UPDATE Area_Tbl SET AreaName = @AreaName, AreaPrice = @AreaPrice WHERE Area_ID = @Area_ID", Con.con))
            {
                cmd.Parameters.AddWithValue("@AreaName", TxtAreaName.Text);
                cmd.Parameters.AddWithValue("@AreaPrice", Convert.ToDouble(TxtAreaPrice.Text));
                cmd.Parameters.AddWithValue("@Area_ID", Convert.ToInt32(TxtArea_ID.Text));
                cmd.ExecuteNonQuery();
            }

            Con.con.Close();
            MessageBox.Show("تم تعديل السجل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Delete_Area_Tbl(DataGridView dgvDepTbl)
        {
            int position = dgvDepTbl.CurrentRow.Index;
            int idPosition = Convert.ToInt32(dgvDepTbl.Rows[position].Cells[0].Value);

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Con.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Area_Tbl WHERE Area_ID = @Area_ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Area_ID", idPosition);
                
                try
                {
                    if (Con.con.State == ConnectionState.Open)
                        Con.con.Close();
                    Con.con.Open();
                    cmd.ExecuteNonQuery();
                    Con.con.Close();
                    MessageBox.Show("تم حذف السجل بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Con.con.Close();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Con.con.State == ConnectionState.Open)
                        Con.con.Close();
                }
            }
        }
        public void Load_Area()
        {
            DgvArea.Rows.Clear();

            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Area_Tbl", Con.con))
            {
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        DgvArea.Rows.Add(rdr["Area_ID"].ToString(), rdr["AreaName"].ToString(), rdr["AreaPrice"].ToString());
                    }
                }
            }

            Con.con.Close();
        }
 

        private void BtnNew2_Click_1(object sender, EventArgs e)
        {
            
            ClearArea();
            
        }

        private void BtnSave2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAreaName.Text) || string.IsNullOrEmpty(TxtAreaPrice.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            Insert_Area();
            ClearArea_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Area();
            Load_Area_Tbl(); // لاظهار التعديل او الاضافة تلقائيا في الكمبوبوكس حق اختيار المنطقة عند اضافه منطقة والرجوع لشاشة العملاء 
            Load_Customer(); // لتحديث الداتا جريد فيو الخاصة بالعملاء عند تعديل بيانات المناطق

        }

        private void BtnDelete2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                Delete_Area_Tbl(DgvArea);
            }

            ClearArea_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Area();
        }

        private void BtnEdate2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAreaName.Text) || string.IsNullOrEmpty(TxtAreaPrice.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            Update_Area();
            ClearArea_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Area();
            Load_Area_Tbl(); // لاظهار التعديل او الاضافة تلقائيا في الكمبوبوكس حق اختيار المنطقة عند اضافه منطقة والرجوع لشاشة العملاء 
            Load_Customer(); // لتحديث الداتا جريد فيو الخاصة بالعملاء عند تعديل بيانات المناطق
        }

            private void DgvArea_Click_1(object sender, EventArgs e)
        {

            if (DgvArea.CurrentRow != null)
            {

            TxtArea_ID.Text = DgvArea.CurrentRow.Cells[0].Value.ToString();
            TxtAreaName.Text = DgvArea.CurrentRow.Cells[1].Value.ToString();
            TxtAreaPrice.Text = DgvArea.CurrentRow.Cells[2].Value.ToString();

            TxtAreaName.Enabled = true;
            TxtAreaPrice.Enabled = true;

            //BtnNew2.Enabled = true;
            BtnSave2.Enabled = false;
            //BtnEdit2.Enabled = true;
            //BtnDelete2.Enabled = true;

            if (_newArea == true)
                BtnNew2.Enabled = true;
            else BtnNew2.Enabled = false;

            if (_editArea == true)
                BtnEdit2.Enabled = true;
            else BtnEdit2.Enabled = false;

            if (_deleteArea == true)
                BtnDelete2.Enabled = true;
            else BtnDelete2.Enabled = false;

            


            }

        }


        ///*********************************************** Customer *******************************************************
        ///
        public void Load_Area_Tbl()
        {
            DataTable dt = new DataTable();
            CmbArea.DataSource = null;
            CmbArea.Items.Clear();
            CmbArea.Text = string.Empty;
            dt.Clear();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Area_Tbl", Con.con))
            {
                try
                {
                    if (Con.con.State == ConnectionState.Open)
                    {
                        Con.con.Close();
                    }
                    Con.con.Open();
                    dt.Load(cmd.ExecuteReader());
                    Con.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (Con.con.State == ConnectionState.Open)
                    {
                        Con.con.Close();
                    }
                }
            }

            if (dt.Rows.Count != 0)
            {
                CmbArea.DataSource = dt;
                CmbArea.DisplayMember = "AreaName";
                CmbArea.ValueMember = "Area_ID";
            }

            if (CmbArea.Items.Count > 0)
            {
                CmbArea.SelectedIndex = -1;
            }
        }
        public void ClearCustomer()
        {
            TxtCustomer_ID.Text = Con.Max_ID("Customer_Tbl", "Customer_ID").ToString();
            TxtCustomerName.Text = string.Empty;
            TxtCustomerName.Focus();
            TxtCustomerPhone1.Text = string.Empty;
            TxtCustomerPhone2.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            CmbArea.SelectedIndex = -1;

            TxtCustomerName.Enabled = true;
            TxtCustomerPhone1.Enabled = true;
            TxtCustomerPhone2.Enabled = true;
            TxtAddress.Enabled = true;
            CmbArea.Enabled = true;

            BtnNew.Enabled = false;

          
            if (_saveCust == true)
                BtnSave.Enabled = true;
            else BtnSave.Enabled = false;

            //BtnSave.Enabled = true;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
        }

         public void ClearCustomer_After_Delete_And_Update_And_Save_Or_Open_Form()
        {
            TxtCustomer_ID.Text = string.Empty;
            TxtCustomerName.Text = string.Empty;
            TxtCustomerPhone1.Text = string.Empty;
            TxtCustomerPhone2.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            CmbArea.SelectedIndex = -1;

            TxtCustomer_ID.Enabled = false;
            TxtCustomerName.Enabled = false;
            TxtCustomerPhone1.Enabled = false;
            TxtCustomerPhone2.Enabled = false;
            TxtAddress.Enabled = false;
            CmbArea.Enabled = false;


            
            if (_newCust == true)
                BtnNew.Enabled = true;
            else BtnNew.Enabled = false;

            //BtnNew.Enabled = true;
            BtnSave.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
        }

       public void Insert_Customer()
    {
        if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();

        SqlCommand command = new SqlCommand("Insert into Customer_Tbl (Customer_ID,CustomerName,CustomerPhone1,CustomerPhone2,Address,Area_ID)Values(@Customer_ID,@CustomerName,@CustomerPhone1,@CustomerPhone2,@Address,@Area_ID)", Con.con);
        command.Parameters.AddWithValue("@Customer_ID", int.Parse(TxtCustomer_ID.Text));
        command.Parameters.AddWithValue("@CustomerName", TxtCustomerName.Text);
        command.Parameters.AddWithValue("@CustomerPhone1", TxtCustomerPhone1.Text);
        command.Parameters.AddWithValue("@CustomerPhone2", TxtCustomerPhone2.Text);
        command.Parameters.AddWithValue("@Address", TxtAddress.Text);
        command.Parameters.AddWithValue("@Area_ID", CmbArea.SelectedValue);
        command.ExecuteNonQuery();
            Con.con.Close();
        MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
       public void Update_Customer()
    {
        if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();

        SqlCommand command = new SqlCommand("Update  Customer_Tbl  set CustomerName = @CustomerName,CustomerPhone1 = @CustomerPhone1,CustomerPhone2 = @CustomerPhone2,Address = @Address,Area_ID = @Area_ID Where Customer_ID = @Customer_ID ", Con.con);

        command.Parameters.AddWithValue("@CustomerName", TxtCustomerName.Text);
        command.Parameters.AddWithValue("@CustomerPhone1", TxtCustomerPhone1.Text);
        command.Parameters.AddWithValue("@CustomerPhone2", TxtCustomerPhone2.Text);
        command.Parameters.AddWithValue("@Address", TxtAddress.Text);
        command.Parameters.AddWithValue("@Area_ID", CmbArea.SelectedValue);
        command.Parameters.AddWithValue("@Customer_ID", int.Parse(TxtCustomer_ID.Text));
        command.ExecuteNonQuery();
            Con.con.Close();
        MessageBox.Show("تم تعديل السجل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
       public void Delete_Customer(DataGridView dgv_Dep_tbl)
    {
        int position = dgv_Dep_tbl.CurrentRow.Index;
        int ID_Position = Convert.ToInt32(dgv_Dep_tbl.Rows[position].Cells[0].Value);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = Con.con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "Delete From Customer_Tbl Where Customer_ID = @Customer_ID";
        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@Customer_ID", ID_Position);

        try
        {
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
                Con.con.Open();
            cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم حذف السجل بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd = null;
        }
        catch (Exception ex)
        {
                Con.con.Close();
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
        }
    }
       public void Load_Customer()
    {
        Dgv_Customer.Rows.Clear();
        if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
        SqlCommand cmd = new SqlCommand("Select * from View_Customer", Con.con);
        SqlDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
            Dgv_Customer.Rows.Add(rdr["Customer_ID"].ToString(), rdr["CustomerName"].ToString(), rdr["CustomerPhone1"].ToString(), rdr["CustomerPhone2"].ToString(), rdr["Address"].ToString(), rdr["AreaName"].ToString(), rdr["AreaPrice"].ToString());
        }
        rdr.Close();
            Con.con.Close();
    }
    
          private void Dgv_Customer_Click_1(object sender, EventArgs e)
          {
              if (Dgv_Customer.CurrentRow != null)
            {
                TxtCustomer_ID.Text = Dgv_Customer.CurrentRow.Cells[0].Value.ToString();
            TxtCustomerName.Text = Dgv_Customer.CurrentRow.Cells[1].Value.ToString();
            TxtCustomerPhone1.Text = Dgv_Customer.CurrentRow.Cells[2].Value.ToString();
            TxtCustomerPhone2.Text = Dgv_Customer.CurrentRow.Cells[3].Value.ToString();
            TxtAddress.Text = Dgv_Customer.CurrentRow.Cells[4].Value.ToString();
            CmbArea.SelectedItem = Dgv_Customer.CurrentRow.Cells[5].Value;

            TxtCustomerName.Enabled = true;
            TxtCustomerPhone1.Enabled = true;
            TxtCustomerPhone2.Enabled = true;
            TxtAddress.Enabled = true;
            CmbArea.Enabled = true;

            //BtnNew.Enabled = true;
            BtnSave.Enabled = false;
            //BtnEdit.Enabled = true;
            //BtnDelete.Enabled = true;

           
            if (_newCust == true)
                BtnNew.Enabled = true;
            else BtnNew.Enabled = false;
          
            if (_eidtCust == true)
                BtnEdit.Enabled = true;
            else BtnEdit.Enabled = false;

            if (_deleteCust == true)
                BtnDelete.Enabled = true;
            else BtnDelete.Enabled = false;

            }
          }

  
   

        private void BtnNew_Click_1(object sender, EventArgs e)
        {
            ClearCustomer();
        }
        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCustomerName.Text) || string.IsNullOrEmpty(TxtCustomerPhone1.Text) || string.IsNullOrEmpty(TxtCustomerPhone2.Text) || string.IsNullOrEmpty(TxtAddress.Text) || string.IsNullOrEmpty(CmbArea.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Insert_Customer();
            ClearCustomer_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Customer();

        }
        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCustomerName.Text) || string.IsNullOrEmpty(TxtCustomerPhone1.Text) || string.IsNullOrEmpty(TxtCustomerPhone2.Text) || string.IsNullOrEmpty(TxtAddress.Text) || string.IsNullOrEmpty(CmbArea.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Update_Customer();
            ClearCustomer_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Customer();
        } 
        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                Delete_Customer(Dgv_Customer);
            }
            ClearCustomer_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Customer();
        }
        private void TxtSearchPhone_TextChanged_1(object sender, EventArgs e)
        {
            Dgv_Customer.Rows.Clear();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from View_Customer Where CustomerPhone1 Like '%" + TxtSearchPhone.Text + "%' Or CustomerPhone2 Like '%" + TxtSearchPhone.Text + "%' ", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Dgv_Customer.Rows.Add(rdr["Customer_ID"].ToString(), rdr["CustomerName"].ToString(), rdr["CustomerPhone1"].ToString(), rdr["CustomerPhone2"].ToString(), rdr["Address"].ToString(), rdr["AreaName"].ToString());
            }
            rdr.Close();
            Con.con.Close();

        }

        private void TxtSearchName_TextChanged_1(object sender, EventArgs e)
        {
            Dgv_Customer.Rows.Clear();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from View_Customer Where CustomerName Like '%" + TxtSearchName.Text + "%' ", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Dgv_Customer.Rows.Add(rdr["Customer_ID"].ToString(), rdr["CustomerName"].ToString(), rdr["CustomerPhone1"].ToString(), rdr["CustomerPhone2"].ToString(), rdr["Address"].ToString(), rdr["AreaName"].ToString());
            }
            rdr.Close();
            Con.con.Close();

        }



        //*************************************************** Delevery ****************************************************

        public void Clear_Delivery()
        {
            TxtDeleveryMan_ID.Text = Con.Max_ID("DeleveryMan_Tbl", "DeleveryMan_ID").ToString();
            TxtDeleveryManName.Text = string.Empty;
            TxtDeleveryManName.Focus();
            TxtDeleveryManPhone.Text = string.Empty;
            TxtDeleveryManAddress.Text = string.Empty;
            TxtDeleveryManBalance.Text = "0.0";

            TxtDeleveryManName.Enabled = true;
            TxtDeleveryManPhone.Enabled = true;
            TxtDeleveryManAddress.Enabled = true;
            TxtDeleveryManBalance.Enabled = true;

            BtnNew1.Enabled = false;

            if (_savedev == true)
                BtnSave1.Enabled = true;
            else BtnSave1.Enabled = false;
 
            ////BtnSave1.Enabled = true;
            BtnEdit1.Enabled = false;
            BtnDelete1.Enabled = false;
        }


        public void Clear_Delivery_After_Delete_And_Update_And_Save_Or_Open_Form()
        {
            TxtDeleveryMan_ID.Text = string.Empty;
            TxtDeleveryManName.Text = string.Empty;
            TxtDeleveryManPhone.Text = string.Empty;
            TxtDeleveryManAddress.Text = string.Empty;
            TxtDeleveryManBalance.Text = "";

            TxtDeleveryMan_ID.Enabled = false;
            TxtDeleveryManName.Enabled = false;
            TxtDeleveryManPhone.Enabled = false;
            TxtDeleveryManAddress.Enabled = false;
            TxtDeleveryManBalance.Enabled = false;

            if (_newdev == true)
                BtnNew1.Enabled = true;
            else BtnNew1.Enabled = false;


            //BtnNew1.Enabled = true;
            BtnSave1.Enabled = false;
            BtnEdit1.Enabled = false;
            BtnDelete1.Enabled = false;
        }

        public void Insert_Delevry()
        {
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Insert into DeleveryMan_Tbl (DeleveryMan_ID, DeleveryManName, DeleveryManPhone, DeleveryManAddress, DeleveryManBalance) Values (@DeleveryMan_ID, @DeleveryManName, @DeleveryManPhone, @DeleveryManAddress, @DeleveryManBalance)", Con.con);
            cmd.Parameters.AddWithValue("@DeleveryMan_ID", int.Parse(TxtDeleveryMan_ID.Text));
            cmd.Parameters.AddWithValue("@DeleveryManName", TxtDeleveryManName.Text);
            cmd.Parameters.AddWithValue("@DeleveryManPhone", TxtDeleveryManPhone.Text);
            cmd.Parameters.AddWithValue("@DeleveryManAddress", TxtDeleveryManAddress.Text);
            cmd.Parameters.AddWithValue("@DeleveryManBalance", double.Parse(TxtDeleveryManBalance.Text));
            cmd.ExecuteNonQuery();
            Con.con.Close();
            MessageBox.Show("تم إضافة السجل بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Update_Delevry()
        {
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();

            SqlCommand cmd = new SqlCommand("Update  DeleveryMan_Tbl set DeleveryManName = @DeleveryManName, DeleveryManPhone = @DeleveryManPhone, DeleveryManAddress = @DeleveryManAddress, DeleveryManBalance = @DeleveryManBalance Where DeleveryMan_ID = @DeleveryMan_ID", Con.con);

            cmd.Parameters.AddWithValue("@DeleveryManName", TxtDeleveryManName.Text);
            cmd.Parameters.AddWithValue("@DeleveryManPhone", TxtDeleveryManPhone.Text);
            cmd.Parameters.AddWithValue("@DeleveryManAddress", TxtDeleveryManAddress.Text).ToString();
            cmd.Parameters.AddWithValue("@DeleveryManBalance", double.Parse(TxtDeleveryManBalance.Text));
            cmd.Parameters.AddWithValue("@DeleveryMan_ID", int.Parse(TxtDeleveryMan_ID.Text));
            cmd.ExecuteNonQuery();
            Con.con.Close();
            MessageBox.Show("تم اضافة السجل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Delete_DelevryMan_Tbl(DataGridView dgv_Dep_tbl)
        {
            int position = dgv_Dep_tbl.CurrentRow.Index;
            int ID_Position = Convert.ToInt32(dgv_Dep_tbl.Rows[position].Cells[0].Value);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete  From DeleveryMan_Tbl Where DeleveryMan_ID = @DeleveryMan_ID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DeleveryMan_ID", ID_Position);
            
            try
            {
                if (Con.con.State == ConnectionState.Open) Con.con.Close();
                Con.con.Open();
                cmd.ExecuteNonQuery();
                Con.con.Close();
                MessageBox.Show("تم حذف السجل بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd = null;
            }
            catch (Exception ex)
            {
                Con.con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.con.State == ConnectionState.Open) Con.con.Close();
            }
        }
        public void Load_Delevry()
        {
            DgvDelevery.Rows.Clear();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from DeleveryMan_Tbl", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DgvDelevery.Rows.Add(rdr["DeleveryMan_ID"].ToString(), rdr["DeleveryManName"].ToString(), rdr["DeleveryManPhone"].ToString(), rdr["DeleveryManAddress"].ToString(), rdr["DeleveryManBalance"].ToString());
            }
            rdr.Close();
            Con.con.Close();
        }

        
        private void DgvDelevery_Click(object sender, EventArgs e)
        {
            if (DgvDelevery.CurrentRow != null)
            {
                TxtDeleveryMan_ID.Text = DgvDelevery.CurrentRow.Cells[0].Value.ToString();
                TxtDeleveryManName.Text = DgvDelevery.CurrentRow.Cells[1].Value.ToString();
                TxtDeleveryManPhone.Text = DgvDelevery.CurrentRow.Cells[2].Value.ToString();
                TxtDeleveryManAddress.Text = DgvDelevery.CurrentRow.Cells[3].Value.ToString();
                TxtDeleveryManBalance.Text = DgvDelevery.CurrentRow.Cells[4].Value.ToString();


                TxtDeleveryManName.Enabled = true;
                TxtDeleveryManPhone.Enabled = true;
                TxtDeleveryManAddress.Enabled = true;
                TxtDeleveryManBalance.Enabled = true;


                //BtnNew1.Enabled = true;
                BtnSave1.Enabled = false;
                //BtnEdit1.Enabled = true;
                //BtnDelete1.Enabled = true;

                if (_newdev == true)
                    BtnNew1.Enabled = true;
                else BtnNew1.Enabled = false;

                if (_eidtdev == true)
                    BtnEdit1.Enabled = true;
                else BtnEdit1.Enabled = false;

                if (_deletedev == true)
                    BtnDelete1.Enabled = true;
                else BtnDelete1.Enabled = false;

            }
        }

       
        ///
        private void BtnNew1_Click(object sender, EventArgs e)
        {
            Clear_Delivery();

        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDeleveryManName.Text) || string.IsNullOrEmpty(TxtDeleveryManPhone.Text) || string.IsNullOrEmpty(TxtDeleveryManAddress.Text) || string.IsNullOrEmpty(TxtDeleveryManBalance.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Insert_Delevry();
            Clear_Delivery_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Delevry();
        }
        
        private void BtnDelete1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
                Delete_DelevryMan_Tbl(DgvDelevery);
            Clear_Delivery_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Delevry();

        }

        private void BtnEdate1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDeleveryManName.Text) || string.IsNullOrEmpty(TxtDeleveryManPhone.Text) || string.IsNullOrEmpty(TxtDeleveryManAddress.Text) || string.IsNullOrEmpty(TxtDeleveryManBalance.Text))
            {
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Update_Delevry();
            Clear_Delivery_After_Delete_And_Update_And_Save_Or_Open_Form();
            Load_Delevry();
        }



        private void Dgv_Customer_DoubleClick_1(object sender, EventArgs e)
        {

            Connection._Customer_ID = int.Parse(Dgv_Customer.CurrentRow.Cells[0].Value.ToString());
            Connection._ServiceTotal = double.Parse(Dgv_Customer.CurrentRow.Cells[6].Value.ToString());
            //// _Customer_ID = Dgv_Customer.CurrentRow.Cells[0].Value.ToString();
            //// _ServiceTotal = Dgv_Customer.CurrentRow.Cells[6].Value.ToString();

        }
        private void DgvDelevery_DoubleClick(object sender, EventArgs e)
        {
            Connection._DeleveryMan_ID = int.Parse(DgvDelevery.CurrentRow.Cells[0].Value.ToString());

        }

        
        private void Dgv_Customer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                try
                {

                    Connection._Customer_ID = int.Parse(Dgv_Customer.CurrentRow.Cells[0].Value.ToString());
                    Connection._ServiceTotal = double.Parse(Dgv_Customer.CurrentRow.Cells[6].Value.ToString());


                    this.Frm_pos.TxtServices.Text = Connection._ServiceTotal.ToString();
                    this.Frm_pos.TxtServices.Refresh();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                try
                {

                    Connection._Customer_ID = int.Parse(Dgv_Customer.CurrentRow.Cells[0].Value.ToString());
                    Connection._ServiceTotal = double.Parse(Dgv_Customer.CurrentRow.Cells[6].Value.ToString());


                    this.Frm_pos.TxtServices.Text = Connection._ServiceTotal.ToString();
                    this.Frm_pos.TxtServices.Refresh();
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void DgvDelevery_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
               
                try
                {

                    Connection._DeleveryMan_ID = int.Parse(DgvDelevery.CurrentRow.Cells[0].Value.ToString());

                    this.Frm_pos.TxtServices.Text = Connection._ServiceTotal.ToString();
                    this.Frm_pos.TxtServices.Refresh();
                    
                    Insert_Tem_Delevery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
        }

        private void DgvDelevery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
         
                try
                {

                    Connection._DeleveryMan_ID = int.Parse(DgvDelevery.CurrentRow.Cells[0].Value.ToString());

                    this.Frm_pos.TxtServices.Text = Connection._ServiceTotal.ToString();
                    this.Frm_pos.TxtServices.Refresh();
                   

                    Insert_Tem_Delevery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
        }


        
        public void Insert_Tem_Delevery()
        {
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Order_Delevery_tbl (Order_ID,Customer_ID,DeleveryMan_ID)values(@Order_ID,@Customer_ID,@DeleveryMan_ID)", Con.con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Order_ID", SqlDbType.VarChar).Value = this.Frm_pos.TxtOrder_No.Text;
            cmd.Parameters.AddWithValue("@Customer_ID", SqlDbType.Int).Value = Connection._Customer_ID;
            cmd.Parameters.AddWithValue("@DeleveryMan_ID", SqlDbType.Int).Value = Connection._DeleveryMan_ID;
            cmd.ExecuteNonQuery();
            Con.con.Close();
            
            cmd = null;
        }

      
        private void TxtSearchD_Phone_TextChanged(object sender, EventArgs e)
        {
            DgvDelevery.Rows.Clear();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from DeleveryMan_Tbl Where DeleveryManPhone Like '%" + TxtSearchD_Phone.Text + "%'", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DgvDelevery.Rows.Add(rdr["DeleveryMan_ID"].ToString(), rdr["DeleveryManName"].ToString(), rdr["DeleveryManPhone"].ToString(), rdr["DeleveryManAddress"].ToString(), rdr["DeleveryManBalance"].ToString());
            }
            rdr.Close();
            Con.con.Close();
        }

        private void TxtSearchD_Name_TextChanged(object sender, EventArgs e)
        {
            DgvDelevery.Rows.Clear();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from DeleveryMan_Tbl Where DeleveryManName Like '%" + TxtSearchD_Name.Text + "%'", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DgvDelevery.Rows.Add(rdr["DeleveryMan_ID"].ToString(), rdr["DeleveryManName"].ToString(), rdr["DeleveryManPhone"].ToString(), rdr["DeleveryManAddress"].ToString(), rdr["DeleveryManBalance"].ToString());
            }
            rdr.Close();
            Con.con.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Cmd2 = null;
            rdr2.Close();
        }

      

       

     
    }
}
