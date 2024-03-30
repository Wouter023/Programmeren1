namespace assignment5
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
            this.number1Label = new System.Windows.Forms.Label();
            this.number2Label = new System.Windows.Forms.Label();
            this.number3Label = new System.Windows.Forms.Label();
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.inputBox3 = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.outputAverageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number1Label
            // 
            this.number1Label.AutoSize = true;
            this.number1Label.Location = new System.Drawing.Point(108, 73);
            this.number1Label.Name = "number1Label";
            this.number1Label.Size = new System.Drawing.Size(75, 20);
            this.number1Label.TabIndex = 0;
            this.number1Label.Text = "Number 1";
            // 
            // number2Label
            // 
            this.number2Label.AutoSize = true;
            this.number2Label.Location = new System.Drawing.Point(108, 125);
            this.number2Label.Name = "number2Label";
            this.number2Label.Size = new System.Drawing.Size(75, 20);
            this.number2Label.TabIndex = 1;
            this.number2Label.Text = "Number 2";
            // 
            // number3Label
            // 
            this.number3Label.AutoSize = true;
            this.number3Label.Location = new System.Drawing.Point(108, 178);
            this.number3Label.Name = "number3Label";
            this.number3Label.Size = new System.Drawing.Size(75, 20);
            this.number3Label.TabIndex = 2;
            this.number3Label.Text = "Number 3";
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(329, 70);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(125, 27);
            this.inputBox1.TabIndex = 3;
            // 
            // inputBox2
            // 
            this.inputBox2.Location = new System.Drawing.Point(329, 122);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(125, 27);
            this.inputBox2.TabIndex = 4;
            // 
            // inputBox3
            // 
            this.inputBox3.Location = new System.Drawing.Point(329, 175);
            this.inputBox3.Name = "inputBox3";
            this.inputBox3.Size = new System.Drawing.Size(125, 27);
            this.inputBox3.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(108, 224);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(346, 29);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(108, 286);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(64, 20);
            this.averageLabel.TabIndex = 7;
            this.averageLabel.Text = "Average";
            // 
            // outputAverageLabel
            // 
            this.outputAverageLabel.AutoSize = true;
            this.outputAverageLabel.Location = new System.Drawing.Point(329, 286);
            this.outputAverageLabel.Name = "outputAverageLabel";
            this.outputAverageLabel.Size = new System.Drawing.Size(50, 20);
            this.outputAverageLabel.TabIndex = 8;
            this.outputAverageLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputBox3);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.number3Label);
            this.Controls.Add(this.number2Label);
            this.Controls.Add(this.number1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label number1Label;
        private Label number2Label;
        private Label number3Label;
        private TextBox inputBox1;
        private TextBox inputBox2;
        private TextBox inputBox3;
        private Button calculateButton;
        private Label averageLabel;
        private Label outputAverageLabel;
    }
}