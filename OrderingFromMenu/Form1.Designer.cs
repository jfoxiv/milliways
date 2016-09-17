namespace OrderingFromMenu {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.comboBoxBeverages = new System.Windows.Forms.ComboBox();
            this.comboBoxAppetizers = new System.Windows.Forms.ComboBox();
            this.comboBoxDesserts = new System.Windows.Forms.ComboBox();
            this.comboBoxMainCourses = new System.Windows.Forms.ComboBox();
            this.labelBeverage = new System.Windows.Forms.Label();
            this.labelAppetizer = new System.Windows.Forms.Label();
            this.labelMainCourses = new System.Windows.Forms.Label();
            this.labelDesserts = new System.Windows.Forms.Label();
            this.textBoxItemSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxItemTax = new System.Windows.Forms.TextBox();
            this.textBoxRunningTotal = new System.Windows.Forms.TextBox();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.bindingSourceDictToBevComboBox = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDictToBevComboBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxBeverages
            // 
            this.comboBoxBeverages.FormattingEnabled = true;
            this.comboBoxBeverages.Location = new System.Drawing.Point(53, 61);
            this.comboBoxBeverages.Name = "comboBoxBeverages";
            this.comboBoxBeverages.Size = new System.Drawing.Size(171, 21);
            this.comboBoxBeverages.TabIndex = 0;
            this.comboBoxBeverages.SelectedIndexChanged += new System.EventHandler(this.comboBoxBeverages_SelectedIndexChanged);
            // 
            // comboBoxAppetizers
            // 
            this.comboBoxAppetizers.FormattingEnabled = true;
            this.comboBoxAppetizers.Location = new System.Drawing.Point(53, 127);
            this.comboBoxAppetizers.Name = "comboBoxAppetizers";
            this.comboBoxAppetizers.Size = new System.Drawing.Size(171, 21);
            this.comboBoxAppetizers.TabIndex = 1;
            this.comboBoxAppetizers.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppetizers_SelectedIndexChanged);
            // 
            // comboBoxDesserts
            // 
            this.comboBoxDesserts.FormattingEnabled = true;
            this.comboBoxDesserts.Location = new System.Drawing.Point(53, 268);
            this.comboBoxDesserts.Name = "comboBoxDesserts";
            this.comboBoxDesserts.Size = new System.Drawing.Size(171, 21);
            this.comboBoxDesserts.TabIndex = 2;
            this.comboBoxDesserts.SelectedIndexChanged += new System.EventHandler(this.comboBoxDesserts_SelectedIndexChanged);
            // 
            // comboBoxMainCourses
            // 
            this.comboBoxMainCourses.FormattingEnabled = true;
            this.comboBoxMainCourses.Location = new System.Drawing.Point(53, 199);
            this.comboBoxMainCourses.Name = "comboBoxMainCourses";
            this.comboBoxMainCourses.Size = new System.Drawing.Size(171, 21);
            this.comboBoxMainCourses.TabIndex = 3;
            this.comboBoxMainCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainCourses_SelectedIndexChanged);
            // 
            // labelBeverage
            // 
            this.labelBeverage.AutoSize = true;
            this.labelBeverage.Location = new System.Drawing.Point(53, 42);
            this.labelBeverage.Name = "labelBeverage";
            this.labelBeverage.Size = new System.Drawing.Size(58, 13);
            this.labelBeverage.TabIndex = 4;
            this.labelBeverage.Text = "Beverages";
            // 
            // labelAppetizer
            // 
            this.labelAppetizer.AutoSize = true;
            this.labelAppetizer.Location = new System.Drawing.Point(53, 108);
            this.labelAppetizer.Name = "labelAppetizer";
            this.labelAppetizer.Size = new System.Drawing.Size(56, 13);
            this.labelAppetizer.TabIndex = 5;
            this.labelAppetizer.Text = "Appetizers";
            // 
            // labelMainCourses
            // 
            this.labelMainCourses.AutoSize = true;
            this.labelMainCourses.Location = new System.Drawing.Point(53, 180);
            this.labelMainCourses.Name = "labelMainCourses";
            this.labelMainCourses.Size = new System.Drawing.Size(71, 13);
            this.labelMainCourses.TabIndex = 6;
            this.labelMainCourses.Text = "Main Courses";
            // 
            // labelDesserts
            // 
            this.labelDesserts.AutoSize = true;
            this.labelDesserts.Location = new System.Drawing.Point(56, 249);
            this.labelDesserts.Name = "labelDesserts";
            this.labelDesserts.Size = new System.Drawing.Size(48, 13);
            this.labelDesserts.TabIndex = 7;
            this.labelDesserts.Text = "Desserts";
            // 
            // textBoxItemSubtotal
            // 
            this.textBoxItemSubtotal.Location = new System.Drawing.Point(263, 200);
            this.textBoxItemSubtotal.Name = "textBoxItemSubtotal";
            this.textBoxItemSubtotal.Size = new System.Drawing.Size(170, 20);
            this.textBoxItemSubtotal.TabIndex = 8;
            this.textBoxItemSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxItemTax
            // 
            this.textBoxItemTax.Location = new System.Drawing.Point(260, 127);
            this.textBoxItemTax.Name = "textBoxItemTax";
            this.textBoxItemTax.Size = new System.Drawing.Size(170, 20);
            this.textBoxItemTax.TabIndex = 9;
            this.textBoxItemTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxRunningTotal
            // 
            this.textBoxRunningTotal.Location = new System.Drawing.Point(260, 269);
            this.textBoxRunningTotal.Name = "textBoxRunningTotal";
            this.textBoxRunningTotal.Size = new System.Drawing.Size(170, 20);
            this.textBoxRunningTotal.TabIndex = 10;
            this.textBoxRunningTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(3, 3);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(154, 63);
            this.buttonClearFields.TabIndex = 11;
            this.buttonClearFields.Text = "Clear Cost Fields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(263, 184);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(66, 13);
            this.labelSubtotal.TabIndex = 12;
            this.labelSubtotal.Text = "ItemSubtotal";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(263, 108);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(48, 13);
            this.labelTax.TabIndex = 13;
            this.labelTax.Text = "Item Tax";
            this.labelTax.UseMnemonic = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(260, 247);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(74, 13);
            this.labelTotal.TabIndex = 14;
            this.labelTotal.Text = "Running Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OrderingFromMenu.Properties.Resources.dont_panic_png;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(493, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 138);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Seven bucks for chips and salsa? Seriously?");
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Location = new System.Drawing.Point(260, 61);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(167, 20);
            this.textBoxItemPrice.TabIndex = 16;
            this.textBoxItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Location = new System.Drawing.Point(260, 45);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(54, 13);
            this.labelItemPrice.TabIndex = 17;
            this.labelItemPrice.Text = "Item Price";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Controls.Add(this.buttonClearFields);
            this.panel1.Location = new System.Drawing.Point(493, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 138);
            this.panel1.TabIndex = 18;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(3, 72);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(154, 61);
            this.buttonQuit.TabIndex = 12;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 332);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelItemPrice);
            this.Controls.Add(this.textBoxItemPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.textBoxRunningTotal);
            this.Controls.Add(this.textBoxItemTax);
            this.Controls.Add(this.textBoxItemSubtotal);
            this.Controls.Add(this.labelDesserts);
            this.Controls.Add(this.labelMainCourses);
            this.Controls.Add(this.labelAppetizer);
            this.Controls.Add(this.labelBeverage);
            this.Controls.Add(this.comboBoxMainCourses);
            this.Controls.Add(this.comboBoxDesserts);
            this.Controls.Add(this.comboBoxAppetizers);
            this.Controls.Add(this.comboBoxBeverages);
            this.Name = "Form1";
            this.Text = "Welcome to Milliways, the Restaurant at the End of the Universe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDictToBevComboBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBeverages;
        private System.Windows.Forms.ComboBox comboBoxAppetizers;
        private System.Windows.Forms.ComboBox comboBoxDesserts;
        private System.Windows.Forms.ComboBox comboBoxMainCourses;
        private System.Windows.Forms.Label labelBeverage;
        private System.Windows.Forms.Label labelAppetizer;
        private System.Windows.Forms.Label labelMainCourses;
        private System.Windows.Forms.Label labelDesserts;
        private System.Windows.Forms.TextBox textBoxItemSubtotal;
        private System.Windows.Forms.TextBox textBoxItemTax;
        private System.Windows.Forms.TextBox textBoxRunningTotal;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.BindingSource bindingSourceDictToBevComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuit;
    }
}

