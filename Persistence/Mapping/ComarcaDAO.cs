using Npgsql;

namespace AC4
{
    public class ComarcaDAO : IComarcaDAO
    {
        private readonly string connectionString;
        public ComarcaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void InsertComarca(ComarcaDTO comarca)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "INSERT INTO Comarca (year,code,name,population,domnet,ecoact,total,individualexp) VALUES (@year,@code,@name,@population,@domnet,@ecoact,@total,@individualexp)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@year", comarca.Year);
                command.Parameters.AddWithValue("@code", comarca.Code);
                command.Parameters.AddWithValue("@name", comarca.Name);
                command.Parameters.AddWithValue("@population", comarca.Population);
                command.Parameters.AddWithValue("@domnet", comarca.DomesticExpense);
                command.Parameters.AddWithValue("@ecoact", comarca.EconomicalActivitiesExpense);
                command.Parameters.AddWithValue("@total", comarca.Total);
                command.Parameters.AddWithValue("@individualexp", comarca.IndividualExpense);
                connection.Open();
                command.ExecuteNonQuery();
            }
            MessageBox.Show($"Comarca {comarca.Code} inserted.", "Guardat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public List<ComarcaDTO> GetAllComarques()
        {
            List<ComarcaDTO> comarques = new List<ComarcaDTO>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT * FROM Comarca";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ComarcaDTO comarca = NpgsqlUtils.GetComarca(reader);
                    comarques.Add(comarca);
                }
            }
            return comarques;
        }
    }
}