
namespace MagicTord_N_SondreTheWebAPI.Services
{
    public class ConnectionStringHelper
    {

        public static string getConnectionString()
        {
            string connection = "Server=tcp:mefit.database.windows.net,1433;Initial Catalog=AzureDB;Persist Security Info=False;User ID=mefit;Password=PyddeBurger123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return connection;
        }
    }
}
