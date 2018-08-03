using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DataBaseProgram
{
    public static class IntermediateStationDAL
    {
        private const string GetAllIntermediateStationsQuery = "select * from IntermediateStation";
        private const string GetIntermediateStationQueryById = "select * from IntermediateStation where Id_IntermediateStation = @id";
        private const string GetIntermediateStationQueryByName = "select i.* from IntermediateStation i join Stations s on i.Id_Station = s.Id_Station where s.Name = @name";
        private const string GetIntermediateStationQueryByStation = "select * from IntermediateStation where Id_Station = @id";
        private const string GetAllIntermediateStationsQueryByTrip = "select * from IntermediateStation where Id_Trip = @id_рейса";
        private const string InsertStation = "INSERT INTO IntermediateStation VALUES(@val1,@val2,@val3,@val4,@val5,@val6);";

        private static List<IntermediateStation> GetIntermediateStationsListFromDataReader(SqlDataReader reader)
        {
            List<IntermediateStation> result = new List<IntermediateStation>();
            while (reader.Read())
            {
                IntermediateStation t = new IntermediateStation()
                {
                    Id_IntermediateStation = reader.GetInt32(0),
                    Id_id_Station = reader.GetInt32(1),
                    Station = StationDAL.GetStationById(reader.GetInt32(1)).Name,
                    Id_id_Trip = reader.GetInt32(2),
                    DepartureDate = reader.GetDateTime(3).ToShortDateString(),
                    ArrivalDate = reader.GetDateTime(5).ToShortDateString(),
                    DepartureTime = reader.GetValue(4).ToString(),
                    ArrivalTime = reader.GetValue(6).ToString()
                };
                result.Add(t);
            }
            return result;
        }

        public static void Insert(int val1, int val2, string val3, string val4, string val5, string val6)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val1", val1);
            pars.Add("@val2", val2);
            pars.Add("@val3", val3);
            pars.Add("@val4", val4);
            pars.Add("@val5", val5);
            pars.Add("@val6", val6);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(InsertStation, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static IntermediateStation GetIntermediateStationFromDataReader(SqlDataReader reader)
        {
            reader.Read();
            IntermediateStation t = new IntermediateStation()
            {
                Id_IntermediateStation = reader.GetInt32(0),
                Id_id_Station = reader.GetInt32(1),
                Station = StationDAL.GetStationById(reader.GetInt32(1)).Name,
                Id_id_Trip = reader.GetInt32(2),
                DepartureDate = reader.GetDateTime(3).ToShortDateString(),
                ArrivalDate = reader.GetDateTime(5).ToShortDateString(),
                DepartureTime = reader.GetValue(4).ToString(),
                ArrivalTime = reader.GetValue(6).ToString()
            };
            return t;
        }

        public static List<IntermediateStation> GetAllIntermediateStations()
        {
            List<IntermediateStation> result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllIntermediateStationsQuery))
                    {
                        result = GetIntermediateStationsListFromDataReader(reader);
                        reader.Close();
                    }
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        
        public static List<IntermediateStation> GetIntermediateStationsByTrip(int trip)
        {
            List<IntermediateStation> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id_рейса",trip);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllIntermediateStationsQueryByTrip, pars))
                    {
                        result = GetIntermediateStationsListFromDataReader(reader);
                        reader.Close();
                    }
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static IntermediateStation GetIntermediateStationById(int id)
        {
            IntermediateStation result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id",id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetIntermediateStationQueryById, pars))
                    {
                        result = GetIntermediateStationFromDataReader(reader);
                        reader.Close();
                    }
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static IntermediateStation GetIntermediateStationByStation(int id)
        {
            IntermediateStation result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetIntermediateStationQueryByStation, pars))
                    {
                        result = GetIntermediateStationFromDataReader(reader);
                        reader.Close();
                    }
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static IntermediateStation GetIntermediateStationByName(string name)
        {
            IntermediateStation result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@name", name);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetIntermediateStationQueryByName, pars))
                    {
                        result = GetIntermediateStationFromDataReader(reader);
                        reader.Close();
                    }
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
