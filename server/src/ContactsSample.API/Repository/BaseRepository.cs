using System.Data;

namespace ContactsSample.API.Repository
{
    public class BaseRepository
    {
        internal IDbConnection connection
        {
            get
            {
                // DB Connection factory
                if (this.connection == null || this.connection.State != ConnectionState.Open)
                    return new MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Database=contacts_sample;Uid=usr_contacts_sample;Pwd=BowaQusizu;");
                else
                    return this.connection;
            }
        }

        public BaseRepository()
        {

        }
    }
}