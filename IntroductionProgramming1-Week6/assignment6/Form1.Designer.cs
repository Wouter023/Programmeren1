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
            this.inputNumberTextBox = new System.Windows.Forms.TextBox();
            this.referenceButton = new System.Windows.Forms.Button();
            this.RefernceOutButton = new System.Windows.Forms.Button();
            this.valueButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // inputNumberTextBox
            // 
            this.inputNumberTextBox.Location = new System.Drawing.Point(281, 65);
            this.inputNumberTextBox.Name = "inputNumberTextBox";
            this.inputNumberTextBox.Size = new System.Drawing.Size(125, 27);
            this.inputNumberTextBox.TabIndex = 1;
            // 
            // referenceButton
            // 
            this.referenceButton.Location = new System.Drawing.Point(89, 146);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(317, 29);
            this.referenceButton.TabIndex = 2;
            this.referenceButton.Text = "Square By Reference";
            this.referenceButton.UseVisualStyleBackColor = true;
            this.referenceButton.Click += new System.EventHandler(this.referenceButton_Click);
            // 
            // RefernceOutButton
            // 
            this.RefernceOutButton.Location = new System.Drawing.Point(89, 181);
            this.RefernceOutButton.Name = "RefernceOutButton";
            this.RefernceOutButton.Size = new System.Drawing.Size(317, 29);
            this.RefernceOutButton.TabIndex = 3;
            this.RefernceOutButton.Text = "Square By Refference Out";
            this.RefernceOutButton.UseVisualStyleBackColor = true;
            this.RefernceOutButton.Click += new System.EventHandler(this.RefernceOutButton_Click);
            // 
            // valueButton
            // 
            this.valueButton.Location = new System.Drawing.Point(89, 216);
            this.valueButton.Name = "valueButton";
            this.valueButton.Size = new System.Drawing.Size(317, 29);
            this.valueButton.TabIndex = 4;
            this.valueButton.Text = "Square By Value";
            this.valueButton.UseVisualStyleBackColor = true;
            this.valueButton.Click += new System.EventHandler(this.valueButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // resultOutputLabel
            // 
            this.resultOutputLabel.AutoSize = true;
            this.resultOutputLabel.Location = new System.Drawing.Point(281, 288);
            this.resultOutputLabel.Name = "resultOutputLabel";
            this.resultOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.resultOutputLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultOutputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueButton);
            this.Controls.Add(this.RefernceOutButton);
            this.Controls.Add(this.referenceButton);
            this.Controls.Add(this.inputNumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inputNumberTextBox;
        private Button referenceButton;
        private Button RefernceOutButton;
        private Button valueButton;
        private Label label2;
        private Label resultOutputLabel;
    }
}