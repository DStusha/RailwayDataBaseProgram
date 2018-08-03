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
    public static class TrainTableDAL
    {
        private const string GetAllTrainTablesQuery = "select * from TrainTable";
        private const string GetTrainTablesByDateQuery = "select * from TrainTable where DepartureDate = @дата";
        private const string GetTrainTablesByStationQuery = "select * from TrainTable where Id_DepartureStation = @стотпр and Id_ArrivalStation = @стназн";
        private const string GetTrainTablesByDStationQuery = "select * from TrainTable where Id_DepartureStation = @стотпр";
        private const string GetTrainTablesByAStationQuery = "select * from TrainTable where Id_ArrivalStation = @стназн";
        private const string GetTrainTableByIdQuery = "select * from TrainTable where Id_Table = @id";
        private const string DeleteTrainTableById = "delete from TrainTable where Id_Table = @id";
        private const string UpdateDDTrainTable = "UPDATE TrainTable SET  DepartureDate = @val where Id_Table =@id;";
        private const string UpdateDSTrainTable = "UPDATE TrainTable SET  Id_DepartureStation = @val where Id_Table =@id;";
        private const string UpdateDTTrainTable = "UPDATE TrainTable SET  DepartureTime = @val where Id_Table =@id;";
        private const string UpdateASTrainTable = "UPDATE TrainTable SET  Id_ArrivalStation = @val where Id_Table =@id;";
        private const string UpdateADTrainTable = "UPDATE TrainTable SET  ArrivalDate = @val where Id_Table =@id;";
        private const string UpdateATTrainTable = "UPDATE TrainTable SET  ArrivalTime = @val where Id_Table =@id;";
        private const string InsertTrainTable = "INSERT INTO TrainTable VALUES(@val1,@val2,@val3,@val4,@val5,@val6);";


        private static List<TrainTable> GetTrainTablesListFromDataReader(SqlDataReader reader)
        {
            List<TrainTable> result = new List<TrainTable>();
            while (reader.Read())
            {
                TrainTable t = new TrainTable()
                {
                    Id_Table = reader.GetInt32(0),
                    DepartureStation = StationDAL.GetStationById(reader.GetInt32(1)).Name,
                    ArrivalStation = StationDAL.GetStationById(reader.GetInt32(2)).Name,
                    DepartureDate = reader.GetDateTime(3).ToShortDateString(),
                    ArrivalDate = reader.GetDateTime(4).ToShortDateString(),
                    DepartureTime = reader.GetValue(5).ToString(),
                    ArrivalTime = reader.GetValue(6).ToString()
                };
                result.Add(t);
            }
            return result;

        }

        private static TrainTable GetTrainTableFromDataReader(SqlDataReader reader)
        {
            reader.Read();
                TrainTable t = new TrainTable()
                {
                    Id_Table = reader.GetInt32(0),
                    DepartureStation = StationDAL.GetStationById(reader.GetInt32(1)).Name,
                    ArrivalStation = StationDAL.GetStationById(reader.GetInt32(2)).Name,
                    DepartureDate = reader.GetDateTime(3).ToShortDateString(),
                    ArrivalDate = reader.GetDateTime(4).ToShortDateString(),
                    DepartureTime = reader.GetValue(5).ToString(),
                    ArrivalTime = reader.GetValue(6).ToString()
                };
            return t;

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
                    db.ExecuteNonQuery(DeleteTrainTableById, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Insert(string val1, string val2, string val3, string val4, string val5, string val6)
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
                    db.ExecuteNonQuery(InsertTrainTable, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateDD(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateDDTrainTable, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateDS(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateDSTrainTable, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateAS(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateASTrainTable, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateAD(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateADTrainTable, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateDT(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateDTTrainTable, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateAT(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateATTrainTable, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static List<TrainTable> GetAllTrainTables()
        {
            List<TrainTable> result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllTrainTablesQuery))
                    {
                        result = GetTrainTablesListFromDataReader(reader);
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

        public static List<TrainTable> GetTrainTablesByDate(string date)
        {
            List<TrainTable> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@дата", date);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTrainTablesByDateQuery, pars))
                    {
                        result = GetTrainTablesListFromDataReader(reader);
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

        public static TrainTable GetTrainTableById(int id)
        {
            TrainTable result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTrainTableByIdQuery, pars))
                    {
                        result = GetTrainTableFromDataReader(reader);
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

        public static List<TrainTable> GetTrainTablesByStation (int ds, int ast)
        {
            List<TrainTable> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@стотпр", ds);
            pars.Add("@стназн", ast);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTrainTablesByStationQuery, pars))
                    {
                        result = GetTrainTablesListFromDataReader(reader);
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

        public static List<TrainTable> GetTrainTablesByDStation(int ds)
        {
            List<TrainTable> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@стотпр", ds);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTrainTablesByDStationQuery, pars))
                    {
                        result = GetTrainTablesListFromDataReader(reader);
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

        public static List<TrainTable> GetTrainTablesByAStation(int ast)
        {
            List<TrainTable> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@стназн", ast);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTrainTablesByAStationQuery, pars))
                    {
                        result = GetTrainTablesListFromDataReader(reader);
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
