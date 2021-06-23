namespace Ex_5
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
            this.staticButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staticButton
            // 
            this.staticButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticButton.Location = new System.Drawing.Point(338, 185);
            this.staticButton.Name = "staticButton";
            this.staticButton.Size = new System.Drawing.Size(131, 44);
            this.staticButton.TabIndex = 0;
            this.staticButton.Text = "STATIC";
            this.staticButton.UseVisualStyleBackColor = true;
            this.staticButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.staticButton_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staticButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button staticButton;
    }
}

