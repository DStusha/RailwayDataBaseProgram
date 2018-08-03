using System;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public partial class fmMain : Form
    {

        #region Main

        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            cbStationsFilling();
            TicketsFilling();
            DriversFilling();
            TrainsFilling();
            IntermediateStationsFilling();
            CancellationReasonsFilling();
            DataGridVeiwFilling();
            dtpTableDate.Checked = false;
            dtpTrips.Checked = false;
        }

        private void DataGridVeiwFilling()
        {
            dgvRT.AutoGenerateColumns = false;
            dgvRT.DataSource = PassengerDAL.GetAllPassengers();
            dgvTable.AutoGenerateColumns = false;
            dgvTable.DataSource = TrainTableDAL.GetAllTrainTables();
            dgvCT.AutoGenerateColumns = false;
            dgvCT.DataSource = CanceledTripDAL.GetAllCancelledTrips();
            dgvTrips.AutoGenerateColumns = false;
            dgvTrips.DataSource = TripDAL.GetAllTrips();
            dgvTickets.AutoGenerateColumns = false;
            dgvTickets.DataSource = TicketDAL.GetAllTickets();
        }

        private void cbStationsFilling()
        {
            foreach (Station s in StationDAL.GetAllStations())
            {
                cbTableDS.Items.Add(s.Name);
                cbTableAS.Items.Add(s.Name);
                cbTripsAS.Items.Add(s.Name);
                cbTripsDS.Items.Add(s.Name);
            }
            cbTableDS.SelectedIndex = cbTableAS.SelectedIndex = cbTripsDS.SelectedIndex = cbTripsAS.SelectedIndex = 0;
        }

        private void TicketsFilling()
        {
            foreach (Ticket tic in TicketDAL.GetAllTickets())
            {
                cbTicPrice.Items.Add(tic.Price);
            }
            cbTicPrice.SelectedIndex = 0;
        }

        private void DriversFilling()
        {
            foreach (Driver dr in DriverDAL.GetAllDrivers())
            {
                cbTripsDriver.Items.Add(dr.Surname + " " + dr.Name[0] + "." + " " + dr.Patronymic[0] + ".");
            }
            cbTripsDriver.SelectedIndex = 0;
        }

        private void TrainsFilling()
        {
            foreach (Train dr in TrainDAL.GetAllTrains())
            {
                cbTripsTrain.Items.Add(dr.TrainNumber);
            }
            cbTripsTrain.SelectedIndex = 0;
        }

        private void IntermediateStationsFilling()
        {
            foreach (IntermediateStation i in IntermediateStationDAL.GetAllIntermediateStations())
            {
                cbTicDS.Items.Add(StationDAL.GetStationByIntermediateStation(i.Id_IntermediateStation).Name);
                cbTicAS.Items.Add(StationDAL.GetStationByIntermediateStation(i.Id_IntermediateStation).Name);
            }
            cbTicDS.SelectedIndex = cbTicAS.SelectedIndex = 0;
        }

        private void CancellationReasonsFilling()
        {
            foreach (CancellationReason r in CancellationReasonDAL.GetAllCancellationReasons())
            {
                listBoxCT.Items.Add(r.Reason);
            }
        }

        #endregion Main

        #region Tickets

        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTicketDel.Enabled = true;
            btnChange.Enabled = true;
        }

        private int? GetPrice()
        {
            if (cbTicPrice.SelectedIndex == 0) return null;
            return int.Parse(cbTicPrice.Text);
        }

        private bool TicketSearchByDepartureStationAndArrivalStationAndPrise()
        {
            if (cbTicAS.SelectedIndex != 0 && cbTicDS.SelectedIndex != 0 && GetPrice() != null)
            {
                dgvTickets.DataSource = TicketDAL.GetTicketsByDsAsPrice(IntermediateStationDAL.GetIntermediateStationByName(cbTicDS.Text).Id_IntermediateStation, IntermediateStationDAL.GetIntermediateStationByName(cbTicAS.Text).Id_IntermediateStation, GetPrice());
                return true;
            }
            return false;
        }

        private bool TicketSearchByDepartureStationAndArrivalStation()
        {
            if (cbTicDS.SelectedIndex != 0 && cbTicAS.SelectedIndex != 0)
            {
                dgvTickets.DataSource = TicketDAL.GetTicketsByDsAs(IntermediateStationDAL.GetIntermediateStationByName(cbTicDS.Text).Id_IntermediateStation, IntermediateStationDAL.GetIntermediateStationByName(cbTicAS.Text).Id_IntermediateStation);
                return true;
            }
            return false;
        }

        private bool TicketSearchByDepartureStationAndPrice()
        {
            if (cbTicDS.SelectedIndex != 0 && GetPrice() != null)
            {
                dgvTickets.DataSource = TicketDAL.GetTicketsByDsPrice(IntermediateStationDAL.GetIntermediateStationByName(cbTicDS.Text).Id_IntermediateStation, GetPrice());
                return true;
            }
            return false;
        }

        private bool TicketSearchByArrivalStationAndPrise()
        {
            if (cbTicAS.SelectedIndex != 0 && GetPrice() != null)
            {
                dgvTickets.DataSource = TicketDAL.GetTicketsByAsPrice(IntermediateStationDAL.GetIntermediateStationByName(cbTicAS.Text).Id_IntermediateStation, GetPrice());
                return true;
            }
            return false;
        }

        private bool TicketSearchByDepartureStation()
        {
            if (cbTicDS.SelectedIndex != 0)
            {
                dgvTickets.DataSource = TicketDAL.GetTicketsByDs(IntermediateStationDAL.GetIntermediateStationByName(cbTicDS.Text).Id_IntermediateStation);
                return true;
            }
            return false;
        }

        private bool TicketSearchByArrivalStation()
        {
            if (cbTicAS.SelectedIndex != 0)
            {
                dgvTickets.DataSource = TicketDAL.GetTicketsByAs(IntermediateStationDAL.GetIntermediateStationByName(cbTicAS.Text).Id_IntermediateStation);
                return true;
            }
            return false;
        }

        private bool TicketSearchByPrise()
        {
            if (GetPrice() != null)
            {
                dgvTickets.DataSource = TicketDAL.GetTicketsByPrice(GetPrice());
                return true;
            }
            return false;
        }

        private void btnTicketSearch_Click(object sender, EventArgs e)
        {
            if (TicketSearchByDepartureStationAndArrivalStationAndPrise()) return;
            if (TicketSearchByDepartureStationAndArrivalStation()) return;
            if (TicketSearchByDepartureStationAndPrice()) return;
            if (TicketSearchByArrivalStationAndPrise()) return;
            if (TicketSearchByArrivalStation()) return;
            if (TicketSearchByDepartureStation()) return;
            if (TicketSearchByPrise()) return;
            dgvTickets.DataSource = TicketDAL.GetAllTickets();
        }

        private void btnTicketAdd_Click(object sender, EventArgs e)
        {
            fmAddTicket f = new fmAddTicket();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Строка добавлена");
                dgvTickets.DataSource = TicketDAL.GetAllTickets();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string type = dgvTickets.SelectedCells[0].OwningColumn.Name;
            string value = dgvTickets.SelectedCells[0].Value.ToString();
            int id = (dgvTickets.SelectedCells[0].OwningRow.DataBoundItem as Ticket).Id_Ticket;
            fmChangeTicket f = new fmChangeTicket(type, value, id);
            f.Text = dgvTickets.SelectedCells[0].OwningColumn.HeaderText;
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Значение изменено");
                dgvTickets.DataSource = TicketDAL.GetAllTickets();
            }
        }

        private void btnTicketDel_Click(object sender, EventArgs e)
        {
            TicketDAL.Delete((dgvTickets.SelectedCells[0].OwningRow.DataBoundItem as Ticket).Id_Ticket);
            dgvTickets.DataSource = TicketDAL.GetAllTickets();
            MessageBox.Show("Строка удалена");
        }

        #endregion Tickets

        #region Trips

        private void btnTripsAdd_Click(object sender, EventArgs e)
        {
            fmAddTrip fm = new fmAddTrip();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Строка добавлена");
                dgvTrips.DataSource = TripDAL.GetAllTrips();
            }
        }

        private void btnTripsIS_Click(object sender, EventArgs e)
        {
            int id_Trip = (dgvTrips.SelectedCells[0].OwningRow.DataBoundItem as Trip).Id_Trip;
            fmIntermediateStation f = new fmIntermediateStation(id_Trip);
            f.ShowDialog();
        }

        private void dgvTrips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTripsDel.Enabled = true;
            btnTripsIS.Enabled = true;
            btnTripsCarriage.Enabled = true;
        }

        private void EnabledSettingStations()
        {
            if (cbTripsDS.SelectedIndex != 0 || cbTripsAS.SelectedIndex != 0)
            {
                cbTripsDriver.Text = "";
                cbTripsDriver.Enabled = false;
                cbTripsTrain.Text = "";
                cbTripsTrain.Enabled = false;
            }
            else
            {
                cbTripsDriver.Enabled = true;
                cbTripsTrain.Enabled = true;
            }
        }

        private void EnabledSettingDate()
        {
            if (cbTripsDS.SelectedIndex !=0 || cbTripsAS.SelectedIndex != 0 || cbTripsDriver.SelectedIndex != 0 || cbTripsTrain.SelectedIndex != 0)
            {
                dtpTableDate.Checked = false;
                dtpTrips.Enabled = false;
            }
            else
            {
                dtpTrips.Enabled = true;
            }
        }

        private void EnabledSettingDriverAndTrain()
        {
            if (cbTripsDriver.SelectedIndex != 0 || cbTripsTrain.SelectedIndex != 0)
            {
                cbTripsDS.Text = "";
                cbTripsDS.Enabled = false;
                cbTripsAS.Text = "";
                cbTripsAS.Enabled = false;
            }
            else
            {
                cbTripsDS.Enabled = true;
                cbTripsAS.Enabled = true;
            }
        }

        private void cbTripsDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledSettingDate();
            EnabledSettingStations();
            EnabledSettingDriverAndTrain();
        }

        private void btnTripsCarriage_Click(object sender, EventArgs e)
        {
            int idTrip = TripDAL.GetAllTrips()[dgvTrips.SelectedCells[0].OwningRow.Index].Id_Trip;
            fmCarriageList f = new fmCarriageList(idTrip);
            f.Show();
        }

        private void dtpTrips_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTrips.Checked)
            {
                cbTripsDS.Enabled = false;
                cbTripsDS.SelectedIndex = 0;
                cbTripsAS.SelectedIndex = 0;
                cbTripsAS.Enabled = false;
                cbTripsDriver.Enabled = false;
                cbTripsDriver.SelectedIndex = 0;
                cbTripsTrain.SelectedIndex = 0;
                cbTripsTrain.Enabled = false;
            }
            else
            {
                cbTripsDS.Enabled = true;
                cbTripsAS.Enabled = true;
                cbTripsTrain.Enabled = true;
                cbTripsDriver.Enabled = true;
            }
        }

        private void SearchTripByStations()
        {
            int IdDepartureStation = cbTripsDS.SelectedIndex != 0?IdDepartureStation = StationDAL.GetStationByName(cbTripsDS.Text).Id_Station:0;
            int IdArrivalStation = cbTripsAS.SelectedIndex != 0?IdArrivalStation = StationDAL.GetStationByName(cbTripsAS.Text).Id_Station:0;
            if (cbTripsDS.SelectedIndex!= 0 && cbTripsAS.SelectedIndex != 0)
                dgvTrips.DataSource = TripDAL.GetTripsByStations(IdDepartureStation, IdArrivalStation);
            if (cbTripsAS.SelectedIndex != 0)
                dgvTrips.DataSource = TripDAL.GetTripsByAStation(IdArrivalStation);
            if (cbTripsDS.SelectedIndex != 0)
                dgvTrips.DataSource = TripDAL.GetTripsByDStation(IdDepartureStation);
        }

        private void SearchByDriverAndTrain()
        {
            int idDriver = cbTripsDriver.SelectedIndex!=0 ? DriverDAL.GetAllDrivers()[cbTripsDriver.SelectedIndex].Id_Driver: 0;
            int idTrain = cbTripsTrain.SelectedIndex != 0? idTrain = TrainDAL.GetAllTrains()[cbTripsTrain.SelectedIndex].Id_Train : 0;
            if (cbTripsDriver.SelectedIndex !=0 && cbTripsTrain.SelectedIndex != 0)
                dgvTrips.DataSource = TripDAL.GetTripsByDriverAndTrain(idDriver, idTrain);
            if (cbTripsTrain.SelectedIndex != 0)
                dgvTrips.DataSource = TripDAL.GetTripsByTrain(idTrain);
            if (cbTripsDriver.SelectedIndex != 0)
                dgvTrips.DataSource = TripDAL.GetTripsByDriver(idDriver);
        }

        private void btnTripsSearch_Click(object sender, EventArgs e)
        {
            if (dtpTrips.Checked) dgvTrips.DataSource = TripDAL.GetTripsByDate(dtpTrips.Value.ToString());
            SearchTripByStations();
            SearchByDriverAndTrain();
        }

        private void btnTripsDel_Click(object sender, EventArgs e)
        {
            TripDAL.Delete((dgvTrips.SelectedCells[0].OwningRow.DataBoundItem as Trip).Id_Trip);
            dgvTrips.DataSource = TripDAL.GetAllTrips();
            MessageBox.Show("Строка удалена");
        }

        #endregion Trips

        #region CancellationTrips

        private void btnCTAdd_Click(object sender, EventArgs e)
        {
            fmAddCancelledtrip f = new fmAddCancelledtrip();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Строка добавлена");
                if (listBoxCT.SelectedIndex >= 0)
                {
                    int idReason = CancellationReasonDAL.GetAllCancellationReasons()[listBoxCT.SelectedIndex].Id_Reason;
                    dgvCT.DataSource = CanceledTripDAL.GetCancelledTripsByReason(idReason);
                }
                else
                {
                    dgvCT.DataSource = CanceledTripDAL.GetAllCancelledTrips();
                }
            }
        }

        private void btnCTSearch_Click(object sender, EventArgs e)
        {
            int idReason = CancellationReasonDAL.GetCancellationReasonByReason(CancellationReasonDAL.GetAllCancellationReasons()[listBoxCT.SelectedIndex].Reason).Id_Reason;
            dgvCT.DataSource = CanceledTripDAL.GetCancelledTripsByReason(idReason);
        }

        private void dgvCT_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnCTDel.Enabled = true;
            btnCTDel.Text = "Удалить";
        }

        private void ChangeCanTrip()
        {
            string type = dgvCT.SelectedCells[0].OwningColumn.Name;
            string value = dgvCT.SelectedCells[0].Value.ToString();
            int id = (dgvCT.SelectedCells[0].OwningRow.DataBoundItem as CanceledTrip).Id_CanceledTrip;
            fmChangeCancelledTrip f = new fmChangeCancelledTrip(type, value, id);
            f.Text = dgvCT.SelectedCells[0].OwningColumn.HeaderText;
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Значение изменено");
                dgvCT.DataSource = CanceledTripDAL.GetAllCancelledTrips();
            }
        }

        private void DelCancelledTrip()
        {
            int idCanceledTrip = (dgvCT.SelectedCells[0].OwningRow.DataBoundItem as CanceledTrip).Id_CanceledTrip;
            CanceledTripDAL.Delete(idCanceledTrip);
            if (listBoxCT.SelectedIndex >= 0)
            {
                int idReason = CancellationReasonDAL.GetCancellationReasonByReason(CancellationReasonDAL.GetAllCancellationReasons()[listBoxCT.SelectedIndex].Reason).Id_Reason;
                dgvCT.DataSource = CanceledTripDAL.GetCancelledTripsByReason(idReason);
            }
            else
            {
                dgvCT.DataSource = CanceledTripDAL.GetAllCancelledTrips();
            }
            MessageBox.Show("Строка удалена");
        }

        private void btnCTDel_Click(object sender, EventArgs e)
        {
            if (btnCTDel.Text == "Удалить")
            {
                DelCancelledTrip();
            }
            else
            {
                ChangeCanTrip();
            }
        }

        private void ChangeCanTrip(object sender, MouseEventArgs e)
        {
            ChangeCanTrip();
        }

        private void listBoxCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idReason = CancellationReasonDAL.GetCancellationReasonByReason(CancellationReasonDAL.GetAllCancellationReasons()[listBoxCT.SelectedIndex].Reason).Id_Reason;
            dgvCT.DataSource = CanceledTripDAL.GetCancelledTripsByReason(idReason);
        }

        private void dgvCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCTDel.Enabled = true;
            btnCTDel.Text = "Изменить";
        }

        #endregion CancellationTrips

        #region Table

        private void ChangeTableCell()
        {
            string type = dgvTable.SelectedCells[0].OwningColumn.Name;
            string value = dgvTable.SelectedCells[0].Value.ToString();
            int id = (dgvTable.SelectedCells[0].OwningRow.DataBoundItem as TrainTable).Id_Table;
            fmChangeTable f = new fmChangeTable(type, value, id);
            f.Text = dgvTable.SelectedCells[0].OwningColumn.HeaderText;
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Значение изменено");
                dgvTable.DataSource = TrainTableDAL.GetAllTrainTables();
            }
        }

        private void dtpTableDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTableDate.Checked)
            {
                cbTableAS.Enabled = false;
                cbTableDS.SelectedIndex = 0;
                cbTableAS.SelectedIndex = 0;
                cbTableDS.Enabled = false;
            }
            else
            {
                cbTableAS.Enabled = true;
                cbTableDS.Enabled = true;
            }
        }

        private void cbTableDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTableDS.SelectedIndex != 0 || cbTableAS.SelectedIndex != 0)
            {
                dtpTableDate.Checked = false;
                dtpTableDate.Enabled = false;
            }
            if(cbTableDS.SelectedIndex == 0 && cbTableAS.SelectedIndex == 0)
            {
                dtpTableDate.Enabled = true;
            }
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelTableRow.Enabled = true;
            btnDelTableRow.Text = "Изменить";
        }

        private void btnAddTableRow_Click(object sender, EventArgs e)
        {
            fmAddTableRow f = new fmAddTableRow();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Строка добавлена");
                dgvTable.DataSource = TrainTableDAL.GetAllTrainTables();
            }
        }

        private void SearchTableByStations()
        {
            int IdDepartureStation = cbTableDS.SelectedIndex!= 0  ? StationDAL.GetStationByName(cbTableDS.Text).Id_Station : 0 ;
            int IdArrivalStation = cbTableAS.SelectedIndex !=0 ? StationDAL.GetStationByName(cbTableAS.Text).Id_Station : 0;
            if (cbTableDS.SelectedIndex!= 0  && cbTableAS.SelectedIndex != 0)
            {
                dgvTable.DataSource = TrainTableDAL.GetTrainTablesByStation(IdDepartureStation, IdArrivalStation);
                return;
            }
            if (cbTableAS.SelectedIndex != 0)
            {
                dgvTable.DataSource = TrainTableDAL.GetTrainTablesByAStation(IdArrivalStation);
                return;
            }
            if (cbTableDS.SelectedIndex != 0)
            {
                dgvTable.DataSource = TrainTableDAL.GetTrainTablesByDStation(IdDepartureStation);
                return;
            }
            dgvTable.DataSource = TrainTableDAL.GetAllTrainTables();
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            if (dtpTableDate.Checked)
            {
                dgvTable.DataSource = TrainTableDAL.GetTrainTablesByDate(dtpTableDate.Value.ToString());
            }
            else { SearchTableByStations(); }     
        }

        private void dgvTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelTableRow.Enabled = true;
            btnDelTableRow.Text = "Удалить";
        }

        private void btnDelTableRow_Click(object sender, EventArgs e)
        {
            if (btnDelTableRow.Text == "Изменить") {
                ChangeTableCell();
            }
            else
            {
                TrainTableDAL.Delete((dgvTable.SelectedCells[0].OwningRow.DataBoundItem as TrainTable).Id_Table);
                dgvTable.DataSource = TrainTableDAL.GetAllTrainTables();
                MessageBox.Show("Строка удалена");             
            }
        }
        #endregion Table

        #region ReferenceTables

        private void TextChanged(object sender, EventArgs e)
        {
            btnRTAdd.Enabled = true;
        }

        private void dgvRT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lbRT.SelectedIndex != 5)
            {
                btnDel.Enabled = true;
                btnDel.Text = "Изменить";
            }
        }

        private void dgvRT_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lbRT.SelectedIndex != 5)
            {
                btnDel.Enabled = true;
                btnDel.Text = "Удалить";
            }
        }

        private void lbRT_Enter(object sender, EventArgs e)
        {
            btnRTAdd.Enabled = false;
            tbRTName.Text = "";
            tbRTPassport.Text = "";
            tbRTPatronymic.Text = "";
            tbRTSurname.Text = "";
        }

        private void ClearText()
        {
            tbRTPassport.Text = "";
            tbRTName.Text = "";
            tbRTPatronymic.Text = "";
            tbRTSurname.Text = "";
        }

        #region UpdateReferenceTables


        private void ChangeRTCell()
        {
            switch (lbRT.SelectedIndex)
            {
                case 0:
                    updatePassenger();
                    break;
                case 1:
                    updateStation();
                    break;
                case 2:
                    updateDriver();
                    break;
                case 3:
                    updateTrain();
                    break;
                case 4:
                    updateCancellationReason();
                    break;
            }
        }

        private void updatePassenger()
        {
            string type = dgvRT.SelectedCells[0].OwningColumn.Name;
            string value = dgvRT.SelectedCells[0].Value.ToString();
            int id = (dgvRT.SelectedCells[0].OwningRow.DataBoundItem as Passenger).Id_Passenger;
            Type typeTable = dgvRT.SelectedCells[0].OwningRow.DataBoundItem.GetType();
            fmChangeValueRT f = new fmChangeValueRT(type, value, id, typeTable );
            f.Text = dgvRT.SelectedCells[0].OwningColumn.HeaderText;
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Значение изменено");
                dgvRT.DataSource = PassengerDAL.GetAllPassengers();
            }
        }

        private void updateStation()
        {
            string type = dgvRT.SelectedCells[0].OwningColumn.Name;
            string value = dgvRT.SelectedCells[0].Value.ToString();
            Type typeTable = dgvRT.SelectedCells[0].OwningRow.DataBoundItem.GetType();
            int id = (dgvRT.SelectedCells[0].OwningRow.DataBoundItem as Station).Id_Station;
            fmChangeValueRT f = new fmChangeValueRT(type, value, id, typeTable);
            f.Text = dgvRT.SelectedCells[0].OwningColumn.HeaderText;
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Значение изменено");
                dgvRT.DataSource = StationDAL.GetAllStations();
            }
        }

        private void updateDriver()
        {
            string type = dgvRT.SelectedCells[0].OwningColumn.Name;
            string value = dgvRT.SelectedCells[0].Value.ToString();
            Type typeTable = dgvRT.SelectedCells[0].OwningRow.DataBoundItem.GetType();
            int id = (dgvRT.SelectedCells[0].OwningRow.DataBoundItem as Driver).Id_Driver;
            fmChangeValueRT f = new fmChangeValueRT(type, value, id, typeTable);
            f.Text = dgvRT.SelectedCells[0].OwningColumn.HeaderText;
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Значение изменено");
                dgvRT.DataSource = DriverDAL.GetAllDrivers();
            }
        }

        private void updateTrain()
        {
            string type = dgvRT.SelectedCells[0].OwningColumn.Name;
            string value = dgvRT.SelectedCells[0].Value.ToString();
            Type typeTable = dgvRT.SelectedCells[0].OwningRow.DataBoundItem.GetType();
            int id = (dgvRT.SelectedCells[0].OwningRow.DataBoundItem as Train).Id_Train;
            fmChangeValueRT f = new fmChangeValueRT(type, value, id, typeTable);
            f.Text = dgvRT.SelectedCells[0].OwningColumn.HeaderText;
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Значение изменено");
                dgvRT.DataSource = TrainDAL.GetAllTrains();
            }
        }

        private void updateCancellationReason()
        {
            string type = dgvRT.SelectedCells[0].OwningColumn.Name;
            string value = dgvRT.SelectedCells[0].Value.ToString();
            Type typeTable = dgvRT.SelectedCells[0].OwningRow.DataBoundItem.GetType();
            int id = (dgvRT.SelectedCells[0].OwningRow.DataBoundItem as CancellationReason).Id_Reason;
            fmChangeValueRT f = new fmChangeValueRT(type, value, id, typeTable);
            f.Text = dgvRT.SelectedCells[0].OwningColumn.HeaderText;
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Значение изменено");
                dgvRT.DataSource = CancellationReasonDAL.GetAllCancellationReasons();
            }
        }

        #endregion UpdateReferenceTables

        #region DeleteReferenceTables

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (btnDel.Text == "Изменить")
            {
                ChangeRTCell();
            }
            else
            {
                DelRTRow();
            }
        }

        private void DelRTRow()
        {
            switch (lbRT.SelectedIndex)
            {
                case 0:
                    DelPassenger((dgvRT.SelectedCells[0].OwningRow.DataBoundItem as Passenger).Id_Passenger);
                    break;
                case 1:
                    DelStation((dgvRT.SelectedCells[0].OwningRow.DataBoundItem as Station).Id_Station);
                    break;
                case 2:
                    DelDrivers((dgvRT.SelectedCells[0].OwningRow.DataBoundItem as Driver).Id_Driver);
                    break;
                case 3:
                    DelTrains((dgvRT.SelectedCells[0].OwningRow.DataBoundItem as Train).Id_Train);
                    break;
                case 4:
                    DelCancellationReason((dgvRT.SelectedCells[0].OwningRow.DataBoundItem as CancellationReason).Id_Reason);
                    break;
                case 5:
                    DelCarriageType((dgvRT.SelectedCells[0].OwningRow.DataBoundItem as CarriageType).Id_CarriageType);
                    break;
            }
            MessageBox.Show("Строка удалена");
        }

        private void DelPassenger(int id)
        {
                PassengerDAL.Delete(id);
                dgvRT.DataSource = PassengerDAL.GetAllPassengers();
        }

        private void DelStation(int id)
        {
            StationDAL.Delete(id);
            dgvRT.DataSource = StationDAL.GetAllStations();
        }

        private void DelDrivers(int id)
        {
            DriverDAL.Delete(id);
            dgvRT.DataSource = DriverDAL.GetAllDrivers();
        }

        private void DelTrains(int id)
        {
            TrainDAL.Delete(id);
            dgvRT.DataSource = TrainDAL.GetAllTrains();
        }

        private void DelCancellationReason(int id)
        {
            CancellationReasonDAL.Delete(id);
            dgvRT.DataSource = CancellationReasonDAL.GetAllCancellationReasons();
        }

        private void DelCarriageType(int id)
        {
            CarriageTypeDAL.Delete(id);
            dgvRT.DataSource = CarriageTypeDAL.GetAllCarriageTypes();
        }

        #endregion DeleteReferenceTables

        #region AddReferenceTables

        private void btnRTAdd_Click(object sender, EventArgs e)
        {
            switch (lbRT.SelectedIndex)
            {
                case 0:
                    AddPassenger();
                    break;
                case 1:
                    AddStation();
                    break;
                case 2:
                    AddDrivers();
                    break;
                case 3:
                    AddTrains();
                    break;
                case 4:
                    AddReasons();
                    break;
            }
        }

        private void AddPassenger()
        {
            if (String.IsNullOrEmpty(tbRTSurname.Text)){
                MessageBox.Show("Введите фамилию!");
                return;
            }
            if (String.IsNullOrEmpty(tbRTName.Text)){
                MessageBox.Show("Введите имя!");
                return;
            }
            if (String.IsNullOrEmpty(tbRTPatronymic.Text)){
                MessageBox.Show("Введите отчество!");
                return;
            }
            if (String.IsNullOrEmpty(tbRTPassport.Text))
            {
                MessageBox.Show("Введите серию и номер паспорта через пробел!");
                return;
            }
            string surname = tbRTSurname.Text;
            string name = tbRTName.Text;
            string patronymic = tbRTPatronymic.Text;
            string passport = tbRTPassport.Text;
            PassengerDAL.Insert(surname, name, patronymic, passport);
            dgvRT.DataSource = PassengerDAL.GetAllPassengers();
            ClearText();
        }

        private void AddDrivers()
        {
            if (String.IsNullOrEmpty(tbRTSurname.Text))
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }
            if (String.IsNullOrEmpty(tbRTName.Text))
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if (String.IsNullOrEmpty(tbRTPatronymic.Text))
            {
                MessageBox.Show("Введите отчество!");
                return;
            }
            if (String.IsNullOrEmpty(tbRTPassport.Text))
            {
                MessageBox.Show("Введите номер телефона!");
                return;
            }

            string surname = tbRTSurname.Text;
            string name = tbRTName.Text;
            string patronymic = tbRTPatronymic.Text;
            string phoneNumber = tbRTPassport.Text;
            DriverDAL.Insert(surname, name, patronymic, phoneNumber);
            dgvRT.DataSource = DriverDAL.GetAllDrivers();
            ClearText();
        }

        private void AddTrains()
        {
            if (String.IsNullOrEmpty(tbRTPassport.Text))
            {
                MessageBox.Show("Введите номер поезда!");
                return;
            }
            int number = int.Parse(tbRTPassport.Text);
            TrainDAL.Insert(number);
            dgvRT.DataSource = TrainDAL.GetAllTrains();
            ClearText();
        }

        private void AddReasons()
        {
            if (String.IsNullOrEmpty(tbRTPassport.Text))
            {
                MessageBox.Show("Введите причину!");
                return;
            }
            string reason = tbRTPassport.Text;
            CancellationReasonDAL.Insert(reason);
            dgvRT.DataSource = CancellationReasonDAL.GetAllCancellationReasons();
            ClearText();
        }

        private void AddStation()
        {
            if (String.IsNullOrEmpty(tbRTSurname.Text))
            {
                MessageBox.Show("Введите название станции!");
                return;
            }
            if (String.IsNullOrEmpty(tbRTName.Text))
            {
                MessageBox.Show("Введите телефон");
                return;
            }
            if (String.IsNullOrEmpty(tbRTPatronymic.Text))
            {
                MessageBox.Show("Введите ФИО начальника!");
                return;
            }
            if (String.IsNullOrEmpty(tbRTPassport.Text))
            {
                MessageBox.Show("Введите отдаленность в КМ!");
                return;
            }

            string name = tbRTSurname.Text;
            string phoneNumber = tbRTName.Text;
            string chief = tbRTPatronymic.Text;
            int distance = int.Parse(tbRTPassport.Text);
            StationDAL.Insert(name, phoneNumber, chief, distance);
            dgvRT.DataSource = StationDAL.GetAllStations();
            ClearText();
        }

        #endregion AddReferenceTables

        #region VisibilitySetting

        private void lbRT_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            if (lbRT.SelectedIndex != 5)
            {
                btnRTAdd.Enabled = true;
                btnDel.Enabled = true;
            }
            if (lbRT.SelectedIndex == 0)
            {
                VisiblePassengers();
            }
            if (lbRT.SelectedIndex == 0 || lbRT.SelectedIndex == 2)
            {
                VisiblePassengerOrDriver();
            }
            if (lbRT.SelectedIndex == 1)
            {
                VisibleStations();
            }
            if (lbRT.SelectedIndex == 2)
            {
                VisibleDrivers();
            }
            if (lbRT.SelectedIndex != 4 || lbRT.SelectedIndex != 5 || lbRT.SelectedIndex != 3)
            {
                VisiblePassengersOrStationsOrDrivers();
            }
            if (lbRT.SelectedIndex == 4 || lbRT.SelectedIndex == 3)
            {
                VisibleTrainsOrReason();
            }
            if (lbRT.SelectedIndex == 4)
            {
                VisibleReason();
            }
            if (lbRT.SelectedIndex == 3)
            {
                VisibleTrain();
            }
            if (lbRT.SelectedIndex == 5)
            {
                VisibleTypeCarriage();
            }
        }

        private void VisiblePassengers()
        {
            dgvRT.Columns[3].DataPropertyName = "Passport";
            dgvRT.Columns[3].Name = "Passport";
            lbRTPassport.Text = "Паспортные данные";
            dgvRT.Columns[3].HeaderText = "Паспортные данные";
            dgvRT.DataSource = PassengerDAL.GetAllPassengers();
        }

        private void VisiblePassengersOrStationsOrDrivers()
        {
            lbRTSurname.Visible = true;
            tbRTSurname.Visible = true;
            tbRTName.Visible = true;
            lbRTName.Visible = true;
            lbRTPatronymic.Visible = true;
            tbRTPatronymic.Visible = true;
            dgvRT.Columns[2].Visible = true;
            dgvRT.Columns[3].Visible = true;
        }

        private void VisibleTypeCarriage()
        {
            btnRTAdd.Enabled = false;
            btnDel.Enabled = false;
            dgvRT.Columns[2].Visible = false;
            dgvRT.Columns[3].Visible = false;
            dgvRT.Columns[0].DataPropertyName = "Type";
            dgvRT.Columns[1].DataPropertyName = "PlasesCount";
            dgvRT.Columns[0].Name = "Type";
            dgvRT.Columns[1].Name = "PlasesCount";
            lbRTSurname.Visible = false;
            tbRTSurname.Visible = false;
            tbRTName.Visible = false;
            lbRTName.Visible = false;
            lbRTPatronymic.Visible = false;
            tbRTPatronymic.Visible = false;
            lbRTPassport.Visible = false;
            tbRTPassport.Visible = false;
            dgvRT.Columns[0].HeaderText = "Тип вагона";
            dgvRT.Columns[0].Name = "Type";
            dgvRT.Columns[1].HeaderText = "Количество мест в вагоне";
            dgvRT.Columns[1].Name = "PlasesCount";
            dgvRT.Columns[1].Visible = true;
            dgvRT.DataSource = CarriageTypeDAL.GetAllCarriageTypes();
        }

        private void VisibleTrain()
        {
            lbRTPassport.Text = "Номер поезда";
            dgvRT.Columns[0].HeaderText = "Номер поезда";
            dgvRT.Columns[0].DataPropertyName = "TrainNumber";
            dgvRT.Columns[0].Name = "TrainNumber";
            dgvRT.DataSource = TrainDAL.GetAllTrains();
        }

        private void VisibleReason()
        {
            lbRTPassport.Text = "Причина";
            dgvRT.Columns[0].HeaderText = "Причина";
            dgvRT.Columns[0].DataPropertyName = "Reason";
            dgvRT.Columns[0].Name = "Reason";
            dgvRT.DataSource = CancellationReasonDAL.GetAllCancellationReasons();
        }

        private void VisibleDrivers()
        {
            dgvRT.Columns[3].DataPropertyName = "PhoneNumber";
            dgvRT.Columns[3].Name = "PhoneNumber";
            dgvRT.Columns[3].HeaderText = "Телефон";
            lbRTPassport.Text = "Телефон";
            dgvRT.DataSource = DriverDAL.GetAllDrivers();
        }
        
        private void VisibleStations()
        {
            dgvRT.Columns[0].DataPropertyName = "Name";
            dgvRT.Columns[1].DataPropertyName = "PhoneNumber";
            dgvRT.Columns[2].DataPropertyName = "Chief";
            dgvRT.Columns[3].DataPropertyName = "DistanceInKM";
            dgvRT.Columns[0].Name = "Name";
            dgvRT.Columns[1].Name = "PhoneNumber";
            dgvRT.Columns[2].Name = "Chief";
            dgvRT.Columns[3].Name = "DistanceInKM";
            dgvRT.Columns[0].HeaderText = "Название станции";
            dgvRT.Columns[1].HeaderText = "Телефон";
            dgvRT.Columns[2].HeaderText = "Начальник";
            dgvRT.Columns[3].HeaderText = "Отдаленность в км";
            lbRTSurname.Text = "Название станции";
            lbRTName.Text = "Телефон";
            lbRTPatronymic.Text = "Начальник";
            lbRTPassport.Text = "Отдаленность в км";
            dgvRT.Columns[1].Visible = true;
            dgvRT.DataSource = StationDAL.GetAllStations();
        }

        private void VisiblePassengerOrDriver() {
            dgvRT.Columns[0].DataPropertyName = "Surname";
            dgvRT.Columns[0].Name = "Surname";
            dgvRT.Columns[1].DataPropertyName = "Name";
            dgvRT.Columns[1].Name = "Name";
            dgvRT.Columns[2].DataPropertyName = "Patronymic";
            dgvRT.Columns[2].Name = "Patronymic";
            lbRTSurname.Text = "Фамилия";
            lbRTName.Text = "Имя";
            lbRTPatronymic.Text = "Отчество";
            dgvRT.Columns[0].HeaderText = "Фамилия";
            dgvRT.Columns[1].HeaderText = "Имя";
            dgvRT.Columns[2].HeaderText = "Отчество";
            dgvRT.Columns[1].Visible = true;
        }

        private void VisibleTrainsOrReason()
        {
            dgvRT.Columns[1].Visible = false;
            dgvRT.Columns[2].Visible = false;
            dgvRT.Columns[3].Visible = false;
            lbRTSurname.Visible = false;
            tbRTSurname.Visible = false;
            tbRTName.Visible = false;
            lbRTName.Visible = false;
            lbRTPatronymic.Visible = false;
            tbRTPatronymic.Visible = false;
        }


        #endregion VisibilitySetting

        #endregion ReferenceTables
    }
}
