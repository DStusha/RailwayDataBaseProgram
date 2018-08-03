using System;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public partial class fmAddTicket : Form
    {

        public fmAddTicket()
        {
            InitializeComponent();
            FillingPassengers();
            FillingIntermediateStations();
            FillingTrips();
            FillingCarriageTypes();
        }

        private void FillingPassengers()
        {
            foreach (Passenger pas in PassengerDAL.GetAllPassengers())
            {
                cbFIO.Items.Add(pas.Surname.Trim(' ') + ' ' + pas.Name[0] + '.' + pas.Patronymic[0] + '.');
            }
        }

        private void FillingIntermediateStations()
        {
            foreach (IntermediateStation i in IntermediateStationDAL.GetAllIntermediateStations())
            {
                cbDS.Items.Add(StationDAL.GetStationByIntermediateStation(i.Id_IntermediateStation).Name);
                cbAS.Items.Add(StationDAL.GetStationByIntermediateStation(i.Id_IntermediateStation).Name);
            }
        }

        private void FillingTrips()
        {
            foreach (Trip tr in TripDAL.GetAllTrips())
            {
                cbNumTrip.Items.Add(tr.Id_Trip);
            }
        }

        private void FillingCarriageTypes()
        {
            foreach (CarriageType tr in CarriageTypeDAL.GetAllCarriageTypes())
            {
                cbType.Items.Add(tr.Type);
            }
        }

        private bool GetPrice()
        {
            if (String.IsNullOrEmpty(tbPrice.Text))
            {
                MessageBox.Show("Введите цену!");
                return false;
            }
            return true;
        }

        private bool GetTrip()
        {
            if (String.IsNullOrEmpty(cbNumTrip.Text))
            {
                MessageBox.Show("Выберите рейс!");
                return false;
            }
            return true;
        }

        private bool GetFIO()
        {
            if (String.IsNullOrEmpty(cbFIO.Text))
            {
                MessageBox.Show("Выберите пассажира!");
                return false;
            }
            return true;
        }

        private bool GetDepartureStation()
        {
            if (String.IsNullOrEmpty(cbDS.Text))
            {
                MessageBox.Show("Выберите станцию отправления!");
                return false;
            }
            return true;
        }

        private bool GetArrivalStation()
        {
            if (String.IsNullOrEmpty(cbAS.Text))
            {
                MessageBox.Show("Выберите станцию назначения!");
                return false;
            }
            return true;
        }

        private bool GetPlaseNumber()
        {
            if (nPlase.Value==0)
            {
                MessageBox.Show("Выберите номер места!");
                return false;
            }
            return true;
        }

        private bool GetCarriageType()
        {
            if (String.IsNullOrEmpty(cbType.Text))
            {
                MessageBox.Show("Выберите тип вагона!");
                return false;
            }
            return true;
        }

        private void InsertTicket()
        {
            int price = int.Parse(tbPrice.Text);
            int FIO = PassengerDAL.GetAllPassengers()[cbFIO.SelectedIndex].Id_Passenger;
            int trip = int.Parse(cbNumTrip.Text);
            int dSt = IntermediateStationDAL.GetIntermediateStationByName(cbDS.Text).Id_IntermediateStation;
            int aSt = IntermediateStationDAL.GetIntermediateStationByName(cbAS.Text).Id_IntermediateStation;
            int type = CarriageTypeDAL.GetCarriageTypeByType(cbType.Text).Id_CarriageType;
            int plaseNum = int.Parse(nPlase.Value.ToString());
            TicketDAL.Insert(price, FIO, trip, dSt, aSt, type, plaseNum);
        }

        private void btnAddTrips_Click(object sender, EventArgs e)
        {
            if (!GetPrice()) return;
            if (!GetFIO()) return;
            if (!GetTrip()) return;
            if (!GetDepartureStation()) return;
            if (!GetArrivalStation()) return;
            if (!GetPlaseNumber()) return;
            if (!GetCarriageType()) return;
            InsertTicket();
            DialogResult = DialogResult.OK;
        }
    }

}
