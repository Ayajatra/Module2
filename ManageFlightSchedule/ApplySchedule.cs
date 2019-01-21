using Session2Library;
using System;
using System.IO;
using System.Windows.Forms;

namespace ManageFlightSchedule
{
    public partial class ApplySchedule : Form
    {
        public ApplySchedule()
        {
            InitializeComponent();
        }

        private void ApplySchedule_Load(object sender, EventArgs e)
        {
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            string fileContent;
            var file = new OpenFileDialog
            {
                Title = "Select csv file to be imported",
                Filter = "csv file (*.csv)|*.csv",
                Multiselect = false
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(file.OpenFile()))
                {
                    fileContent = reader.ReadToEnd();
                }
                var rows = fileContent.Split('\n');
                using (var session = new Session2Entities())
                {
                    foreach (var row in rows)
                    {
                        var cells = row.Split(',');
                        // NOT IMPLEMENTED
                    }
                }
            }
        }
    }
}