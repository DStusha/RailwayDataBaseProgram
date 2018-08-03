using System;

namespace DataBaseProgram
{
    public class IntermediateStation
    {
        public int Id_IntermediateStation { get; set; }
        public string Station { get; set; }
        public int  Id_id_Station { get; set; }
        public int Id_id_Trip { get; set; }
        public String DepartureDate{ get; set; }
        public String DepartureTime { get; set; }
        public String ArrivalDate { get; set; }
        public String ArrivalTime { get; set; }
    }
}
