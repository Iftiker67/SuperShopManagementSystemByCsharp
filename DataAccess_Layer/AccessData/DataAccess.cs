using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Presentation_Layer;

namespace DataAccess_Layer.AccessData
{
    class DataAccess:IDisposable
    {
        SqlConnection con;
        SqlCommand cmd;
        public DataAccess()
        {
            con = new SqlConnection(GlobalConfig.GetConnectionString());
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        #region Open Close Connection
        public void OpenConnection()
        {
            this.con.Open();
        }
        public void Dispose()
        {
            this.con.Close();
        }
        #endregion

        #region Trial Basis
        public object ExecuteQueryType(string procedure, params object[] paramterWithValue)
        {
            this.cmd.Parameters.Clear();
            cmd.CommandText = procedure;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int length = (paramterWithValue.Length) / 2;
            for (int i = 0; i < length; i++)
            {
                cmd.Parameters.AddWithValue((string)paramterWithValue[i], (string)paramterWithValue[i + length]);
            }
            this.OpenConnection();
            object str = this.cmd.ExecuteScalar();
            this.Dispose();
            return str;
        }

        #endregion
        public DataTable SqlDataTable(string procedure, params object[] paramterWithValue)
        {
            this.cmd.Parameters.Clear();
            cmd.CommandText = procedure;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int length = (paramterWithValue.Length) / 2;
            for (int i = 0; i < length; i++)
            {
                cmd.Parameters.AddWithValue((string)paramterWithValue[i], (string)paramterWithValue[i + length]);
            }
            this.OpenConnection();
            SqlDataReader result = this.cmd.ExecuteReader();
            DataTable dt = new DataTable();
            if(result.HasRows)
            {
                dt.Load(result);
            }
            this.Dispose();
            return dt;
        }

        public SqlDataReader SqlExecuteReader(string procedure, params object[] paramterWithValue)
        {
            this.cmd.Parameters.Clear(); //to clear all parameters which are added in cmd.
            cmd.CommandText = procedure;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int length = (paramterWithValue.Length) / 2;
            for (int i = 0; i < length; i++)
            {
                cmd.Parameters.AddWithValue((string)paramterWithValue[i], (string)paramterWithValue[i + length]);
            }
            this.OpenConnection();
            SqlDataReader sdr = this.cmd.ExecuteReader();
            return sdr;
        }
        //public int SqlExecuteNonQuery(string procedure,string parameter1, string parameter2,string p1value,string p2value)
        //{
        //    this.cmd.Parameters.Clear(); //to clear all parameters which are added in cmd.
        //    cmd.CommandText = procedure;
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    this.OpenConnection();
        //    int i;
        //    switch (procedure)
        //    {
        //        case "spInsertCategory":
        //            i = SuccessFull(procedure, parameter1, parameter2,p1value,p2value);
        //            this.Dispose();
        //            return i;
        //        case "spSearchUser":
        //            i = SuccessFull(procedure, parameter1, parameter2, p1value, p2value);
        //            this.Dispose();
        //            return i;
        //    }
        //    this.Dispose();
        //    return -1;
           
        //}

        public object SqlExecuteScalar(string procedure, params object[] paramterWithValue)
        {
            this.cmd.Parameters.Clear();
            cmd.CommandText = procedure;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int length = (paramterWithValue.Length) / 2;
            for (int i = 0; i < length; i++)
            {
                cmd.Parameters.AddWithValue((string)paramterWithValue[i], (string)paramterWithValue[i + length]);
            }
            this.OpenConnection();
            object result = this.cmd.ExecuteScalar();
            this.Dispose();
            return result;
        }
        public int SqlExecuteNonQuery(string procedure, params object[] p)
        {
            this.cmd.Parameters.Clear();
            cmd.CommandText = procedure;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int length = (p.Length) / 2;
            for(int i=0; i < length; i++)
            {
                cmd.Parameters.AddWithValue((string)p[i],(string)p[i+length]);
            }
            this.OpenConnection();
            int result = this.cmd.ExecuteNonQuery();
            this.Dispose();
            return result;
            //this.cmd.Parameters.Clear(); //to clear all parameters which are added in cmd.
            //cmd.CommandText = procedure;
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //int i;
            //switch (procedure)
            //{
            //    case "spInsertProduct":
            //        i = SuccessFull(procedure, parameter1, parameter2, p1value, p2value);
            //        return i;
            //    case "spSearchUser":
            //        i = SuccessFull(procedure, parameter1, parameter2, p1value, p2value);
            //        return i;
            //}

            //return -1;

        }

        public string GetId(string procedure, string parameter1, string p1value)
        {
            this.cmd.Parameters.Clear(); //to clear all parameters which are added in cmd.
            cmd.CommandText = procedure;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            string i;
            cmd.Parameters.AddWithValue(parameter1, p1value);
            this.OpenConnection();
            i = this.cmd.ExecuteScalar().ToString();
            if (i !=string.Empty)
            {
                this.Dispose();
                return i;
            }
            else
            {
                this.Dispose();
                return string.Empty;
            }
        }
        //public object SqlExecuteScalar(string procedure, string parameter1, string p1value)
        //{
        //    this.cmd.Parameters.Clear(); //to clear all parameters which are added in cmd.
        //    cmd.CommandText = procedure;
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    object i;
        //    cmd.Parameters.AddWithValue(parameter1, p1value);
        //    this.OpenConnection();
        //    i = this.cmd.ExecuteScalar();
        //    this.Dispose();
        //    return i;
        //    //if (!string.IsNullOrEmpty(i))
        //    //{
        //    //    this.Dispose();
        //    //    return i;
        //    //}
        //    //else
        //    //{
        //    //    this.Dispose();
        //    //    return 0;
        //    //}
        //}

        //public int SqlExecuteScalar(string procedure, string parameter1, string parameter2, string p1value, string p2value)
        //{
        //    this.cmd.Parameters.Clear(); //to clear all parameters which are added in cmd.
        //    cmd.CommandText = procedure;
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    int i;
        //    cmd.Parameters.AddWithValue(parameter1, p1value);
        //    cmd.Parameters.AddWithValue(parameter2, p2value);
        //    this.OpenConnection();
        //    i = Int32.Parse(this.cmd.ExecuteScalar().ToString()); 
        //    if (i > 0)
        //    {
        //        this.Dispose();
        //        return i;
        //    }
        //    else
        //    {
        //        this.Dispose();
        //        return 0;
        //    }
        //}
        private int SuccessFull(string procedure, string parameter1, string parameter2,string p1value,string p2value)
        {
            cmd.Parameters.AddWithValue(parameter1, p1value);
            cmd.Parameters.AddWithValue(parameter2, p2value);
            this.OpenConnection();
            //int i = Int32.Parse(this.cmd.ExecuteScalar().ToString());
            int i = this.cmd.ExecuteNonQuery(); //it will return effected row number by DML operation..
            if (i > 0)
            {
                this.Dispose();
                return i;
            }
            else
            {
                this.Dispose();
                return 0;
            }
        }

        public string SqlExecuteNonQueryWithoutParameter(string procedure,string outparameter,string parameter1,string parameter2,string p1value,string p2value)
        {
            this.cmd.Parameters.Clear();
            cmd.CommandText = procedure;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter outp = new SqlParameter();
            outp.ParameterName = outparameter;
            outp.Direction = ParameterDirection.Output;
            outp.DbType = (DbType)SqlDbType.NVarChar;
            outp.Size = 50;
            cmd.Parameters.Add(outp);
            cmd.Parameters.AddWithValue(parameter1, p1value);
            cmd.Parameters.AddWithValue(parameter2, p2value);
            this.OpenConnection();
            int i = this.cmd.ExecuteNonQuery();
            this.Dispose();
            return outp.Value.ToString();
        }

        #region Trial
        //public int SqlExecuteQuery(string userid, string pass)
        //{
        //    cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "select count(*) from users where userid='" + userid + "' and password='" + pass + "'";
        //    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    //cmd.CommandType = System.Data.CommandType.Text;
        //    this.con.Open();
        //    int i = Int32.Parse(this.cmd.ExecuteScalar().ToString());
        //    if (i > 0)
        //    {
        //        this.Dispose();
        //        return i;
        //    }
        //    else
        //    {
        //        this.Dispose();
        //        return i;
        //    }

        //}
        #endregion

    }
}
