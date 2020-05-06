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
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.Label();
            this.drawer = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.rushOrder = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputWidth = new System.Windows.Forms.TextBox();
            this.inputDepth = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.inputDrawer = new System.Windows.Forms.ComboBox();
            this.inputMaterial = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(22, 68);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(169, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Enter Your Full Name";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(22, 119);
            this.width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(216, 20);
            this.width.TabIndex = 2;
            this.width.Text = "Enter the Width of the Desk";
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Location = new System.Drawing.Point(22, 172);
            this.depth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(218, 20);
            this.depth.TabIndex = 3;
            this.depth.Text = "Enter the Depth of the Desk";
            // 
            // drawer
            // 
            this.drawer.AutoSize = true;
            this.drawer.Location = new System.Drawing.Point(22, 225);
            this.drawer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(156, 20);
            this.drawer.TabIndex = 4;
            this.drawer.Text = "Number of Drawers";
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Location = new System.Drawing.Point(22, 278);
            this.material.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(195, 20);
            this.material.TabIndex = 5;
            this.material.Text = "Material of Desk Surface";
            // 
            // rushOrder
            // 
            this.rushOrder.AutoSize = true;
            this.rushOrder.Location = new System.Drawing.Point(22, 335);
            this.rushOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(115, 20);
            this.rushOrder.TabIndex = 6;
            this.rushOrder.Text = "Shipping Time";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(260, 68);
            this.inputName.Margin = new System.Windows.Forms.Padding(4);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(124, 27);
            this.inputName.TabIndex = 8;
            // 
            // inputWidth
            // 
            this.inputWidth.Location = new System.Drawing.Point(258, 115);
            this.inputWidth.Margin = new System.Windows.Forms.Padding(4);
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(124, 27);
            this.inputWidth.TabIndex = 10;
            this.inputWidth.Validating += new System.ComponentModel.CancelEventHandler(this.inputWidth_Validating);
            // 
            // inputDepth
            // 
            this.inputDepth.Location = new System.Drawing.Point(260, 169);
            this.inputDepth.Margin = new System.Windows.Forms.Padding(4);
            this.inputDepth.Name = "inputDepth";
            this.inputDepth.Size = new System.Drawing.Size(124, 27);
            this.inputDepth.TabIndex = 11;
            this.inputDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputDepth_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(260, 440);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(124, 27);
            this.textBox8.TabIndex = 15;
            // 
            // inputDrawer
            // 
            this.inputDrawer.FormattingEnabled = true;
            this.inputDrawer.Location = new System.Drawing.Point(260, 216);
            this.inputDrawer.Margin = new System.Windows.Forms.Padding(4);
            this.inputDrawer.Name = "inputDrawer";
            this.inputDrawer.Size = new System.Drawing.Size(150, 28);
            this.inputDrawer.TabIndex = 16;
            // 
            // inputMaterial
            // 
            this.inputMaterial.FormattingEnabled = true;
            this.inputMaterial.Location = new System.Drawing.Point(260, 278);
            this.inputMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.inputMaterial.Name = "inputMaterial";
            this.inputMaterial.Size = new System.Drawing.Size(150, 28);
            this.inputMaterial.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(571, 329);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 24);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Base price $200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Desk top surface costs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(525, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Desk top surface cost 1 dollar per square in over 1000 square inches";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Each Drawer $50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Laminate $100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pine$50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Veneer $125";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(763, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Oak $200";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(763, 286);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Rosewood $300";
            // 
            // AddQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.inputMaterial);
            this.Controls.Add(this.inputDrawer);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.inputDepth);
            this.Controls.Add(this.inputWidth);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.material);
            this.Controls.Add(this.drawer);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddQuotes";
            this.Text = "AddQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.Label drawer;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.Label rushOrder;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputWidth;
        private System.Windows.Forms.TextBox inputDepth;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox inputDrawer;
        private System.Windows.Forms.ComboBox inputMaterial;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}