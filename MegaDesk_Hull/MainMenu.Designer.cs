﻿namespace MegaDesk_Hull
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addQuote = new System.Windows.Forms.Button();
            this.SearchQuote = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuote
            // 
            this.addQuote.BackColor = System.Drawing.Color.White;
            this.addQuote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addQuote.Location = new System.Drawing.Point(29, 97);
            this.addQuote.Margin = new System.Windows.Forms.Padding(4);
            this.addQuote.Name = "addQuote";
            this.addQuote.Padding = new System.Windows.Forms.Padding(5);
            this.addQuote.Size = new System.Drawing.Size(172, 40);
            this.addQuote.TabIndex = 0;
            this.addQuote.Text = "Add Quotes";
            this.addQuote.UseVisualStyleBackColor = false;
            this.addQuote.Click += new System.EventHandler(this.addQuote_Click);
            // 
            // SearchQuote
            // 
            this.SearchQuote.BackColor = System.Drawing.Color.White;
            this.SearchQuote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SearchQuote.FlatAppearance.BorderSize = 3;
            this.SearchQuote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchQuote.Location = new System.Drawing.Point(29, 169);
            this.SearchQuote.Margin = new System.Windows.Forms.Padding(5);
            this.SearchQuote.Name = "SearchQuote";
            this.SearchQuote.Size = new System.Drawing.Size(172, 40);
            this.SearchQuote.TabIndex = 2;
            this.SearchQuote.Text = "Search Quotes";
            this.SearchQuote.UseVisualStyleBackColor = false;
            this.SearchQuote.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit.FlatAppearance.BorderSize = 2;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Location = new System.Drawing.Point(29, 244);
            this.exit.Margin = new System.Windows.Forms.Padding(5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(172, 40);
            this.exit.TabIndex = 3;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 399);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.SearchQuote);
            this.Controls.Add(this.addQuote);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuote;
        private System.Windows.Forms.Button SearchQuote;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

