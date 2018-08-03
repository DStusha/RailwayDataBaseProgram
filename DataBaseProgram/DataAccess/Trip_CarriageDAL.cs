using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProgram
{
    public static class Trip_CarriageDAL
    {
        private const string InsertTC = "INSERT INTO Trips_Carriage VALUES(@val1,@val2,@val3);";
        private const string GetAllTrip_CarriageQuery = "select * from Trips_Carriage where Id_Trip = @id";

        private static List<Trip_Carriage> GetTrip_CarriageListFromDataReader(SqlDataReader reader)
        {
            List<Trip_Carriage> result = new List<Trip_Carriage>();
            while (reader.Read())
            {
                Trip_Carriage t = new Trip_Carriage()
                {
                    Id_Trip = reader.GetInt32(1),
                    Type = CarriageTypeDAL.GetCarriageTypeById(reader.GetInt32(0)).Type,
                    Id_CarriageType = reader.GetInt32(0),
                    Count = reader.GetInt32(2)
                };
                result.Add(t);
            }
            return result;

        }

        public static List<Trip_Carriage> GetAllTrip_Carriage(int id)
        {
            List<Trip_Carriage> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllTrip_CarriageQuery,pars))
                    {
                        result = GetTrip_CarriageListFromDataReader(reader);
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

        public static void Insert(int val1, int val2, int val3)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val1", val1);
            pars.Add("@val2", val2);
            pars.Add("@val3", val3);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(InsertTC, pars);
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
