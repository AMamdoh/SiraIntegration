using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SiraIntegration.Helpers
{
    public static class DapperHelper
    {
        private static string _connectionString;

        public static void SetConnection(string serverIp, string databaseName, string userId, string password)
        {
            _connectionString = $"Server={serverIp};Database={databaseName};Integrated Security=True;";
            

            // _connectionString = $"Server={serverIp};Database={databaseName};User Id={userId};Password={password};";
        }

        public static T Get<T>(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<T>(sql, parameters);
            }
        }

        public static IEnumerable<T> GetList<T>(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<T>(sql, parameters).ToList();
            }
        }

        public static int Add(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Execute(sql, parameters);
            }
        }

        public static int Update(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Execute(sql, parameters);
            }
        }

        public static int Remove(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Execute(sql, parameters);
            }
        }
    }
}