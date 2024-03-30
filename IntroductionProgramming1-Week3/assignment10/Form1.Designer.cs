namespace assignment10
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
            this.ageNameLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.calculatePriceButton = new System.Windows.Forms.Button();
            this.priceTicketLabel = new System.Windows.Forms.Label();
            this.priceOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ageNameLabel
            // 
            this.ageNameLabel.AutoSize = true;
            this.ageNameLabel.Location = new System.Drawing.Point(105, 75);
            this.ageNameLabel.Name = "ageNameLabel";
            this.ageNameLabel.Size = new System.Drawing.Size(36, 20);
            this.ageNameLabel.TabIndex = 0;
            this.ageNameLabel.Text = "Age";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(280, 72);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(125, 27);
            this.ageTextBox.TabIndex = 1;
            // 
            // calculatePriceButton
            // 
            this.calculatePriceButton.Location = new System.Drawing.Point(105, 138);
            this.calculatePriceButton.Name = "calculatePriceButton";
            this.calculatePriceButton.Size = new System.Drawing.Size(300, 29);
            this.calculatePriceButton.TabIndex = 2;
            this.calculatePriceButton.Text = "Calculate Price";
            this.calculatePriceButton.UseVisualStyleBackColor = true;
            this.calculatePriceButton.Click += new System.EventHandler(this.calculatePriceButton_Click);
            // 
            // priceTicketLabel
            // 
            this.priceTicketLabel.AutoSize = true;
            this.priceTicketLabel.Location = new System.Drawing.Point(105, 216);
            this.priceTicketLabel.Name = "priceTicketLabel";
            this.priceTicketLabel.Size = new System.Drawing.Size(81, 20);
            this.priceTicketLabel.TabIndex = 3;
            this.priceTicketLabel.Text = "Price ticket";
            // 
            // priceOutputLabel
            // 
            this.priceOutputLabel.AutoSize = true;
            this.priceOutputLabel.Location = new System.Drawing.Point(280, 216);
            this.priceOutputLabel.Name = "priceOutputLabel";
            this.priceOutputLabel.Size = new System.Drawing.Size(50, 20);
            this.priceOutputLabel.TabIndex = 4;
            this.priceOutputLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceOutputLabel);
            this.Controls.Add(this.priceTicketLabel);
            this.Controls.Add(this.calculatePriceButton);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.ageNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ageNameLabel;
        private TextBox ageTextBox;
        private Button calculatePriceButton;
        private Label priceTicketLabel;
        private Label priceOutputLabel;
    }
}