namespace road_trip_api.Configuration
{
    public interface IConnectionManager
    {
        public string GetMainDBConnectionString(string DatabaseName);
    }

    public class ConnectionManager : IConnectionManager
    {
        private readonly IConfiguration _configuration;
        public ConnectionManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMainDBConnectionString(string DatabaseName)
        {
            return _configuration.GetConnectionString(DatabaseName);
        }
    }
}
