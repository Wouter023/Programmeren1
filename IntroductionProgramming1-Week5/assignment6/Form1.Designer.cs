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
            this.beforeOutputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.afterOutputLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Content table (before)";
            // 
            // beforeOutputLabel
            // 
            this.beforeOutputLabel.AutoSize = true;
            this.beforeOutputLabel.Location = new System.Drawing.Point(37, 74);
            this.beforeOutputLabel.Name = "beforeOutputLabel";
            this.beforeOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.beforeOutputLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(340, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content table (after)";
            // 
            // afterOutputLabel
            // 
            this.afterOutputLabel.AutoSize = true;
            this.afterOutputLabel.Location = new System.Drawing.Point(340, 74);
            this.afterOutputLabel.Name = "afterOutputLabel";
            this.afterOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.afterOutputLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comparisoin number";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(212, 519);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(125, 27);
            this.inputTextBox.TabIndex = 5;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(373, 518);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(94, 29);
            this.compareButton.TabIndex = 6;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.afterOutputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beforeOutputLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label beforeOutputLabel;
        private Label label2;
        private Label afterOutputLabel;
        private Label label3;
        private TextBox inputTextBox;
        private Button compareButton;
    }
}