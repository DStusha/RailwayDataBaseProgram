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
    public static class PassengerDAL
    {
        private const string GetAllPassengersQuery = "select * from Passengers";
        private const string GetPassengerByIdQuery = "select * from Passengers where Id_Passenger = @id";
        private const string DeletePassengerById = "delete from Passengers where Id_Passenger = @id";
        private const string QUpdateSurname = "UPDATE Passengers SET Surname = @val where Id_Passenger = @id;";
        private const string QUpdateName = "UPDATE Passengers SET Name = @val where Id_Passenger = @id;";
        private const string QUpdatePatronymic = "UPDATE Passengers SET Patronymic = @val where Id_Passenger = @id;";
        private const string QUpdatePassport = "UPDATE Passengers SET Passport = @val where Id_Passenger = @id;";
        private const string InsertPassenger = "INSERT INTO Passengers VALUES(@val1,@val2,@val3,@val4);";

        private static List<Passenger> GetPassengersListFromDataReader(SqlDataReader reader)
        {
            List<Passenger> result = new List<Passenger>();
            while (reader.Read())
            {
                Passenger t = new Passenger()
                {
                    Id_Passenger = reader.GetInt32(0),
                    Surname = reader.GetString(1),
                    Name = reader.GetString(2),
                    Patronymic = reader.GetString(3),
                    Passport = reader.GetString(4)
                };
                result.Add(t);
            }
            return result;

        }

        private static Passenger GetPassengerFromDataReader(SqlDataReader reader)
        {
                reader.Read();
                Passenger t = new Passenger()
                {
                    Id_Passenger = reader.GetInt32(0),
                    Surname = reader.GetString(1),
                    Name = reader.GetString(2),
                    Patronymic = reader.GetString(3),
                    Passport = reader.GetString(4)
                };
                return(t);
        }

        public static Passenger GetPassengerById(int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@id", id);
            Passenger result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetPassengerByIdQuery, pars))
                    {
                        result = GetPassengerFromDataReader(reader);
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

        public static List<Passenger> GetAllPassengers()
        {
            List<Passenger> result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllPassengersQuery))
                    {
                        result = GetPassengersListFromDataReader(reader);
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
                    db.ExecuteNonQuery(DeletePassengerById, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                    db.ExecuteNonQuery(InsertPassenger, pars);
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

        public static void UpdatePassport(string val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(QUpdatePassport, pars);
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
