using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Factory
{
    public partial class MainForm : Form
    {

        BindingList<Product> lstProducts = new BindingList<Product>();
        BindingList<Machine> lstMachines = new BindingList<Machine>();
        List<Treatment> treatmentlijstje = new List<Treatment>();
        List<List<string>> lstTreatments = new List<List<string>>();
        char ProductType = 'A';
     

        public MainForm()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Product.ProductBacklog.CollectionChanged += ProductBacklog_CollectionChanged; // ProductBacklog_CollectionChanged;
            Product.ProductBacklog.CollectionChanged += (s,eeeee)=>{ this.Invoke(new Action(() => {
                productBox.DataSource = null;
                //productBox.DataSource = Product.ProductBacklog.Where(x=>x.GetTreatments().Any()).ToList();
                })); };
         
            
            
            //new Thread(new ThreadStart(main)).Start();
            LboxMachines.DataSource = lstMachines;
            LboxMachines.DisplayMember = nameof(Machine.StatusString);

      


            //Add new products, as an istance of the class product, to the list of products
            //Product.ProductBacklog.Add(new Product("Bas Oenema", 'A', 3, true));
            //Product.ProductBacklog.Add(new Product("Emiel Brommer", 'C', 0, false));
            //Product.ProductBacklog.Add(new Product("Willem Fikkert", 'A', 2, false));
            //Product.ProductBacklog.Add(new Product("Arnout van der Ploeg", 'B', 4, false));
            //Product.ProductBacklog.Add(new Product("Thom Verwater", 'B', 4, true));
            //Product.ProductBacklog.Add(new Product("Kevin Schipper", 'C', 1, true));

            //Treatment inf = new Treatment("Infinity1") {
            //    new Treatment("Infinity2") {
            //         new Treatment("Infinity3") {
            // }}};
            //inf.First().First().Add(inf);
            //Product.ProductBacklog.Add(new Product("∞",inf));
            //Product.ProductBacklog.Add(new Product("Leon Kristiaan",
            //    new Treatment("Driehoeken") {
            //        new Treatment("Drill") {
            //            new Treatment("Deburr")
            //        },
            //        new Treatment("Drill") ,
            //        new Treatment("Drill") ,
            //        new Treatment("Drill") ,
            //        new Treatment("Drill") ,
            //    }));

            //Add new machine, as an instance of the class Machine, for each machine in the factory           
            foreach (Productiecel pc in SplitProductionReady.Panel1.Controls.OfType<Productiecel>())
            {
                Machine m = new Machine(pc.Name, pc.ProductionCellFunction);
                lstMachines.Add(m);
                pc.SetMachine(m);
            }
        }

     

        private void ProductBacklog_CollectionChanged(object sender,
            NotifyCollectionChangedEventArgs e)
        {
           
              switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach(Product a in e.NewItems)
                    {
                       Program.MainForm.Invoke(
                            new Action(() =>
                            {
                                
                                ProductCarrier targetCarrier= new ProductCarrier(a);
                                ProductCarrier tooRemoveCarrier = SplitProductionReady.Panel1.Controls.OfType<ProductCarrier>().Where(x => x.CarrierProduct == targetCarrier.CarrierProduct).FirstOrDefault();
                                if (tooRemoveCarrier != null)
                                    SplitProductionReady.Panel1.Controls.Remove(tooRemoveCarrier);
                                //If the product is fully produced, the product will go to ready   
                                if (a.GetTreatmentsList().Count == 0)
                                    ReadyPanel.Controls.Add(targetCarrier);
                                
                                else
                                    QueuePanel.Controls.Add(targetCarrier);
                               
                            }));
                        
                    };
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach(Product b in e.OldItems)
                    {
                        Program.MainForm.Invoke(
                            new Action(() =>
                            {
                                ProductCarrier producedCarrier;
                                ProductCarrier targetCarrier = new ProductCarrier(b);
                                QueuePanel.Controls.Remove(producedCarrier = QueuePanel.Controls.OfType<ProductCarrier>().Where(x => x.CarrierProduct == targetCarrier.CarrierProduct).First());
                                Productiecel targetProductioncell = SplitProductionReady.Panel1.Controls.OfType<Productiecel>().Where(x => x.GetMachine().CurrentProduct == b).First();
                                producedCarrier.Location = new Point(targetProductioncell.Location.X + 15, targetProductioncell.Location.Y+135);
                                SplitProductionReady.Panel1.Controls.Add(producedCarrier);
                            }));
                    }
                    break;
            }
            //throw new Exception("Something happend");
        }

        //Main
        public static void main()
        {
          
        }

        //Add a product to the productbacklogg
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //bool doubleChecker;
            //doubleChecker = false;

            //foreach (Product p in Product.ProductBacklog)
            //{
            //    if (txtProductName.Text == p.orderName)
            //    {
            //        doubleChecker = true;
            //    }
            //}
            //if (doubleChecker)
            //{
            //    MessageBox.Show(txtProductName.Text + "bestaat al, verzin een andere naam ");
            //}
            //else
           // {
                Product.ProductBacklog.Add(new Product(txtProductName.Text, ProductType, Convert.ToInt32(nmbrOfHoles.Value), chckbxDeburr.Checked));
            //}

        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if(sender == btnTypeA)
                ProductType = 'A';
            if (sender == btnTypeB)
                ProductType = 'B';
            if (sender == btnTypeC)
                ProductType = 'C';
            if (sender == btnTypeD)
                ProductType = 'D';
            //reset all button colors.
            btnTypeA.BackColor = btnTypeB.BackColor = btnTypeC.BackColor = btnTypeD.BackColor = Color.Transparent;
            //change the color of the button that got clicked.
            ((Button)sender).BackColor = Color.CadetBlue;
        }

        private void lblConfigProduct_Click(object sender, EventArgs e)
        {
            chckbxDeburr.Text += "r";
        }

        private void ReadyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbxAllProductsAdded_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
