using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProgram
{
    public class Trip
    {
        public int Id_Trip { get; set; }
        public int Id_Id_Table { get; set; }
        public string DStation { get; set; }
        public string AStation { get; set; }
        public string Driver { get; set; }
        public int Id_id_driver { get; set; }
        public int Id_id_train { get; set; }
        public int TrainNum { get; set; }
        public String RealDepartureDate { get; set; }
        public String RealDepartureTime { get; set; }
        public String RealArrivalDate { get; set; }
        public String RealArrivalTime { get; set; }
    }
}
