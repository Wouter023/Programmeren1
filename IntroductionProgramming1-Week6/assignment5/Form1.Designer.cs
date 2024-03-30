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
            this.numberOneLabel = new System.Windows.Forms.Label();
            this.numberTwoLabel = new System.Windows.Forms.Label();
            this.numberOneInputTextBox = new System.Windows.Forms.TextBox();
            this.numberTwoInputTextBox = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multipleButton = new System.Windows.Forms.Button();
            this.deviderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberOneLabel
            // 
            this.numberOneLabel.AutoSize = true;
            this.numberOneLabel.Location = new System.Drawing.Point(57, 47);
            this.numberOneLabel.Name = "numberOneLabel";
            this.numberOneLabel.Size = new System.Drawing.Size(75, 20);
            this.numberOneLabel.TabIndex = 0;
            this.numberOneLabel.Text = "Number 1";
            // 
            // numberTwoLabel
            // 
            this.numberTwoLabel.AutoSize = true;
            this.numberTwoLabel.Location = new System.Drawing.Point(57, 85);
            this.numberTwoLabel.Name = "numberTwoLabel";
            this.numberTwoLabel.Size = new System.Drawing.Size(75, 20);
            this.numberTwoLabel.TabIndex = 1;
            this.numberTwoLabel.Text = "Number 2";
            // 
            // numberOneInputTextBox
            // 
            this.numberOneInputTextBox.Location = new System.Drawing.Point(191, 44);
            this.numberOneInputTextBox.Name = "numberOneInputTextBox";
            this.numberOneInputTextBox.Size = new System.Drawing.Size(222, 27);
            this.numberOneInputTextBox.TabIndex = 2;
            // 
            // numberTwoInputTextBox
            // 
            this.numberTwoInputTextBox.Location = new System.Drawing.Point(191, 82);
            this.numberTwoInputTextBox.Name = "numberTwoInputTextBox";
            this.numberTwoInputTextBox.Size = new System.Drawing.Size(222, 27);
            this.numberTwoInputTextBox.TabIndex = 3;
            // 
            // sumButton
            // 
            this.sumButton.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumButton.Location = new System.Drawing.Point(57, 150);
            this.sumButton.Margin = new System.Windows.Forms.Padding(0);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(100, 100);
            this.sumButton.TabIndex = 4;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusButton.Location = new System.Drawing.Point(207, 150);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(100, 100);
            this.minusButton.TabIndex = 5;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // multipleButton
            // 
            this.multipleButton.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multipleButton.Location = new System.Drawing.Point(358, 150);
            this.multipleButton.Name = "multipleButton";
            this.multipleButton.Size = new System.Drawing.Size(100, 100);
            this.multipleButton.TabIndex = 6;
            this.multipleButton.Text = "x";
            this.multipleButton.UseVisualStyleBackColor = true;
            this.multipleButton.Click += new System.EventHandler(this.multipleButton_Click);
            // 
            // deviderButton
            // 
            this.deviderButton.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviderButton.Location = new System.Drawing.Point(504, 150);
            this.deviderButton.Name = "deviderButton";
            this.deviderButton.Size = new System.Drawing.Size(100, 100);
            this.deviderButton.TabIndex = 7;
            this.deviderButton.Text = ":";
            this.deviderButton.UseVisualStyleBackColor = true;
            this.deviderButton.Click += new System.EventHandler(this.deviderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // resultOutputLabel
            // 
            this.resultOutputLabel.AutoSize = true;
            this.resultOutputLabel.Location = new System.Drawing.Point(191, 310);
            this.resultOutputLabel.Name = "resultOutputLabel";
            this.resultOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.resultOutputLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultOutputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deviderButton);
            this.Controls.Add(this.multipleButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.numberTwoInputTextBox);
            this.Controls.Add(this.numberOneInputTextBox);
            this.Controls.Add(this.numberTwoLabel);
            this.Controls.Add(this.numberOneLabel);
            this.Name = "Form1";
            this.Text = "Methods assignment 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numberOneLabel;
        private Label numberTwoLabel;
        private TextBox numberOneInputTextBox;
        private TextBox numberTwoInputTextBox;
        private Button sumButton;
        private Button minusButton;
        private Button multipleButton;
        private Button deviderButton;
        private Label label3;
        private Label resultOutputLabel;
    }
}