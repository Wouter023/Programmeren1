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
            this.label1 = new System.Windows.Forms.Label();
            this.degreesInputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultOutputLabel = new System.Windows.Forms.Label();
            this.CToKRadioButton = new System.Windows.Forms.RadioButton();
            this.CToFRadioButton = new System.Windows.Forms.RadioButton();
            this.FToCRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degrees";
            // 
            // degreesInputTextBox
            // 
            this.degreesInputTextBox.Location = new System.Drawing.Point(329, 50);
            this.degreesInputTextBox.Name = "degreesInputTextBox";
            this.degreesInputTextBox.Size = new System.Drawing.Size(125, 27);
            this.degreesInputTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FToCRadioButton);
            this.groupBox1.Controls.Add(this.CToFRadioButton);
            this.groupBox1.Controls.Add(this.CToKRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(77, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(77, 298);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(377, 29);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Calculate";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted degrees";
            // 
            // resultOutputLabel
            // 
            this.resultOutputLabel.AutoSize = true;
            this.resultOutputLabel.Location = new System.Drawing.Point(329, 362);
            this.resultOutputLabel.Name = "resultOutputLabel";
            this.resultOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.resultOutputLabel.TabIndex = 5;
            // 
            // CToKRadioButton
            // 
            this.CToKRadioButton.AutoSize = true;
            this.CToKRadioButton.Location = new System.Drawing.Point(17, 35);
            this.CToKRadioButton.Name = "CToKRadioButton";
            this.CToKRadioButton.Size = new System.Drawing.Size(137, 24);
            this.CToKRadioButton.TabIndex = 0;
            this.CToKRadioButton.TabStop = true;
            this.CToKRadioButton.Text = "Celsius to Kelvin";
            this.CToKRadioButton.UseVisualStyleBackColor = true;
            // 
            // CToFRadioButton
            // 
            this.CToFRadioButton.AutoSize = true;
            this.CToFRadioButton.Location = new System.Drawing.Point(17, 65);
            this.CToFRadioButton.Name = "CToFRadioButton";
            this.CToFRadioButton.Size = new System.Drawing.Size(165, 24);
            this.CToFRadioButton.TabIndex = 1;
            this.CToFRadioButton.TabStop = true;
            this.CToFRadioButton.Text = "Celsius to Fahrenheit";
            this.CToFRadioButton.UseVisualStyleBackColor = true;
            // 
            // FToCRadioButton
            // 
            this.FToCRadioButton.AutoSize = true;
            this.FToCRadioButton.Location = new System.Drawing.Point(17, 95);
            this.FToCRadioButton.Name = "FToCRadioButton";
            this.FToCRadioButton.Size = new System.Drawing.Size(165, 24);
            this.FToCRadioButton.TabIndex = 2;
            this.FToCRadioButton.TabStop = true;
            this.FToCRadioButton.Text = "Fahrenheit to Celsius";
            this.FToCRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultOutputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.degreesInputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox degreesInputTextBox;
        private GroupBox groupBox1;
        private Button submitButton;
        private Label label2;
        private Label resultOutputLabel;
        private RadioButton FToCRadioButton;
        private RadioButton CToFRadioButton;
        private RadioButton CToKRadioButton;
    }
}