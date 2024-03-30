namespace LesVoorbeeld2
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
            this.kgInputTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculateForceOnEarthButton = new System.Windows.Forms.Button();
            this.outputForceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kgInputTextbox
            // 
            this.kgInputTextbox.Location = new System.Drawing.Point(322, 108);
            this.kgInputTextbox.Name = "kgInputTextbox";
            this.kgInputTextbox.Size = new System.Drawing.Size(125, 27);
            this.kgInputTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the mass of the object in kg";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalculateForceOnEarthButton
            // 
            this.CalculateForceOnEarthButton.Location = new System.Drawing.Point(453, 106);
            this.CalculateForceOnEarthButton.Name = "CalculateForceOnEarthButton";
            this.CalculateForceOnEarthButton.Size = new System.Drawing.Size(94, 29);
            this.CalculateForceOnEarthButton.TabIndex = 2;
            this.CalculateForceOnEarthButton.Text = "button1";
            this.CalculateForceOnEarthButton.UseVisualStyleBackColor = true;
            this.CalculateForceOnEarthButton.Click += new System.EventHandler(this.CalculateForceOnEarthButton_Click);
            // 
            // outputForceLabel
            // 
            this.outputForceLabel.AutoSize = true;
            this.outputForceLabel.Location = new System.Drawing.Point(96, 196);
            this.outputForceLabel.Name = "outputForceLabel";
            this.outputForceLabel.Size = new System.Drawing.Size(0, 20);
            this.outputForceLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputForceLabel);
            this.Controls.Add(this.CalculateForceOnEarthButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kgInputTextbox);
            this.Name = "Form1";
            this.Text = "Force on Earth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox kgInputTextbox;
        private Label label1;
        private Button CalculateForceOnEarthButton;
        private Label outputForceLabel;
    }
}