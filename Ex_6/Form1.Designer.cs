namespace Ex_6
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
            this.DayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DayTextBox
            // 
            this.DayTextBox.Location = new System.Drawing.Point(21, 69);
            this.DayTextBox.Name = "DayTextBox";
            this.DayTextBox.Size = new System.Drawing.Size(108, 26);
            this.DayTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(671, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(344, 69);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(108, 26);
            this.YearTextBox.TabIndex = 5;
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Location = new System.Drawing.Point(183, 69);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(108, 26);
            this.MonthTextBox.TabIndex = 6;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(155, 135);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(192, 65);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "FindDayOfWeek";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(155, 248);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(139, 26);
            this.ResultTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DayTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

