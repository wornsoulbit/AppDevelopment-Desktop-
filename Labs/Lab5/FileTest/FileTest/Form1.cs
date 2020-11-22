using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTest {
    public partial class FileTestForm : Form {
        public FileTestForm()
        {
            InitializeComponent();
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fileName = InputTextBox.Text;

                if (File.Exists(fileName))
                {
                    GetInformation(fileName);
                    StreamReader stream = null;

                    try
                    {
                        using (stream = new StreamReader(fileName))
                        {
                            OutputTextBox.AppendText(stream.ReadToEnd());
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Directory.Exists(fileName))
                {
                    GetInformation(fileName);

                    string[] directoryList = Directory.GetDirectories(fileName);

                    OutputTextBox.AppendText("Directory contents:\n");

                    foreach (var directory in directoryList)
                        OutputTextBox.AppendText(directory + "\n");
                }
                else
                {
                    MessageBox.Show(InputTextBox.Text + " does not exist", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetInformation(string fileName)
        {
            OutputTextBox.Clear();
            OutputTextBox.AppendText(fileName + " exists\n");
        }
    }
}
