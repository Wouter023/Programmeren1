namespace assignment6
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
            this.label1 = new System.Windows.Forms.Label();
            this.amountInputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.showOutputFinalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start amount";
            // 
            // amountInputTextBox
            // 
            this.amountInputTextBox.Location = new System.Drawing.Point(197, 80);
            this.amountInputTextBox.Name = "amountInputTextBox";
            this.amountInputTextBox.Size = new System.Drawing.Size(125, 27);
            this.amountInputTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(57, 127);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(265, 29);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate final capital";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final capital";
            // 
            // showOutputFinalPrice
            // 
            this.showOutputFinalPrice.AutoSize = true;
            this.showOutputFinalPrice.Location = new System.Drawing.Point(272, 192);
            this.showOutputFinalPrice.Name = "showOutputFinalPrice";
            this.showOutputFinalPrice.Size = new System.Drawing.Size(50, 20);
            this.showOutputFinalPrice.TabIndex = 4;
            this.showOutputFinalPrice.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showOutputFinalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.amountInputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox amountInputTextBox;
        private Button calculateButton;
        private Label label2;
        private Label showOutputFinalPrice;
    }
}