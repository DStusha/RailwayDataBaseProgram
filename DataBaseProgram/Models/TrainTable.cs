using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProgram
{
    public class TrainTable
    {
        public int Id_Table { get; set; }
        public String DepartureStation { get; set; }
        public String ArrivalStation { get; set; }
        public String DepartureDate { get; set; }
        public String DepartureTime { get; set; }
        public String ArrivalDate { get; set; }
        public String ArrivalTime { get; set; }
    }
}
