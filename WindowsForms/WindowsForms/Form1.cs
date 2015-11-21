using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.BookServices;
using System.IO;
using WindowsForms.product;
using System.Data.SqlClient;
using WindowsForms.category;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductserviceClient bs = new ProductserviceClient();
        CategoryServiceClient ct = new CategoryServiceClient();
        private string _hinh = "";

       
       
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bs.GetAll();
            cbCategory.DataSource = ct.GetAll();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Name";
            cbCategory.Text = "";
            
        }
        private void Emty()
        {
            txtName.Text = "";
            txtDetail.Text = "";
            txtImage.Text = "";
            txtID.Text = "";
            txtPrice.Text = string.Empty;
            cbCategory.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ProductserviceClient bs = new ProductserviceClient();
            Product p = new Product
            {
                Name = txtName.Text,
                Category = cbCategory.Text,
               //CreatedDate = Convert.ToDateTime(txtCreatedDay.Text),
                Price = Convert.ToDecimal(txtPrice.Text),
                Detail = txtDetail.Text,
                Image = txtImage.Text
                
             
            };
            bs.AddProduct(p);

            dataGridView1.DataSource = bs.GetAll();
            Emty();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                Product p = new Product();
                p.ID = Convert.ToInt32(txtID.Text);
                p.Name = txtName.Text;
                p.Category = cbCategory.Text;
                p.Price = Convert.ToDecimal(txtPrice.Text);
                p.Detail = txtDetail.Text;
                p.Image = txtImage.Text;

                bs.UpdateProduct(p);
                dataGridView1.DataSource = bs.GetAll();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (MessageBox.Show("Chương trình sẽ xóa sản phẩm ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    bs.DeleteProduct(Convert.ToInt32(txtID.Text));

                    //Fill data 
                    dataGridView1.DataSource = bs.GetAll();
                    Emty();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa", "Thông báo");
            }

        }

        public void btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "file hinh|*.jpg|all file|*.*";
            dlg.InitialDirectory = @"E:\";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = dlg.FileNames;
                foreach (string i in tmp)
                {
                    FileInfo fi = new FileInfo(i);
                    string[] xxx = i.Split('\\');
                    string des = @"../../../WindowsForms/Images/" + xxx[xxx.Length - 1];
                    File.Delete(des);

                    //over.
                    fi.CopyTo(des);
                    txtImage.Text = "";
                    txtImage.Text = des;
                    //MessageBox.Show("Chọn hình ảnh thành công");
                    picImage.Image = Image.FromFile(des);
                    _hinh = Path.GetFileName(des);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Product p = bs.GetByID(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            txtID.Text = p.ID.ToString();
            txtName.Text = p.Name;
            txtPrice.Text = p.Price.ToString();
            cbCategory.Text = p.Category;
            txtDetail.Text = p.Detail;
            txtImage.Text = p.Image;

           
        }




      
    }
}
