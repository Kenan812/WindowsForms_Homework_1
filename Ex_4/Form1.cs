using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ex_4
{
    public partial class Form1 : Form
    {
        private bool mouseClicked = false;
        int count = 1;

        Point mouseClickedPosition = new Point(0, 0);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClickedPosition.X = e.X;
            mouseClickedPosition.Y = e.Y;

            mouseClicked = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                TextBox textBox = new TextBox();

                textBox.Location = mouseClickedPosition;
                textBox.Multiline = true;
                textBox.Name = count.ToString();

                if (Math.Abs(e.X - mouseClickedPosition.X) < 10 || Math.Abs(e.Y - mouseClickedPosition.Y) < 10)
                {
                    MessageBox.Show("Square too small", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                textBox.Size = new Size(Math.Abs(e.X - mouseClickedPosition.X), Math.Abs(e.Y - mouseClickedPosition.Y));

                textBox.TabIndex = 0;
                textBox.Text = count.ToString();
                textBox.TextAlign = HorizontalAlignment.Center;
                textBox.Font = new Font(textBox.Font.FontFamily, 15);
                textBox.MouseClick += new MouseEventHandler(textBox_mouseClick);
                textBox.MouseDoubleClick += new MouseEventHandler(textBox_mouseDoubleClick);

                this.Controls.Add(textBox);

                count++;
            }

            mouseClickedPosition.X = 0;
            mouseClickedPosition.Y = 0;

            mouseClicked = false;
        }


        private void textBox_mouseClick(object sender, MouseEventArgs e)
        {
            TextBox t = (sender as TextBox);

            List<TextBox> textBoxes = new List<TextBox>();

            if (e.Button == MouseButtons.Left)
            {
                foreach (Control c in this.Controls)
                {
                    TextBox textBox = (c as TextBox);

                    if (textBox.Bounds.Contains(e.Location.X + t.Location.X, e.Location.Y + t.Location.Y))
                    {
                        textBoxes.Add(textBox);
                    }
                }

                if (textBoxes.Count != 0)
                {
                    this.Text = $"Name: {textBoxes[textBoxes.Count - 1].Text} Area: {textBoxes[textBoxes.Count - 1].Height * textBoxes[textBoxes.Count - 1].Width}  Position: ({textBoxes[textBoxes.Count - 1].Left}, {textBoxes[textBoxes.Count - 1].Top})";
                }
            }
        }


        private void textBox_mouseDoubleClick(object sender, MouseEventArgs e)
        {
            TextBox t = (sender as TextBox);

            List<TextBox> textBoxes = new List<TextBox>();

            if (e.Button == MouseButtons.Left)
            {
                foreach (Control c in this.Controls)
                {
                    TextBox textBox = (c as TextBox);

                    if (textBox.Bounds.Contains(e.Location.X + t.Location.X, e.Location.Y + t.Location.Y))
                    {
                        this.Controls.Remove(textBox);
                        return;
                    }
                }
            }
        }

    }
}
