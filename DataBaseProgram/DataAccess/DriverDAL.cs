using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace DataBaseProgram
{
    public static class DriverDAL
    {
        private const string GetAllDriversQuery = "select * from Drivers";
        private const string GetDriverQueryById = "select * from Drivers where Id_Driver = @id";
        private const string DeleteById = "delete from  Drivers  where Id_Driver = @id";
        private const string InsertDriver = "INSERT INTO Drivers VALUES(@val1,@val2,@val3,@val4);";
        private const string QUpdateSurname = "UPDATE Drivers SET Surname = @val where Id_Driver = @id;";
        private const string QUpdateName = "UPDATE Drivers SET Name = @val where Id_Driver = @id;";
        private const string QUpdatePatronymic = "UPDATE Drivers SET Patronymic = @val where Id_Driver = @id;";
        private const string QUpdatePhoneNumber = "UPDATE Drivers SET PhoneNumber = @val where Id_Driver = @id;";

        private static List<Driver> GetDriversListFromDataReader(SqlDataReader reader)
        {
            List<Driver> result = new List<Driver>();
            while (reader.Read())
            {
                Driver t = new Driver()
                {
                    Id_Driver = reader.GetInt32(0),
                    Surname = reader.GetString(1),
                    Name = reader.GetString(2),
                    Patronymic = reader.GetString(3),
                    PhoneNumber = reader.GetString(4)
                };
                result.Add(t);
            }
            return result;

        }

        private static Driver GetDriverFromDataReader(SqlDataReader reader)
        {
            reader.Read();
                Driver t = new Driver()
                {
                    Id_Driver = reader.GetInt32(0),
                    Surname = reader.GetString(1),
                    Name = reader.GetString(2),
                    Patronymic = reader.GetString(3),
                    PhoneNumber = reader.GetString(4)
                };
            return t;
        }

        public static Driver GetDriverById(int id)
        {
            Driver result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetDriverQueryById, pars))
                    {
                        result = GetDriverFromDataReader(reader);
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

        public static List<Driver> GetAllDrivers()
        {
            List<Driver> result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllDriversQuery))
                    {
                        result = GetDriversListFromDataReader(reader);
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

        public static void Insert(string val1, string val2, string val3, string val4)
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
                    db.ExecuteNonQuery(InsertDriver, pars);
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

        public static void UpdateSurname(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdateSurname, pars);
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

        public static void UpdatePatronymic(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdatePatronymic, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

    }
}
