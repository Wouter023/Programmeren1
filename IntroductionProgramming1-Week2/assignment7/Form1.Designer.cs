namespace assignment7
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
            this.startKmLabel = new System.Windows.Forms.Label();
            this.endKmLabel = new System.Windows.Forms.Label();
            this.pricePerKmLabel = new System.Windows.Forms.Label();
            this.startKmInputTextBox = new System.Windows.Forms.TextBox();
            this.endKmInputTextBox = new System.Windows.Forms.TextBox();
            this.pricePerKmInputTextBox = new System.Windows.Forms.TextBox();
            this.eraseButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exclVatLabel = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.inclLabel = new System.Windows.Forms.Label();
            this.outputPriceExVat = new System.Windows.Forms.Label();
            this.outputVatPrice = new System.Windows.Forms.Label();
            this.outputPriceInVat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startKmLabel
            // 
            this.startKmLabel.AutoSize = true;
            this.startKmLabel.Location = new System.Drawing.Point(84, 76);
            this.startKmLabel.Name = "startKmLabel";
            this.startKmLabel.Size = new System.Drawing.Size(64, 20);
            this.startKmLabel.TabIndex = 0;
            this.startKmLabel.Text = "Start km";
            // 
            // endKmLabel
            // 
            this.endKmLabel.AutoSize = true;
            this.endKmLabel.Location = new System.Drawing.Point(84, 121);
            this.endKmLabel.Name = "endKmLabel";
            this.endKmLabel.Size = new System.Drawing.Size(58, 20);
            this.endKmLabel.TabIndex = 1;
            this.endKmLabel.Text = "End km";
            // 
            // pricePerKmLabel
            // 
            this.pricePerKmLabel.AutoSize = true;
            this.pricePerKmLabel.Location = new System.Drawing.Point(84, 171);
            this.pricePerKmLabel.Name = "pricePerKmLabel";
            this.pricePerKmLabel.Size = new System.Drawing.Size(75, 20);
            this.pricePerKmLabel.TabIndex = 2;
            this.pricePerKmLabel.Text = "Price / km";
            // 
            // startKmInputTextBox
            // 
            this.startKmInputTextBox.Location = new System.Drawing.Point(280, 73);
            this.startKmInputTextBox.Name = "startKmInputTextBox";
            this.startKmInputTextBox.Size = new System.Drawing.Size(125, 27);
            this.startKmInputTextBox.TabIndex = 3;
            // 
            // endKmInputTextBox
            // 
            this.endKmInputTextBox.Location = new System.Drawing.Point(280, 118);
            this.endKmInputTextBox.Name = "endKmInputTextBox";
            this.endKmInputTextBox.Size = new System.Drawing.Size(125, 27);
            this.endKmInputTextBox.TabIndex = 4;
            // 
            // pricePerKmInputTextBox
            // 
            this.pricePerKmInputTextBox.Location = new System.Drawing.Point(280, 168);
            this.pricePerKmInputTextBox.Name = "pricePerKmInputTextBox";
            this.pricePerKmInputTextBox.Size = new System.Drawing.Size(125, 27);
            this.pricePerKmInputTextBox.TabIndex = 5;
            // 
            // eraseButton
            // 
            this.eraseButton.Location = new System.Drawing.Point(515, 72);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(94, 29);
            this.eraseButton.TabIndex = 6;
            this.eraseButton.Text = "Erase";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(515, 167);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 29);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exclVatLabel
            // 
            this.exclVatLabel.AutoSize = true;
            this.exclVatLabel.Location = new System.Drawing.Point(84, 276);
            this.exclVatLabel.Name = "exclVatLabel";
            this.exclVatLabel.Size = new System.Drawing.Size(100, 20);
            this.exclVatLabel.TabIndex = 8;
            this.exclVatLabel.Text = "Price excl VAT";
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.Location = new System.Drawing.Point(280, 276);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(34, 20);
            this.vatLabel.TabIndex = 9;
            this.vatLabel.Text = "VAT";
            // 
            // inclLabel
            // 
            this.inclLabel.AutoSize = true;
            this.inclLabel.Location = new System.Drawing.Point(515, 276);
            this.inclLabel.Name = "inclLabel";
            this.inclLabel.Size = new System.Drawing.Size(97, 20);
            this.inclLabel.TabIndex = 10;
            this.inclLabel.Text = "Price incl VAT";
            // 
            // outputPriceExVat
            // 
            this.outputPriceExVat.AutoSize = true;
            this.outputPriceExVat.Location = new System.Drawing.Point(84, 323);
            this.outputPriceExVat.Name = "outputPriceExVat";
            this.outputPriceExVat.Size = new System.Drawing.Size(50, 20);
            this.outputPriceExVat.TabIndex = 11;
            this.outputPriceExVat.Text = "label1";
            // 
            // outputVatPrice
            // 
            this.outputVatPrice.AutoSize = true;
            this.outputVatPrice.Location = new System.Drawing.Point(280, 323);
            this.outputVatPrice.Name = "outputVatPrice";
            this.outputVatPrice.Size = new System.Drawing.Size(50, 20);
            this.outputVatPrice.TabIndex = 12;
            this.outputVatPrice.Text = "label1";
            // 
            // outputPriceInVat
            // 
            this.outputPriceInVat.AutoSize = true;
            this.outputPriceInVat.Location = new System.Drawing.Point(515, 323);
            this.outputPriceInVat.Name = "outputPriceInVat";
            this.outputPriceInVat.Size = new System.Drawing.Size(50, 20);
            this.outputPriceInVat.TabIndex = 13;
            this.outputPriceInVat.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputPriceInVat);
            this.Controls.Add(this.outputVatPrice);
            this.Controls.Add(this.outputPriceExVat);
            this.Controls.Add(this.inclLabel);
            this.Controls.Add(this.vatLabel);
            this.Controls.Add(this.exclVatLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.pricePerKmInputTextBox);
            this.Controls.Add(this.endKmInputTextBox);
            this.Controls.Add(this.startKmInputTextBox);
            this.Controls.Add(this.pricePerKmLabel);
            this.Controls.Add(this.endKmLabel);
            this.Controls.Add(this.startKmLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label startKmLabel;
        private Label endKmLabel;
        private Label pricePerKmLabel;
        private TextBox startKmInputTextBox;
        private TextBox endKmInputTextBox;
        private TextBox pricePerKmInputTextBox;
        private Button eraseButton;
        private Button calculateButton;
        private Label exclVatLabel;
        private Label vatLabel;
        private Label inclLabel;
        private Label outputPriceExVat;
        private Label outputVatPrice;
        private Label outputPriceInVat;
    }
}