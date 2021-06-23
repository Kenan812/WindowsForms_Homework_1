namespace Ex_3
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
            this.rectangle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.Lime;
            this.rectangle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rectangle.Location = new System.Drawing.Point(29, 29);
            this.rectangle.Multiline = true;
            this.rectangle.Name = "rectangle";
            this.rectangle.ReadOnly = true;
            this.rectangle.Size = new System.Drawing.Size(730, 395);
            this.rectangle.TabIndex = 0;
            this.rectangle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangle_MouseClick);
            this.rectangle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rectangle_KeyDown);
            this.rectangle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rectangle_KeyUp);
            this.rectangle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rectangle_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.rectangle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rectangle;
    }
}

