using System.Data;

namespace ContactsSample.API.Repository
{
    public class BaseRepository
    {
        private IDbConnection connection;

        internal string selectLastIdSQL = "select CAST(LAST_INSERT_ID() AS UNSIGNED INTEGER);";

        public BaseRepository()
        {

        }

        internal IDbConnection ConnectionFactory()
        {
            if (this.connection == null || this.connection.State != ConnectionState.Open)
                this.connection = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Database=contacts_sample;Uid=usr_contacts_sample;Pwd=BowaQusizu;");

            return this.connection;
        }
    }
}