using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500, 300);
        }

        private void staticButton_MouseMove(object sender, MouseEventArgs e)
        {
            Size formSize = this.Size;
            int dx = 10;
            int dy = 10;
            Random rnd = new Random();


            if (staticButton.ClientRectangle.Contains(new Point(e.X, e.Y)))
            {

                if (e.X + staticButton.Location.X <= staticButton.Location.X + (staticButton.Width / 2 - 2))
                    dx = 10;
                else if (e.X + staticButton.Location.X >= staticButton.Location.X + (staticButton.Width / 2 + 2))
                    dx = -10;
                else dx = 0;


                if (staticButton.Location.X + dx <= 1 || staticButton.Location.X + dx + staticButton.Width >= formSize.Width - 1)
                    dx = 0;


                if (e.Y + staticButton.Location.Y <= staticButton.Location.Y + (staticButton.Height / 2 - 2))
                    dy = 10;
                else if (e.Y + staticButton.Location.Y >= staticButton.Location.Y + (staticButton.Height / 2 + 2))
                    dy = -10;
                else dy = 0;


                if (staticButton.Location.Y + dy <= 2 || staticButton.Location.Y + dy + staticButton.Height >= formSize.Height - 49)
                    dy = 0;


                staticButton.Location = new Point(staticButton.Location.X + dx, staticButton.Location.Y + dy);
            }
        }
    }
}
