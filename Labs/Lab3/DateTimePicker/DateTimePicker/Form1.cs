using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker {
    public partial class DateTimePicker : Form {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dropOffDate = dateTimePicker1.Value;

            if (dropOffDate.DayOfWeek == DayOfWeek.Friday ||
                dropOffDate.DayOfWeek == DayOfWeek.Saturday ||
                dropOffDate.DayOfWeek == DayOfWeek.Sunday)
                EstimatedDeliveryDateLabel.Text = dropOffDate.AddDays(3).ToLongDateString();
            else
                EstimatedDeliveryDateLabel.Text = dropOffDate.AddDays(2).ToLongDateString();
        }

        private void DateTimePicker_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(1);
        }
    }
}
