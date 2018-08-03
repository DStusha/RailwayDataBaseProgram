using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;


namespace DataBaseProgram
{
    public static class CancellationReasonDAL
    {
        private const string GetAllReasonsQuery = "select * from CancellationReason";
        private const string GetReasonQueryById = "select * from CancellationReason where Id_CancellationReason = @id_причины";
        private const string GetReasonQueryByReason = "select * from CancellationReason where Reason = @причина";
        private const string DeleteById = "delete from CancellationReason  where Id_CancellationReason = @id";
        private const string InsertReason = "INSERT INTO CancellationReason VALUES(@val);";
        private const string QUpdateCancellationReason = "UPDATE CancellationReason SET Reason = @val where Id_CancellationReason = @id;";

        private static List<CancellationReason> GetReasonsListFromDataReader(SqlDataReader reader)
        {
            List<CancellationReason> result = new List<CancellationReason>();
            while (reader.Read())
            {
                CancellationReason t = new CancellationReason()
                {
                    Id_Reason = reader.GetInt32(0),
                    Reason = reader.GetString(1)
                };
                result.Add(t);
            }
            return result;

        }

        private static CancellationReason GetReasonFromDataReader(SqlDataReader reader)
        {
            reader.Read();
                CancellationReason t = new CancellationReason()
                {
                    Id_Reason = reader.GetInt32(0),
                    Reason = reader.GetString(1)
                };

            return t;
        }

        public static List<CancellationReason> GetAllCancellationReasons()
        {
            List<CancellationReason> result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllReasonsQuery))
                    {
                        result = GetReasonsListFromDataReader(reader);
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

        public static void Insert(string val)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(InsertReason, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CancellationReason GetCancellationReasonById(int numReason)
        {
            CancellationReason result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id_причины", numReason);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetReasonQueryById,pars))
                    {
                        result = GetReasonFromDataReader(reader);
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

        public static CancellationReason GetCancellationReasonByReason(string reas)
        {
            CancellationReason result = null;
            Hashtable pars = new Hashtable();
            pars.Add("причина", reas);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetReasonQueryByReason, pars))
                    {
                        result = GetReasonFromDataReader(reader);
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

        public static void UpdateCancellationReason(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdateCancellationReason, pars);
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
