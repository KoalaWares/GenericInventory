using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KoalaShopLib;
namespace Demo
{
    public partial class ProductForm : Form
    {
        //DECLARE Fields and Properties before Constructor declaration
        //SET ALL private fields as NULL , empty for string, 0 for numeric types
        //Remember, PUBLIC FIELDS are BAAAAAD! according to Joe 
        IKoalaShop koalaShop = null;

        //Sa Contructor ta mag set sa values sa ato fields ug properties
        public ProductForm()
        {
            InitializeComponent();
            //Use this. keyword to access all members(method,property,field) within class.
            //Gagama kog DALFactory para dli ma expose ang DALController nga class sa View
            //layer para masunud nato ang Abstraction,
            this.koalaShop = KoalaShopFactory.CreateKoalaShop();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void AddProductTSMItem_Click(object sender, EventArgs e)
        {
            ProductDetailsForm form = new ProductDetailsForm();
            form.ShowDialog();
            this.RefreshDataGrid();
        }

        //Since gamitun ni xa sa pag load sa form, ge stub out na nko xa as method/
        void RefreshDataGrid()
        {
            this.dataGridView1.DataSource = this.koalaShop.ProductController.GetAllProductViews();
        }
    }
}
