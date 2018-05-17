namespace Factory
{
    partial class Productiecel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PnlInput = new System.Windows.Forms.Panel();
            this.PnlOutput = new System.Windows.Forms.Panel();
            this.LblCellFunction = new System.Windows.Forms.Label();
            this.LblCellState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(78, 104);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(95, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // PnlInput
            // 
            this.PnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlInput.Location = new System.Drawing.Point(3, 4);
            this.PnlInput.Name = "PnlInput";
            this.PnlInput.Size = new System.Drawing.Size(67, 123);
            this.PnlInput.TabIndex = 2;
            this.PnlInput.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintArrow);
            // 
            // PnlOutput
            // 
            this.PnlOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlOutput.Location = new System.Drawing.Point(180, 4);
            this.PnlOutput.Name = "PnlOutput";
            this.PnlOutput.Size = new System.Drawing.Size(67, 123);
            this.PnlOutput.TabIndex = 3;
            this.PnlOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintArrow);
            // 
            // LblCellFunction
            // 
            this.LblCellFunction.BackColor = System.Drawing.Color.Transparent;
            this.LblCellFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblCellFunction.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCellFunction.Location = new System.Drawing.Point(0, 0);
            this.LblCellFunction.Name = "LblCellFunction";
            this.LblCellFunction.Size = new System.Drawing.Size(250, 19);
            this.LblCellFunction.TabIndex = 1;
            this.LblCellFunction.Text = "LblCellName";
            this.LblCellFunction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblCellFunction.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblCellState
            // 
            this.LblCellState.BackColor = System.Drawing.Color.Transparent;
            this.LblCellState.Location = new System.Drawing.Point(84, 23);
            this.LblCellState.MinimumSize = new System.Drawing.Size(83, 17);
            this.LblCellState.Name = "LblCellState";
            this.LblCellState.Size = new System.Drawing.Size(83, 17);
            this.LblCellState.TabIndex = 4;
            this.LblCellState.Text = "LblCellState";
            this.LblCellState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Productiecel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.PnlOutput);
            this.Controls.Add(this.LblCellState);
            this.Controls.Add(this.PnlInput);
            this.Controls.Add(this.LblCellFunction);
            this.Controls.Add(this.progressBar1);
            this.MaximumSize = new System.Drawing.Size(250, 130);
            this.MinimumSize = new System.Drawing.Size(250, 130);
            this.Name = "Productiecel";
            this.Size = new System.Drawing.Size(250, 130);
            this.Load += new System.EventHandler(this.Productiecel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel PnlInput;
        private System.Windows.Forms.Panel PnlOutput;
        private System.Windows.Forms.Label LblCellFunction;
        private System.Windows.Forms.Label LblCellState;
    }
}
