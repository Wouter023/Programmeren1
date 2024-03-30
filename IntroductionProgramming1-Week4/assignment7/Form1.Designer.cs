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
            this.sideInputTextBox = new System.Windows.Forms.TextBox();
            this.createSquareButton = new System.Windows.Forms.Button();
            this.squareOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side";
            // 
            // sideInputTextBox
            // 
            this.sideInputTextBox.Location = new System.Drawing.Point(180, 36);
            this.sideInputTextBox.Name = "sideInputTextBox";
            this.sideInputTextBox.Size = new System.Drawing.Size(125, 27);
            this.sideInputTextBox.TabIndex = 1;
            // 
            // createSquareButton
            // 
            this.createSquareButton.Location = new System.Drawing.Point(43, 93);
            this.createSquareButton.Name = "createSquareButton";
            this.createSquareButton.Size = new System.Drawing.Size(262, 29);
            this.createSquareButton.TabIndex = 2;
            this.createSquareButton.Text = "Create square";
            this.createSquareButton.UseVisualStyleBackColor = true;
            this.createSquareButton.Click += new System.EventHandler(this.createSquareButton_Click);
            // 
            // squareOutputLabel
            // 
            this.squareOutputLabel.AutoSize = true;
            this.squareOutputLabel.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.squareOutputLabel.Location = new System.Drawing.Point(43, 162);
            this.squareOutputLabel.Name = "squareOutputLabel";
            this.squareOutputLabel.Size = new System.Drawing.Size(96, 27);
            this.squareOutputLabel.TabIndex = 3;
            this.squareOutputLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.squareOutputLabel);
            this.Controls.Add(this.createSquareButton);
            this.Controls.Add(this.sideInputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox sideInputTextBox;
        private Button createSquareButton;
        private Label squareOutputLabel;
    }
}