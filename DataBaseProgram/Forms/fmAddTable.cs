using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public partial class fmAddTableRow : Form
    {

        public fmAddTableRow()
        {
            InitializeComponent();
            FillingStation();
        }

        private void FillingStation()
        {
            foreach (Station s in StationDAL.GetAllStations())
            {
                cbAT1.Items.Add(s.Name);
                cbAT2.Items.Add(s.Name);
            }
        }

        private bool GetDepartureStation()
        {
            if (String.IsNullOrEmpty(cbAT1.Text))
            {
                MessageBox.Show("Выберите станцию отправления!");
                return false;
            }
            return true;
        }

        private bool GetArrivalStation()
        {
            if (String.IsNullOrEmpty(cbAT2.Text))
            {
                MessageBox.Show("Выберите станцию назначения!");
                return false;
            }
            return true;
        }

        private void InsertTrainTable()
        {
            string departureStation = StationDAL.GetStationByName(cbAT1.Text).Id_Station.ToString();
            string arrivalStation = StationDAL.GetStationByName(cbAT2.Text).Id_Station.ToString();
            string departureDate = dtpDD.Value.ToString();
            string arrivalDate = dtpAD.Value.ToString();
            string departureTime = dtpDT.Value.ToString();
            string arrivalTime = dtpAT.Value.ToString();
            TrainTableDAL.Insert(departureStation, arrivalStation, departureDate, arrivalDate, departureTime, arrivalTime);
        }

        private void btnAddTrips_Click(object sender, EventArgs e)
        {
            if (!GetArrivalStation()) return;
            if (!GetDepartureStation()) return;
            InsertTrainTable();
            DialogResult = DialogResult.OK;
        }
    }
}
