using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class ProductCarrier : UserControl
    {
        public string ProductCarrierName
        {
            get { return LblProductName.Text; }
            set { LblProductName.Text = value; }
        }
   


        public ProductCarrier(string _productCarrierName)
        {
            InitializeComponent();
            LblProductName.Text = _productCarrierName;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
