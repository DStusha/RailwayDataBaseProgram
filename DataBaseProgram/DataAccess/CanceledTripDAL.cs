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
    public static class CanceledTripDAL
    {
        private const string GetAllTripsQuery = "select * from CanceledTrips";
        private const string GetAllTripsQueryByReason = "select * from CanceledTrips where Id_Reason = @id";
        private const string InsertTrip = "INSERT INTO CanceledTrips VALUES(@val1,@val2);";
        private const string DeleteCT = "delete from CanceledTrips where Id_CanceledTrip = @id";
        private const string QUpdateTrip = "UPDATE CanceledTrips SET Id_Trip = @val where Id_CanceledTrip = @id;";
        private const string QUpdateReason = "UPDATE CanceledTrips SET Id_Reason = @val where Id_CanceledTrip = @id;";

        private static List<CanceledTrip> GetTripsListFromDataReader(SqlDataReader reader)
        {
            List<CanceledTrip> result = new List<CanceledTrip>();
            while (reader.Read())
            {
                CanceledTrip t = new CanceledTrip()
                {
                    Id_CanceledTrip = reader.GetInt32(0),
                    Reason = CancellationReasonDAL.GetCancellationReasonById(reader.GetInt32(1)).Reason,
                    Id_id_Trip = reader.GetInt32(2)
                };
                result.Add(t);
            }
            return result;

        }

        public static List<CanceledTrip> GetAllCancelledTrips()
        {
            List<CanceledTrip> result = null;
            try
            {
                using(DBManager db = new DBManager())
                {
                    db.Open();
                    using(SqlDataReader reader = db.ExecuteQuery(GetAllTripsQuery))
                    {
                        result = GetTripsListFromDataReader(reader);
                        reader.Close();
                    }
                    db.Close();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static void UpdateTrip(int val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdateTrip, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateReason(int val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdateReason, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                    db.ExecuteNonQuery(DeleteCT, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Insert(int val1, int val2)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val1", val1);
            pars.Add("@val2", val2);
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

        public static List<CanceledTrip> GetCancelledTripsByReason(int id)
        {
            List<CanceledTrip> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id",id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllTripsQueryByReason, pars))
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
