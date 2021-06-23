using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int msgBoxCount = 0;
            int letterCount = 0;
            string text;

            text = "Finished school 20 with red diploma";
            MessageBox.Show(text, "", MessageBoxButtons.OK);
            msgBoxCount++;
            letterCount += text.Length;

            text = "Programming languges: C, C++, C#, Python, Java";
            MessageBox.Show(text , "", MessageBoxButtons.OK);
            msgBoxCount++;
            letterCount += text.Length;

            text = "Languages: azerbaijani, russian, english, french, german";
            MessageBox.Show(text, "", MessageBoxButtons.OK);
            msgBoxCount++;
            letterCount += text.Length;

            text = "GitHub link: https://github.com/Kenan812";
            letterCount += text.Length;
            msgBoxCount++;
            MessageBox.Show(text, ((double)letterCount / (double)msgBoxCount).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
