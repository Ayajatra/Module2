using AMONIC_Airlines.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AMONIC_Airlines
{
    public partial class ManageFlight : Form
    {
        public ManageFlight()
        {
            InitializeComponent();
        }

        public void GetSetGrid()
        {
            if (!(comboBoxFrom.SelectedValue.ToString() == comboBoxTo.SelectedValue.ToString()) || (comboBoxFrom.SelectedValue.ToString() == "0" && comboBoxTo.SelectedValue.ToString() == "0"))
            {
                using (var db = new Session2Entities())
                {
                    var q = db.Schedules.Select(x => new
                    {
                        x.ID,
                        x.Date,
                        x.Time,
                        From = x.Route.Airport.IATACode,
                        To = x.Route.Airport1.IATACode,
                        x.FlightNumber,
                        Aircraft = x.Aircraft.Name,
                        x.EconomyPrice,
                        BusinessPrice = Math.Floor(x.EconomyPrice * 135 / 100),
                        FirstClassPrice = Math.Floor(x.EconomyPrice * 135 / 100 * 130 / 100),
                        x.Confirmed
                    });

                    q = q.Where(x => DbFunctions.TruncateTime(x.Date) == DbFunctions.TruncateTime(dateTimePicker.Value));

                    if (comboBoxFrom.SelectedValue.ToString() != "0")
                    {
                        q = q.Where(x => x.From == comboBoxFrom.SelectedValue.ToString());
                    }

                    if (comboBoxTo.SelectedValue.ToString() != "0")
                    {
                        q = q.Where(x => x.To == comboBoxTo.SelectedValue.ToString());
                    }

                    if (!string.IsNullOrEmpty(textBoxFlight.Text))
                    {
                        q = q.Where(x => x.FlightNumber == textBoxFlight.Text);
                    }

                    switch (comboBoxSort.SelectedValue.ToString())
                    {
                        case "Date-Time":
                            q = q.OrderBy(x => x.Date);
                            break;

                        case "Economy Price":
                            q = q.OrderBy(x => x.EconomyPrice);
                            break;

                        case "Cancelled":
                            q = q.OrderBy(x => x.Confirmed);
                            break;
                    }

                    dataGridView.DataSource = q.ToList();
                    dataGridView.Columns["ID"].Visible = false;
                    dataGridView.Columns["Confirmed"].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("You cannot select the same airport for the 'from' and 'to' criteria");
            }
        }

        private void GetSetAirport()
        {
            using (var db = new Session2Entities())
            {
                var q = db.Airports.Select(x => new { ID = x.IATACode, x.Name });
                var r = q.ToList();
                r.Insert(0, new { ID = "0", Name = "All Airports" });

                comboBoxFrom.ValueMember = "ID";
                comboBoxFrom.DisplayMember = "Name";
                comboBoxFrom.DataSource = r;

                comboBoxTo.BindingContext = new BindingContext();
                comboBoxTo.ValueMember = "ID";
                comboBoxTo.DisplayMember = "Name";
                comboBoxTo.DataSource = r;
            }
        }

        private void GetSetSort()
        {
            List<string> sorts = new List<string>()
            {
                "Date-Time",
                "Economy Price",
                "Cancelled"
            };
            comboBoxSort.DataSource = sorts;
        }

        public void GetSetGridColor()
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

        private void ManageFlight_Load(object sender, EventArgs e)
        {
            GetSetAirport();
            GetSetSort();
            GetSetGrid();
            GetSetGridColor();
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.OwningRow.Cells["Confirmed"].Value.ToString() == "True")
            {
                buttonCancel.Text = "Cancel Flight";
                buttonCancel.BackColor = Color.DarkRed;
            }
            else
            {
                buttonCancel.Text = "Confirm Flight";
                buttonCancel.BackColor = Color.Green;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            GetSetGrid();
            GetSetGridColor();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView.CurrentCell.OwningRow.Cells["ID"].Value.ToString());
                using (var db = new Session2Entities())
                {
                    Schedule q = db.Schedules.FirstOrDefault(x => x.ID == id);
                    q.Confirmed = buttonCancel.Text == "Cancel Flight" ? false : true;
                    db.SaveChanges();
                    GetSetGrid();
                    GetSetGridColor();
                }
            }
            catch
            {
                MessageBox.Show("Please select flight that you want to change the confirmation first!");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int currentID = int.Parse(dataGridView.CurrentCell.OwningRow.Cells["ID"].Value.ToString());

            EditFlight edit = new EditFlight(currentID);
            edit.Owner = this;
            edit.ShowDialog();

            GetSetGrid();
            GetSetGridColor();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            ImportFlight import = new ImportFlight();
            import.Owner = this;
            import.ShowDialog();
        }
    }
}