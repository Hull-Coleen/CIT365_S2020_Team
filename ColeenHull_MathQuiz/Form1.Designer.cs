namespace ColeenHull_MathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.leftDivideLabel = new System.Windows.Forms.Label();
            this.leftTimesLabel = new System.Windows.Forms.Label();
            this.leftMinusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.rightTimesLabel = new System.Windows.Forms.Label();
            this.rightDivideLabel = new System.Windows.Forms.Label();
            this.rightMinusLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Location = new System.Drawing.Point(664, 27);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 31);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Location = new System.Drawing.Point(122, 125);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(70, 29);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            // 
            // leftDivideLabel
            // 
            this.leftDivideLabel.Location = new System.Drawing.Point(95, 282);
            this.leftDivideLabel.Name = "leftDivideLabel";
            this.leftDivideLabel.Size = new System.Drawing.Size(70, 29);
            this.leftDivideLabel.TabIndex = 3;
            this.leftDivideLabel.Text = "?";
            // 
            // leftTimesLabel
            // 
            this.leftTimesLabel.Location = new System.Drawing.Point(104, 227);
            this.leftTimesLabel.Name = "leftTimesLabel";
            this.leftTimesLabel.Size = new System.Drawing.Size(70, 29);
            this.leftTimesLabel.TabIndex = 4;
            this.leftTimesLabel.Text = "?";
            // 
            // leftMinusLabel
            // 
            this.leftMinusLabel.Location = new System.Drawing.Point(113, 171);
            this.leftMinusLabel.Name = "leftMinusLabel";
            this.leftMinusLabel.Size = new System.Drawing.Size(70, 29);
            this.leftMinusLabel.TabIndex = 5;
            this.leftMinusLabel.Text = "?";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(283, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(261, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = " ÷";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(278, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "×";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(283, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "-";
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Location = new System.Drawing.Point(406, 125);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(70, 29);
            this.plusRightLabel.TabIndex = 10;
            this.plusRightLabel.Text = "?";
            // 
            // rightTimesLabel
            // 
            this.rightTimesLabel.Location = new System.Drawing.Point(384, 227);
            this.rightTimesLabel.Name = "rightTimesLabel";
            this.rightTimesLabel.Size = new System.Drawing.Size(70, 29);
            this.rightTimesLabel.TabIndex = 11;
            this.rightTimesLabel.Text = "?";
            // 
            // rightDivideLabel
            // 
            this.rightDivideLabel.Location = new System.Drawing.Point(362, 291);
            this.rightDivideLabel.Name = "rightDivideLabel";
            this.rightDivideLabel.Size = new System.Drawing.Size(70, 29);
            this.rightDivideLabel.TabIndex = 12;
            this.rightDivideLabel.Text = "?";
            // 
            // rightMinusLabel
            // 
            this.rightMinusLabel.Location = new System.Drawing.Point(384, 171);
            this.rightMinusLabel.Name = "rightMinusLabel";
            this.rightMinusLabel.Size = new System.Drawing.Size(70, 29);
            this.rightMinusLabel.TabIndex = 13;
            this.rightMinusLabel.Text = "?";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(482, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "=";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(460, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 29);
            this.label13.TabIndex = 15;
            this.label13.Text = "=";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(469, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 29);
            this.label14.TabIndex = 16;
            this.label14.Text = "=";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(460, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 29);
            this.label15.TabIndex = 17;
            this.label15.Text = "=";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(575, 123);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 34);
            this.sum.TabIndex = 2;
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(575, 171);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(120, 34);
            this.difference.TabIndex = 3;
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(575, 222);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 34);
            this.product.TabIndex = 4;
            // 
            // quotient
            // 
            this.quotient.Location = new System.Drawing.Point(575, 291);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(120, 34);
            this.quotient.TabIndex = 5;
            this.quotient.ValueChanged += new System.EventHandler(this.quotient_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Location = new System.Drawing.Point(301, 368);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(188, 39);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 449);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.product);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rightMinusLabel);
            this.Controls.Add(this.rightDivideLabel);
            this.Controls.Add(this.rightTimesLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leftMinusLabel);
            this.Controls.Add(this.leftTimesLabel);
            this.Controls.Add(this.leftDivideLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Coleen Hull Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label leftDivideLabel;
        private System.Windows.Forms.Label leftTimesLabel;
        private System.Windows.Forms.Label leftMinusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label rightTimesLabel;
        private System.Windows.Forms.Label rightDivideLabel;
        private System.Windows.Forms.Label rightMinusLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

