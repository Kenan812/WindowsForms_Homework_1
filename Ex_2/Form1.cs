using System;
using System.Windows.Forms;

namespace Ex_2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        private int num;
        private int count = 1;


        public Form1()
        {
            InitializeComponent();
            Play();
        }


        void Play()
        {
            num = rnd.Next(1, 2001);
            guessTextBox.Text = String.Empty;

            MessageBox.Show($"{num}");
            count = 1;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = Int32.Parse(guessTextBox.Text);

                if (guess == num)
                {
                    DialogResult d = MessageBox.Show($"Number of trials: {count}\nAnother game?", "GAME WON", MessageBoxButtons.YesNo);

                    if (d == DialogResult.Yes) Play();
                    else
                    {
                        MessageBox.Show("The end");
                        this.Close();
                    }
                }

                else
                {
                    count++;

                    if (guess < num) MessageBox.Show("Your guess is lower than needed", "Not correct answer", MessageBoxButtons.OK);
                    else MessageBox.Show("Your guess is higher than needed", "Not correct answer", MessageBoxButtons.OK);


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Your input is wrong", "WRONG INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                guessTextBox.Text = String.Empty;
            }
        }


    }
}
