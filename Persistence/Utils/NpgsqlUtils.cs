using Microsoft.Extensions.Configuration;
using Npgsql;

namespace AC4
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            return config.GetConnectionString("MyPostgresConn");
        }
        public static ComarcaDTO GetComarca(NpgsqlDataReader reader)
        {
            ComarcaDTO c = new ComarcaDTO
            {
                Year = reader.GetInt32(1),
                Code = reader.GetInt32(2),
                Name = reader.GetString(3),
                Population = reader.GetInt32(4),
                DomesticExpense = reader.GetInt32(5),
                EconomicalActivitiesExpense = reader.GetInt32(6),
                Total = reader.GetInt32(7),
                IndividualExpense = reader.GetDecimal(8),
            };
            return c;
        }
    }
}