namespace assignment8
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
            this.shirtsLabel = new System.Windows.Forms.Label();
            this.jeansLabel = new System.Windows.Forms.Label();
            this.inputShirtsAmount = new System.Windows.Forms.TextBox();
            this.inputJeansAmount = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.invoiceBox = new System.Windows.Forms.GroupBox();
            this.totalDisplayLabel = new System.Windows.Forms.Label();
            this.totalInstrucLabel = new System.Windows.Forms.Label();
            this.vatDisplayLabel = new System.Windows.Forms.Label();
            this.vatInstrucLabel = new System.Windows.Forms.Label();
            this.priceDisplayLabel = new System.Windows.Forms.Label();
            this.priceInstrucLabel = new System.Windows.Forms.Label();
            this.dateDisplayLabel = new System.Windows.Forms.Label();
            this.dateInstrucLabel = new System.Windows.Forms.Label();
            this.invoiceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shirtsLabel
            // 
            this.shirtsLabel.AutoSize = true;
            this.shirtsLabel.Location = new System.Drawing.Point(86, 66);
            this.shirtsLabel.Name = "shirtsLabel";
            this.shirtsLabel.Size = new System.Drawing.Size(204, 20);
            this.shirtsLabel.TabIndex = 0;
            this.shirtsLabel.Text = "Number of T-shirts  ( x 30,00):";
            // 
            // jeansLabel
            // 
            this.jeansLabel.AutoSize = true;
            this.jeansLabel.Location = new System.Drawing.Point(86, 111);
            this.jeansLabel.Name = "jeansLabel";
            this.jeansLabel.Size = new System.Drawing.Size(190, 20);
            this.jeansLabel.TabIndex = 1;
            this.jeansLabel.Text = "Number of jeans  ( x 30,00):";
            // 
            // inputShirtsAmount
            // 
            this.inputShirtsAmount.Location = new System.Drawing.Point(353, 66);
            this.inputShirtsAmount.Name = "inputShirtsAmount";
            this.inputShirtsAmount.Size = new System.Drawing.Size(125, 27);
            this.inputShirtsAmount.TabIndex = 2;
            // 
            // inputJeansAmount
            // 
            this.inputJeansAmount.Location = new System.Drawing.Point(353, 108);
            this.inputJeansAmount.Name = "inputJeansAmount";
            this.inputJeansAmount.Size = new System.Drawing.Size(125, 27);
            this.inputJeansAmount.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(86, 175);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(392, 29);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // invoiceBox
            // 
            this.invoiceBox.Controls.Add(this.totalDisplayLabel);
            this.invoiceBox.Controls.Add(this.totalInstrucLabel);
            this.invoiceBox.Controls.Add(this.vatDisplayLabel);
            this.invoiceBox.Controls.Add(this.vatInstrucLabel);
            this.invoiceBox.Controls.Add(this.priceDisplayLabel);
            this.invoiceBox.Controls.Add(this.priceInstrucLabel);
            this.invoiceBox.Controls.Add(this.dateDisplayLabel);
            this.invoiceBox.Controls.Add(this.dateInstrucLabel);
            this.invoiceBox.Location = new System.Drawing.Point(86, 236);
            this.invoiceBox.Name = "invoiceBox";
            this.invoiceBox.Size = new System.Drawing.Size(392, 163);
            this.invoiceBox.TabIndex = 5;
            this.invoiceBox.TabStop = false;
            this.invoiceBox.Text = "Invoice";
            this.invoiceBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // totalDisplayLabel
            // 
            this.totalDisplayLabel.AutoSize = true;
            this.totalDisplayLabel.Location = new System.Drawing.Point(267, 130);
            this.totalDisplayLabel.Name = "totalDisplayLabel";
            this.totalDisplayLabel.Size = new System.Drawing.Size(50, 20);
            this.totalDisplayLabel.TabIndex = 7;
            this.totalDisplayLabel.Text = "label1";
            // 
            // totalInstrucLabel
            // 
            this.totalInstrucLabel.AutoSize = true;
            this.totalInstrucLabel.Location = new System.Drawing.Point(6, 130);
            this.totalInstrucLabel.Name = "totalInstrucLabel";
            this.totalInstrucLabel.Size = new System.Drawing.Size(82, 20);
            this.totalInstrucLabel.TabIndex = 6;
            this.totalInstrucLabel.Text = "Total price:";
            // 
            // vatDisplayLabel
            // 
            this.vatDisplayLabel.AutoSize = true;
            this.vatDisplayLabel.Location = new System.Drawing.Point(267, 96);
            this.vatDisplayLabel.Name = "vatDisplayLabel";
            this.vatDisplayLabel.Size = new System.Drawing.Size(50, 20);
            this.vatDisplayLabel.TabIndex = 5;
            this.vatDisplayLabel.Text = "label1";
            // 
            // vatInstrucLabel
            // 
            this.vatInstrucLabel.AutoSize = true;
            this.vatInstrucLabel.Location = new System.Drawing.Point(6, 96);
            this.vatInstrucLabel.Name = "vatInstrucLabel";
            this.vatInstrucLabel.Size = new System.Drawing.Size(37, 20);
            this.vatInstrucLabel.TabIndex = 4;
            this.vatInstrucLabel.Text = "VAT:";
            // 
            // priceDisplayLabel
            // 
            this.priceDisplayLabel.AutoSize = true;
            this.priceDisplayLabel.Location = new System.Drawing.Point(267, 63);
            this.priceDisplayLabel.Name = "priceDisplayLabel";
            this.priceDisplayLabel.Size = new System.Drawing.Size(50, 20);
            this.priceDisplayLabel.TabIndex = 3;
            this.priceDisplayLabel.Text = "label1";
            // 
            // priceInstrucLabel
            // 
            this.priceInstrucLabel.AutoSize = true;
            this.priceInstrucLabel.Location = new System.Drawing.Point(6, 63);
            this.priceInstrucLabel.Name = "priceInstrucLabel";
            this.priceInstrucLabel.Size = new System.Drawing.Size(41, 20);
            this.priceInstrucLabel.TabIndex = 2;
            this.priceInstrucLabel.Text = "Price";
            // 
            // dateDisplayLabel
            // 
            this.dateDisplayLabel.AutoSize = true;
            this.dateDisplayLabel.Location = new System.Drawing.Point(267, 32);
            this.dateDisplayLabel.Name = "dateDisplayLabel";
            this.dateDisplayLabel.Size = new System.Drawing.Size(50, 20);
            this.dateDisplayLabel.TabIndex = 1;
            this.dateDisplayLabel.Text = "label1";
            // 
            // dateInstrucLabel
            // 
            this.dateInstrucLabel.AutoSize = true;
            this.dateInstrucLabel.Location = new System.Drawing.Point(6, 32);
            this.dateInstrucLabel.Name = "dateInstrucLabel";
            this.dateInstrucLabel.Size = new System.Drawing.Size(44, 20);
            this.dateInstrucLabel.TabIndex = 0;
            this.dateInstrucLabel.Text = "Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invoiceBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputJeansAmount);
            this.Controls.Add(this.inputShirtsAmount);
            this.Controls.Add(this.jeansLabel);
            this.Controls.Add(this.shirtsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.invoiceBox.ResumeLayout(false);
            this.invoiceBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label shirtsLabel;
        private Label jeansLabel;
        private TextBox inputShirtsAmount;
        private TextBox inputJeansAmount;
        private Button calculateButton;
        private GroupBox invoiceBox;
        private Label totalDisplayLabel;
        private Label totalInstrucLabel;
        private Label vatDisplayLabel;
        private Label vatInstrucLabel;
        private Label priceDisplayLabel;
        private Label priceInstrucLabel;
        private Label dateDisplayLabel;
        private Label dateInstrucLabel;
    }
}