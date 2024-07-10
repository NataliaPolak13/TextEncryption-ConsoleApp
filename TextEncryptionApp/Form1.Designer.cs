namespace TextEncryptionApp
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
            firstTextBox = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            secondTextBox = new TextBox();
            encryptButton = new Button();
            decryptButton = new Button();
            SuspendLayout();
            // 
            // firstTextBox
            // 
            firstTextBox.Anchor = AnchorStyles.None;
            firstTextBox.Location = new Point(53, 129);
            firstTextBox.Multiline = true;
            firstTextBox.Name = "firstTextBox";
            firstTextBox.ScrollBars = ScrollBars.Vertical;
            firstTextBox.Size = new Size(603, 475);
            firstTextBox.TabIndex = 0;
            firstTextBox.TextChanged += firstTextBox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(197, 33);
            label1.Name = "label1";
            label1.Size = new Size(992, 59);
            label1.TabIndex = 1;
            label1.Text = "Witaj w aplikacji szyfrującej i deszyfrującej tekst";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(256, 54);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 32);
            linkLabel1.TabIndex = 2;
            // 
            // secondTextBox
            // 
            secondTextBox.Anchor = AnchorStyles.None;
            secondTextBox.Location = new Point(707, 129);
            secondTextBox.Multiline = true;
            secondTextBox.Name = "secondTextBox";
            secondTextBox.ReadOnly = true;
            secondTextBox.ScrollBars = ScrollBars.Vertical;
            secondTextBox.Size = new Size(608, 475);
            secondTextBox.TabIndex = 3;
            // 
            // encryptButton
            // 
            encryptButton.Anchor = AnchorStyles.None;
            encryptButton.Location = new Point(53, 626);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(308, 64);
            encryptButton.TabIndex = 4;
            encryptButton.Text = "Szyfruj";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.Anchor = AnchorStyles.None;
            decryptButton.Location = new Point(707, 626);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(308, 64);
            decryptButton.TabIndex = 5;
            decryptButton.Text = "Deszyfruj";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1370, 747);
            Controls.Add(decryptButton);
            Controls.Add(encryptButton);
            Controls.Add(secondTextBox);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(firstTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstTextBox;
        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox secondTextBox;
        private Button encryptButton;
        private Button decryptButton;
    }
}
