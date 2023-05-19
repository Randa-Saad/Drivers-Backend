


using Transflo.Entity;
using Transflo.Entity.Driver;

namespace Transflo.Repository.Driver
{
    public interface IDriverRepository
    {
        Task<Response> Add(DriverEntity driver);
        Task<Response> Update(DriverEntity driver);
        Task<Response> Remove(int id);
        Task<List<DriverEntity>> Getall();
        Task<DriverEntity> GetById(int id);
    }
}
