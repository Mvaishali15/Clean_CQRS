using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace StudentAPI.Infrastructure.DbContext
{
    public class DapperContext
    {
        //private readonly string _connectionString;
        //public DapperContext(IConfiguration configuration)
        //{
        //    _connectionString = configuration.GetConnectionString("StuDBconnection");
        //}

        //public IDbConnection CreateConnection()
        //{
        //    return new SqlConnection(_connectionString);
        //}

        private readonly DapperSettings _dapperSettings;
        public DapperContext(IOptions<DapperSettings> DapperSettings)
        {
            _dapperSettings = DapperSettings.Value;
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_dapperSettings.SqlServer);

        //public bool IsConnectionEstablished()
        //{
        //    try
        //    {
        //        using (var connection = new SqlConnection(_dapperSettings.SqlServer))
        //        {
        //            connection.Open();
        //            return true; 
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false; 
        //    }
        //}
    }
}
