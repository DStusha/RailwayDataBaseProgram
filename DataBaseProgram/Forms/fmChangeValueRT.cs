using System;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public partial class fmChangeValueRT : Form
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Type TableType { get; set; }

        public fmChangeValueRT(string type, string Value, int id, Type t)
        {
            InitializeComponent();
            Type = type;
            tbValue.Text = Value;
            Id = id;
            TableType = t;
        }

        private void UpdatePassenger(string newValue)
        {
            switch (Type)
            {
                case PassengerConst.Surname:
                    PassengerDAL.UpdateSurname(newValue, Id);
                    break;
                case PassengerConst.Name:
                    PassengerDAL.UpdateName(newValue, Id);
                    break;
                case PassengerConst.Patronymic:
                    PassengerDAL.UpdatePatronymic(newValue, Id);
                    break;
                case PassengerConst.Passport:
                    PassengerDAL.UpdatePassport(newValue, Id);
                    break;
            }
        }

        private void UpdateDriver(string newValue)
        {
            switch (Type)
            {
                case DriverConst.Surname:
                    DriverDAL.UpdateSurname(newValue, Id);
                    break;
                case DriverConst.Name:
                    DriverDAL.UpdateName(newValue, Id);
                    break;
                case DriverConst.Patronymic:
                    DriverDAL.UpdatePatronymic(newValue, Id);
                    break;
                case DriverConst.PhoneNumber:
                    DriverDAL.UpdatePhoneNumber(newValue, Id);
                    break;
            }
        }

        private void UpdateStation(string newValue)
        {
            switch (Type)
            {
                case StationConst.PhoneNumber:
                    StationDAL.UpdatePhoneNumber(newValue, Id);
                    break;
                case StationConst.Name:
                    StationDAL.UpdateName(newValue, Id);
                    break;
                case StationConst.Chief:
                    StationDAL.UpdateChief(newValue, Id);
                    break;
                case StationConst.DistanceInKM:
                    StationDAL.UpdateDistance(newValue, Id);
                    break;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Passenger p = new Passenger();
            Station s = new Station();
            Driver d = new Driver();
            Train t = new Train();
            CancellationReason c = new CancellationReason();
            if (TableType.Equals(p.GetType())) UpdatePassenger(tbNewValue.Text);
            if (TableType.Equals(s.GetType())) UpdateStation(tbNewValue.Text);
            if (TableType.Equals(d.GetType())) UpdateDriver(tbNewValue.Text);
            if (TableType.Equals(t.GetType())) TrainDAL.UpdateTrainNum(tbNewValue.Text, Id);
            if (TableType.Equals(c.GetType())) CancellationReasonDAL.UpdateCancellationReason(tbNewValue.Text, Id);
          
        }
    }
}
