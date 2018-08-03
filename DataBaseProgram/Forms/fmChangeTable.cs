using System;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public partial class fmChangeTable : Form
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public fmChangeTable(string type, string Value, int id)
        {
            InitializeComponent();
            Type = type;
            tbValue.Text = Value;
            Id = id;
            SettingVisibleStations();
            SettingVisibleDate();
            SettingVisibleTime();
        }

        private void SettingVisibleStations()
        {
            if (Type == TrainTableConst.DepartureStation || Type == TrainTableConst.ArrivalStation)
            {
                tbValue2.Visible = false;
                cbNewV.Visible = true;
                foreach (Station s in StationDAL.GetAllStations())
                {
                    cbNewV.Items.Add(s.Name);
                }
            }
        }

        private void SettingVisibleDate()
        {
            if (Type == TrainTableConst.DepartureDate || Type == TrainTableConst.ArrivalDate)
            {
                dtpChange.Visible = true;
                cbNewV.Visible = false;
                tbValue2.Visible = false;
            }
        }

        private void SettingVisibleTime()
        {
            if (Type == TrainTableConst.ArrivalTime || Type == TrainTableConst.DepartureTime)
            {
                dtpChange.Visible = false;
                cbNewV.Visible = false;
                tbValue2.Visible = true;
            }
        }

        private void UpdateTable(string newVId, string newValue)
        {
            switch (Type)
            {
                case TrainTableConst.DepartureStation:
                    TrainTableDAL.UpdateDS(newVId, Id);
                    break;
                case TrainTableConst.ArrivalStation:
                    TrainTableDAL.UpdateAS(newVId, Id);
                    break;
                case TrainTableConst.DepartureDate:
                    TrainTableDAL.UpdateDD(newValue, Id);
                    break;
                case TrainTableConst.ArrivalDate:
                    TrainTableDAL.UpdateAD(newValue, Id);
                    break;
                case TrainTableConst.DepartureTime:
                    TrainTableDAL.UpdateDT(newValue, Id);
                    break;
                case TrainTableConst.ArrivalTime:
                    TrainTableDAL.UpdateAT(newValue, Id);
                    break;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string txt = null;
            string Id_NewValue = null;
            if (tbValue2.Visible) txt = tbValue2.Text;
            if (cbNewV.Visible)
            {
                txt = cbNewV.Text;
                Id_NewValue = StationDAL.GetStationByName(cbNewV.Text).Id_Station.ToString();
            }
            if(dtpChange.Visible)
            {
                txt = dtpChange.Value.ToShortDateString();
            }
            UpdateTable(Id_NewValue, txt);
        }
    }
}
