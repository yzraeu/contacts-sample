using System.Data;

namespace ContactsSample.API.Repository
{
    public class BaseRepository
    {
        private IDbConnection connection;

        public BaseRepository()
        {

        }

        internal IDbConnection ConnectionFactory()
        {
            if (this.connection == null || this.connection.State != ConnectionState.Open)
                return new MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Database=contacts_sample;Uid=usr_contacts_sample;Pwd=BowaQusizu;");
            else
                return this.connection;
        }
    }
}