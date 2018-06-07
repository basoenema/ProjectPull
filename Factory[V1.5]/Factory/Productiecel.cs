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
    public partial class Productiecel : UserControl
    {
        public string ProductionCellFunction {
            get { return LblCellFunction.Text; }
            set { LblCellFunction.Text = value; }
        }
        
        string _productionCellState;
        
        public string ProductionCellState
        {
            get { return _productionCellState; }
            set {
                _productionCellState = value;
                LblCellState.Text = value; }
        }
        public int ProductionCellProces { get; set; }
        public bool Available;
        private Machine _Machine;
       

        public void SetMachine(Machine m)
        {
            if(_Machine != null)
                 _Machine.PropertyChanged -= MachineStateChanged;
            _Machine = m;
            if (m == null) return;
                 _Machine.PropertyChanged += MachineStateChanged;
        }

        public Machine GetMachine()
        {
            return _Machine;
        }

        private void MachineStateChanged(object sender, PropertyChangedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => MachineStateChanged(sender, e)));
                return;
            }
            switch (e.PropertyName)
            {
                case nameof(_Machine.State):
                    switch (_Machine.State)
                    {
                        case MachineState.Idle:
                            BackColor = Color.LightGray;
                            LblCellState.Text = "Idle";
                            break;
                        case MachineState.Paused:
                            BackColor = Color.LightSkyBlue;
                            LblCellState.Text = "Paused";
                            break;
                        case MachineState.RequestingProduct:
                            BackColor = Color.Turquoise;
                            LblCellState.Text = "Request for Products";
                            break;
                        case MachineState.Working:
                            BackColor = Color.LightGreen;
                            LblCellState.Text = "In progress";
                            break;
                    }
                    break;
                case nameof(_Machine.CurrentProgress):
                    progressBar1.Value = _Machine.CurrentProgress;
                    //This is to make the progress bar update instantly instead of smoothly scrolling.
                    if (progressBar1.Value == 0)
                        progressBar1.Value++;
                    progressBar1.Value--;
                    progressBar1.Value++;
                    break;
                case nameof(_Machine.MaxProgress):
                    progressBar1.Maximum = _Machine.MaxProgress;

                    break;
        }
            Invalidate();
        }

        public Productiecel()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PaintArrow(object sender, PaintEventArgs e)
        {
            Control senderPanel = (Control)sender;

            e.Graphics.DrawLine(Pens.Black,
                new Point(0, senderPanel.Height / 2),
                new Point(senderPanel.Width, senderPanel.Height / 2)
                );
            e.Graphics.DrawLine(Pens.Black,
                new Point(senderPanel.Width, senderPanel.Height / 2),
                new Point(senderPanel.Width - 20, senderPanel.Height / 2 - 20)
                );
            e.Graphics.DrawLine(Pens.Black,
                new Point(senderPanel.Width, senderPanel.Height / 2),
                new Point(senderPanel.Width - 20, senderPanel.Height / 2 + 20)

                );
        }

        private void Productiecel_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnOn_Click(object sender, EventArgs e)
        {
            _Machine.TurnOn();
            if (_Machine.CurrentProduct != null)
                _Machine.State = MachineState.Working;
            
        }

        private void BtnOff_Click(object sender, EventArgs e)
        {
            _Machine.TurnOff();
            
            //Parent.Controls.Remove(Parent.Controls.OfType<ProductCarrier>().Where(x => x.CarrierProduct == _Machine.CurrentProduct).FirstOrDefault());
        }
    }
}
