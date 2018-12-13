using Session2Library;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ManageFlightSchedule
{
    public partial class ScheduleEdit : Form
    {
        private int id;

        public ScheduleEdit(int _ID)
        {
            InitializeComponent();
            id = _ID;
        }

        private DateTime date;

        private void ScheduleEdit_Load(object sender, EventArgs e)
        {
            using (var session = new Session2Entities())
            {
                var q = session.Schedules.Where(x => x.ID == id).FirstOrDefault();
                string from = q.Route.Airport.IATACode;
                string to = q.Route.Airport1.IATACode;
                string aircraft = q.Aircraft.Name;
                date = q.Date;
                TimeSpan time = q.Time;
                decimal price = q.EconomyPrice;

                labelFrom.Text = from;
                labelTo.Text = to;
                labelAircraft.Text = aircraft;
                dateTimePicker.Value = date;
                textBoxTime.Text = time.ToString();
                textBoxPrice.Text = price.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!FieldsIsEmpty())
            {
                // 1 = earlier, 0 = same, -1 = later
                if (DateTime.Compare(date, dateTimePicker.Value) >= 0)
                {
                    if (TimeSpan.TryParseExact(textBoxTime.Text, @"hh\:mm\:ss", null, out TimeSpan t))
                    {
                        if (Decimal.TryParse(textBoxPrice.Text, out decimal d))
                        {
                            using (var session = new Session2Entities())
                            {
                                var q = session.Schedules.Where(x => x.ID == id).FirstOrDefault();
                                q.Date = dateTimePicker.Value;
                                q.Time = t;
                                q.EconomyPrice = d;

                                session.SaveChanges();

                                ManageFlight parent = (ManageFlight)Owner;
                                parent.SetGrid();
                                Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid number for the price");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid time (hh:mm:ss)");
                    }
                }
                else
                {
                    MessageBox.Show("You cannot select date from the future.");
                }
            }
            else
            {
                MessageBox.Show("Please don't leave any field empty");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool FieldsIsEmpty()
        {
            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    return string.IsNullOrEmpty(((TextBox)control).Text) ? true : false;
                }
            }
            return false;
        }
    }
}