using AMONIC_Airlines.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AMONIC_Airlines
{
    public partial class EditFlight : Form
    {
        private int ID;
        private Session2Entities db = new Session2Entities();
        private Schedule q;

        public EditFlight(int _id)
        {
            InitializeComponent();
            ID = _id;
        }

        private void EditFlight_Load(object sender, EventArgs e)
        {
            q = db.Schedules.FirstOrDefault(x => x.ID == ID);
            labelFrom.Text = q.Route.Airport.IATACode;
            labelTo.Text = q.Route.Airport1.IATACode;
            labelAircraft.Text = q.Aircraft.Name;
            dateTimePicker.Value = q.Date;
            textBoxTime.Text = q.Time.ToString(@"hh\:mm");
            textBoxPrice.Text = decimal.Round(q.EconomyPrice).ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (TimeSpan.TryParseExact(textBoxTime.Text, @"hh\:mm", null, out TimeSpan t))
            {
                q.Time = t;

                if (decimal.TryParse(textBoxPrice.Text, out decimal d))
                {
                    q.EconomyPrice = d;
                    q.Date = dateTimePicker.Value.Date;
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Please enter number for the price");
                }
            }
            else
            {
                MessageBox.Show("Please enter the correct time format (hh:mm)");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}