namespace COMP123_M2020_Lesson8_Part1
{
    public partial class HelloWorldForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ClickmeButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLableName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeLabel.Location = new System.Drawing.Point(7, 207);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(618, 47);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Hello, World!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickmeButton
            // 
            this.ClickmeButton.AutoSize = true;
            this.ClickmeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClickmeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClickmeButton.Location = new System.Drawing.Point(249, 267);
            this.ClickmeButton.Name = "ClickmeButton";
            this.ClickmeButton.Size = new System.Drawing.Size(138, 41);
            this.ClickmeButton.TabIndex = 1;
            this.ClickmeButton.Text = "Click Me!";
            this.ClickmeButton.UseVisualStyleBackColor = false;
            this.ClickmeButton.Click += new System.EventHandler(this.ClickmeButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(206, 100);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(194, 38);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLableName
            // 
            this.NameLableName.BackColor = System.Drawing.SystemColors.Control;
            this.NameLableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameLableName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLableName.Location = new System.Drawing.Point(182, 35);
            this.NameLableName.Name = "NameLableName";
            this.NameLableName.Size = new System.Drawing.Size(256, 47);
            this.NameLableName.TabIndex = 0;
            this.NameLableName.Text = "Enter Your Name";
            this.NameLableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 441);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ClickmeButton);
            this.Controls.Add(this.NameLableName);
            this.Controls.Add(this.WelcomeLabel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "HelloWorldForm";
            this.Text = "Hello World!";
            this.Load += new System.EventHandler(this.HelloWorldForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private system.Windows.forms
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ClickmeButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLableName;
    }
}

