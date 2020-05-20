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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material.Location = new System.Drawing.Point(12, 40);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(154, 25);
            this.material.TabIndex = 1;
            this.material.Text = "Surface Material";
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
            this.inputMaterial.Location = new System.Drawing.Point(172, 40);
            this.inputMaterial.Name = "inputMaterial";
            this.inputMaterial.Size = new System.Drawing.Size(121, 24);
            this.inputMaterial.TabIndex = 2;
            this.inputMaterial.SelectedIndexChanged += new System.EventHandler(this.inputMaterial_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 309);
            this.dataGridView1.TabIndex = 3;
            // 
            // searchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inputMaterial);
            this.Controls.Add(this.material);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "searchQuotes";
            this.Text = "searchQuotes";
            this.Load += new System.EventHandler(this.searchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.ComboBox inputMaterial;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}