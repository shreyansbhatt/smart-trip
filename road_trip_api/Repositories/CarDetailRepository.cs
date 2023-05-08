using Dapper;
using road_trip_api.Configuration;
using road_trip_api.Models;
using System.Data.SqlClient;

namespace road_trip_api.Repositories
{
    public interface ICarDetailRepository
    {
        IEnumerable<CarManufacturers> GetCarManufacturers();
    }
    public class CarDetailRepository: ICarDetailRepository
    {
        private readonly IConnectionManager _connectionManager;
        private readonly string _connectionString;

        public CarDetailRepository(IConnectionManager connectionManager) 
        {
            _connectionManager = connectionManager;
            _connectionString = _connectionManager.GetMainDBConnectionString("SmartTrip");
        }
        public IEnumerable<CarManufacturers> GetCarManufacturers()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var query = "SELECT Id,Name,Description FROM CarManufacturers where IsDeleted = 0";
            var carManufacturers = connection.Query<CarManufacturers>(query);
            return carManufacturers;
        }
    }
}
