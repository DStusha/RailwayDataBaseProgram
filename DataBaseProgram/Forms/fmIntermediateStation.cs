using System;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public partial class fmIntermediateStation : Form
    {
        public int Id_Trip { get; set; }

        public fmIntermediateStation( int id_Trip)
        {
            InitializeComponent();
            Id_Trip = id_Trip;
            FillingStation();
            dgvIS.AutoGenerateColumns = false;
        }

        private void FillingStation()
        {
            foreach (Station s in StationDAL.GetAllStations())
            {
                cbStation.Items.Add(s.Name);
            }
        }

        private bool GetStation()
        {
            if (String.IsNullOrEmpty(cbStation.Text))
            {
                MessageBox.Show("Выберите станцию!");
                return false;
            }
            return true;
        }

        private void AddStation()
        {
            if (!GetStation()) return ;
            int idStation = StationDAL.GetStationByName(cbStation.Text).Id_Station;
            string departureDate = dtpIS2.Text;
            string departureTime = dtpIS1.Text;
            string arrivalDate = dtpIS4.Text;
            string arrivalTime = dtpIS3.Text;
            IntermediateStationDAL.Insert(idStation, Id_Trip, departureDate, departureTime, arrivalDate, arrivalTime);
            MessageBox.Show("Строка добавлена");
            dgvIS.DataSource = IntermediateStationDAL.GetIntermediateStationsByTrip(Id_Trip); ;
        }

        private void btnISAddStation_Click(object sender, EventArgs e)
        {
            if (btnISAddStation.Text == "Добавить")
            {
                AddStation();
            }
            else
            {
                dgvIS.DataSource = IntermediateStationDAL.GetIntermediateStationsByTrip(Id_Trip);
            }
        }

        private void VisibleSettingIfShow()
        {
            btnISAddStation.Text = "Показать";
            btnISAddStation.Visible = true;
            lbIS1.Visible = false;
            lbIS2.Visible = false;
            lbIS3.Visible = false;
            cbStation.Visible = false;
            dtpIS1.Visible = false;
            dtpIS2.Visible = false;
            dtpIS3.Visible = false;
            dtpIS4.Visible = false;
        }

        private void VisibleSettingIfAdd()
        {
            btnISAddStation.Text = "Добавить";
            btnISAddStation.Visible = true;
            lbIS1.Visible = true;
            lbIS2.Visible = true;
            lbIS3.Visible = true;
            cbStation.Visible = true;
            dtpIS1.Visible = true;
            dtpIS2.Visible = true;
            dtpIS3.Visible = true;
            dtpIS4.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvIS.DataSource = null;
            if (listBox1.SelectedIndex == 0) VisibleSettingIfShow();
            if (listBox1.SelectedIndex == 1) VisibleSettingIfAdd();
        }
    }
}
