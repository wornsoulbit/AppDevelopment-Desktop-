using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLib {
    public partial class CreateFile : BankUIForm.BankUIForm {

        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;

        public CreateFile()
        {
            InitializeComponent();
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (SaveFileDialog fileChoser = new SaveFileDialog())
            {
                fileChoser.CheckFileExists = false;

                result = fileChoser.ShowDialog();
                fileName = fileChoser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (fileName == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                        SaveAsButton.Enabled = false;
                        EnterButton.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string[] values = GetTextBoxValues();

            Record record = new Record();

            if (values[(int) TextBoxIndices.ACCOUNT] != string.Empty)
            {
                try
                {
                    int accountNum = Int32.Parse(values[(int)TextBoxIndices.ACCOUNT]);

                    if (accountNum > 0)
                    {
                        record.Account = accountNum;
                        record.FirstName = values[(int)TextBoxIndices.FIRST];
                        record.LastName = values[(int)TextBoxIndices.LAST];
                        record.Balance = Decimal.Parse(values[(int)TextBoxIndices.BALANCE]);

                        formatter.Serialize(output, record);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClearTextBoxes();
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                try
                {
                    output.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.Exit();
        }
    }
}
