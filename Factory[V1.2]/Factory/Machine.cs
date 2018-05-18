using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public enum MachineState { Idle,Working,Paused,RequestingProduct }
    public class Machine : INotifyPropertyChanged
    {
        //Machine Atributes
        public string name;
        ///The treatment the machine can handle

        Product _currProduct;

        public string treatmentMachine;
        public bool available = true;

        public MachineState State { get { return _state; } set { _state = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(State)));
            //invokes on the form thread, allowing it to actually draw the change. 
            Program.MainForm.Invoke(
                    //tells any collections cointaining this object that a property has changed, and should respond to it if it has that property visible.
                    new Action(() => { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusString))); }));
                    } }
        private MachineState _state;
        
        public event PropertyChangedEventHandler PropertyChanged;

        


        /// <summary>
        /// Machine Constructor
        /// </summary>
        /// <param name="_name">Name of this machine</param>
        /// <param name="_treatmentsMachine">the treatment this machine can complete</param>
        public Machine(string _name, string _treatmentsMachine)
        {
            name = _name;
            treatmentMachine = _treatmentsMachine;
            Task.Factory.StartNew(MachineTask);//starts the machine.
        }
        /// <summary>
        /// The task representing the machines activities.
        /// </summary>
        /// <returns></returns>
        public async Task MachineTask()
        {
            while (true)
            {
                State = MachineState.RequestingProduct;

                //find a product to treat.
                lock (Product.ProductBacklog)//this means no other thread/task can enter any section of code that also locks the object in the lock statement.
                { 
                    //because of the lock, its impossible for 2 machines to pick the same product.
                    _currProduct = Product.ProductBacklog.FirstOrDefault(x => x.GetTreatments().Contains(treatmentMachine));
                        Product.ProductBacklog.Remove(_currProduct);
                }
                if (_currProduct != null)
                {
                    //treat
                    Console.WriteLine($"Treatment:{treatmentMachine} is done by: {name} at the product of {_currProduct}");
                    State = MachineState.Working;
                    await Task.Delay(2500);//waits for a second.
                    _currProduct.Treat(treatmentMachine);
                    //return product to backlog
                    lock (Product.ProductBacklog)
                    {
                        Product.ProductBacklog.Add(_currProduct);
                        _currProduct = null;
                    }
                }
                else
                {
                    //wait for more products to arrive or become available.
                    await Task.Delay(1000);
                    State = MachineState.Idle;
                }
            }
        }

        public string StatusString => $"{name} : {Enum.GetName(typeof(MachineState), State)} p: {_currProduct?.orderName ?? "none"}";
    }
}
