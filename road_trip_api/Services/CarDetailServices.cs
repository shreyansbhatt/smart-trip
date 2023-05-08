using road_trip_api.Models;
using road_trip_api.Repositories;

namespace road_trip_api.Services
{
    public interface ICarDetailServices 
    {
        IEnumerable<CarManufacturers> GetCarManufacturers();
    }
    public class CarDetailServices : ICarDetailServices
    {
        private readonly ICarDetailRepository _carDetailRepo;

        public CarDetailServices(ICarDetailRepository carDetailRepo)
        {
            _carDetailRepo = carDetailRepo;
        }
        public IEnumerable<CarManufacturers> GetCarManufacturers()
        {
            return _carDetailRepo.GetCarManufacturers();
        }
    }
}
