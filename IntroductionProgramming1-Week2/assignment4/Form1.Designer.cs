namespace assignment4
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
            this.enterPriceLabe = new System.Windows.Forms.Label();
            this.userPriceInput = new System.Windows.Forms.TextBox();
            this.calculatePriceButton = new System.Windows.Forms.Button();
            this.priceNameLabel = new System.Windows.Forms.Label();
            this.vatNameLabel = new System.Windows.Forms.Label();
            this.totalNameLabel = new System.Windows.Forms.Label();
            this.outputPriceLabel = new System.Windows.Forms.Label();
            this.outputVatLabel = new System.Windows.Forms.Label();
            this.outputTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterPriceLabe
            // 
            this.enterPriceLabe.AutoSize = true;
            this.enterPriceLabe.Location = new System.Drawing.Point(99, 83);
            this.enterPriceLabe.Name = "enterPriceLabe";
            this.enterPriceLabe.Size = new System.Drawing.Size(95, 20);
            this.enterPriceLabe.TabIndex = 0;
            this.enterPriceLabe.Text = "Enter a price:";
            // 
            // userPriceInput
            // 
            this.userPriceInput.Location = new System.Drawing.Point(285, 80);
            this.userPriceInput.Name = "userPriceInput";
            this.userPriceInput.Size = new System.Drawing.Size(140, 27);
            this.userPriceInput.TabIndex = 1;
            // 
            // calculatePriceButton
            // 
            this.calculatePriceButton.Location = new System.Drawing.Point(100, 142);
            this.calculatePriceButton.Name = "calculatePriceButton";
            this.calculatePriceButton.Size = new System.Drawing.Size(325, 29);
            this.calculatePriceButton.TabIndex = 2;
            this.calculatePriceButton.Text = "Determine VAT";
            this.calculatePriceButton.UseVisualStyleBackColor = true;
            this.calculatePriceButton.Click += new System.EventHandler(this.calculatePriceButton_Click);
            // 
            // priceNameLabel
            // 
            this.priceNameLabel.AutoSize = true;
            this.priceNameLabel.Location = new System.Drawing.Point(100, 230);
            this.priceNameLabel.Name = "priceNameLabel";
            this.priceNameLabel.Size = new System.Drawing.Size(44, 20);
            this.priceNameLabel.TabIndex = 3;
            this.priceNameLabel.Text = "Price:";
            // 
            // vatNameLabel
            // 
            this.vatNameLabel.AutoSize = true;
            this.vatNameLabel.Location = new System.Drawing.Point(100, 270);
            this.vatNameLabel.Name = "vatNameLabel";
            this.vatNameLabel.Size = new System.Drawing.Size(37, 20);
            this.vatNameLabel.TabIndex = 4;
            this.vatNameLabel.Text = "VAT:";
            // 
            // totalNameLabel
            // 
            this.totalNameLabel.AutoSize = true;
            this.totalNameLabel.Location = new System.Drawing.Point(100, 311);
            this.totalNameLabel.Name = "totalNameLabel";
            this.totalNameLabel.Size = new System.Drawing.Size(45, 20);
            this.totalNameLabel.TabIndex = 5;
            this.totalNameLabel.Text = "Total:";
            // 
            // outputPriceLabel
            // 
            this.outputPriceLabel.AutoSize = true;
            this.outputPriceLabel.Location = new System.Drawing.Point(375, 230);
            this.outputPriceLabel.Name = "outputPriceLabel";
            this.outputPriceLabel.Size = new System.Drawing.Size(50, 20);
            this.outputPriceLabel.TabIndex = 6;
            this.outputPriceLabel.Text = "label1";
            // 
            // outputVatLabel
            // 
            this.outputVatLabel.AutoSize = true;
            this.outputVatLabel.Location = new System.Drawing.Point(375, 270);
            this.outputVatLabel.Name = "outputVatLabel";
            this.outputVatLabel.Size = new System.Drawing.Size(50, 20);
            this.outputVatLabel.TabIndex = 7;
            this.outputVatLabel.Text = "label1";
            // 
            // outputTotalLabel
            // 
            this.outputTotalLabel.AutoSize = true;
            this.outputTotalLabel.Location = new System.Drawing.Point(375, 311);
            this.outputTotalLabel.Name = "outputTotalLabel";
            this.outputTotalLabel.Size = new System.Drawing.Size(50, 20);
            this.outputTotalLabel.TabIndex = 8;
            this.outputTotalLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputTotalLabel);
            this.Controls.Add(this.outputVatLabel);
            this.Controls.Add(this.outputPriceLabel);
            this.Controls.Add(this.totalNameLabel);
            this.Controls.Add(this.vatNameLabel);
            this.Controls.Add(this.priceNameLabel);
            this.Controls.Add(this.calculatePriceButton);
            this.Controls.Add(this.userPriceInput);
            this.Controls.Add(this.enterPriceLabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label enterPriceLabe;
        private TextBox userPriceInput;
        private Button calculatePriceButton;
        private Label priceNameLabel;
        private Label vatNameLabel;
        private Label totalNameLabel;
        private Label outputPriceLabel;
        private Label outputVatLabel;
        private Label outputTotalLabel;
    }
}