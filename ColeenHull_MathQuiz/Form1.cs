using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ColeenHull_MathQuiz
{
    public partial class Form1 : Form
    {
        // get today's date
        DateTime currentTime = DateTime.Now; 
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();
        // These integer variables store the numbers for the addition problem. 
        int addend1;
        int addend2;
   
        // for the subtraction problem. 
        int minuend;
        int subtrahend;
        
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;
 
        // for the division problem. 
        int dividend;
        int divisor;
        // This integer variable keeps track of the remaining time.
        int timeLeft;
        //method to set  
        public void StartTheQuiz()
        { 
            // Fill in the addition problem.
            // Generate two random numbers to add.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // assign add variables to additions labels
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            
            // set sum to zero
            sum.Value = 0;

            // get random nubmers for subatration problem
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            // assign subtration values to subtraction labels
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;
            // get between 2 and 11
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            // assign multiplication values to multiplication labels
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;
            // Start the timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //reset colors
            timeLabel.BackColor = Color.White;
            sum.ForeColor = Color.Black;
            difference.ForeColor = Color.Black;
            quotient.ForeColor = Color.Black;
            product.ForeColor = Color.Black;
            StartTheQuiz();
            startButton.Enabled = false;
        }
        /*
        /// Check the answer to see if the user got everything right.
        /// <returns>True if the answer's correct, false otherwise.</returns>
        */
        private bool CheckTheAnswer()
        {
            //checks the vairables against the number entered into the different input labels
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // stop times and give message
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                // if timer is 5 or under change teh background to red
                if (timeLeft < 6)
                { 
                    timeLabel.BackColor = Color.Red; 
                }
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop(); 
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
               
                startButton.Enabled = true;
            }
        }

        private void answer_enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        // show the date on loading
        private void load(object sender, EventArgs e)
        {
            date.Text = currentTime.ToString(" dd MMMM  yyyy");      
        }
        // when value in sum is changed check the answer
        private void Sum(object sender, EventArgs e)
        {
            // if answer is correct change text color and make a sound
            if (sum.Value == addend1 + addend2)
            {
                sum.ForeColor = Color.Green;
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                simpleSound.Play();
            }
        }
        // when value in difference is changed check the answer
        private void difference_ValueChanged(object sender, EventArgs e)
        {
            // if answer is correct change text color and make a sound
            if (difference.Value == minuend - subtrahend)
            {
                difference.ForeColor = Color.Green; 
                SystemSounds.Beep.Play();
            }
        }
        // when value in product is changed check the answer
        private void product_ValueChanged(object sender, EventArgs e)
        {
            // if answer is correct change text color and make a sound
            if (product.Value == multiplicand * multiplier)
            {
                product.ForeColor = Color.Green;
                SystemSounds.Beep.Play();
            }
        }
        // when value in quorient is changed check the answer
        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            // if answer is correct change text color and make a sound
            if (quotient.Value == dividend / divisor)
            {
                quotient.ForeColor = Color.Green;
                SystemSounds.Beep.Play();
            }
        }
    }
}
