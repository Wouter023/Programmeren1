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
            this.label1 = new System.Windows.Forms.Label();
            this.numberInputTextBox = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputFirstSumLabel = new System.Windows.Forms.Label();
            this.outputSecondSumLabel = new System.Windows.Forms.Label();
            this.outputEqualLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number (n)";
            // 
            // numberInputTextBox
            // 
            this.numberInputTextBox.Location = new System.Drawing.Point(220, 36);
            this.numberInputTextBox.Name = "numberInputTextBox";
            this.numberInputTextBox.Size = new System.Drawing.Size(125, 27);
            this.numberInputTextBox.TabIndex = 1;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(42, 85);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(303, 29);
            this.compareButton.TabIndex = 2;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "sum = 1 + 2 + ... + n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "sum = n * (n+1) / 2";
            // 
            // outputFirstSumLabel
            // 
            this.outputFirstSumLabel.AutoSize = true;
            this.outputFirstSumLabel.Location = new System.Drawing.Point(295, 141);
            this.outputFirstSumLabel.Name = "outputFirstSumLabel";
            this.outputFirstSumLabel.Size = new System.Drawing.Size(50, 20);
            this.outputFirstSumLabel.TabIndex = 5;
            this.outputFirstSumLabel.Text = "label4";
            // 
            // outputSecondSumLabel
            // 
            this.outputSecondSumLabel.AutoSize = true;
            this.outputSecondSumLabel.Location = new System.Drawing.Point(295, 185);
            this.outputSecondSumLabel.Name = "outputSecondSumLabel";
            this.outputSecondSumLabel.Size = new System.Drawing.Size(50, 20);
            this.outputSecondSumLabel.TabIndex = 6;
            this.outputSecondSumLabel.Text = "label4";
            // 
            // outputEqualLabel
            // 
            this.outputEqualLabel.AutoSize = true;
            this.outputEqualLabel.Location = new System.Drawing.Point(42, 235);
            this.outputEqualLabel.Name = "outputEqualLabel";
            this.outputEqualLabel.Size = new System.Drawing.Size(50, 20);
            this.outputEqualLabel.TabIndex = 7;
            this.outputEqualLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputEqualLabel);
            this.Controls.Add(this.outputSecondSumLabel);
            this.Controls.Add(this.outputFirstSumLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.numberInputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox numberInputTextBox;
        private Button compareButton;
        private Label label2;
        private Label label3;
        private Label outputFirstSumLabel;
        private Label outputSecondSumLabel;
        private Label outputEqualLabel;
    }
}