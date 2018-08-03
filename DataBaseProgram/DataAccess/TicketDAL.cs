using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections;

namespace DataBaseProgram
{
    public static class TicketDAL
    {
        private const string GetAllTicketsQuery = "select * from Tickets";
        private const string GetAllTicketsQueryByTrip = "select * from Tickets where Id_Trip = @рейс";
        private const string GetTicketsQueryByDsAsPrice = "select * from Tickets where Id_LandingStation = @ds and Id_ExitStation = @as and Price = @price";
        private const string GetTicketsQueryByDs = "select * from Tickets where Id_LandingStation = @ds";
        private const string GetTicketsQueryByDsAs = "select * from Tickets where Id_LandingStation = @ds and Id_ExitStation = @as";
        private const string GetTicketsQueryByPrice = "select * from Tickets where Price = @price";
        private const string GetTicketsQueryByDsPrice = "select * from Tickets where Id_LandingStation = @ds and Price = @price";
        private const string GetTicketsQueryByAs = "select * from Tickets where Id_ExitStation = @as";
        private const string GetTicketsQueryByAsPrice = "select * from Tickets where Id_ExitStation = @as and Price = @price";
        private const string InsertTicket = "INSERT INTO Tickets VALUES(@val1,@val2,@val3,@val4,@val5,@val6,@val7);";
        private const string UpdateTicketTrip = "UPDATE Tickets SET Id_Trip = @val where Id_Ticket = @id;";
        private const string UpdateTicPassenger = "UPDATE Tickets SET Id_Passenger = @val where Id_Ticket = @id;";
        private const string UpdateTicLS = "UPDATE Tickets SET Id_LandingStation = @val where Id_Ticket = @id;";
        private const string UpdateTicES = "UPDATE Tickets SET Id_ExitStation = @val where Id_Ticket = @id;";
        private const string UpdateTicPrice = "UPDATE Tickets SET Price = @val where Id_Ticket = @id;";
        private const string UpdateTicType = "UPDATE Tickets SET Id_CarriageType = @val where Id_Ticket = @id;";
        private const string UpdateTicPlase = "UPDATE Tickets SET PlaseNumber = @val where Id_Ticket = @id;";
        private const string DeleteTicket = "delete from Tickets where Id_Ticket = @id";

        private static List<Ticket> GetTicketsListFromDataReader(SqlDataReader reader)
        {
            List<Ticket> result = new List<Ticket>();
            while (reader.Read())
            {   
                Ticket t = new Ticket()
                {
                    Id_Ticket = reader.GetInt32(0),
                    Passenger = PassengerDAL.GetPassengerById(reader.GetInt32(2)).Surname.Trim(' ') + ' ' + PassengerDAL.GetPassengerById(reader.GetInt32(2)).Name[0] + '.' + PassengerDAL.GetPassengerById(reader.GetInt32(2)).Patronymic[0] + '.',
                    Id_id_Trip = reader.GetInt32(3),
                    LandingStation = StationDAL.GetStationByIntermediateStation(reader.GetInt32(4)).Name,
                    ExitStation = StationDAL.GetStationByIntermediateStation(reader.GetInt32(5)).Name,
                    CarriageType = CarriageTypeDAL.GetCarriageTypeById(reader.GetInt32(6)).Type,
                    PlaseNumber = reader.GetInt32(7),
                    Price = reader.GetInt32(1),
                };
                result.Add(t);
            }
            return result;

        }

        public static List<Ticket> GetAllTickets()
        {
            List<Ticket> result = null;
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllTicketsQuery))
                    {
                        result = GetTicketsListFromDataReader(reader);
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
                    db.ExecuteNonQuery(DeleteTicket, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                    db.ExecuteNonQuery(UpdateTicketTrip, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateType(int val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateTicType, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdatePlaseNumber(int val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateTicPlase, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdatePrice(int val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateTicPrice, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdatePassenger(int val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateTicPassenger, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateLS(int val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateTicLS, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateES(int val, int id)
        {
            Hashtable pars = new Hashtable();
            pars.Add("@val", val);
            pars.Add("@id", id);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.ExecuteNonQuery(UpdateTicES, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Insert(int val1, int val2, int val3, int val4, int val5, int val6, int val7)
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
                    db.ExecuteNonQuery(InsertTicket, pars);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Ticket> GetTicketsByName(int trip)
        {
            List<Ticket> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@рейс", trip);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetAllTicketsQueryByTrip, pars))
                    {
                        result = GetTicketsListFromDataReader(reader);
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

        public static List<Ticket> GetTicketsByDsAsPrice(int ds, int aS, int? price)
        {
            List<Ticket> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@ds", ds);
            pars.Add("@as", aS);
            pars.Add("@price", price);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTicketsQueryByDsAsPrice, pars))
                    {
                        result = GetTicketsListFromDataReader(reader);
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

        public static List<Ticket> GetTicketsByDs(int ds)
        {
            List<Ticket> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@ds", ds);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTicketsQueryByDs, pars))
                    {
                        result = GetTicketsListFromDataReader(reader);
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

        public static List<Ticket> GetTicketsByAs(int aS)
        {
            List<Ticket> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@as", aS);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTicketsQueryByAs, pars))
                    {
                        result = GetTicketsListFromDataReader(reader);
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

        public static List<Ticket> GetTicketsByDsAs(int ds, int aS)
        {
            List<Ticket> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@ds", ds);
            pars.Add("@as", aS);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTicketsQueryByDsAs, pars))
                    {
                        result = GetTicketsListFromDataReader(reader);
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

        public static List<Ticket> GetTicketsByPrice(int? price)
        {
            List<Ticket> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@price", price);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTicketsQueryByPrice, pars))
                    {
                        result = GetTicketsListFromDataReader(reader);
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

        public static List<Ticket> GetTicketsByDsPrice(int ds, int? price)
        {
            List<Ticket> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@ds", ds);
            pars.Add("@price", price);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTicketsQueryByDsPrice, pars))
                    {
                        result = GetTicketsListFromDataReader(reader);
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

        public static List<Ticket> GetTicketsByAsPrice(int aS, int? price)
        {
            List<Ticket> result = null;
            Hashtable pars = new Hashtable();
            pars.Add("@as", aS);
            pars.Add("@price", price);
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    using (SqlDataReader reader = db.ExecuteQuery(GetTicketsQueryByAsPrice, pars))
                    {
                        result = GetTicketsListFromDataReader(reader);
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
