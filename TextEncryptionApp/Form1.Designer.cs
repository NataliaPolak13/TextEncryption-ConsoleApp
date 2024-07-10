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
            components = new System.ComponentModel.Container();
            firstTextBox = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            secondTextBox = new TextBox();
            encryptButton = new Button();
            decryptButton = new Button();
            toolTip1 = new ToolTip(components);
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // firstTextBox
            // 
            firstTextBox.Anchor = AnchorStyles.None;
            firstTextBox.Location = new Point(35, 96);
            firstTextBox.Multiline = true;
            firstTextBox.Name = "firstTextBox";
            firstTextBox.ScrollBars = ScrollBars.Vertical;
            firstTextBox.Size = new Size(603, 475);
            firstTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(184, 9);
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
            secondTextBox.Location = new Point(689, 96);
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
            encryptButton.Location = new Point(35, 593);
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
            decryptButton.Location = new Point(689, 593);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(308, 64);
            decryptButton.TabIndex = 5;
            decryptButton.Text = "Deszyfruj";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "How to use?";
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.ToolTip;
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.helpTEA;
            pictureBox2.Location = new Point(1260, 611);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1334, 681);
            Controls.Add(pictureBox2);
            Controls.Add(decryptButton);
            Controls.Add(encryptButton);
            Controls.Add(secondTextBox);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(firstTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private ToolTip toolTip1;
        private PictureBox pictureBox2;
    }
}
