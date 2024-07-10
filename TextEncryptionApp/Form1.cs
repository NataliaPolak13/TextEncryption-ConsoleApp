using TextEncryption.Services.Implementation;
namespace TextEncryptionApp
{
    public partial class Form1 : Form
    {
        private bool canDecrypt = false;

        public Form1()
        {
            InitializeComponent();
        }

        private async void encryptButton_Click(object sender, EventArgs e)
        {
            encryptButton.Enabled = false;
            try
            {
                string text = firstTextBox.Text;
                Encryption encryption = new Encryption();
                string tempText = await Task.Run(() => encryption.GetTextToEncryptFinal(text));
                secondTextBox.Text = tempText;

                canDecrypt = true;
            }
            finally
            {
                encryptButton.Enabled = true;
            }
        }

        private async void decryptButton_Click(object sender, EventArgs e)
        {
            if (!canDecrypt)
            {
                MessageBox.Show("Please encrypt the text before decrypting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decryptButton.Enabled = false;
            try
            {
                string text = secondTextBox.Text;
                Decryption decryption = new Decryption();
                string tempText = await Task.Run(() => decryption.DecryptFinalText(text));
                secondTextBox.Text = tempText;

                canDecrypt = false;
            }
            finally
            {
                decryptButton.Enabled = true;
            }
        }

        private void firstTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

