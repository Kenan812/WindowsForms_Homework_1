using System.Windows.Forms;

namespace Ex_3
{
    public partial class Form1 : Form
    {
        private bool ctrl_pressed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ctrl_pressed) this.Close();
                
                MessageBox.Show("This point is outside the rectangle", "Result", MessageBoxButtons.OK);
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.Text = $"Width: {rectangle.Width}   Height: {rectangle.Height}";
            }
        }

        private void rectangle_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ctrl_pressed) this.Close();


                if (rectangle.Bounds.Contains(e.Location))
                    MessageBox.Show("This point is inside the rectangle", "Result", MessageBoxButtons.OK);
                else
                    MessageBox.Show("This point is on the edge of the rectangle", "Result", MessageBoxButtons.OK);
            }

        }

        private void rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X: {e.X}  Y: {e.Y}";

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) ctrl_pressed = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) ctrl_pressed = false;
        }

        private void rectangle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) ctrl_pressed = true;
        }

        private void rectangle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) ctrl_pressed = false;
        }
    }

}
