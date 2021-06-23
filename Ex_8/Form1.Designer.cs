namespace Ex_8
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
            this.RefuellingGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costInputTextBox = new System.Windows.Forms.TextBox();
            this.lirtesInputTextBox = new System.Windows.Forms.TextBox();
            this.GasolineCostGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalRefuellingCostTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costInputRadioButton = new System.Windows.Forms.RadioButton();
            this.litresInputRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.petrolPricePerLitrTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.petrolChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.MiniCafeGroupBox = new System.Windows.Forms.GroupBox();
            this.cocaColaCountTextBox = new System.Windows.Forms.TextBox();
            this.cocaColaPriceTextBox = new System.Windows.Forms.TextBox();
            this.frenchFriesCountTextBox = new System.Windows.Forms.TextBox();
            this.hamburgerPriceTextBox = new System.Windows.Forms.TextBox();
            this.hamburgerCountTextBox = new System.Windows.Forms.TextBox();
            this.frenchFriesPriceTextBox = new System.Windows.Forms.TextBox();
            this.hotDogCountTextBox = new System.Windows.Forms.TextBox();
            this.hotDogPriceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FoodCostGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalFoodCostTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hamburgerCheckBox = new System.Windows.Forms.CheckBox();
            this.frenchFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.cocaColaCheckBox = new System.Windows.Forms.CheckBox();
            this.hotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.TotalCostGroupBox = new System.Windows.Forms.GroupBox();
            this.countTotalPriceButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.clientTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.RefuellingGroupBox.SuspendLayout();
            this.GasolineCostGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MiniCafeGroupBox.SuspendLayout();
            this.FoodCostGroupBox.SuspendLayout();
            this.TotalCostGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefuellingGroupBox
            // 
            this.RefuellingGroupBox.Controls.Add(this.label5);
            this.RefuellingGroupBox.Controls.Add(this.label4);
            this.RefuellingGroupBox.Controls.Add(this.costInputTextBox);
            this.RefuellingGroupBox.Controls.Add(this.lirtesInputTextBox);
            this.RefuellingGroupBox.Controls.Add(this.GasolineCostGroupBox);
            this.RefuellingGroupBox.Controls.Add(this.groupBox1);
            this.RefuellingGroupBox.Controls.Add(this.label3);
            this.RefuellingGroupBox.Controls.Add(this.petrolPricePerLitrTextBox);
            this.RefuellingGroupBox.Controls.Add(this.label2);
            this.RefuellingGroupBox.Controls.Add(this.label1);
            this.RefuellingGroupBox.Controls.Add(this.petrolChoiceComboBox);
            this.RefuellingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefuellingGroupBox.Location = new System.Drawing.Point(37, 24);
            this.RefuellingGroupBox.Name = "RefuellingGroupBox";
            this.RefuellingGroupBox.Size = new System.Drawing.Size(364, 437);
            this.RefuellingGroupBox.TabIndex = 0;
            this.RefuellingGroupBox.TabStop = false;
            this.RefuellingGroupBox.Text = "Refuelling";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "l.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "AZN";
            // 
            // costInputTextBox
            // 
            this.costInputTextBox.Location = new System.Drawing.Point(199, 232);
            this.costInputTextBox.Name = "costInputTextBox";
            this.costInputTextBox.Size = new System.Drawing.Size(111, 30);
            this.costInputTextBox.TabIndex = 9;
            this.costInputTextBox.TextChanged += new System.EventHandler(this.costInputTextBox_TextChanged);
            // 
            // lirtesInputTextBox
            // 
            this.lirtesInputTextBox.Location = new System.Drawing.Point(199, 178);
            this.lirtesInputTextBox.Name = "lirtesInputTextBox";
            this.lirtesInputTextBox.Size = new System.Drawing.Size(111, 30);
            this.lirtesInputTextBox.TabIndex = 8;
            this.lirtesInputTextBox.TextChanged += new System.EventHandler(this.lirtesInputTextBox_TextChanged);
            // 
            // GasolineCostGroupBox
            // 
            this.GasolineCostGroupBox.Controls.Add(this.label6);
            this.GasolineCostGroupBox.Controls.Add(this.totalRefuellingCostTextBox);
            this.GasolineCostGroupBox.Location = new System.Drawing.Point(19, 297);
            this.GasolineCostGroupBox.Name = "GasolineCostGroupBox";
            this.GasolineCostGroupBox.Size = new System.Drawing.Size(326, 109);
            this.GasolineCostGroupBox.TabIndex = 7;
            this.GasolineCostGroupBox.TabStop = false;
            this.GasolineCostGroupBox.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "AZN";
            // 
            // totalRefuellingCostTextBox
            // 
            this.totalRefuellingCostTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.totalRefuellingCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalRefuellingCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRefuellingCostTextBox.Location = new System.Drawing.Point(146, 41);
            this.totalRefuellingCostTextBox.Name = "totalRefuellingCostTextBox";
            this.totalRefuellingCostTextBox.Size = new System.Drawing.Size(122, 46);
            this.totalRefuellingCostTextBox.TabIndex = 10;
            this.totalRefuellingCostTextBox.Text = "0.00";
            this.totalRefuellingCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.costInputRadioButton);
            this.groupBox1.Controls.Add(this.litresInputRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(19, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // costInputRadioButton
            // 
            this.costInputRadioButton.AutoSize = true;
            this.costInputRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costInputRadioButton.Location = new System.Drawing.Point(21, 71);
            this.costInputRadioButton.Name = "costInputRadioButton";
            this.costInputRadioButton.Size = new System.Drawing.Size(67, 24);
            this.costInputRadioButton.TabIndex = 4;
            this.costInputRadioButton.TabStop = true;
            this.costInputRadioButton.Text = "Cost";
            this.costInputRadioButton.UseVisualStyleBackColor = true;
            this.costInputRadioButton.CheckedChanged += new System.EventHandler(this.costInputRadioButton_CheckedChanged);
            // 
            // litresInputRadioButton
            // 
            this.litresInputRadioButton.AutoSize = true;
            this.litresInputRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litresInputRadioButton.Location = new System.Drawing.Point(21, 25);
            this.litresInputRadioButton.Name = "litresInputRadioButton";
            this.litresInputRadioButton.Size = new System.Drawing.Size(90, 24);
            this.litresInputRadioButton.TabIndex = 3;
            this.litresInputRadioButton.TabStop = true;
            this.litresInputRadioButton.Text = "Amount";
            this.litresInputRadioButton.UseVisualStyleBackColor = true;
            this.litresInputRadioButton.CheckedChanged += new System.EventHandler(this.litresInputRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "AZN";
            // 
            // petrolPricePerLitrTextBox
            // 
            this.petrolPricePerLitrTextBox.Location = new System.Drawing.Point(96, 95);
            this.petrolPricePerLitrTextBox.Name = "petrolPricePerLitrTextBox";
            this.petrolPricePerLitrTextBox.Size = new System.Drawing.Size(177, 30);
            this.petrolPricePerLitrTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-185, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Petrol";
            // 
            // petrolChoiceComboBox
            // 
            this.petrolChoiceComboBox.FormattingEnabled = true;
            this.petrolChoiceComboBox.Items.AddRange(new object[] {
            "AI 92",
            "AI 96(Premium)",
            "E-15",
            "Diesel"});
            this.petrolChoiceComboBox.Location = new System.Drawing.Point(96, 38);
            this.petrolChoiceComboBox.Name = "petrolChoiceComboBox";
            this.petrolChoiceComboBox.Size = new System.Drawing.Size(177, 33);
            this.petrolChoiceComboBox.TabIndex = 0;
            this.petrolChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.petrolChoiceComboBox_SelectedIndexChanged);
            // 
            // MiniCafeGroupBox
            // 
            this.MiniCafeGroupBox.Controls.Add(this.cocaColaCountTextBox);
            this.MiniCafeGroupBox.Controls.Add(this.cocaColaPriceTextBox);
            this.MiniCafeGroupBox.Controls.Add(this.frenchFriesCountTextBox);
            this.MiniCafeGroupBox.Controls.Add(this.hamburgerPriceTextBox);
            this.MiniCafeGroupBox.Controls.Add(this.hamburgerCountTextBox);
            this.MiniCafeGroupBox.Controls.Add(this.frenchFriesPriceTextBox);
            this.MiniCafeGroupBox.Controls.Add(this.hotDogCountTextBox);
            this.MiniCafeGroupBox.Controls.Add(this.hotDogPriceTextBox);
            this.MiniCafeGroupBox.Controls.Add(this.label9);
            this.MiniCafeGroupBox.Controls.Add(this.FoodCostGroupBox);
            this.MiniCafeGroupBox.Controls.Add(this.label7);
            this.MiniCafeGroupBox.Controls.Add(this.hamburgerCheckBox);
            this.MiniCafeGroupBox.Controls.Add(this.frenchFriesCheckBox);
            this.MiniCafeGroupBox.Controls.Add(this.cocaColaCheckBox);
            this.MiniCafeGroupBox.Controls.Add(this.hotDogCheckBox);
            this.MiniCafeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiniCafeGroupBox.Location = new System.Drawing.Point(467, 24);
            this.MiniCafeGroupBox.Name = "MiniCafeGroupBox";
            this.MiniCafeGroupBox.Size = new System.Drawing.Size(364, 437);
            this.MiniCafeGroupBox.TabIndex = 1;
            this.MiniCafeGroupBox.TabStop = false;
            this.MiniCafeGroupBox.Text = "Mini Cafe";
            // 
            // cocaColaCountTextBox
            // 
            this.cocaColaCountTextBox.Location = new System.Drawing.Point(268, 211);
            this.cocaColaCountTextBox.Name = "cocaColaCountTextBox";
            this.cocaColaCountTextBox.Size = new System.Drawing.Size(80, 30);
            this.cocaColaCountTextBox.TabIndex = 19;
            this.cocaColaCountTextBox.TextChanged += new System.EventHandler(this.cocaColaCountTextBox_TextChanged);
            // 
            // cocaColaPriceTextBox
            // 
            this.cocaColaPriceTextBox.Location = new System.Drawing.Point(168, 211);
            this.cocaColaPriceTextBox.Name = "cocaColaPriceTextBox";
            this.cocaColaPriceTextBox.Size = new System.Drawing.Size(80, 30);
            this.cocaColaPriceTextBox.TabIndex = 18;
            this.cocaColaPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frenchFriesCountTextBox
            // 
            this.frenchFriesCountTextBox.Location = new System.Drawing.Point(268, 160);
            this.frenchFriesCountTextBox.Name = "frenchFriesCountTextBox";
            this.frenchFriesCountTextBox.Size = new System.Drawing.Size(80, 30);
            this.frenchFriesCountTextBox.TabIndex = 17;
            this.frenchFriesCountTextBox.TextChanged += new System.EventHandler(this.frenchFriesCountTextBox_TextChanged);
            // 
            // hamburgerPriceTextBox
            // 
            this.hamburgerPriceTextBox.Location = new System.Drawing.Point(168, 110);
            this.hamburgerPriceTextBox.Name = "hamburgerPriceTextBox";
            this.hamburgerPriceTextBox.Size = new System.Drawing.Size(80, 30);
            this.hamburgerPriceTextBox.TabIndex = 16;
            this.hamburgerPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hamburgerCountTextBox
            // 
            this.hamburgerCountTextBox.Location = new System.Drawing.Point(268, 110);
            this.hamburgerCountTextBox.Name = "hamburgerCountTextBox";
            this.hamburgerCountTextBox.Size = new System.Drawing.Size(80, 30);
            this.hamburgerCountTextBox.TabIndex = 15;
            this.hamburgerCountTextBox.TextChanged += new System.EventHandler(this.hamburgerCountTextBox_TextChanged);
            // 
            // frenchFriesPriceTextBox
            // 
            this.frenchFriesPriceTextBox.Location = new System.Drawing.Point(168, 159);
            this.frenchFriesPriceTextBox.Name = "frenchFriesPriceTextBox";
            this.frenchFriesPriceTextBox.Size = new System.Drawing.Size(80, 30);
            this.frenchFriesPriceTextBox.TabIndex = 14;
            this.frenchFriesPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hotDogCountTextBox
            // 
            this.hotDogCountTextBox.Location = new System.Drawing.Point(268, 58);
            this.hotDogCountTextBox.Name = "hotDogCountTextBox";
            this.hotDogCountTextBox.Size = new System.Drawing.Size(80, 30);
            this.hotDogCountTextBox.TabIndex = 13;
            this.hotDogCountTextBox.TextChanged += new System.EventHandler(this.hotDogCountTextBox_TextChanged);
            // 
            // hotDogPriceTextBox
            // 
            this.hotDogPriceTextBox.Location = new System.Drawing.Point(168, 58);
            this.hotDogPriceTextBox.Name = "hotDogPriceTextBox";
            this.hotDogPriceTextBox.Size = new System.Drawing.Size(80, 30);
            this.hotDogPriceTextBox.TabIndex = 11;
            this.hotDogPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Count";
            // 
            // FoodCostGroupBox
            // 
            this.FoodCostGroupBox.Controls.Add(this.label8);
            this.FoodCostGroupBox.Controls.Add(this.totalFoodCostTextBox);
            this.FoodCostGroupBox.Location = new System.Drawing.Point(22, 297);
            this.FoodCostGroupBox.Name = "FoodCostGroupBox";
            this.FoodCostGroupBox.Size = new System.Drawing.Size(326, 109);
            this.FoodCostGroupBox.TabIndex = 8;
            this.FoodCostGroupBox.TabStop = false;
            this.FoodCostGroupBox.Text = "Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(274, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "AZN";
            // 
            // totalFoodCostTextBox
            // 
            this.totalFoodCostTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.totalFoodCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalFoodCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFoodCostTextBox.Location = new System.Drawing.Point(146, 41);
            this.totalFoodCostTextBox.Name = "totalFoodCostTextBox";
            this.totalFoodCostTextBox.Size = new System.Drawing.Size(122, 46);
            this.totalFoodCostTextBox.TabIndex = 10;
            this.totalFoodCostTextBox.Text = "0.00";
            this.totalFoodCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Price";
            // 
            // hamburgerCheckBox
            // 
            this.hamburgerCheckBox.AutoSize = true;
            this.hamburgerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamburgerCheckBox.Location = new System.Drawing.Point(18, 113);
            this.hamburgerCheckBox.Name = "hamburgerCheckBox";
            this.hamburgerCheckBox.Size = new System.Drawing.Size(132, 28);
            this.hamburgerCheckBox.TabIndex = 6;
            this.hamburgerCheckBox.Text = "Hamburger";
            this.hamburgerCheckBox.UseVisualStyleBackColor = true;
            this.hamburgerCheckBox.CheckStateChanged += new System.EventHandler(this.hamburgerCheckBox_CheckStateChanged);
            // 
            // frenchFriesCheckBox
            // 
            this.frenchFriesCheckBox.AutoSize = true;
            this.frenchFriesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchFriesCheckBox.Location = new System.Drawing.Point(18, 163);
            this.frenchFriesCheckBox.Name = "frenchFriesCheckBox";
            this.frenchFriesCheckBox.Size = new System.Drawing.Size(144, 28);
            this.frenchFriesCheckBox.TabIndex = 5;
            this.frenchFriesCheckBox.Text = "French Fries";
            this.frenchFriesCheckBox.UseVisualStyleBackColor = true;
            this.frenchFriesCheckBox.CheckStateChanged += new System.EventHandler(this.frenchFriesCheckBox_CheckStateChanged);
            // 
            // cocaColaCheckBox
            // 
            this.cocaColaCheckBox.AutoSize = true;
            this.cocaColaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocaColaCheckBox.Location = new System.Drawing.Point(18, 214);
            this.cocaColaCheckBox.Name = "cocaColaCheckBox";
            this.cocaColaCheckBox.Size = new System.Drawing.Size(124, 28);
            this.cocaColaCheckBox.TabIndex = 4;
            this.cocaColaCheckBox.Text = "Coca-Cola";
            this.cocaColaCheckBox.UseVisualStyleBackColor = true;
            this.cocaColaCheckBox.CheckStateChanged += new System.EventHandler(this.cocaColaCheckBox_CheckStateChanged);
            // 
            // hotDogCheckBox
            // 
            this.hotDogCheckBox.AutoSize = true;
            this.hotDogCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotDogCheckBox.Location = new System.Drawing.Point(18, 61);
            this.hotDogCheckBox.Name = "hotDogCheckBox";
            this.hotDogCheckBox.Size = new System.Drawing.Size(106, 28);
            this.hotDogCheckBox.TabIndex = 3;
            this.hotDogCheckBox.Text = "Hot-Dog";
            this.hotDogCheckBox.UseVisualStyleBackColor = true;
            this.hotDogCheckBox.CheckStateChanged += new System.EventHandler(this.hotDogCheckBox_CheckStateChanged);
            // 
            // TotalCostGroupBox
            // 
            this.TotalCostGroupBox.Controls.Add(this.countTotalPriceButton);
            this.TotalCostGroupBox.Controls.Add(this.label10);
            this.TotalCostGroupBox.Controls.Add(this.clientTotalCostTextBox);
            this.TotalCostGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostGroupBox.Location = new System.Drawing.Point(37, 509);
            this.TotalCostGroupBox.Name = "TotalCostGroupBox";
            this.TotalCostGroupBox.Size = new System.Drawing.Size(794, 175);
            this.TotalCostGroupBox.TabIndex = 2;
            this.TotalCostGroupBox.TabStop = false;
            this.TotalCostGroupBox.Text = "Total Cost";
            // 
            // countTotalPriceButton
            // 
            this.countTotalPriceButton.Location = new System.Drawing.Point(132, 84);
            this.countTotalPriceButton.Name = "countTotalPriceButton";
            this.countTotalPriceButton.Size = new System.Drawing.Size(185, 65);
            this.countTotalPriceButton.TabIndex = 13;
            this.countTotalPriceButton.Text = "Count Total Price";
            this.countTotalPriceButton.UseVisualStyleBackColor = true;
            this.countTotalPriceButton.Click += new System.EventHandler(this.countTotalPriceButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(694, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "AZN";
            // 
            // clientTotalCostTextBox
            // 
            this.clientTotalCostTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.clientTotalCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientTotalCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientTotalCostTextBox.Location = new System.Drawing.Point(547, 103);
            this.clientTotalCostTextBox.Name = "clientTotalCostTextBox";
            this.clientTotalCostTextBox.Size = new System.Drawing.Size(122, 46);
            this.clientTotalCostTextBox.TabIndex = 11;
            this.clientTotalCostTextBox.Text = "0.00";
            this.clientTotalCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clientTotalCostTextBox.TextChanged += new System.EventHandler(this.clientTotalCostTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(875, 716);
            this.Controls.Add(this.TotalCostGroupBox);
            this.Controls.Add(this.MiniCafeGroupBox);
            this.Controls.Add(this.RefuellingGroupBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BestOIL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.RefuellingGroupBox.ResumeLayout(false);
            this.RefuellingGroupBox.PerformLayout();
            this.GasolineCostGroupBox.ResumeLayout(false);
            this.GasolineCostGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MiniCafeGroupBox.ResumeLayout(false);
            this.MiniCafeGroupBox.PerformLayout();
            this.FoodCostGroupBox.ResumeLayout(false);
            this.FoodCostGroupBox.PerformLayout();
            this.TotalCostGroupBox.ResumeLayout(false);
            this.TotalCostGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RefuellingGroupBox;
        private System.Windows.Forms.GroupBox MiniCafeGroupBox;
        private System.Windows.Forms.GroupBox TotalCostGroupBox;
        private System.Windows.Forms.ComboBox petrolChoiceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox petrolPricePerLitrTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costInputTextBox;
        private System.Windows.Forms.TextBox lirtesInputTextBox;
        private System.Windows.Forms.GroupBox GasolineCostGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalRefuellingCostTextBox;
        private System.Windows.Forms.RadioButton costInputRadioButton;
        private System.Windows.Forms.RadioButton litresInputRadioButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox FoodCostGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalFoodCostTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox hamburgerCheckBox;
        private System.Windows.Forms.CheckBox frenchFriesCheckBox;
        private System.Windows.Forms.CheckBox cocaColaCheckBox;
        private System.Windows.Forms.CheckBox hotDogCheckBox;
        private System.Windows.Forms.TextBox hotDogPriceTextBox;
        private System.Windows.Forms.TextBox hotDogCountTextBox;
        private System.Windows.Forms.TextBox cocaColaCountTextBox;
        private System.Windows.Forms.TextBox cocaColaPriceTextBox;
        private System.Windows.Forms.TextBox frenchFriesCountTextBox;
        private System.Windows.Forms.TextBox hamburgerPriceTextBox;
        private System.Windows.Forms.TextBox hamburgerCountTextBox;
        private System.Windows.Forms.TextBox frenchFriesPriceTextBox;
        private System.Windows.Forms.Button countTotalPriceButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox clientTotalCostTextBox;
    }
}

