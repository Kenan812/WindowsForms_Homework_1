using System;
using System.Windows.Forms;

namespace Ex_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (Int32.Parse(MonthTextBox.Text) <= 0 || Int32.Parse(MonthTextBox.Text) >= 13)
                {
                    MessageBox.Show("Not correct input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Int32.Parse(DayTextBox.Text) <= 0)
                {
                    MessageBox.Show("Not correct input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DateTime.DaysInMonth(Int32.Parse(YearTextBox.Text), Int32.Parse(MonthTextBox.Text)) < Int32.Parse(DayTextBox.Text))
                {
                    MessageBox.Show("Not correct input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime d = new DateTime(Int32.Parse(YearTextBox.Text), Int32.Parse(MonthTextBox.Text), Int32.Parse(DayTextBox.Text));

                dateTimePicker1.Value = d;

                ResultTextBox.Text = dateTimePicker1.Value.DayOfWeek.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Not correct input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
