namespace MegaDesk_Hull
{
    partial class searchQuotes
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
            this.material = new System.Windows.Forms.Label();
            this.inputMaterial = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Location = new System.Drawing.Point(47, 88);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(202, 17);
            this.material.TabIndex = 1;
            this.material.Text = "Please Enter the Surface Type";
            this.material.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputMaterial
            // 
            this.inputMaterial.FormattingEnabled = true;
            this.inputMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Rosewood",
            "Oak ",
            "Pine",
            "Veneer"});
            this.inputMaterial.Location = new System.Drawing.Point(257, 85);
            this.inputMaterial.Name = "inputMaterial";
            this.inputMaterial.Size = new System.Drawing.Size(121, 24);
            this.inputMaterial.TabIndex = 2;
            // 
            // searchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputMaterial);
            this.Controls.Add(this.material);
            this.Controls.Add(this.button1);
            this.Name = "searchQuotes";
            this.Text = "searchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.ComboBox inputMaterial;
    }
}