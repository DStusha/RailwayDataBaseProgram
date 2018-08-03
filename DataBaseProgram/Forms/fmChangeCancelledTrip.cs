using System;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public partial class fmChangeCancelledTrip : Form
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public fmChangeCancelledTrip( string TypeV, string Value,int id)
        {
            InitializeComponent();
            Type = TypeV;
            Id = id;
            tbValue.Text = Value;
            if (Type == CancelledTripConst.Id_canTrip)
            {
                foreach (Trip tr in TripDAL.GetAllTrips())
                {
                    cbNewV.Items.Add(tr.Id_Trip);
                }
            }
            else
            {
                foreach (CancellationReason cr in CancellationReasonDAL.GetAllCancellationReasons())
                {
                    cbNewV.Items.Add(cr.Reason);
                }
            }
        }

        private void UpdateCancelledTrip(int newVId)
        {
            switch (Type)
            {
                case CancelledTripConst.Id_canTrip:
                    CanceledTripDAL.UpdateTrip(newVId, Id);
                    break;
                case CancelledTripConst.Reason:
                    CanceledTripDAL.UpdateReason(newVId, Id);
                    break;
            }
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            string txt = cbNewV.Text;
            int idNewV = Type == CancelledTripConst.Id_canTrip ? int.Parse(txt.Trim()): CancellationReasonDAL.GetCancellationReasonByReason(txt).Id_Reason;
            UpdateCancelledTrip(idNewV);
        }
    }
}
