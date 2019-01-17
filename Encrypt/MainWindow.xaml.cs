using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Encrypt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            string textToEncrypt = UserTextToEncrypt.Text;
            string encryptedString = StringCrypter.Encrypt(textToEncrypt, UserPassWord.Text);
            EncryptedText.Text = encryptedString;
        }

        private void Decrypt_Click(object sender, RoutedEventArgs e)
        {
            string textToDecrypt = UserTextToDecrypt.Text;
            string DecryptedString = StringCrypter.Decrypt(textToDecrypt, UserPassWord.Text);
            DecryptedText.Text = DecryptedString;
        }

        private void CopyEncryptedText_Click(object sender, RoutedEventArgs e)
        {
            string copiedEncryptedText = EncryptedText.Text;
            Clipboard.SetText(copiedEncryptedText);
        }
    }
}
