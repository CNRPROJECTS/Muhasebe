﻿using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MuhShared;



namespace MuhApi.DB
{
    public class DbRepo
    {
        private readonly string _conString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;

        public MUser UserLogin(MUserLogin u)
        {
            using (var sqlconn = new SqlConnection(_conString))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("username", u.Username);
                p.Add("password", u.Password);
                if (sqlconn.State == ConnectionState.Closed) sqlconn.Open();
                return sqlconn.QueryFirstOrDefault<MUser>("Accounting.AdminLogin", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}