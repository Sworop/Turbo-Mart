using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Cms;
using Turbo_Mart.Data;
using Turbo_Mart.Model;

namespace Turbo_Mart
{
    public partial class AddCategoryForm : Form
    {
        private readonly AppDbContext db;

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void batch_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=productname_txt.Text;


            db.Categories.Add(category);
            db.SaveChanges();
        }
    }
}
