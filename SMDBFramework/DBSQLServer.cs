using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SMDBFramework
{
    public class DBSQLServer
    {
        // Execute Reader, Execute Scalar, Execute Non Query
        private string _connstring;

        public DBSQLServer(string connstring)
        {
            _connstring = connstring;
        }
        
        // Array, Collection, Generics, DataSet and DataTable
        public DataTable GetDataList(string StoredProceName)
        {
            DataTable dtData = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                }
            }

                return dtData;
        }

        public DataTable GetDataList(string StoredProceName, DBParameter parameter)
        {
            DataTable dtData = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                }
            }

            return dtData;
        }

        public DataTable GetDataList(string StoredProceName, DBParameter[] parameters)
        {
            DataTable dtData = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    foreach(var para in parameters)
                    { 
                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                }
            }

            return dtData;
        }

        //Overloading Function
        public object GetScalarValue(string storedProceName)
        {
            object Value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    Value = cmd.ExecuteScalar();
                }
            }
            return Value;
        }

        public object GetScalarValue(string storedProceName, DBParameter parameter)
        {
            object Value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);

                    Value = cmd.ExecuteScalar();
                }
            }
            return Value;
        }

        public object GetScalarValue(string storedProceName, DBParameter[] parameters)
        {
            object Value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    foreach (var para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }
                    Value = cmd.ExecuteScalar();
                }
            }
            return Value;
        }

        public DataTable Getdata(string storedProceName)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    { 
                        conn.Open();
                        try
                        {
                            da.Fill(dt);
                            return dt;

                        }
                        catch (Exception ex)
                        {
                            //logger.Error(ex);
                            throw ex;
                        }
                    }
                    
                }
            }       
        }

        public void SaveOrUpdateRecord(string storedProceName, Object obj)
        {
            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    //Parameters
                    Type type = obj.GetType();
                    BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] Properties = type.GetProperties(flags);

                    foreach(var property in Properties)
                    {
                        cmd.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj, null));
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
