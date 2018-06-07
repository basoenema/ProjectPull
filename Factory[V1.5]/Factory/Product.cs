using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Product 
    {
        public static ObservableCollection<Product> ProductBacklog = new ObservableCollection<Product>();
      //  public event PropertyChangedEventHandler PropertyChanged;
   

        //Product Atributes
        public string orderName;
        public char productType;
        public int amountHoles = 0;
        public bool deburr = false;
        private List<Treatment> _requiredTreatments = new List<Treatment>();
        //Product Constructor
        public Product(string _orderName, char _productType, int _amountHoles, bool _deburr)
        {
            orderName = _orderName;
            productType = _productType;
            amountHoles = _amountHoles;
            deburr = _deburr;

            //keep your if statments simple! no if else if else chains, its spaggeti.
            _requiredTreatments.Add(new Treatment("Saw"));
            if (amountHoles > 0)
                _requiredTreatments.Add(new Treatment("Drill"));
            if (deburr)
                _requiredTreatments.Add(new Treatment("Deburr"));
        }

        public Product(string _orderName, IEnumerable<Treatment> treatments)
        {
            orderName = _orderName;
            _requiredTreatments = treatments.ToList();
        }

        public void Treat(Treatment treatment)
        {
        }


       public void Treat(string treatment)
        {
            foreach(Treatment t in _requiredTreatments.Where(x=>x.Name==treatment).ToArray())
            {
                //Remove the treatment of the machine from the product treatments
                _requiredTreatments.Remove(t);
                _requiredTreatments.AddRange(t.After);
            }

            //If there are no treatments in the list of treatments of the product
            if (!_requiredTreatments.Any())
            {
                //finished
                Console.WriteLine($"product:{this} was finished!");
            }
        }
        public override string ToString()
        {
            return orderName;
        }

        //Returns private list treatments, needed for productcarrier.
        public List<Treatment> GetTreatmentsList()
        {
            return _requiredTreatments;
        }

        //Product Methods
        //R
        /// <summary>
        /// Ienumerable showing what treatments this product needs. 
        /// its made a read only collection to prevent others from changing it. Otherwise other objects might empty the list, 
        /// and the product would not realise it was finished.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetTreatments() => _requiredTreatments.Select(x=>x.Name);

    }
}
