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
    public static class TrainDAL
    {
        private const string GetAllTrainsQuery = "select * from Trains";
        private const string GetTrainQueryById = "select * from Trains where Id_Train = @id";
        private const string DeleteById = "delete from Trains where Id_Train = @id";
        private const string InsertTrain = "INSERT INTO Trains VALUES(@val);";
        private const string QUpdateTrain= "UPDATE Trains SET TrainNumber = @val where Id_Train = @id;";

        private static List<Train> GetTrainsListFromDataReader(SqlDataReader reader)
        {
            List<Train> result = new List<Train>();
            while (reader.Read())
            {
                Train t = new Train()
                {
                    Id_Train = reader.GetInt32(0),
                    TrainNumber = reader.GetInt32(1),
                };
                result.Add(t);
            }
            return result;

        }

        private static Train GetTrainFromDataReader(SqlDataReader reader)
        {
            reader.Read();
                Train t = new Train()
                {
                    Id_Train = reader.GetInt32(0),
                    TrainNumber = reader.GetInt32(1),
                };
            return t;

        }

        public static Train GetTrainById(int id)
        {
            Train result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTrainQueryById, pars))
                    {
                        result = GetTrainFromDataReader(reader);
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

        public static List<Train> GetAllTrains()
        {
            List<Train> result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllTrainsQuery))
                    {
                        result = GetTrainsListFromDataReader(reader);
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

        public static void Insert(int val)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(InsertTrain, pars);
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
                    db.ExecuteNonQuery(DeleteById, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateTrainNum(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdateTrain, pars);
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
