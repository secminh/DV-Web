using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;
using System.ServiceModel;
namespace Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceHost product;
        ServiceHost category;
        ServiceHost user;
        private void btnstart_Click(object sender, EventArgs e)
        {
            product = new ServiceHost(typeof(Productservice));
            category = new ServiceHost(typeof(CategoryService));
            user = new ServiceHost(typeof(UserService));
            product.Open();
            category.Open();
            user.Open();
            lblstatus.Text = "ss";
            
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            product.Close();
            category.Close();
            user.Close();
            lblstatus.Text = "stopped";
        }

    }
}
