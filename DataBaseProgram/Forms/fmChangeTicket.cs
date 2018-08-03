using System;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public partial class fmChangeTicket : Form
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public fmChangeTicket(string type, string value, int id)
        {
            InitializeComponent();
            tbOldValue.Text = value;
            Type = type;
            Id = id;
            if (type == TicketConst.Price || type == TicketConst.PlaseNumber)
            {
                tbNew.Visible = type == TicketConst.Price;
                nudNew.Visible = type == TicketConst.PlaseNumber;
            }
            else
            {
                cbNew.Visible = true;
                FillingCbNew(type);
            }
        }

        private void FillingCbNew(string type)
        {
            if (type == TicketConst.LandingStation || type == TicketConst.ExitStation) FillingIntermediateStations();
            if (type == TicketConst.Trip) FillingTrips();
            if (type == TicketConst.Passenger)FillingPassengers();
            if (type == TicketConst.CarriageType)FillingCarriageTypes();
        }

        private void FillingPassengers()
        {
            foreach (Passenger pas in PassengerDAL.GetAllPassengers())
            {
                cbNew.Items.Add(pas.Surname.Trim(' ') + ' ' + pas.Name[0] + '.' + pas.Patronymic[0] + '.');
            }
        }

        private void FillingIntermediateStations()
        {
            foreach (IntermediateStation i in IntermediateStationDAL.GetAllIntermediateStations())
            {
                cbNew.Items.Add(StationDAL.GetStationByIntermediateStation(i.Id_IntermediateStation).Name);
            }
        }

        private void FillingTrips()
        {
            foreach (Trip tr in TripDAL.GetAllTrips())
            {
                cbNew.Items.Add(tr.Id_Trip);
            }
        }

        private void FillingCarriageTypes()
        {
            foreach (CarriageType tr in CarriageTypeDAL.GetAllCarriageTypes())
            {
                cbNew.Items.Add(tr.Type);
            }
        }

        private void UpdateTicket(int newVId, string newValue)
        {
            switch (Type)
            {
                case TicketConst.Trip:
                    TicketDAL.UpdateTrip(int.Parse(newValue), Id);
                    break;
                case TicketConst.Passenger:
                    TicketDAL.UpdatePassenger(PassengerDAL.GetAllPassengers()[newVId].Id_Passenger, Id);
                    break;
                case TicketConst.LandingStation:
                    TicketDAL.UpdateLS(IntermediateStationDAL.GetAllIntermediateStations()[newVId].Id_IntermediateStation, Id);
                    break;
                case TicketConst.ExitStation:
                    TicketDAL.UpdateES(IntermediateStationDAL.GetAllIntermediateStations()[newVId].Id_IntermediateStation, Id);
                    break;
                case TicketConst.Price:
                    TicketDAL.UpdatePrice(int.Parse(newValue), Id);
                    break;
                case TicketConst.CarriageType:
                    TicketDAL.UpdateType(CarriageTypeDAL.GetAllCarriageTypes()[newVId].Id_CarriageType, Id);
                    break;
                case TicketConst.PlaseNumber:
                    TicketDAL.UpdatePlaseNumber(int.Parse(newValue), Id);
                    break;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string txt;
            int Id_NewValue = 0;
            if (cbNew.Visible)
            {
                txt = cbNew.Text;
                Id_NewValue = cbNew.SelectedIndex;
            }
            else
            {
                txt = (tbNew.Visible) ? tbNew.Text : nudNew.Value.ToString();
            }
            UpdateTicket(Id_NewValue, txt);
        }
    }
}
