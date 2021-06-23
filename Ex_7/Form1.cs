using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.CompareTo(DateTime.Now) < 0)
            {
                resultTextBox.Text = "Provided date is earlier than current date";
            }

            else
            {

                if (radioButton1.Checked == true)
                {
                    resultTextBox.Text = $"{dateTimePicker1.Value.Subtract(DateTime.Now).TotalDays / 366}";
                }
                else if (radioButton2.Checked == true)
                {
                    resultTextBox.Text = $"{(dateTimePicker1.Value.Subtract(DateTime.Now).TotalDays / 366 * 12 )}";
                }
                else if (radioButton3.Checked == true)
                {
                    resultTextBox.Text = $"{(int)(dateTimePicker1.Value.Subtract(DateTime.Now).TotalDays)}";
                }
                else if (radioButton4.Checked == true)
                {
                    resultTextBox.Text = $"{(int)(dateTimePicker1.Value.Subtract(DateTime.Now).TotalHours)}";
                }
                else if (radioButton5.Checked == true)
                {
                    resultTextBox.Text = $"{(int)(dateTimePicker1.Value.Subtract(DateTime.Now).TotalMinutes)}";
                }
                else if (radioButton6.Checked == true)
                {
                    resultTextBox.Text = $"{(int)(dateTimePicker1.Value.Subtract(DateTime.Now).TotalSeconds)}";
                }
            }
        }
    }
}
