using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public partial class fmAddTrip : Form
    {
        public int Id_Table { get; set; } = 0;
        public fmAddTrip()
        {
            InitializeComponent();
            FillingDriver();
            FillingTrain();
            dgvTable.AutoGenerateColumns = false;
            dgvTable.DataSource = TrainTableDAL.GetAllTrainTables();          
        }

        private void FillingDriver()
        {
            foreach (Driver dr in DriverDAL.GetAllDrivers())
            {
                cbDriver.Items.Add(dr.Surname + " " + dr.Name[0] + "." + " " + dr.Patronymic[0] + ".");
            }
        }

        private void FillingTrain()
        {
            foreach (Train dr in TrainDAL.GetAllTrains())
            {
                cbTrain.Items.Add(dr.TrainNumber);
            }
        }

        private bool GetFIO()
        {
            if (String.IsNullOrEmpty(cbDriver.Text))
            {
                MessageBox.Show("Выберите машиниста!");
                return false;
            }
            return true;
        }

        private bool GetTrainNumber()
        {
            if (String.IsNullOrEmpty(cbTrain.Text))
            {
                MessageBox.Show("Выберите номер поезда!");
                return false;
            }
            return true;
        }

        private bool GetIdTable()
        {
            if (Id_Table == 0)
            {
                MessageBox.Show("Выберите строку в расписании!");
                return false;
            }
            return true;
        }

        /*private void AddSoftCount(int idAddedTrip)
        {
            int cnt = int.Parse(numericUpDown1.Value.ToString());
            foreach (CarriageType t in CarriageTypeDAL.GetAllCarriageTypes())
            {
                if (t.Type.Trim() == CarriageTypeConst.Soft) Trip_CarriageDAL.Insert(t.Id_CarriageType, idAddedTrip, cnt);
            }
        }

        private void AddCoupeCount(int idAddedTrip)
        {
            int cnt = int.Parse(numericUpDown2.Value.ToString());
            foreach (CarriageType t in CarriageTypeDAL.GetAllCarriageTypes())
            {
                if (t.Type.Trim() == CarriageTypeConst.Coupe)Trip_CarriageDAL.Insert(t.Id_CarriageType, idAddedTrip, cnt);
            }
        }

        private void AddLuxCount(int idAddedTrip)
        {
            int cnt = int.Parse(numericUpDown3.Value.ToString());
            foreach (CarriageType t in CarriageTypeDAL.GetAllCarriageTypes())
            {
                if (t.Type.Trim() == CarriageTypeConst.Lux)Trip_CarriageDAL.Insert(t.Id_CarriageType, idAddedTrip, cnt);
            }
        }

        private void AddSittingCount(int idAddedTrip)
        {
            int cnt = int.Parse(numericUpDown4.Value.ToString());
            foreach (CarriageType t in CarriageTypeDAL.GetAllCarriageTypes())
            {
                if (t.Type.Trim() == CarriageTypeConst.Sitting)Trip_CarriageDAL.Insert(t.Id_CarriageType, idAddedTrip, cnt);
            }
        }

        private void AddReserverSeatCount(int idAddedTrip)
        {
            int cnt = int.Parse(numericUpDown5.Value.ToString());
            foreach (CarriageType t in CarriageTypeDAL.GetAllCarriageTypes())
            {
                if (t.Type.Trim() == CarriageTypeConst.ReserverSeat)Trip_CarriageDAL.Insert(t.Id_CarriageType, idAddedTrip, cnt);
            }
        }

        private void AddCarriageCount()
        {
            int id = TripDAL.GetAllTrips()[TripDAL.GetAllTrips().Count - 1].Id_Trip;
            AddCoupeCount(id);
            AddLuxCount(id);
            AddReserverSeatCount(id);
            AddSittingCount(id);
            AddSoftCount(id);
        }*/

        private void InsertTrip()
        {
            int driver = DriverDAL.GetAllDrivers()[cbDriver.SelectedIndex].Id_Driver;
            int train = TrainDAL.GetAllTrains()[cbTrain.SelectedIndex].Id_Train;
            string departureDate = dtpDate1.Text;
            string departureTime = dtpTime1.Text;
            string arrivalDate = dtpDate2.Text;
            string arrivalTime = dtpTime2.Text;
            TripDAL.Insert(Id_Table, driver, train, departureDate, departureTime, arrivalDate, arrivalTime);
        }

        private void btnAddTrips_Click(object sender, EventArgs e)
        {
            if (!GetFIO()) return;
            if (!GetTrainNumber()) return;
            if (!GetIdTable()) return;
            InsertTrip();
            //AddCarriageCount();
            DialogResult = DialogResult.OK;
        }

        private void dgvTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id_Table = (dgvTable.SelectedCells[0].OwningRow.DataBoundItem as TrainTable).Id_Table;
        }
    }
}
