namespace MegaDesk_Hull
{
    partial class AddQuotes
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
            this.components = new System.ComponentModel.Container();
            this.BackButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.Label();
            this.drawer = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.rushOrder = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputWidth = new System.Windows.Forms.TextBox();
            this.inputDepth = new System.Windows.Forms.TextBox();
            this.inputDrawer = new System.Windows.Forms.ComboBox();
            this.inputMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.overCost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.overCostPrice = new System.Windows.Forms.Label();
            this.totalCostPrice = new System.Windows.Forms.Label();
            this.materialCostPrice = new System.Windows.Forms.Label();
            this.drawerNumPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.shippingInput = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.shippingCostLabel = new System.Windows.Forms.Label();
            this.shippingCostPrice = new System.Windows.Forms.Label();
            this.dollarSign = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.CausesValidation = false;
            this.BackButton.Location = new System.Drawing.Point(17, 411);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 30);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(13, 24);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(85, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Full Name";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(7, 45);
            this.width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(126, 20);
            this.width.TabIndex = 2;
            this.width.Text = "Desk Width (In)";
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Location = new System.Drawing.Point(5, 88);
            this.depth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(128, 20);
            this.depth.TabIndex = 3;
            this.depth.Text = "Desk Depth (In)";
            // 
            // drawer
            // 
            this.drawer.AutoSize = true;
            this.drawer.Location = new System.Drawing.Point(7, 32);
            this.drawer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(128, 20);
            this.drawer.TabIndex = 4;
            this.drawer.Text = "Drawer Number";
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Location = new System.Drawing.Point(5, 72);
            this.material.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(132, 20);
            this.material.TabIndex = 5;
            this.material.Text = "Surface Material";
            // 
            // rushOrder
            // 
            this.rushOrder.AutoSize = true;
            this.rushOrder.Location = new System.Drawing.Point(24, 339);
            this.rushOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(115, 20);
            this.rushOrder.TabIndex = 6;
            this.rushOrder.Text = "Shipping Time";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(116, 17);
            this.inputName.Margin = new System.Windows.Forms.Padding(4);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(218, 27);
            this.inputName.TabIndex = 8;
            this.inputName.Validating += new System.ComponentModel.CancelEventHandler(this.inputName_Validating);
            this.inputName.Validated += new System.EventHandler(this.inputName_Validated);
            // 
            // inputWidth
            // 
            this.inputWidth.Location = new System.Drawing.Point(155, 38);
            this.inputWidth.Margin = new System.Windows.Forms.Padding(4);
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(124, 27);
            this.inputWidth.TabIndex = 10;
            this.inputWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputWidth_KeyPress);
            this.inputWidth.Validating += new System.ComponentModel.CancelEventHandler(this.inputWidth_Validating);
            this.inputWidth.Validated += new System.EventHandler(this.inputWidth_Validated);
            // 
            // inputDepth
            // 
            this.inputDepth.Location = new System.Drawing.Point(155, 81);
            this.inputDepth.Margin = new System.Windows.Forms.Padding(4);
            this.inputDepth.Name = "inputDepth";
            this.inputDepth.Size = new System.Drawing.Size(124, 27);
            this.inputDepth.TabIndex = 11;
            this.inputDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputDepth_KeyPress);
            this.inputDepth.Validating += new System.ComponentModel.CancelEventHandler(this.inputDepth_Validating);
            this.inputDepth.Validated += new System.EventHandler(this.inputDepth_Validated);
            // 
            // inputDrawer
            // 
            this.inputDrawer.FormattingEnabled = true;
            this.inputDrawer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.inputDrawer.Location = new System.Drawing.Point(155, 27);
            this.inputDrawer.Margin = new System.Windows.Forms.Padding(4);
            this.inputDrawer.Name = "inputDrawer";
            this.inputDrawer.Size = new System.Drawing.Size(150, 28);
            this.inputDrawer.TabIndex = 16;
            this.inputDrawer.SelectedIndexChanged += new System.EventHandler(this.inputDrawer_SelectedIndexChanged);
            // 
            // inputMaterial
            // 
            this.inputMaterial.FormattingEnabled = true;
            this.inputMaterial.Location = new System.Drawing.Point(155, 69);
            this.inputMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.inputMaterial.Name = "inputMaterial";
            this.inputMaterial.Size = new System.Drawing.Size(150, 28);
            this.inputMaterial.TabIndex = 17;
            this.inputMaterial.SelectedIndexChanged += new System.EventHandler(this.inputMaterial_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Base Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cost Per Sq In  over 1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Base incl. 1000 sq in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Each Drawer $50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total Drawer Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Material Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Total Cost";
            // 
            // overCost
            // 
            this.overCost.AutoSize = true;
            this.overCost.Location = new System.Drawing.Point(13, 141);
            this.overCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.overCost.Name = "overCost";
            this.overCost.Size = new System.Drawing.Size(122, 20);
            this.overCost.TabIndex = 27;
            this.overCost.Text = "Cost over 1000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.depth);
            this.groupBox1.Controls.Add(this.width);
            this.groupBox1.Controls.Add(this.inputWidth);
            this.groupBox1.Controls.Add(this.inputDepth);
            this.groupBox1.Location = new System.Drawing.Point(17, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 128);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drawer);
            this.groupBox2.Controls.Add(this.material);
            this.groupBox2.Controls.Add(this.inputDrawer);
            this.groupBox2.Controls.Add(this.inputMaterial);
            this.groupBox2.Location = new System.Drawing.Point(17, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 113);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dollarSign);
            this.groupBox3.Controls.Add(this.shippingCostPrice);
            this.groupBox3.Controls.Add(this.shippingCostLabel);
            this.groupBox3.Controls.Add(this.overCostPrice);
            this.groupBox3.Controls.Add(this.totalCostPrice);
            this.groupBox3.Controls.Add(this.materialCostPrice);
            this.groupBox3.Controls.Add(this.drawerNumPrice);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.overCost);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(449, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 379);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cost Estimate";
            // 
            // overCostPrice
            // 
            this.overCostPrice.Location = new System.Drawing.Point(300, 141);
            this.overCostPrice.Name = "overCostPrice";
            this.overCostPrice.Size = new System.Drawing.Size(45, 20);
            this.overCostPrice.TabIndex = 34;
            this.overCostPrice.Text = "0";
            this.overCostPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalCostPrice
            // 
            this.totalCostPrice.Location = new System.Drawing.Point(300, 332);
            this.totalCostPrice.Name = "totalCostPrice";
            this.totalCostPrice.Size = new System.Drawing.Size(45, 20);
            this.totalCostPrice.TabIndex = 33;
            this.totalCostPrice.Text = "0";
            this.totalCostPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // materialCostPrice
            // 
            this.materialCostPrice.Location = new System.Drawing.Point(300, 252);
            this.materialCostPrice.Name = "materialCostPrice";
            this.materialCostPrice.Size = new System.Drawing.Size(45, 20);
            this.materialCostPrice.TabIndex = 32;
            this.materialCostPrice.Text = "0";
            this.materialCostPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // drawerNumPrice
            // 
            this.drawerNumPrice.Location = new System.Drawing.Point(300, 215);
            this.drawerNumPrice.Name = "drawerNumPrice";
            this.drawerNumPrice.Size = new System.Drawing.Size(45, 20);
            this.drawerNumPrice.TabIndex = 31;
            this.drawerNumPrice.Text = "0";
            this.drawerNumPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(300, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = " 50";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(300, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "  1";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(300, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = " 200";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // shippingInput
            // 
            this.shippingInput.FormattingEnabled = true;
            this.shippingInput.Items.AddRange(new object[] {
            "Normal 14 Days",
            "Rush 7 Days",
            "Rush 5 Days",
            "Rush 3 Days"});
            this.shippingInput.Location = new System.Drawing.Point(172, 336);
            this.shippingInput.Margin = new System.Windows.Forms.Padding(4);
            this.shippingInput.Name = "shippingInput";
            this.shippingInput.Size = new System.Drawing.Size(150, 28);
            this.shippingInput.TabIndex = 18;
            this.shippingInput.SelectedIndexChanged += new System.EventHandler(this.shippingInput_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(740, 411);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 30);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(634, 411);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(80, 30);
            this.resetButton.TabIndex = 31;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // shippingCostLabel
            // 
            this.shippingCostLabel.AutoSize = true;
            this.shippingCostLabel.Location = new System.Drawing.Point(13, 289);
            this.shippingCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shippingCostLabel.Name = "shippingCostLabel";
            this.shippingCostLabel.Size = new System.Drawing.Size(113, 20);
            this.shippingCostLabel.TabIndex = 35;
            this.shippingCostLabel.Text = "Shipping Cost";
            // 
            // shippingCostPrice
            // 
            this.shippingCostPrice.Location = new System.Drawing.Point(300, 289);
            this.shippingCostPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shippingCostPrice.Name = "shippingCostPrice";
            this.shippingCostPrice.Size = new System.Drawing.Size(45, 20);
            this.shippingCostPrice.TabIndex = 36;
            this.shippingCostPrice.Text = "0";
            this.shippingCostPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dollarSign
            // 
            this.dollarSign.AutoSize = true;
            this.dollarSign.Location = new System.Drawing.Point(240, 35);
            this.dollarSign.Name = "dollarSign";
            this.dollarSign.Size = new System.Drawing.Size(23, 20);
            this.dollarSign.TabIndex = 37;
            this.dollarSign.Text = " $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = " $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = " $";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(240, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = " $";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = " $";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(240, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 20);
            this.label15.TabIndex = 42;
            this.label15.Text = " $";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(240, 332);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = " $";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(240, 287);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = " $";
            // 
            // AddQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.shippingInput);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.name);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddQuotes";
            this.Text = "AddQuotes";
            this.Load += new System.EventHandler(this.AddQuotes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.Label drawer;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.Label rushOrder;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputWidth;
        private System.Windows.Forms.TextBox inputDepth;
        private System.Windows.Forms.ComboBox inputDrawer;
        private System.Windows.Forms.ComboBox inputMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label overCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox shippingInput;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label overCostPrice;
        private System.Windows.Forms.Label totalCostPrice;
        private System.Windows.Forms.Label materialCostPrice;
        private System.Windows.Forms.Label drawerNumPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label shippingCostPrice;
        private System.Windows.Forms.Label shippingCostLabel;
        private System.Windows.Forms.Label dollarSign;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}