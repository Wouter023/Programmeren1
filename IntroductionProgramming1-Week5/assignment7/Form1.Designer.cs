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
            this.showOutputLabel = new System.Windows.Forms.Label();
            this.throwButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showOutputLabel
            // 
            this.showOutputLabel.AutoSize = true;
            this.showOutputLabel.Location = new System.Drawing.Point(43, 38);
            this.showOutputLabel.Name = "showOutputLabel";
            this.showOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.showOutputLabel.TabIndex = 0;
            // 
            // throwButton
            // 
            this.throwButton.Location = new System.Drawing.Point(43, 186);
            this.throwButton.Name = "throwButton";
            this.throwButton.Size = new System.Drawing.Size(94, 29);
            this.throwButton.TabIndex = 1;
            this.throwButton.Text = "Throw";
            this.throwButton.UseVisualStyleBackColor = true;
            this.throwButton.Click += new System.EventHandler(this.throwButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.throwButton);
            this.Controls.Add(this.showOutputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label showOutputLabel;
        private Button throwButton;
    }
}