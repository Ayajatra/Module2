using AMONIC_Airlines.Model;
using System;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AMONIC_Airlines
{
    public partial class ImportFlight : Form
    {
        private Session2Entities db = new Session2Entities();
        private Schedule x = new Schedule();

        public ImportFlight()
        {
            InitializeComponent();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            int success = 0;
            int duplicate = 0;
            int missing = 0;

            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "csv file (*.csv) | *csv",
                Title = "Select a csv file to be imported",
                Multiselect = false
            };

            if (file.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectory.Text = file.FileName;

                string csv;
                Stream fileStream = file.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    csv = reader.ReadToEnd();
                }

                string[] rows = csv.Split('\n');
                foreach (string row in rows)
                {
                    string[] cells = row.Split(',');
                    if (cells.Length == 9)
                    {
                        string[] dateFormat =
                        {
                            "yyyy-MM-dd",
                            "dd/MM/yyyy",
                            "d/MM/yyyy",
                            "dd/M/yyyy",
                            "d/M/yyyy",
                            "MM/dd/yyyy",
                            "M/dd/yyyy",
                            "MM/d/yyyy",
                            "M/d/yyyy"
                        };

                        string[] timeFormat =
                        {
                            @"hh\:mm",
                            @"h\:mm",
                            @"hh\:m",
                            @"h\:m"
                        };

                        DateTime t;
                        if (DateTime.TryParseExact(cells[1], dateFormat, null, DateTimeStyles.None, out t))
                        {
                            TimeSpan s;
                            if (TimeSpan.TryParseExact(cells[2], timeFormat, null, out s))
                            {
                                int aircraftID;
                                if (int.TryParse(cells[6], out aircraftID))
                                {
                                    decimal p;
                                    if (decimal.TryParse(cells[7], out p))
                                    {
                                        string flightNumber = cells[3];
                                        string departCode = cells[4];
                                        string arrivalCode = cells[5];
                                        string confirmed = cells[8].Replace("\r", "").Replace("\n", "");
                                        var query = db.Schedules.FirstOrDefault(x => x.FlightNumber == flightNumber && DbFunctions.TruncateTime(x.Date) == DbFunctions.TruncateTime(t));
                                        if (cells[0] == "ADD")
                                        {
                                            if (query == null)
                                            {
                                                x.Date = t;
                                                x.Time = s;
                                                x.FlightNumber = flightNumber;
                                                int routeID = db.Routes.FirstOrDefault(x => x.Airport.IATACode == departCode && x.Airport1.IATACode == arrivalCode).ID;
                                                x.RouteID = routeID;
                                                x.AircraftID = aircraftID;
                                                x.Confirmed = confirmed == "OK" ? true : false;
                                                x.EconomyPrice = p;
                                                db.Schedules.Add(x);
                                                db.SaveChanges();

                                                success++;
                                                ManageFlight flight = (ManageFlight)Owner;
                                                flight.GetSetGrid();
                                                flight.GetSetGridColor();
                                            }
                                            else
                                            {
                                                duplicate++;
                                            }
                                        }
                                        else if (cells[0] == "EDIT")
                                        {
                                            if (query == null)
                                            {
                                                missing++;
                                            }
                                            else
                                            {
                                                query.Date = t;
                                                query.Time = s;
                                                query.FlightNumber = flightNumber;
                                                int routeID = db.Routes.FirstOrDefault(x => x.Airport.IATACode == departCode && x.Airport1.IATACode == arrivalCode).ID;
                                                x.RouteID = routeID;
                                                x.AircraftID = aircraftID;
                                                x.Confirmed = cells[7] == "OK" ? true : false;
                                                x.EconomyPrice = p;
                                                db.SaveChanges();

                                                success++;
                                                ManageFlight flight = (ManageFlight)Owner;
                                                flight.GetSetGrid();
                                                flight.GetSetGridColor();
                                            }
                                        }
                                        else
                                        {
                                            missing++;
                                        }
                                    }
                                    else
                                    {
                                        missing++;
                                    }
                                }
                                else
                                {
                                    missing++;
                                }
                            }
                            else
                            {
                                missing++;
                            }
                        }
                        else
                        {
                            missing++;
                        }
                    }
                    else
                    {
                        missing++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a csv file");
            }
            labelSuccess.Text = success.ToString();
            labelDuplicate.Text = duplicate.ToString();
            labelMissing.Text = missing.ToString();
        }
    }
}