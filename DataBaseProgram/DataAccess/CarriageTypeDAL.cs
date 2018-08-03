using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections;

namespace DataBaseProgram
{
    public static class CarriageTypeDAL
    {
        private const string GetAllCarriageTypesQuery = "select * from CarriageType";
        private const string GetCarriageTypeQueryById = "select * from CarriageType where Id_CarriageType = @id";
        private const string GetCarriageTypeQueryByType = "select * from CarriageType where Type = @type";
        private const string DeleteById = "delete from  CarriageType where Id_CarriageType = @id";
        private const string InsertType = "INSERT INTO CarriageType VALUES(@val, @val1);";
        private const string QUpdateType = "UPDATE CarriageType SET Type = @val where Id_CarriageType = @id;";
        private const string QUpdatePlasesCount = "UPDATE CarriageType SET PlasesCount = @val where Id_CarriageType = @id;";

        private static List<CarriageType> GetCarriageTypesListFromDataReader(SqlDataReader reader)
        {
            List<CarriageType> result = new List<CarriageType>();
            while (reader.Read())
            {
                CarriageType t = new CarriageType()
                {
                    Id_CarriageType = reader.GetInt32(0),
                    Type = reader.GetString(1),
                    PlasesCount = reader.GetInt32(2)
                };
                result.Add(t);
            }
            return result;

        }

        private static CarriageType GetCarriageTypeFromDataReader(SqlDataReader reader)
        {
            reader.Read();
            CarriageType t = new CarriageType()
            {
                Id_CarriageType = reader.GetInt32(0),
                Type = reader.GetString(1),
                PlasesCount = reader.GetInt32(2)
            };
            return t;
        }

        public static void Insert(string val, int val1)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@val1", val1);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(InsertType, pars);
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

        public static List<CarriageType> GetAllCarriageTypes()
        {
            List<CarriageType> result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllCarriageTypesQuery))
                    {
                        result = GetCarriageTypesListFromDataReader(reader);
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

        public static CarriageType GetCarriageTypeById(int id)
        {
            CarriageType result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetCarriageTypeQueryById,pars))
                    {
                        result = GetCarriageTypeFromDataReader(reader);
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

        public static CarriageType GetCarriageTypeByType(string type)
        {
            CarriageType result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@type", type);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetCarriageTypeQueryByType, pars))
                    {
                        result = GetCarriageTypeFromDataReader(reader);
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

        public static void UpdateType(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdateType, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void UpdatePlasesCount(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdatePlasesCount, pars);
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
