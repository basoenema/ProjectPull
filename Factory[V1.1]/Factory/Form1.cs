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
using System.Windows.Forms;


namespace Factory
{
    public partial class Form1 : Form
    {
        BindingList<Product> lstProducts = new BindingList<Product>();
        BindingList<Machine> lstMachines = new BindingList<Machine>();
        List<List<string>> lstTreatments = new List<List<string>>();
        char ProductType = 'A';
        //Thread t = new Thread(Main);

        public Form1()
        {
            Console.WriteLine("Hi");
            InitializeComponent();
            //t.Start();
          

            //Paint += Form1_Paint;
            //this.Invalidate(); //this is how you make the paint event go.
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    //e.Graphics is what you use to paint things.
        //    e.Graphics.FillRectangle(Brushes.Red, new RectangleF( new PointF(0, 0), new SizeF(100,100)));
        //}


        //public static void Main()
        //{
        //    foreach (Product p in Product.ProductBacklog)
        //    {
                
        //    }
        //}
        public void Form1_Load(object sender, EventArgs e)
        {
            Product.ProductBacklog.CollectionChanged += ProductBacklog_CollectionChanged;
                
         
            
            
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
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach(Product a in e.NewItems)
                    {
                        Program.MainForm.Invoke(
                            new Action(() =>
                            {
                                QueuePanel.Controls.Add(
                                    new ProductCarrier(a.orderName));  }));
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach(Product b in e.OldItems)
                    {
                        Program.MainForm.Invoke(
                            new Action(() =>
                            {
                                QueuePanel.Controls.Remove(
                                    new ProductCarrier(b.orderName));   }));
                    }
                    break;
            }
            //throw new Exception("Something happend");
        }

        //Main
        public static void main()
        {
          
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product.ProductBacklog.Add(new Product(txtProductName.Text, ProductType, Convert.ToInt32(nmbrOfHoles.Value) , chckbxDeburr.ThreeState));
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

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void ProductionCellA_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void QueuePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductionCellB_Load(object sender, EventArgs e)
        {

        }
    }
}
