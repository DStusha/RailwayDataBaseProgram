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
    public partial class fmCarriageList : Form
    {
        public fmCarriageList(int id_Trip)
        {
            InitializeComponent();
            dgvCount.AutoGenerateColumns = false;
            dgvCount.DataSource = Trip_CarriageDAL.GetAllTrip_Carriage(id_Trip);
        }

    }
}
