using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProgram
{
    public class Ticket
    {
        public int Id_Ticket { get; set; }
        public string Passenger { get; set; }
        public int Id_id_Trip { get; set; }
        public string LandingStation { get; set; }
        public string ExitStation { get; set; }
        public string CarriageType { get; set; }
        public int PlaseNumber { get; set; }
        public int Price { get; set; }
    }
}
