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
        int Adder = 1;
        ///The treatment the machine can handle

        public int MaxProgress { get => _MaxProgress; }
        int _MaxProgress;
        public int CurrentProgress { get => _CurrentProgress; }
        int _CurrentProgress;


        Product _CurrentProduct;

        public Product CurrentProduct { get => _CurrentProduct; }

        public string treatmentMachine;
        private Task<Task> _MachineTask;
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

        public void TurnOff()
        {
            _Enabled = false;
            if (State == MachineState.Idle)
                State = MachineState.Idle;
            else            
                State = MachineState.Paused;
            
           
        }
        public void TurnOn()
        {
            _Enabled = true;
            State = MachineState.RequestingProduct;
        }
        bool _Enabled = true;

        /// <summary>
        /// Machine Constructor
        /// </summary>
        /// <param name="_name">Name of this machine</param>
        /// <param name="_treatmentsMachine">the treatment this machine can complete</param>
        public Machine(string _name, string _treatmentsMachine)
        {
            name = _name;
            treatmentMachine = _treatmentsMachine;
            _MachineTask = Task.Factory.StartNew(MachineTask);//starts the machine.
        }
        /// <summary>
        /// The task representing the machines activities.
        /// </summary>
        /// <returns></returns>
        public async Task MachineTask()
        {
            while (true)
            {
                
                if (!_Enabled)
                {
                    //State = MachineState.Idle;
                    await Task.Delay(1000);
                    continue;
                }
                    State = MachineState.RequestingProduct;

                //find a product to treat.
                lock (Product.ProductBacklog)//this means no other thread/task can enter any section of code that also locks the object in the lock statement.
                {
                    //because of the lock, its impossible for 2 machines to pick the same product.
                    //gets a product from the list of products to treat which has the same treatment in the list as the treatment of the machine
                    _CurrentProduct = Product.ProductBacklog.FirstOrDefault(x => x.GetTreatments().Contains(treatmentMachine));
                    //removes this product from the list

                    Product.ProductBacklog.Remove(_CurrentProduct);

                }
                if (_CurrentProduct != null)
                {
                    //treat
                    Console.WriteLine($"Treatment:{treatmentMachine} is done by: {name} at the product of {_CurrentProduct}");
                    //Sets the state of the machine to working, changes the color of the machine
                    State = MachineState.Working;
                    //Drilling gives a longer delay
                    if(treatmentMachine == "Drill")
                       Adder = (_CurrentProduct.amountHoles*200);
                    _MaxProgress =  5000 + Adder;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MaxProgress)));
                    for (; _CurrentProgress < _MaxProgress; _CurrentProgress += 100)
                    {
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentProgress)));
                        await Task.Delay(100);
                        while (!_Enabled)
                        {
                            await Task.Delay(1000);
                            //_CurrentProduct = null;
                            //_CurrentProgress = 0;
                            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentProgress)));
                            //break;
                        }
                    }
                    if (_CurrentProduct == null)
                        continue;

                    _CurrentProgress = 0;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentProgress)));


                    //removes the treatment of the machine from the list of treatments of the product
                    _CurrentProduct.Treat(treatmentMachine);
                    //return product to backlog
                    lock (Product.ProductBacklog)
                    {
                        Product.ProductBacklog.Add(_CurrentProduct);
                        _CurrentProduct = null;
                    }
                }
                else
                {
                    //wait for more products to arrive or become available.
                    State = MachineState.Idle;
                    await Task.Delay(1000);
                }
            }
        }

        public string StatusString => $"{name} : {Enum.GetName(typeof(MachineState), State)} p: {_CurrentProduct?.orderName ?? "none"}";
    }
}
