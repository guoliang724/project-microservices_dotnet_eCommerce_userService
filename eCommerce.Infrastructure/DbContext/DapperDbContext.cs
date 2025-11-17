

using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace eCommerce.Infrastructure.DbContext
{
    public class DapperDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;
        public DapperDbContext(IConfiguration iconfiguartion) 
        { 
           _configuration = iconfiguartion;
            string? connectionString = _configuration.GetConnectionString("PostgresConnection");

            _dbConnection =  new NpgsqlConnection(connectionString);
        }

        public IDbConnection DbConnection => _dbConnection;
    }
}
