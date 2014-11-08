using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//import sa KoalaShopLip
using KoalaShopLib;
using KoalaShopLib.Models;
namespace Demo
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();

            //pag kuha ug data gkan sa database, ena ani ni xa para makasabot mo
            //mag using para automatic dispose sa resources
            //in ani mg initialize sa koala shop
            using (IKoalaShop koalaShop =  KoalaShopFactory.CreateKoalaShop())
            {
                //mag kuha tag records gkan database
                this.dataGridView1.DataSource = koalaShop.CategoryRepo.GetAll();
            }

        }
    }
}
