using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace practika
{
    public partial class calculateHash : Form
    {
        public calculateHash()
        {
            InitializeComponent();
        } 

        static String calculationCheckSumOfStringSHA256(string StringWithData)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(StringWithData);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        static string calculateCheckSumOfFileMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void calculateHashClick(object sender, EventArgs e)
        {
            if (isString.Checked)
                if (stringForHash.Text.Length != 0)
                    calculatedHash.Text = calculationCheckSumOfStringSHA256(stringForHash.Text);
                else
                    MessageBox.Show("String 'Data' is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (isFile.Checked)
                if (!pathToFile.Text.Equals("Path to file.."))
                    calculatedHash.Text = calculateCheckSumOfFileMD5(pathToFile.Text);
                else
                    MessageBox.Show("Chose the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Select type of data for calculatng hash.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void choseFileButton_Click(object sender, EventArgs e)
        {
            using (var opnDlg = new OpenFileDialog())
            { 
                if (opnDlg.ShowDialog() == DialogResult.OK)
                    pathToFile.Text = opnDlg.FileName;   
            }
        }

        private void copyHashButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(calculatedHash.Text);
        }
    }
}
