using Session2Library;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ManageFlightSchedule
{
    public partial class ManageFlight : Form
    {
        private bool selected = false;

        public ManageFlight()
        {
            InitializeComponent();
        }

        private void ManageFlight_Load(object sender, EventArgs e)
        {
            SetAirports();
            SetSortBy();
            SetGrid();
        }

        public void SetGrid()
        {
            using (var session = new Session2Entities())
            {
                if (comboBoxFrom.SelectedValue.ToString() != comboBoxTo.SelectedValue.ToString() || (comboBoxFrom.SelectedValue.ToString() == "0" && comboBoxTo.SelectedValue.ToString() == "0"))
                {
                    var q = session.Schedules.Select(s => new
                    {
                        s.ID,
                        s.Date,
                        s.Time,
                        From = s.Route.Airport.IATACode,
                        To = s.Route.Airport1.IATACode,
                        s.FlightNumber,
                        s.Aircraft.Name,
                        s.EconomyPrice,
                        BusinessPrice = Math.Floor((s.EconomyPrice * 135) / 100),
                        FirstClassPrice = Math.Floor((((s.EconomyPrice * 135) / 100) * 130) / 100),
                        s.Confirmed
                    });

                    // 0 == All
                    if (comboBoxFrom.SelectedValue.ToString() != "0")
                    {
                        q = q.Where(s => s.From == comboBoxFrom.SelectedValue.ToString());
                    }

                    if (comboBoxTo.SelectedValue.ToString() != "0")
                    {
                        q = q.Where(s => s.To == comboBoxTo.SelectedValue.ToString());
                    }

                    q = q.Where(s => s.Date == dateTimePickerOutbound.Value);
                    if (!string.IsNullOrEmpty(textBoxFlightNumber.Text))
                    {
                        q = q.Where(s => s.FlightNumber == textBoxFlightNumber.Text);
                    }

                    // See void SetSortBy()
                    switch (comboBoxSortBy.SelectedValue.ToString())
                    {
                        case "0":
                            q = q.OrderBy(s => s.Date);
                            break;

                        case "1":
                            q = q.OrderBy(s => s.EconomyPrice);
                            break;

                        case "2":
                            q = q.OrderBy(s => s.Confirmed);
                            break;
                    }

                    // Array is faster here
                    dataGridView.DataSource = q.ToArray();
                    dataGridView.Columns["ID"].Visible = false;
                    dataGridView.Columns["Confirmed"].Visible = false;
                    SetGridColor();
                }
                else
                {
                    MessageBox.Show("You cannot select the same Airport for From and To");
                }
            }
        }

        private void SetGridColor()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Confirmed"].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = default(Color);
                    row.DefaultCellStyle.ForeColor = default(Color);
                }
            }
        }

        private void SetAirports()
        {
            using (var session = new Session2Entities())
            {
                var airports = session.Airports.Select(a => new { a.IATACode, a.Name }).ToList();

                airports.Insert(0, new { IATACode = "0", Name = "All Airports" });

                comboBoxFrom.ValueMember = "IATACode";
                comboBoxFrom.DisplayMember = "Name";
                comboBoxFrom.DataSource = airports;

                // This is here because there will be telepathy problem if not
                comboBoxTo.BindingContext = new BindingContext();
                comboBoxTo.ValueMember = "IATACode";
                comboBoxTo.DisplayMember = "Name";
                comboBoxTo.DataSource = airports;
            }
        }

        private void SetSortBy()
        {
            var sorts = new[]
            {
                new {ID = 0, Name = "Date-Time"},
                new {ID = 1, Name = "Price"},
                new {ID = 2, Name = "Cancelled"}
            }.ToList();

            comboBoxSortBy.ValueMember = "ID";
            comboBoxSortBy.DisplayMember = "Name";
            comboBoxSortBy.DataSource = sorts;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            SetGrid();
        }

        private void buttonCancelFlight_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                int id = int.Parse(dataGridView.CurrentCell.OwningRow.Cells["ID"].Value.ToString());
                using (var session = new Session2Entities())
                {
                    var q = session.Schedules.FirstOrDefault(x => x.ID == id);
                    if (buttonCancelFlight.Text == "Confirm Flight")
                    {
                        q.Confirmed = true;
                    }
                    else
                    {
                        q.Confirmed = false;
                    }
                    session.SaveChanges();
                    System.Threading.Thread.Sleep(1000);
                    SetGrid();
                }
            }
            else
            {
                MessageBox.Show($"Please select schedule that you want to {buttonCancelFlight.Text} first!");
            }
        }

        private void buttonEditFlight_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                int id = int.Parse(dataGridView.CurrentCell.OwningRow.Cells["ID"].Value.ToString());
                var edit = new ScheduleEdit(id);
                edit.Owner = this;
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select schedule that you want to edit first");
            }
        }

        private void buttonImportChange_Click(object sender, EventArgs e)
        {
            var apply = new ApplySchedule();
            apply.Owner = this;
            apply.ShowDialog();
        }

        private void dataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            selected = true;
            if (dataGridView.CurrentCell.OwningRow.Cells["Confirmed"].Value.ToString() == "False")
            {
                buttonCancelFlight.Text = "Confirm Flight";
                buttonCancelFlight.BackColor = Color.DarkGreen;
            }
            else
            {
                buttonCancelFlight.Text = "Cancel Flight";
                buttonCancelFlight.BackColor = Color.DarkRed;
            }
        }
    }
}