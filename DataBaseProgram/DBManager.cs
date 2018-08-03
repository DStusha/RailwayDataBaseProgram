using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DataBaseProgram
{
    class DBManager: IDisposable
    {
        private const string connectionString = @"Data Source = DNS\SQLEXPRESS; Initial Catalog = RailwayDB; Integrated Security = true;";
        private SqlConnection connection = null;

        public DBManager()
        {
            this.connection = new SqlConnection(connectionString);
        }
        
        public void Dispose()
        {
            if (connection.State != ConnectionState.Closed) 
                Close();
            connection.Dispose();
        }

        public void Open()
        {
            if (connection.State == ConnectionState.Open) return;
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Close()
        {
            if (connection.State == ConnectionState.Closed) return;
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ExecuteQuery(String sql, Hashtable pars = null)
        {
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                try
                {
                    if(pars!=null && pars.Count > 0)
                    {
                        foreach(DictionaryEntry entry in pars)
                        {
                            cmd.Parameters.Add(new SqlParameter(entry.Key.ToString(), entry.Value));
                        }
                    }
                    return cmd.ExecuteReader();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void ExecuteNonQuery(String sql, Hashtable pars = null)
        {
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                try
                {
                    if (pars != null && pars.Count > 0)
                    {
                        foreach (DictionaryEntry entry in pars)
                        {
                            cmd.Parameters.Add(new SqlParameter(entry.Key.ToString(), entry.Value));
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}
