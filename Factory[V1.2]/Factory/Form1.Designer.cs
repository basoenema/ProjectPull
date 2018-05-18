namespace Factory
{

    
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LboxMachines = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabProduction = new System.Windows.Forms.TabPage();
            this.TabAddProduct = new System.Windows.Forms.TabPage();
            this.lblSelectedType = new System.Windows.Forms.Label();
            this.txtbxSelectedType = new System.Windows.Forms.TextBox();
            this.lblAllProductsAdded = new System.Windows.Forms.Label();
            this.txtbxAllProductsAdded = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.chckbxDeburr = new System.Windows.Forms.CheckBox();
            this.nmbrOfHoles = new System.Windows.Forms.NumericUpDown();
            this.lblAmountOfHoles = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.lblConfigProduct = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.btnTypeD = new System.Windows.Forms.Button();
            this.btnTypeC = new System.Windows.Forms.Button();
            this.btnTypeB = new System.Windows.Forms.Button();
            this.btnTypeA = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SplitQueueSP = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.QueuePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SplitProductionReady = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductionCellB = new Factory.Productiecel();
            this.ProductionCellD = new Factory.Productiecel();
            this.ProductionCellE = new Factory.Productiecel();
            this.ProductionCellF = new Factory.Productiecel();
            this.ProductionCellC = new Factory.Productiecel();
            this.ProductionCellA = new Factory.Productiecel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabProduction.SuspendLayout();
            this.TabAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrOfHoles)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitQueueSP)).BeginInit();
            this.SplitQueueSP.Panel1.SuspendLayout();
            this.SplitQueueSP.Panel2.SuspendLayout();
            this.SplitQueueSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitProductionReady)).BeginInit();
            this.SplitProductionReady.Panel1.SuspendLayout();
            this.SplitProductionReady.Panel2.SuspendLayout();
            this.SplitProductionReady.SuspendLayout();
            this.SuspendLayout();
            // 
            // LboxMachines
            // 
            this.LboxMachines.FormattingEnabled = true;
            this.LboxMachines.ItemHeight = 16;
            this.LboxMachines.Location = new System.Drawing.Point(6, 6);
            this.LboxMachines.Name = "LboxMachines";
            this.LboxMachines.Size = new System.Drawing.Size(891, 484);
            this.LboxMachines.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Machines";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabProduction);
            this.tabControl1.Controls.Add(this.TabAddProduct);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1332, 861);
            this.tabControl1.TabIndex = 2;
            // 
            // TabProduction
            // 
            this.TabProduction.Controls.Add(this.LboxMachines);
            this.TabProduction.Location = new System.Drawing.Point(4, 25);
            this.TabProduction.Name = "TabProduction";
            this.TabProduction.Padding = new System.Windows.Forms.Padding(3);
            this.TabProduction.Size = new System.Drawing.Size(1324, 832);
            this.TabProduction.TabIndex = 0;
            this.TabProduction.Text = "Production";
            this.TabProduction.UseVisualStyleBackColor = true;
            this.TabProduction.Click += new System.EventHandler(this.TabProduction_Click);
            // 
            // TabAddProduct
            // 
            this.TabAddProduct.Controls.Add(this.lblSelectedType);
            this.TabAddProduct.Controls.Add(this.txtbxSelectedType);
            this.TabAddProduct.Controls.Add(this.lblAllProductsAdded);
            this.TabAddProduct.Controls.Add(this.txtbxAllProductsAdded);
            this.TabAddProduct.Controls.Add(this.btnAddProduct);
            this.TabAddProduct.Controls.Add(this.chckbxDeburr);
            this.TabAddProduct.Controls.Add(this.nmbrOfHoles);
            this.TabAddProduct.Controls.Add(this.lblAmountOfHoles);
            this.TabAddProduct.Controls.Add(this.lblProductName);
            this.TabAddProduct.Controls.Add(this.txtProductName);
            this.TabAddProduct.Controls.Add(this.lblAddProduct);
            this.TabAddProduct.Controls.Add(this.lblConfigProduct);
            this.TabAddProduct.Controls.Add(this.lblProductType);
            this.TabAddProduct.Controls.Add(this.btnTypeD);
            this.TabAddProduct.Controls.Add(this.btnTypeC);
            this.TabAddProduct.Controls.Add(this.btnTypeB);
            this.TabAddProduct.Controls.Add(this.btnTypeA);
            this.TabAddProduct.Location = new System.Drawing.Point(4, 25);
            this.TabAddProduct.Name = "TabAddProduct";
            this.TabAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.TabAddProduct.Size = new System.Drawing.Size(1324, 832);
            this.TabAddProduct.TabIndex = 1;
            this.TabAddProduct.Text = "Add product";
            this.TabAddProduct.UseVisualStyleBackColor = true;
            // 
            // lblSelectedType
            // 
            this.lblSelectedType.AutoSize = true;
            this.lblSelectedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedType.Location = new System.Drawing.Point(342, 164);
            this.lblSelectedType.Name = "lblSelectedType";
            this.lblSelectedType.Size = new System.Drawing.Size(114, 18);
            this.lblSelectedType.TabIndex = 15;
            this.lblSelectedType.Text = "Selected Type";
            // 
            // txtbxSelectedType
            // 
            this.txtbxSelectedType.Location = new System.Drawing.Point(485, 162);
            this.txtbxSelectedType.Name = "txtbxSelectedType";
            this.txtbxSelectedType.ReadOnly = true;
            this.txtbxSelectedType.Size = new System.Drawing.Size(150, 22);
            this.txtbxSelectedType.TabIndex = 14;
            // 
            // lblAllProductsAdded
            // 
            this.lblAllProductsAdded.AutoSize = true;
            this.lblAllProductsAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllProductsAdded.Location = new System.Drawing.Point(709, 30);
            this.lblAllProductsAdded.Name = "lblAllProductsAdded";
            this.lblAllProductsAdded.Size = new System.Drawing.Size(97, 25);
            this.lblAllProductsAdded.TabIndex = 13;
            this.lblAllProductsAdded.Text = "Products";
            // 
            // txtbxAllProductsAdded
            // 
            this.txtbxAllProductsAdded.Location = new System.Drawing.Point(664, 54);
            this.txtbxAllProductsAdded.Multiline = true;
            this.txtbxAllProductsAdded.Name = "txtbxAllProductsAdded";
            this.txtbxAllProductsAdded.Size = new System.Drawing.Size(184, 308);
            this.txtbxAllProductsAdded.TabIndex = 12;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(485, 322);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(115, 40);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // chckbxDeburr
            // 
            this.chckbxDeburr.AutoSize = true;
            this.chckbxDeburr.Location = new System.Drawing.Point(485, 125);
            this.chckbxDeburr.Name = "chckbxDeburr";
            this.chckbxDeburr.Size = new System.Drawing.Size(74, 21);
            this.chckbxDeburr.TabIndex = 10;
            this.chckbxDeburr.Text = "Deburr";
            this.chckbxDeburr.UseVisualStyleBackColor = true;
            // 
            // nmbrOfHoles
            // 
            this.nmbrOfHoles.Location = new System.Drawing.Point(485, 91);
            this.nmbrOfHoles.Name = "nmbrOfHoles";
            this.nmbrOfHoles.Size = new System.Drawing.Size(120, 22);
            this.nmbrOfHoles.TabIndex = 9;
            // 
            // lblAmountOfHoles
            // 
            this.lblAmountOfHoles.AutoSize = true;
            this.lblAmountOfHoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfHoles.Location = new System.Drawing.Point(342, 92);
            this.lblAmountOfHoles.Name = "lblAmountOfHoles";
            this.lblAmountOfHoles.Size = new System.Drawing.Size(131, 18);
            this.lblAmountOfHoles.TabIndex = 8;
            this.lblAmountOfHoles.Text = "Amount of holes";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(342, 56);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(52, 18);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(485, 54);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 22);
            this.txtProductName.TabIndex = 5;
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(390, 287);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(155, 25);
            this.lblAddProduct.TabIndex = 4;
            this.lblAddProduct.Text = "3. Add Product";
            // 
            // lblConfigProduct
            // 
            this.lblConfigProduct.AutoSize = true;
            this.lblConfigProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigProduct.Location = new System.Drawing.Point(390, 30);
            this.lblConfigProduct.Name = "lblConfigProduct";
            this.lblConfigProduct.Size = new System.Drawing.Size(208, 25);
            this.lblConfigProduct.TabIndex = 4;
            this.lblConfigProduct.Text = "2. Configure product";
            this.lblConfigProduct.Click += new System.EventHandler(this.lblConfigProduct_Click);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(67, 30);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(222, 25);
            this.lblProductType.TabIndex = 4;
            this.lblProductType.Text = "1. Select product type";
            // 
            // btnTypeD
            // 
            this.btnTypeD.Location = new System.Drawing.Point(168, 212);
            this.btnTypeD.Name = "btnTypeD";
            this.btnTypeD.Size = new System.Drawing.Size(150, 150);
            this.btnTypeD.TabIndex = 3;
            this.btnTypeD.Text = "Type D";
            this.btnTypeD.UseVisualStyleBackColor = true;
            this.btnTypeD.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // btnTypeC
            // 
            this.btnTypeC.Location = new System.Drawing.Point(12, 212);
            this.btnTypeC.Name = "btnTypeC";
            this.btnTypeC.Size = new System.Drawing.Size(150, 150);
            this.btnTypeC.TabIndex = 2;
            this.btnTypeC.Text = "Type C";
            this.btnTypeC.UseVisualStyleBackColor = true;
            this.btnTypeC.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // btnTypeB
            // 
            this.btnTypeB.Location = new System.Drawing.Point(168, 56);
            this.btnTypeB.Name = "btnTypeB";
            this.btnTypeB.Size = new System.Drawing.Size(150, 150);
            this.btnTypeB.TabIndex = 1;
            this.btnTypeB.Text = "Type B";
            this.btnTypeB.UseVisualStyleBackColor = true;
            this.btnTypeB.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // btnTypeA
            // 
            this.btnTypeA.Location = new System.Drawing.Point(12, 56);
            this.btnTypeA.Name = "btnTypeA";
            this.btnTypeA.Size = new System.Drawing.Size(150, 150);
            this.btnTypeA.TabIndex = 0;
            this.btnTypeA.Text = "Type A";
            this.btnTypeA.UseVisualStyleBackColor = true;
            this.btnTypeA.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SplitQueueSP);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1324, 832);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SplitQueueSP
            // 
            this.SplitQueueSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitQueueSP.Location = new System.Drawing.Point(3, 3);
            this.SplitQueueSP.Name = "SplitQueueSP";
            // 
            // SplitQueueSP.Panel1
            // 
            this.SplitQueueSP.Panel1.Controls.Add(this.label4);
            this.SplitQueueSP.Panel1.Controls.Add(this.QueuePanel);
            // 
            // SplitQueueSP.Panel2
            // 
            this.SplitQueueSP.Panel2.Controls.Add(this.SplitProductionReady);
            this.SplitQueueSP.Size = new System.Drawing.Size(1318, 826);
            this.SplitQueueSP.SplitterDistance = 282;
            this.SplitQueueSP.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(79, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Queue";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // QueuePanel
            // 
            this.QueuePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueuePanel.Location = new System.Drawing.Point(-1, 88);
            this.QueuePanel.Name = "QueuePanel";
            this.QueuePanel.Size = new System.Drawing.Size(289, 738);
            this.QueuePanel.TabIndex = 11;
            this.QueuePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.QueuePanel_Paint);
            // 
            // SplitProductionReady
            // 
            this.SplitProductionReady.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitProductionReady.Location = new System.Drawing.Point(0, 0);
            this.SplitProductionReady.Name = "SplitProductionReady";
            // 
            // SplitProductionReady.Panel1
            // 
            this.SplitProductionReady.Panel1.Controls.Add(this.label1);
            this.SplitProductionReady.Panel1.Controls.Add(this.ProductionCellB);
            this.SplitProductionReady.Panel1.Controls.Add(this.ProductionCellD);
            this.SplitProductionReady.Panel1.Controls.Add(this.ProductionCellE);
            this.SplitProductionReady.Panel1.Controls.Add(this.ProductionCellF);
            this.SplitProductionReady.Panel1.Controls.Add(this.ProductionCellC);
            this.SplitProductionReady.Panel1.Controls.Add(this.ProductionCellA);
            // 
            // SplitProductionReady.Panel2
            // 
            this.SplitProductionReady.Panel2.Controls.Add(this.label3);
            this.SplitProductionReady.Size = new System.Drawing.Size(1032, 826);
            this.SplitProductionReady.SplitterDistance = 763;
            this.SplitProductionReady.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Production";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductionCellB
            // 
            this.ProductionCellB.BackColor = System.Drawing.Color.SkyBlue;
            this.ProductionCellB.Location = new System.Drawing.Point(446, 97);
            this.ProductionCellB.MaximumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellB.MinimumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellB.Name = "ProductionCellB";
            this.ProductionCellB.ProductionCellFunction = "Deburr";
            this.ProductionCellB.ProductionCellProces = 0;
            this.ProductionCellB.ProductionCellState = "";
            this.ProductionCellB.Size = new System.Drawing.Size(250, 130);
            this.ProductionCellB.TabIndex = 5;
            this.ProductionCellB.Load += new System.EventHandler(this.ProductionCellB_Load);
            // 
            // ProductionCellD
            // 
            this.ProductionCellD.BackColor = System.Drawing.Color.SkyBlue;
            this.ProductionCellD.Location = new System.Drawing.Point(446, 350);
            this.ProductionCellD.MaximumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellD.MinimumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellD.Name = "ProductionCellD";
            this.ProductionCellD.ProductionCellFunction = "Drill";
            this.ProductionCellD.ProductionCellProces = 0;
            this.ProductionCellD.ProductionCellState = "";
            this.ProductionCellD.Size = new System.Drawing.Size(250, 130);
            this.ProductionCellD.TabIndex = 4;
            // 
            // ProductionCellE
            // 
            this.ProductionCellE.BackColor = System.Drawing.Color.SkyBlue;
            this.ProductionCellE.Location = new System.Drawing.Point(68, 597);
            this.ProductionCellE.MaximumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellE.MinimumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellE.Name = "ProductionCellE";
            this.ProductionCellE.ProductionCellFunction = "Saw";
            this.ProductionCellE.ProductionCellProces = 0;
            this.ProductionCellE.ProductionCellState = "";
            this.ProductionCellE.Size = new System.Drawing.Size(250, 130);
            this.ProductionCellE.TabIndex = 3;
            // 
            // ProductionCellF
            // 
            this.ProductionCellF.BackColor = System.Drawing.Color.SkyBlue;
            this.ProductionCellF.Location = new System.Drawing.Point(446, 597);
            this.ProductionCellF.MaximumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellF.MinimumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellF.Name = "ProductionCellF";
            this.ProductionCellF.ProductionCellFunction = "Drill";
            this.ProductionCellF.ProductionCellProces = 0;
            this.ProductionCellF.ProductionCellState = "";
            this.ProductionCellF.Size = new System.Drawing.Size(250, 130);
            this.ProductionCellF.TabIndex = 2;
            // 
            // ProductionCellC
            // 
            this.ProductionCellC.BackColor = System.Drawing.Color.SkyBlue;
            this.ProductionCellC.Location = new System.Drawing.Point(68, 350);
            this.ProductionCellC.MaximumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellC.MinimumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellC.Name = "ProductionCellC";
            this.ProductionCellC.ProductionCellFunction = "Deburr";
            this.ProductionCellC.ProductionCellProces = 0;
            this.ProductionCellC.ProductionCellState = "";
            this.ProductionCellC.Size = new System.Drawing.Size(250, 130);
            this.ProductionCellC.TabIndex = 1;
            // 
            // ProductionCellA
            // 
            this.ProductionCellA.BackColor = System.Drawing.Color.SkyBlue;
            this.ProductionCellA.Location = new System.Drawing.Point(67, 97);
            this.ProductionCellA.MaximumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellA.MinimumSize = new System.Drawing.Size(250, 130);
            this.ProductionCellA.Name = "ProductionCellA";
            this.ProductionCellA.ProductionCellFunction = "Saw";
            this.ProductionCellA.ProductionCellProces = 0;
            this.ProductionCellA.ProductionCellState = "";
            this.ProductionCellA.Size = new System.Drawing.Size(250, 130);
            this.ProductionCellA.TabIndex = 0;
            this.ProductionCellA.Load += new System.EventHandler(this.ProductionCellA_Load);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(81, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 861);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabProduction.ResumeLayout(false);
            this.TabAddProduct.ResumeLayout(false);
            this.TabAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrOfHoles)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.SplitQueueSP.Panel1.ResumeLayout(false);
            this.SplitQueueSP.Panel1.PerformLayout();
            this.SplitQueueSP.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitQueueSP)).EndInit();
            this.SplitQueueSP.ResumeLayout(false);
            this.SplitProductionReady.Panel1.ResumeLayout(false);
            this.SplitProductionReady.Panel1.PerformLayout();
            this.SplitProductionReady.Panel2.ResumeLayout(false);
            this.SplitProductionReady.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitProductionReady)).EndInit();
            this.SplitProductionReady.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LboxMachines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabProduction;
        private System.Windows.Forms.TabPage TabAddProduct;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Button btnTypeD;
        private System.Windows.Forms.Button btnTypeC;
        private System.Windows.Forms.Button btnTypeB;
        private System.Windows.Forms.Button btnTypeA;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblAmountOfHoles;
        private System.Windows.Forms.NumericUpDown nmbrOfHoles;
        private System.Windows.Forms.Label lblAllProductsAdded;
        private System.Windows.Forms.TextBox txtbxAllProductsAdded;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.CheckBox chckbxDeburr;
        private System.Windows.Forms.Label lblSelectedType;
        private System.Windows.Forms.TextBox txtbxSelectedType;
        private System.Windows.Forms.Label lblConfigProduct;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer SplitQueueSP;
        private System.Windows.Forms.SplitContainer SplitProductionReady;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Productiecel ProductionCellB;
        private Productiecel ProductionCellD;
        private Productiecel ProductionCellF;
        private Productiecel ProductionCellC;
        private Productiecel ProductionCellA;
        private System.Windows.Forms.Label label3;
        private Productiecel ProductionCellE;
        private System.Windows.Forms.FlowLayoutPanel QueuePanel;
    }
}

