using System;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public partial class fmAddCancelledtrip : Form
    {

        public fmAddCancelledtrip()
        {
            InitializeComponent();
            FillingCancellationReasons();
            FillingTrips();
        }

        private void FillingCancellationReasons()
        {
            foreach (CancellationReason cr in CancellationReasonDAL.GetAllCancellationReasons())
            {
                cbReason.Items.Add(cr.Reason);
            }
        }

        private void FillingTrips()
        {
            foreach (Trip tr in TripDAL.GetAllTrips())
            {
                cbNumTrip.Items.Add(tr.Id_Trip);
            }
        }

        private bool GetReason()
        {
            if (String.IsNullOrEmpty(cbReason.Text))
            {
                MessageBox.Show("Выберите причину!");
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

        private void btnAddTrips_Click(object sender, EventArgs e)
        {
            if (!GetReason()) return;
            if (!GetTrip()) return;
            int idReason = CancellationReasonDAL.GetAllCancellationReasons()[cbReason.SelectedIndex].Id_Reason;
            int idTrip = TripDAL.GetAllTrips()[cbNumTrip.SelectedIndex].Id_Trip;
            CanceledTripDAL.Insert(idReason, idTrip);
            DialogResult = DialogResult.OK;
        }

    }
}
