namespace assignment9
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
            this.sportGroupBox = new System.Windows.Forms.GroupBox();
            this.footballRadioButton = new System.Windows.Forms.RadioButton();
            this.handballRadioButton = new System.Windows.Forms.RadioButton();
            this.ageNameLabel = new System.Windows.Forms.Label();
            this.membershipNameLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.membershipTextBox = new System.Windows.Forms.TextBox();
            this.calculateFeeButton = new System.Windows.Forms.Button();
            this.feeNameLabel = new System.Windows.Forms.Label();
            this.priceOutputLabel = new System.Windows.Forms.Label();
            this.sportGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sportGroupBox
            // 
            this.sportGroupBox.Controls.Add(this.handballRadioButton);
            this.sportGroupBox.Controls.Add(this.footballRadioButton);
            this.sportGroupBox.Location = new System.Drawing.Point(89, 66);
            this.sportGroupBox.Name = "sportGroupBox";
            this.sportGroupBox.Size = new System.Drawing.Size(250, 99);
            this.sportGroupBox.TabIndex = 0;
            this.sportGroupBox.TabStop = false;
            this.sportGroupBox.Text = "Sport";
            // 
            // footballRadioButton
            // 
            this.footballRadioButton.AutoSize = true;
            this.footballRadioButton.Location = new System.Drawing.Point(6, 26);
            this.footballRadioButton.Name = "footballRadioButton";
            this.footballRadioButton.Size = new System.Drawing.Size(85, 24);
            this.footballRadioButton.TabIndex = 0;
            this.footballRadioButton.TabStop = true;
            this.footballRadioButton.Text = "Football";
            this.footballRadioButton.UseVisualStyleBackColor = true;
            this.footballRadioButton.CheckedChanged += new System.EventHandler(this.footballRadioButton_CheckedChanged);
            // 
            // handballRadioButton
            // 
            this.handballRadioButton.AutoSize = true;
            this.handballRadioButton.Location = new System.Drawing.Point(6, 56);
            this.handballRadioButton.Name = "handballRadioButton";
            this.handballRadioButton.Size = new System.Drawing.Size(91, 24);
            this.handballRadioButton.TabIndex = 1;
            this.handballRadioButton.TabStop = true;
            this.handballRadioButton.Text = "Handball";
            this.handballRadioButton.UseVisualStyleBackColor = true;
            this.handballRadioButton.CheckedChanged += new System.EventHandler(this.handballRadioButton_CheckedChanged);
            // 
            // ageNameLabel
            // 
            this.ageNameLabel.AutoSize = true;
            this.ageNameLabel.Location = new System.Drawing.Point(89, 201);
            this.ageNameLabel.Name = "ageNameLabel";
            this.ageNameLabel.Size = new System.Drawing.Size(36, 20);
            this.ageNameLabel.TabIndex = 1;
            this.ageNameLabel.Text = "Age";
            // 
            // membershipNameLabel
            // 
            this.membershipNameLabel.AutoSize = true;
            this.membershipNameLabel.Location = new System.Drawing.Point(89, 236);
            this.membershipNameLabel.Name = "membershipNameLabel";
            this.membershipNameLabel.Size = new System.Drawing.Size(152, 20);
            this.membershipNameLabel.TabIndex = 2;
            this.membershipNameLabel.Text = "Membership duration";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(335, 198);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(125, 27);
            this.ageTextBox.TabIndex = 3;
            // 
            // membershipTextBox
            // 
            this.membershipTextBox.Location = new System.Drawing.Point(335, 233);
            this.membershipTextBox.Name = "membershipTextBox";
            this.membershipTextBox.Size = new System.Drawing.Size(125, 27);
            this.membershipTextBox.TabIndex = 4;
            // 
            // calculateFeeButton
            // 
            this.calculateFeeButton.Location = new System.Drawing.Point(89, 288);
            this.calculateFeeButton.Name = "calculateFeeButton";
            this.calculateFeeButton.Size = new System.Drawing.Size(371, 38);
            this.calculateFeeButton.TabIndex = 5;
            this.calculateFeeButton.Text = "Calculate Fee";
            this.calculateFeeButton.UseVisualStyleBackColor = true;
            this.calculateFeeButton.Click += new System.EventHandler(this.calculateFeeButton_Click);
            // 
            // feeNameLabel
            // 
            this.feeNameLabel.AutoSize = true;
            this.feeNameLabel.Location = new System.Drawing.Point(89, 351);
            this.feeNameLabel.Name = "feeNameLabel";
            this.feeNameLabel.Size = new System.Drawing.Size(105, 20);
            this.feeNameLabel.TabIndex = 6;
            this.feeNameLabel.Text = "Fee to be paid";
            // 
            // priceOutputLabel
            // 
            this.priceOutputLabel.AutoSize = true;
            this.priceOutputLabel.Location = new System.Drawing.Point(335, 351);
            this.priceOutputLabel.Name = "priceOutputLabel";
            this.priceOutputLabel.Size = new System.Drawing.Size(50, 20);
            this.priceOutputLabel.TabIndex = 7;
            this.priceOutputLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceOutputLabel);
            this.Controls.Add(this.feeNameLabel);
            this.Controls.Add(this.calculateFeeButton);
            this.Controls.Add(this.membershipTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.membershipNameLabel);
            this.Controls.Add(this.ageNameLabel);
            this.Controls.Add(this.sportGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sportGroupBox.ResumeLayout(false);
            this.sportGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox sportGroupBox;
        private RadioButton handballRadioButton;
        private RadioButton footballRadioButton;
        private Label ageNameLabel;
        private Label membershipNameLabel;
        private TextBox ageTextBox;
        private TextBox membershipTextBox;
        private Button calculateFeeButton;
        private Label feeNameLabel;
        private Label priceOutputLabel;
    }
}