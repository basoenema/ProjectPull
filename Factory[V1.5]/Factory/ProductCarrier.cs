using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Factory
{
    public partial class ProductCarrier : UserControl
    {
        List<Treatment> productCarrierTreatments = new List<Treatment>();
        List<ProductCarrier> allProductCarriers = new List<ProductCarrier>();
        List<Treatment> treatmentlijstje = new List<Treatment>();

        public string ProductCarrierName
        {
            get { return LblProductName.Text; }
            set { LblProductName.Text = value; }
        }

        public Product CarrierProduct { get; internal set; }

        public ProductCarrier(Product productToProductCarrier)
        {
            InitializeComponent();
            foreach (Treatment t in productToProductCarrier.GetTreatmentsList())
            {
                ListBoxPendingTreatments.Items.Add(t.Name);
            }
            CarrierProduct = productToProductCarrier;
            LblProductName.Text = productToProductCarrier.orderName;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblProductName_Click(object sender, EventArgs e)
        {

        }
    }
}
