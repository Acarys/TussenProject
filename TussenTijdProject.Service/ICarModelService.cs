using TussentijdsProject.Domain;

namespace TussenTijdProject.Service
{
    public interface ICarModelService
    {
        Task<IEnumerable<CarModel>> GetCarList();
        Task<CarModel> GetCarById(int id);
    }
}
