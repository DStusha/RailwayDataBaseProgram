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
    public partial class fmAddIntermediateStation : Form
    {
        public fmAddIntermediateStation()
        {
            InitializeComponent();
            foreach(Station s in StationDAL.GetAllStations())
            {
                cbS.Items.Add(s.Name);
            }
        }

        private void btnAddTrips_Click(object sender, EventArgs e)
        {

        }
    }
}
