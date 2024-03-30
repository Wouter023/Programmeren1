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
            this.secondsLabel = new System.Windows.Forms.Label();
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.klokLabel = new System.Windows.Forms.Label();
            this.outputTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(103, 98);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(67, 20);
            this.secondsLabel.TabIndex = 0;
            this.secondsLabel.Text = "Seconds:";
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(337, 95);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(125, 27);
            this.inputBox1.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(103, 147);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(359, 29);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // klokLabel
            // 
            this.klokLabel.AutoSize = true;
            this.klokLabel.Location = new System.Drawing.Point(103, 213);
            this.klokLabel.Name = "klokLabel";
            this.klokLabel.Size = new System.Drawing.Size(177, 20);
            this.klokLabel.TabIndex = 3;
            this.klokLabel.Text = "Hours : Minutes : Seconds";
            // 
            // outputTimeLabel
            // 
            this.outputTimeLabel.AutoSize = true;
            this.outputTimeLabel.Location = new System.Drawing.Point(103, 258);
            this.outputTimeLabel.Name = "outputTimeLabel";
            this.outputTimeLabel.Size = new System.Drawing.Size(50, 20);
            this.outputTimeLabel.TabIndex = 4;
            this.outputTimeLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputTimeLabel);
            this.Controls.Add(this.klokLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.secondsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label secondsLabel;
        private TextBox inputBox1;
        private Button calculateButton;
        private Label klokLabel;
        private Label outputTimeLabel;
    }
}