using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.category;

namespace WindowsForms
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        CategoryServiceClient sp = new CategoryServiceClient();
        private void Category_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sp.GetAll();
        }
    }
}
