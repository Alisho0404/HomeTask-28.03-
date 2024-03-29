using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Infrastrcture.DataContext
{
    public class DapperContext
    { 
        private readonly string _connectionString=
          "Host=localhost;Port=5432;Database=CT28.03;User Id=postgres;Password=909662643;"; 
        public NpgsqlConnection Connection()
        {
            return new NpgsqlConnection(_connectionString);
        }

    }
}
