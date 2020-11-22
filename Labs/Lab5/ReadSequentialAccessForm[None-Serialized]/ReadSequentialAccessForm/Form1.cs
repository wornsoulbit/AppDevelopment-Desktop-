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

namespace ReadSequentialAccessForm {
    public partial class ReadSequentialAccessForm : BankUIForm.BankUIForm {

        private StreamReader fileReader;

        public ReadSequentialAccessForm()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                ClearTextBoxes();

                if (fileName == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else
                {
                    try
                    {
                        FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        fileReader = new StreamReader(input);

                        OpenFileButton.Enabled = false;
                        NextResultButton.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void NextResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                string inputRecord = fileReader.ReadLine();
                string[] inputFields;

                if (inputRecord != null)
                {
                    inputFields = inputRecord.Split(',');

                    Record record = new Record(Convert.ToInt32(inputFields[0]), inputFields[1], inputFields[2], Convert.ToDecimal(inputFields[3]));

                    SetTextBoxValues(inputFields);
                }
                else
                {
                    fileReader.Close();
                    OpenFileButton.Enabled = true;
                    NextResultButton.Enabled = false;
                    ClearTextBoxes();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error reading from file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
