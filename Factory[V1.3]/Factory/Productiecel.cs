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

        private void MachineStateChanged(object sender, PropertyChangedEventArgs e)
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new Action(()=>MachineStateChanged(sender, e)));
            }
            if (e.PropertyName != nameof(Machine.State)) return;
            switch (_Machine.State)
            {
                case MachineState.Idle:
                    BackColor = Color.LightGray;
                    break;
                case MachineState.Paused:
                    BackColor = Color.LightSkyBlue;
                    break;
                case MachineState.RequestingProduct:
                    BackColor = Color.Turquoise;
                    break;
                case MachineState.Working:
                    BackColor = Color.LightGreen;
                    break;                                     
            }
            Invalidate();
        }

        public Productiecel()
        {
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
    }
}
