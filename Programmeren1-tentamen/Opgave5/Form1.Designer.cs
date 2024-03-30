namespace Opgave5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.klasseTextLabel = new System.Windows.Forms.Label();
            this.tweedeKlasseRadioButton = new System.Windows.Forms.RadioButton();
            this.eersteKlasseRadioButton = new System.Windows.Forms.RadioButton();
            this.aantalTextLabel = new System.Windows.Forms.Label();
            this.aantalInputTextbox = new System.Windows.Forms.TextBox();
            this.railrunnerTextLabel = new System.Windows.Forms.Label();
            this.railrunnerInputTextbox = new System.Windows.Forms.TextBox();
            this.calculatePriceButton = new System.Windows.Forms.Button();
            this.prijsLabel = new System.Windows.Forms.Label();
            this.priceOutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // klasseTextLabel
            // 
            this.klasseTextLabel.AutoSize = true;
            this.klasseTextLabel.Location = new System.Drawing.Point(47, 37);
            this.klasseTextLabel.Name = "klasseTextLabel";
            this.klasseTextLabel.Size = new System.Drawing.Size(53, 20);
            this.klasseTextLabel.TabIndex = 0;
            this.klasseTextLabel.Text = "Klasse:";
            // 
            // tweedeKlasseRadioButton
            // 
            this.tweedeKlasseRadioButton.AutoSize = true;
            this.tweedeKlasseRadioButton.Location = new System.Drawing.Point(183, 35);
            this.tweedeKlasseRadioButton.Name = "tweedeKlasseRadioButton";
            this.tweedeKlasseRadioButton.Size = new System.Drawing.Size(91, 24);
            this.tweedeKlasseRadioButton.TabIndex = 1;
            this.tweedeKlasseRadioButton.TabStop = true;
            this.tweedeKlasseRadioButton.Text = "2e Klasse";
            this.tweedeKlasseRadioButton.UseVisualStyleBackColor = true;
            // 
            // eersteKlasseRadioButton
            // 
            this.eersteKlasseRadioButton.AutoSize = true;
            this.eersteKlasseRadioButton.Location = new System.Drawing.Point(302, 35);
            this.eersteKlasseRadioButton.Name = "eersteKlasseRadioButton";
            this.eersteKlasseRadioButton.Size = new System.Drawing.Size(91, 24);
            this.eersteKlasseRadioButton.TabIndex = 2;
            this.eersteKlasseRadioButton.TabStop = true;
            this.eersteKlasseRadioButton.Text = "1e Klasse";
            this.eersteKlasseRadioButton.UseVisualStyleBackColor = true;
            // 
            // aantalTextLabel
            // 
            this.aantalTextLabel.AutoSize = true;
            this.aantalTextLabel.Location = new System.Drawing.Point(50, 78);
            this.aantalTextLabel.Name = "aantalTextLabel";
            this.aantalTextLabel.Size = new System.Drawing.Size(55, 20);
            this.aantalTextLabel.TabIndex = 3;
            this.aantalTextLabel.Text = "Aantal:";
            // 
            // aantalInputTextbox
            // 
            this.aantalInputTextbox.Location = new System.Drawing.Point(183, 75);
            this.aantalInputTextbox.Name = "aantalInputTextbox";
            this.aantalInputTextbox.Size = new System.Drawing.Size(125, 27);
            this.aantalInputTextbox.TabIndex = 4;
            // 
            // railrunnerTextLabel
            // 
            this.railrunnerTextLabel.AutoSize = true;
            this.railrunnerTextLabel.Location = new System.Drawing.Point(50, 120);
            this.railrunnerTextLabel.Name = "railrunnerTextLabel";
            this.railrunnerTextLabel.Size = new System.Drawing.Size(76, 20);
            this.railrunnerTextLabel.TabIndex = 5;
            this.railrunnerTextLabel.Text = "Railrunner";
            // 
            // railrunnerInputTextbox
            // 
            this.railrunnerInputTextbox.Location = new System.Drawing.Point(183, 117);
            this.railrunnerInputTextbox.Name = "railrunnerInputTextbox";
            this.railrunnerInputTextbox.Size = new System.Drawing.Size(125, 27);
            this.railrunnerInputTextbox.TabIndex = 6;
            // 
            // calculatePriceButton
            // 
            this.calculatePriceButton.Location = new System.Drawing.Point(183, 185);
            this.calculatePriceButton.Name = "calculatePriceButton";
            this.calculatePriceButton.Size = new System.Drawing.Size(125, 29);
            this.calculatePriceButton.TabIndex = 7;
            this.calculatePriceButton.Text = "Bereken";
            this.calculatePriceButton.UseVisualStyleBackColor = true;
            this.calculatePriceButton.Click += new System.EventHandler(this.calculatePriceButton_Click);
            // 
            // prijsLabel
            // 
            this.prijsLabel.AutoSize = true;
            this.prijsLabel.Location = new System.Drawing.Point(55, 236);
            this.prijsLabel.Name = "prijsLabel";
            this.prijsLabel.Size = new System.Drawing.Size(39, 20);
            this.prijsLabel.TabIndex = 8;
            this.prijsLabel.Text = "Prijs:";
            // 
            // priceOutputTextBox
            // 
            this.priceOutputTextBox.Location = new System.Drawing.Point(183, 233);
            this.priceOutputTextBox.Name = "priceOutputTextBox";
            this.priceOutputTextBox.Size = new System.Drawing.Size(125, 27);
            this.priceOutputTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceOutputTextBox);
            this.Controls.Add(this.prijsLabel);
            this.Controls.Add(this.calculatePriceButton);
            this.Controls.Add(this.railrunnerInputTextbox);
            this.Controls.Add(this.railrunnerTextLabel);
            this.Controls.Add(this.aantalInputTextbox);
            this.Controls.Add(this.aantalTextLabel);
            this.Controls.Add(this.eersteKlasseRadioButton);
            this.Controls.Add(this.tweedeKlasseRadioButton);
            this.Controls.Add(this.klasseTextLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label klasseTextLabel;
        private RadioButton tweedeKlasseRadioButton;
        private RadioButton eersteKlasseRadioButton;
        private Label aantalTextLabel;
        private TextBox aantalInputTextbox;
        private Label railrunnerTextLabel;
        private TextBox railrunnerInputTextbox;
        private Button calculatePriceButton;
        private Label prijsLabel;
        private TextBox priceOutputTextBox;
    }
}