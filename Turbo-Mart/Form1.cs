using System.Data;
using Turbo_Mart.Data;
using Turbo_Mart.Model;

namespace Turbo_Mart
{
    public partial class Form1 : Form
    {
        //private readonly AppDbContext db;
        public Form1()
        {
            InitializeComponent();
            PopulateComboBox();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            AppDbContext db =new AppDbContext();
            var categories = db.Categories.ToArray();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = productname_txt.Text;
            product.Price = float.Parse(price_txt.Text);
            product.BatchNumber = batch_txt.Text;
            product.CategoryId = Convert.ToInt32(category_cb.SelectedValue);

            AppDbContext db = new AppDbContext();

            db.Products.Add(product);

            db.SaveChanges();


        }

        private void PopulateComboBox()
        {
            AppDbContext db = new AppDbContext();
            var categories = db.Categories.ToArray();

            category_cb.DataSource = categories;
            category_cb.DisplayMember = "CategoryName";
            category_cb.ValueMember = "Id";

            var name = "test";

        }
    }
}

