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
    public partial class Frm_pos : Form
    {
        
        Connection Con;
        //QrCode Qr = new QrCode(this);

        public Frm_pos()
        {
            InitializeComponent();
            Con = new Connection();
            
        }

        // بداية الكود 

        Button btnCat;
        //Label LblName;
        //Label LblPrice;
        //Panel PicPanel;
        //Panel MainPanel;

        private string _filter = "";


        public void filter_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
            {
                _filter = control.Tag.ToString();
            }
            // or 
            //Label label = (Label)sender;
            //_filter = label.Tag.ToString();
            // or 
            //Button button = (Button)sender;
            //_filter = button.Tag.ToString();


            //_filter = sender.Tag.ToString(); // old  code

            Load_Items_By_Cat();   // تحميل المنتجات بنائا على التصنيفات على شكل صور
            //loadall_Item_Button_By_CatName();  // تحميل المنتجات بنائا على التصنيفات على شكل ازرار
        }

        public void loadall_cat()
        {
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Controls.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Cat_tbl", Con.con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                btnCat = new Button();
                btnCat.Width = 195;
                btnCat.Height = 30;
                btnCat.Text = rdr["CatName"].ToString();
                btnCat.Tag = rdr["Cat_ID"].ToString();
                btnCat.FlatStyle = FlatStyle.Flat;
                btnCat.FlatAppearance.BorderSize = 0;
                btnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnCat.BackColor = Color.FromArgb(Convert.ToInt32(rdr["Color"]));
                btnCat.ForeColor = Color.White;
                btnCat.Cursor = Cursors.Hand;
                btnCat.Font = new System.Drawing.Font("Tajawal", 10.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                btnCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnCat.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                FlowLayoutPanel1.Controls.Add(btnCat);
                btnCat.Click += filter_Click;
            }
            rdr.Close();
            Con.con.Close();
        }

        

        private void TxtSearchCat_TextChanged(object sender, EventArgs e)
        {
               // كود مربع بحث التصنيفات الكات 

            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Controls.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Cat_tbl Where CatName LIKE '%" + TxtSearchCat.Text + "%'", Con.con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                btnCat = new Button();
                btnCat.Width = 195;
                btnCat.Height = 30;
                btnCat.Text = rdr["CatName"].ToString();
                btnCat.Tag = rdr["Cat_ID"].ToString();
                btnCat.FlatStyle = FlatStyle.Flat;
                btnCat.FlatAppearance.BorderSize = 0;
                btnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnCat.BackColor = Color.FromArgb(Convert.ToInt32(rdr["Color"]));
                btnCat.ForeColor = Color.White;
                btnCat.Cursor = Cursors.Hand;
                btnCat.Font = new System.Drawing.Font("Tajawal", 10.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                btnCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnCat.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                FlowLayoutPanel1.Controls.Add(btnCat);
                btnCat.Click += filter_Click;
            }
            rdr.Close();
            Con.con.Close();
        }



        private void Frm_pos_Load(object sender, EventArgs e)
        {
             //loadall_cat()    //// تحميل التصنيفات  
        ////Load_Items()   ////// تحميل المنتجات على شكل صور 
        //loadall_Item_Button()   //// تحميل المنتجات على شكل ازرار 
        Get_Info(); // عشان جلب الرقم الضريبي واسم الشركة عشان الفاتورة الالكترونية        
        // فحص حالة الكاشير اذا لم يستلم الصندوق يقوم بعرض شاشة الاستلام عند دخول شاشة البيع مباشرة 
        if (!Connection._Cashier_Status)
              {
                  Frm_Istlam Frm_Istlam = new Frm_Istlam(this);
                  Frm_Istlam.ShowDialog();  
                }
        }


        public void Load_Items()
        {
        // تحميل المنتجات على شكل صور 

        FlowLayoutPanel2.AutoScroll = true;
        FlowLayoutPanel2.Controls.Clear();
        if (Con.con.State == ConnectionState.Open)
        {
            Con.con.Close();
        }
        Con.con.Open();
        SqlCommand cmd = new SqlCommand("Select * From Prd_tbl", Con.con);
        SqlDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
            Panel MainPanel = new Panel();
            MainPanel.Width = 123;
            MainPanel.Height = 140;
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            //******************************************************************
            Label lblName = new Label();
            lblName.BackColor = Color.FromArgb(45, 45, 48);
            lblName.ForeColor = Color.White;
            lblName.Text = rdr["PrdName"].ToString();
            lblName.Tag = rdr["Prd_ID"].ToString();
            lblName.Font = new System.Drawing.Font("Tajawal", 9.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.AutoSize = false;
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Dock = DockStyle.Top;
            //******************************************************************
            Label lblPrice = new Label();
            lblPrice.BackColor = Color.FromArgb(245, 246, 250);
            lblPrice.ForeColor = Color.FromArgb(232, 65, 24);
            lblPrice.Text = "السعر : " + new string(' ', 4) + rdr["PrdPrice"].ToString(); 
            lblPrice.Tag = rdr["Prd_ID"].ToString();
            lblPrice.Font = new System.Drawing.Font("Tajawal", 9.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.AutoSize = false;
            lblPrice.BorderStyle = BorderStyle.FixedSingle;
            lblPrice.Dock = DockStyle.Bottom;
            //******************************************************************
            Panel picPanel = new Panel();
            //******************************************************************
            byte[] data = (byte[])rdr["Prd_Image"];
            MemoryStream ms = new MemoryStream(data);
            Bitmap bitamp = new Bitmap(ms);
            picPanel.Tag = rdr["Prd_ID"].ToString();
            picPanel.BackColor = Color.Transparent;
            picPanel.BackgroundImageLayout = ImageLayout.Stretch;
            picPanel.BackgroundImage = bitamp;
            picPanel.Dock = DockStyle.Fill;
            //******************************************************************
            MainPanel.Controls.Add(lblName);
            MainPanel.Controls.Add(lblPrice);
            MainPanel.Controls.Add(picPanel);
            //******************************************************************
            FlowLayoutPanel2.Controls.Add(MainPanel);
            //******************************************************************
            picPanel.Click += Select_Click;
            lblName.Click += Select_Click;
            lblPrice.Click += Select_Click;
        }
        rdr.Close();
        Con.con.Close();
        }

        public void Select_Click(object sender, EventArgs e)
        {
            if (TxtOrder_No.Text == string.Empty || TxtTableName.Text == string.Empty)
            {
                MessageBox.Show("عفواً ، قم بعمل فاتورة أولاً", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            Control control = sender as Control;
            if (control != null)
            {
                Connection._ID = Convert.ToInt32(control.Tag);
            }
            // or 
            //Label label = (Label)sender;
            //Con._ID =  Convert.ToInt32(label.Tag);
            // or 
            //Button button = (Button)sender;
            //Con._ID = Convert.ToInt32(button.Tag);


           // Con._ID = sender.Tag.ToString(); // old code 


            FrmQty frmQty = new FrmQty(this);
               //frmQty.Show(); // تعمل على اظهار الشاشة 
               frmQty.ShowDialog(); // تعمل على اظهار الشاشة في الاعلى فوق الشاشات
            }

        public void Load_Items_By_Cat()
        {
            // تحميل المنتجات بنائا على التصنيفات على شكل صور 

            FlowLayoutPanel2.AutoScroll = true;
            FlowLayoutPanel2.Controls.Clear();
            if (Con.con.State == ConnectionState.Open)
            {
                Con.con.Close();
            }
            Con.con.Open();
            SqlCommand Cmd = new SqlCommand("Select * From Prd_tbl Where Cat_ID = @Cat_ID", Con.con);
            Cmd.Parameters.AddWithValue("@Cat_ID", _filter);
            SqlDataReader rdr = Cmd.ExecuteReader();
            while (rdr.Read())
            {
                Panel MainPanel = new Panel();
                MainPanel.Width = 123;
                MainPanel.Height = 140;
                MainPanel.BorderStyle = BorderStyle.FixedSingle;
                //******************************************************************
                Label LblName = new Label();
                LblName.BackColor = Color.FromArgb(45, 45, 48);
                LblName.ForeColor = Color.White;
                LblName.Text = rdr["PrdName"].ToString();
                LblName.Tag = rdr["Prd_ID"].ToString();
                LblName.Font = new Font("Tajawal", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
                LblName.TextAlign = ContentAlignment.MiddleCenter;
                LblName.AutoSize = false;
                LblName.BorderStyle = BorderStyle.FixedSingle;
                LblName.Dock = DockStyle.Top;
                //******************************************************************
                Label LblPrice = new Label();
                LblPrice.BackColor = Color.FromArgb(245, 246, 250);
                LblPrice.ForeColor = Color.FromArgb(232, 65, 24);
                LblPrice.Text = "السعر : " + new string(' ', 4) + rdr["PrdPrice"].ToString(); 
                LblPrice.Tag = rdr["Prd_ID"].ToString();
                LblPrice.Font = new Font("Tajawal", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
                LblPrice.TextAlign = ContentAlignment.MiddleCenter;
                LblPrice.AutoSize = false;
                LblPrice.BorderStyle = BorderStyle.FixedSingle;
                LblPrice.Dock = DockStyle.Bottom;
                //******************************************************************
                Panel picPanel = new Panel();
                //******************************************************************
                byte[] data = (byte[])rdr["Prd_Image"];
                MemoryStream ms = new MemoryStream(data);
                Bitmap bitamp = new Bitmap(ms);
                picPanel.Tag = rdr["Prd_ID"].ToString();
                picPanel.BackColor = Color.Transparent;
                picPanel.BackgroundImageLayout = ImageLayout.Stretch;
                picPanel.BackgroundImage = bitamp;
                picPanel.Dock = DockStyle.Fill;
                //******************************************************************
                MainPanel.Controls.Add(LblName);
                MainPanel.Controls.Add(LblPrice);
                MainPanel.Controls.Add(picPanel);
                //******************************************************************
                FlowLayoutPanel2.Controls.Add(MainPanel);
                //******************************************************************
                picPanel.Click += Select_Click;
                LblName.Click += Select_Click;
                LblPrice.Click += Select_Click;
            }
            rdr.Close();
            Con.con.Close();
        }

        private void TxtSearchPrd_TextChanged(object sender, EventArgs e)
        {
            //البحث عن المنتجات وظهورها على شكل صور 

            //حدث مربع النص الذي يعمل بحث عن المنتجات

            FlowLayoutPanel2.AutoScroll = true;
            FlowLayoutPanel2.Controls.Clear();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Prd_tbl Where PrdName Like '%" + TxtSearchPrd.Text + "%'", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Panel MainPanel = new Panel();
                MainPanel.Width = 123;
                MainPanel.Height = 140;
                MainPanel.BorderStyle = BorderStyle.FixedSingle;
                //******************************************************************
                Label LblName = new Label();
                LblName.BackColor = Color.FromArgb(45, 45, 48);
                LblName.ForeColor = Color.White;
                LblName.Text = rdr["PrdName"].ToString();
                LblName.Tag = rdr["Prd_ID"].ToString();
                LblName.Font = new Font("Tajawal", 9.0f, FontStyle.Bold);
                LblName.TextAlign = ContentAlignment.MiddleCenter;
                LblName.AutoSize = false;
                LblName.BorderStyle = BorderStyle.FixedSingle;
                LblName.Dock = DockStyle.Top;
                //******************************************************************
                Label LblPrice = new Label();
                LblPrice.BackColor = Color.FromArgb(245, 246, 250);
                LblPrice.ForeColor = Color.FromArgb(232, 65, 24);
                LblPrice.Text = "السعر : " + "    " + rdr["PrdPrice"].ToString();
                LblPrice.Tag = rdr["Prd_ID"].ToString();
                LblPrice.Font = new Font("Tajawal", 9.0f, FontStyle.Bold);
                LblPrice.TextAlign = ContentAlignment.MiddleCenter;
                LblPrice.AutoSize = false;
                LblPrice.BorderStyle = BorderStyle.FixedSingle;
                LblPrice.Dock = DockStyle.Bottom;
                //******************************************************************
                Panel picPanel = new Panel();
                byte[] data = (byte[])rdr["Prd_Image"];
                MemoryStream ms = new MemoryStream(data);
                Bitmap bitamp = new Bitmap(ms);
                picPanel.Tag = rdr["Prd_ID"].ToString();
                picPanel.BackColor = Color.Transparent;
                picPanel.BackgroundImageLayout = ImageLayout.Stretch;
                picPanel.BackgroundImage = bitamp;
                picPanel.Dock = DockStyle.Fill;
                //******************************************************************
                MainPanel.Controls.Add(LblName);
                MainPanel.Controls.Add(LblPrice);
                MainPanel.Controls.Add(picPanel);
                //******************************************************************
                FlowLayoutPanel2.Controls.Add(MainPanel);
                //******************************************************************
                picPanel.Click += Select_Click;
                LblName.Click += Select_Click;
                LblPrice.Click += Select_Click;
            }

            rdr.Close();
            Con.con.Close();
            }

        private void btnShowAllI_item_Click(object sender, EventArgs e)
        {
              // زر تم اضافته من عندي 
            Load_Items();  // تحميل المنتجات على شكل صور 
        }


        public void loadall_Item_Button()
        {
            // تحميل المنتجات على شكل ازرار 

            FlowLayoutPanel2.AutoScroll = true;
            FlowLayoutPanel2.Controls.Clear();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Prd_tbl", Con.con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Button btnPrd = new Button();
                btnPrd.Width = 165;
                btnPrd.Height = 64;
                btnPrd.Text = rdr["PrdName"].ToString() + "\r\n" + "السعر : " + "    " + rdr["PrdPrice"].ToString();
                btnPrd.Tag = rdr["Prd_ID"].ToString();
                btnPrd.FlatStyle = FlatStyle.Flat;
                btnPrd.FlatAppearance.BorderSize = 0;
                btnPrd.FlatStyle = FlatStyle.Flat;
                btnPrd.BackColor = Color.FromArgb(64, 64, 64);
                btnPrd.ForeColor = Color.White;
                btnPrd.Cursor = Cursors.Hand;
                btnPrd.Font = new Font("Tajawal", 10.0f, FontStyle.Bold);
                btnPrd.TextAlign = ContentAlignment.MiddleCenter;
                btnPrd.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                FlowLayoutPanel2.Controls.Add(btnPrd);
                btnPrd.Click += Select_Click;

            }
            rdr.Close();
            Con.con.Close();
        }


        public void loadall_Item_Button_By_CatName()
        {
            // تحميل المنتجات بنائا على التصنيفات على شكل ازرار 

            FlowLayoutPanel2.AutoScroll = true;
            FlowLayoutPanel2.Controls.Clear();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Prd_tbl Where Cat_ID = @Cat_ID", Con.con);
            cmd.Parameters.AddWithValue("@Cat_ID", _filter);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Button btnPrd = new Button();
                btnPrd.Width = 165;
                btnPrd.Height = 64; 
                btnPrd.Text = rdr["PrdName"].ToString() + "\r\n" + "السعر : " + "    " + rdr["PrdPrice"].ToString();
                btnPrd.Tag = rdr["Prd_ID"].ToString();
                btnPrd.FlatStyle = FlatStyle.Flat;
                btnPrd.FlatAppearance.BorderSize = 0;
                btnPrd.FlatStyle = FlatStyle.Flat;
                btnPrd.BackColor = Color.FromArgb(64, 64, 64);
                btnPrd.ForeColor = Color.White;
                btnPrd.Cursor = Cursors.Hand;
                btnPrd.Font = new Font("Tajawal", 10.0f, FontStyle.Bold);
                btnPrd.TextAlign = ContentAlignment.MiddleCenter;
                btnPrd.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                FlowLayoutPanel2.Controls.Add(btnPrd);
                btnPrd.Click += Select_Click;

            }
            rdr.Close();
            Con.con.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            // الكود القديم يظهر اختيار الطاولة
            //Frm_Select_Table Frm_Select_Table = new Frm_Select_Table();
            //loadTable.loadall_Table();
            ////loadTable.Show();
            //loadTable.ShowDialog();

            // الكود الجديد لاختيار نوع الطلب أولا
         Frm_Order_Type Frm_Order_Type = new Frm_Order_Type(this);
            //Frm_Order_Type.Show(); // تعمل على اظهار الشاشة 
         Frm_Order_Type.ShowDialog(); // تعمل على اظهار الشاشة في الاعلى فوق الشاشات
            

        }

        // ---------------------------------------- Get Order Number ----------------------------------------

        public string Get_Order_No()
        {
            string _Get_Order_No = "";

            try
            {
                string orderdate = DateTime.Now.ToString("yyyyMMdd");
                if (Con.con.State == ConnectionState.Open) Con.con.Close();
                Con.con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Order_tbl Where Order_No Like '"+ @orderdate + "%' order by Order_ID desc", Con.con);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {
                    Int64 orderNo = Convert.ToInt64(rdr["Order_No"]);
                    _Get_Order_No = Convert.ToString(orderNo + 1);
                    
                }
                else
                {
                    _Get_Order_No = orderdate + "0001"; 
                }
                rdr.Close();
                Con.con.Close();
                return _Get_Order_No;
            }
            catch 
            {
                MessageBox.Show("يوجد خطأ في جلب رقم الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _Get_Order_No; 
            }
        }




        public void Load_Order()
        {
            Dgv.Rows.Clear();
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * From View_Order Where Order_No Like '" + TxtOrder_No.Text + "'", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Dgv.Rows.Add(rdr["Order_ID"].ToString(), rdr["Prd_ID"].ToString(), rdr["PrdName"].ToString(), rdr["SalePrice"].ToString(), rdr["Qty"].ToString(), rdr["Total"].ToString());
            }
            rdr.Close();
            Con.con.Close();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                // زيادة بمقدار واحد في الداتا جريد فيو
                if (Con.con.State == ConnectionState.Open) Con.con.Close();
                Con.con.Open();
                SqlCommand cmd = new SqlCommand("Update Order_tbl Set Qty = Qty + @Qty Where Order_ID=@Order_ID ", Con.con);
                cmd.Parameters.AddWithValue("@Qty", 1);
                cmd.Parameters.AddWithValue("@Order_ID", Dgv.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                Con.con.Close();
                //  تعديل الاجمالي
                if (Con.con.State == ConnectionState.Open) Con.con.Close();
                Con.con.Open();
                cmd = new SqlCommand("Update Order_tbl Set Total = SalePrice * Qty Where Order_ID=@Order_ID ", Con.con);
                cmd.Parameters.AddWithValue("@Order_ID", Dgv.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                Con.con.Close();
                Load_Order();
                Order_Table();

            }
            else if (e.ColumnIndex == 7)
            {
                // انقاص بمقدار واحد في الداتا جريد فيو
                if (Convert.ToInt16(Dgv.CurrentRow.Cells[4].Value) > 1) // edit
                {
                    //  قم بعملية الانقاص 
                    if (Con.con.State == ConnectionState.Open) Con.con.Close();
                    Con.con.Open();
                    SqlCommand cmd = new SqlCommand("Update Order_tbl Set Qty = Qty - @Qty Where Order_ID=@Order_ID ", Con.con);
                    cmd.Parameters.AddWithValue("@Qty", 1);
                    cmd.Parameters.AddWithValue("@Order_ID", Dgv.CurrentRow.Cells[0].Value);
                    cmd.ExecuteNonQuery();
                    Con.con.Close();
                    // تعديل الاجمالي
                    if (Con.con.State == ConnectionState.Open) Con.con.Close();
                    Con.con.Open();
                    cmd = new SqlCommand("Update Order_tbl Set Total = SalePrice * Qty Where Order_ID=@Order_ID ", Con.con);
                    cmd.Parameters.AddWithValue("@Order_ID", Dgv.CurrentRow.Cells[0].Value);
                    cmd.ExecuteNonQuery();
                    Con.con.Close();
                    Load_Order();
                    Order_Table();

                }
                else
                {
                    // قم بعمل حذف للمنتج
                    Delete_Prd();
                    //   تم استدعاء هذا الداله هنا لتجنب عدم افراغ الحقول من القيم عند عمل انقاص دريجي للصنف حتى  ينحذف مع عدم وجود اصناف اخرى بجانب الصنف الموجود
                    Order_Table();

                }

            }
            else if (e.ColumnIndex == 8)
            {
                // حذف المنتج من الداتا جريد فيو 
                Delete_Prd();

            }
        }


        // حذف المنتج من الداتا جريد فيو 
        public void Delete_Prd()
        {
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Delete FROM Order_tbl Where Order_ID=@Order_ID ", Con.con);
            cmd.Parameters.AddWithValue("@Order_ID", Dgv.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            Con.con.Close();
            Load_Order();
        }


        // نستدعي هذا الدالة عند عمل فاتورة جديدة او عند التعديل على الداتا جريد فيو 
        public void Order_Table()
        {
            if (Res_csharp.Properties.Settings.Default.Tax_Status == true)
            {
                Con.Get_Tax_Value();
            }
            else
            {
                Connection._Tax_Value = 0.0;
            }

            double Total1 = 0.0, _Total_Tax = 0.0;
            foreach (DataGridViewRow row in Dgv.Rows)
            {
                Total1 += Convert.ToDouble(row.Cells[5].Value);
            }
            TxtTotal.Text = Total1.ToString(); //  حقل المجموع 
            _Total_Tax = Total1 * Connection._Tax_Value / 100; // حساب الضريبة
            LblTax.Text = _Total_Tax.ToString(); // حقل الضريبة
            TxtFinalTotal.Text = (Total1 + _Total_Tax + Connection._ServiceTotal).ToString(); // حقل المجموع النهائي يساوي المجموع + الضريبة + سعر خدمة التوصيل 
            TxtCount.Text = Dgv.Rows.Count.ToString(); // عداد عدد المواد
            //TxtServices.Text = Con._ServiceTotal.ToString();
        }


        public void GetOrder()
        {
            bool found;
            string tno = "";
            DateTime orderdate1 = DateTime.MinValue;
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("select * from Order_tbl Where TableName Like '" + TxtTableName.Text + "' And Status ='Open'", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                // في حال وجود طلب محجوز لطاولة 
                found = true;
                tno = rdr["Order_No"].ToString();
                orderdate1 = DateTime.Parse(rdr["Order_Date"].ToString());
            }
            else
            {
                 // في حال لايوجد طلب لهذه الطاولة نفتح فاتورة جديد
                found = false; 
                tno = Get_Order_No();
                
            }
            rdr.Close();
            Con.con.Close();

            // في حال وجود طلب محجوز للطاولة نعطي رقم الطلب لحقل رقم الفاتورة ونحمل الطلب المحجوز للداتا جريد فيو 
            if (found == true)
            {
                TxtOrder_No.Text = tno;
                OrderDate.Value = orderdate1;
                
            }
            else
            {
                TxtOrder_No.Text = tno;
                OrderDate.Value = DateTime.Parse(DateTime.Now.ToString()); // DateTime.Now.ToString("yyyyMMdd");

            }


               //########################################################## New Code ##########################################################
                // هذا الكود عشان يجلب قيمة خدمات التوصيل مع بيانات العميل والموصل عند اختيار فاتورة خدمة توصيل او تعديل السابقة بحيث انها لم تدفع بعد
            if (found == true)
            {
                if (Con.con.State == ConnectionState.Open) Con.con.Close();
                Con.con.Open();
                cmd = new SqlCommand("Select * FROM View_Order_Delevery Where Order_ID=@Order_ID ", Con.con);
                cmd.Parameters.AddWithValue("@Order_ID", tno);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {
                    Connection._Customer_ID = int.Parse(rdr["Customer_ID"].ToString());
                    Connection._DeleveryMan_ID = int.Parse(rdr["DeleveryMan_ID"].ToString());
                    Connection._ServiceTotal = double.Parse(rdr["AreaPrice"].ToString());
                    //Con._order_Type = "Delevery";
                }
                else
                {
                    Connection._Customer_ID = 0;
                    Connection._DeleveryMan_ID = 0;
                    Connection._ServiceTotal = 0.0;
                }
                rdr.Close();
                Con.con.Close();
            }
            tno = "";
            found = false;
            
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtOrder_No.Text) || string.IsNullOrEmpty(TxtTableName.Text))
            {
                MessageBox.Show("عفواً ، قم بعمل فاتورة أولاً", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            Get_Info_Print();
            Con.Get_Tax_Value();

            //Qr.Get_QrCode();

            Frm_Paid Frm_Paid = new Frm_Paid(this);
            Connection._Order_No = TxtOrder_No.Text;
            Connection._FinalTotal = double.Parse(TxtFinalTotal.Text);
            Connection._TaxTotal = double.Parse(LblTax.Text);
            Connection._Order_Total = double.Parse(TxtTotal.Text);
            Frm_Paid.TxtFinalTotal.Text = TxtFinalTotal.Text;
            Frm_Paid.TxtDiscount.Text = "0.0"; // حقل الخصم 
            Frm_Paid.TxtPaid.Text = "0";
            Frm_Paid.TxtUnPaid.Text = "0";
            Frm_Paid.CmbPaidType.SelectedIndex = -1;
            Frm_Paid.ShowDialog(); // تعمل على اظهار الشاشة في الاعلى فوق الشاشات

        }

         // عشان جلب الرقم الضريبي واسم الشركة عشان الفاتورة الالكترونية

        public void Get_Info()
        {
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Company_tbl", Con.con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows)
            {
                Connection._CompanyName = rdr["CompanyName"].ToString();
                Connection._vat_No = rdr["Vat_No"].ToString();
            }
            rdr.Close();
            Con.con.Close();
        }

         // ################################### تحميل الاقسام بدون تكرار #########################################
        public void Get_Info_Print()
        {
            if (Con.con.State == ConnectionState.Open) Con.con.Close();
            Con.con.Open();
            DataTable mydt = new DataTable();
            mydt.Clear();
            dgv_Print.DataSource = null;
            SqlCommand cmd = new SqlCommand("Select Distinct Dep_ID as 'القسم' , Dep_Name as 'اسم القسم' , PrinterName as 'اسم الطابعة' , Stauts as 'الحالة' FROM View_ByDep Where Order_No=@Order_No ", Con.con);
            cmd.Parameters.AddWithValue("@Order_No", TxtOrder_No.Text);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(mydt);
            if (mydt.Rows.Count > 0)
            {
                dgv_Print.DataSource = mydt;
            }
            else
            {
                dgv_Print.DataSource = null;
            }
            Con.con.Close();
        }




        private void BtnSelectDelevery_Click(object sender, EventArgs e)
        {
            Frm_Delevery frm = new Frm_Delevery(this);
            frm.ShowDialog();
        }

        private void BtnIstlam_Click(object sender, EventArgs e)
        {

            Frm_Istlam frm = new Frm_Istlam(this);
            frm.TxtTotal.Text = "0.0";
            // frm.Show(); // تعمل على اظهار الشاشة 
            frm.ShowDialog(); // تعمل على اظهار الشاشة في الاعلى فوق الشاشات
        }

        private void BtnTaslem_Click(object sender, EventArgs e)
        {
            Frm_Taslem frm = new Frm_Taslem();
            frm.Get_Start_Balance();
            frm.Get_Cash();
            frm.Get_Visa();
            frm.TxtTotal.Text = (float.Parse(frm.TxtTotalCash.Text) + float.Parse(frm.TxtTotalVisa.Text) + float.Parse(frm.TxtStart_Balance.Text)).ToString();

            //frm.TxtTotal.Text = frm.TxtTotalCash.Text + frm.TxtTotalVisa.Text + frm.TxtStart_Balance.Text;
     
            // frm.Show(); // تعمل على اظهار الشاشة 
            frm.ShowDialog(); // تعمل على اظهار الشاشة في الاعلى فوق الشاشات
        }

        




    }
}
