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
    public static class StationDAL
    {
        private const string GetAllStationsQuery = "select * from Stations";
        private const string GetStationQueryById = "select * from Stations where Id_Station = @id_станции";
        private const string GetStationQueryByIntermediateStation = "select s.* from IntermediateStation i join Stations s on i.Id_Station = s.Id_Station where Id_IntermediateStation = @id";
        private const string GetStationQueryByName = "select * from Stations where Name = @название";
        private const string DeleteById = "delete from  Stations  where Id_Station = @id";
        private const string InsertStation = "INSERT INTO Stations VALUES(@val1,@val2,@val3,@val4);";
        private const string QUpdatePhoneNumber = "UPDATE Stations SET PhoneNumber = @val where Id_Station = @id;";
        private const string QUpdateChief = "UPDATE Stations SET Chief = @val where Id_Station = @id;";
        private const string QUpdateName = "UPDATE Stations SET Name = @val where Id_Station = @id;";
        private const string QUpdateDistanceInKM = "UPDATE Stations SET DistanceInKM = @val where Id_Station = @id;";

        private static List<Station> GetStationsListFromDataReader(SqlDataReader reader)
        {
            List<Station> result = new List<Station>();
            while (reader.Read())
            {
                Station t = new Station()
                {
                    Id_Station = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    PhoneNumber = reader.GetString(2),
                    Chief = reader.GetString(3),
                    DistanceInKM = reader.GetInt32(4)
                };
                result.Add(t);
            }
            return result;

        }

        private static Station GetStationFromDataReader(SqlDataReader reader)
        {
            reader.Read();
            Station  t = new Station()
            {
                Id_Station = reader.GetInt32(0),
                Name = reader.GetString(1),
                PhoneNumber = reader.GetString(2),
                Chief = reader.GetString(3),
                DistanceInKM = reader.GetInt32(4)
            };
            return t;
        }

        public static List<Station> GetAllStations()
        {
            List<Station> result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllStationsQuery))
                    {
                        result = GetStationsListFromDataReader(reader);
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

        public static void Delete(int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(DeleteById, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Insert(string val1, string val2, string val3, int val4)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val1", val1);
            pars.Add("@val2", val2);
            pars.Add("@val3", val3);
            pars.Add("@val4", val4);
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

        public static Station GetStationById(int id)
        {
            Station result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id_станции", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetStationQueryById, pars))
                    {
                        result = GetStationFromDataReader(reader);
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

        public static Station GetStationByIntermediateStation(int id)
        {
            Station result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetStationQueryByIntermediateStation, pars))
                    {
                        result = GetStationFromDataReader(reader);
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

        public static Station GetStationByName(string name)
        {
            Station result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@название", name);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetStationQueryByName, pars))
                    {
                        result = GetStationFromDataReader(reader);
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

        public static void UpdatePhoneNumber(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdatePhoneNumber, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateName(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdateName, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateChief(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdateChief, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateDistance(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdateDistanceInKM, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
