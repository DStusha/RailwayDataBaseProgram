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
    public static class TripDAL
    {
        private const string GetAllTripsQuery = "select * from Trips";
        private const string GetTripsQueryByDate = "select * from Trips where RealDepartureDate = @date";
        private const string GetTripsByStationQuery = "select * from Trips t join TrainTable tt on t.Id_Table = tt.Id_Table where tt.Id_DepartureStation = @стотпр and Id_ArrivalStation = @стназн";
        private const string GetTripsByDStationQuery = "select * from Trips t join TrainTable tt on t.Id_Table = tt.Id_Table where tt.Id_DepartureStation = @стотпр";
        private const string GetTripsByAStationQuery = "select * from Trips t join TrainTable tt on t.Id_Table = tt.Id_Table where tt.Id_ArrivalStation = @стназн";
        private const string GetTripsByDriverAndTrainQuery = "select * from Trips where Id_Driver = @drid and Id_Train = @tid";
        private const string GetTripsByDriverQuery = "select * from Trips where Id_Driver = @drid";
        private const string GetTripsByTrainQuery = "select * from Trips Id_Table where Id_Train = @tid";
        private const string InsertTrip = "INSERT INTO Trips VALUES(@val1,@val2,@val3,@val4,@val5,@val6,@val7);";
        private const string DeleteTrip = "delete from Trips where Id_Trip = @id";

        private static List<Trip> GetTripsListFromDataReader(SqlDataReader reader)
        {
            List<Trip> result = new List<Trip>();
            while (reader.Read())
            {
                Driver dr = DriverDAL.GetDriverById(reader.GetInt32(2));
                string fio = dr.Surname + " " + dr.Name[0] + "." + " " + dr.Patronymic[0] + ".";
                Trip t = new Trip()
                {
                    Id_Trip = reader.GetInt32(0),
                    Id_Id_Table = reader.GetInt32(1),
                    DStation = TrainTableDAL.GetTrainTableById(reader.GetInt32(1)).DepartureStation,
                    AStation = TrainTableDAL.GetTrainTableById(reader.GetInt32(1)).ArrivalStation,
                    Id_id_driver = reader.GetInt32(2),
                    Driver = fio,
                    Id_id_train = reader.GetInt32(3),
                    TrainNum = TrainDAL.GetTrainById(reader.GetInt32(3)).TrainNumber,
                    RealDepartureDate = reader.GetDateTime(4).ToShortDateString(),
                    RealDepartureTime = reader.GetValue(5).ToString(),
                    RealArrivalDate = reader.GetDateTime(6).ToShortDateString(),
                    RealArrivalTime = reader.GetValue(7).ToString(),
                };
                result.Add(t);
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
                    db.ExecuteNonQuery(DeleteTrip, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Insert(int val1, int val2, int val3, string val4, string val5, string val6, string val7)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val1", val1);
            pars.Add("@val2", val2);
            pars.Add("@val3", val3);
            pars.Add("@val4", val4);
            pars.Add("@val5", val5);
            pars.Add("@val6", val6);
            pars.Add("@val7", val7);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(InsertTrip, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Trip> GetTripsByDriverAndTrain(int drid, int tid)
        {
            List<Trip> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@drid", drid);
            pars.Add("@tid", tid);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTripsByDriverAndTrainQuery, pars))
                    {
                        result = GetTripsListFromDataReader(reader);
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

        public static List<Trip> GetTripsByDriver(int drid)
        {
            List<Trip> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@drid", drid);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTripsByDriverQuery, pars))
                    {
                        result = GetTripsListFromDataReader(reader);
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

        public static List<Trip> GetTripsByTrain(int tid)
        {
            List<Trip> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@tid", tid);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTripsByTrainQuery, pars))
                    {
                        result = GetTripsListFromDataReader(reader);
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

        public static List<Trip> GetTripsByStations(int ds, int ast)
        {
            List<Trip> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@стотпр", ds);
            pars.Add("@стназн", ast);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTripsByStationQuery, pars))
                    {
                        result = GetTripsListFromDataReader(reader);
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

        public static List<Trip> GetTripsByDStation(int ds)
        {
            List<Trip> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@стотпр", ds);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTripsByDStationQuery, pars))
                    {
                        result = GetTripsListFromDataReader(reader);
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

        public static List<Trip> GetTripsByAStation(int ast)
        {
            List<Trip> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@стназн", ast);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTripsByAStationQuery, pars))
                    {
                        result = GetTripsListFromDataReader(reader);
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

        public static List<Trip> GetAllTrips()
        {
            List<Trip> result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllTripsQuery))
                    {
                        result = GetTripsListFromDataReader(reader);
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

        public static List<Trip> GetTripsByDate(string date)
        {
            List<Trip> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@date", date);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTripsQueryByDate, pars))
                    {
                        result = GetTripsListFromDataReader(reader);
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
