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
            this.deskQuotesDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuotesDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 407);
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
            this.material.Location = new System.Drawing.Point(12, 39);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(154, 25);
            this.material.TabIndex = 1;
            this.material.Text = "Surface Material";
            // 
            // inputMaterial
            // 
            this.inputMaterial.FormattingEnabled = true;
            this.inputMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Rosewood",
            "Pine",
            "Veneer"});
            this.inputMaterial.Location = new System.Drawing.Point(181, 40);
            this.inputMaterial.Name = "inputMaterial";
            this.inputMaterial.Size = new System.Drawing.Size(121, 24);
            this.inputMaterial.TabIndex = 2;
            this.inputMaterial.SelectedIndexChanged += new System.EventHandler(this.inputMaterial_SelectedIndexChanged);
            // 
            // deskQuotesDisplay
            // 
            this.deskQuotesDisplay.AllowUserToAddRows = false;
            this.deskQuotesDisplay.AllowUserToDeleteRows = false;
            this.deskQuotesDisplay.AllowUserToOrderColumns = true;
            this.deskQuotesDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deskQuotesDisplay.BackgroundColor = System.Drawing.Color.White;
            this.deskQuotesDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deskQuotesDisplay.Location = new System.Drawing.Point(26, 89);
            this.deskQuotesDisplay.Name = "deskQuotesDisplay";
            this.deskQuotesDisplay.RowHeadersWidth = 60;
            this.deskQuotesDisplay.RowTemplate.Height = 24;
            this.deskQuotesDisplay.Size = new System.Drawing.Size(880, 300);
            this.deskQuotesDisplay.TabIndex = 3;
            // 
            // searchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 449);
            this.Controls.Add(this.deskQuotesDisplay);
            this.Controls.Add(this.inputMaterial);
            this.Controls.Add(this.material);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "searchQuotes";
            this.Text = "searchQuotes";
            this.Load += new System.EventHandler(this.searchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskQuotesDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.ComboBox inputMaterial;
        private System.Windows.Forms.DataGridView deskQuotesDisplay;
    }
}