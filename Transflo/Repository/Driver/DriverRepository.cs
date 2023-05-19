using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Transflo.Data;
using Transflo.Entity;
using Transflo.Entity.Driver;
using Transflo.Models;

namespace Transflo.Repository.Driver
{
    public class DriverRepository : IDriverRepository
    {
        private readonly ApplicationDbContext _appDBContext;
        private readonly IMapper mapper;
        public DriverRepository(ApplicationDbContext context, IMapper mapper)
        {
            _appDBContext = context ?? throw new ArgumentNullException(nameof(context));
            this.mapper = mapper;
        }

        public async Task<Response> Add(DriverEntity driver)
        {
            try
            {
                string Result = string.Empty;

                if (driver != null)
                {
                    using (var dbtransaction = await this._appDBContext.Database.BeginTransactionAsync())
                    {   
                        //create instance of driver
                        var _newDriver = new TblDriver()
                        {
                             FirstName = driver.FirstName,
                             LastName = driver.LastName,
                             Email = driver.Email,
                             PhoneNumber = driver.PhoneNumber
                        };
                        await this._appDBContext.Drivers.AddAsync(_newDriver);
                        await this._appDBContext.SaveChangesAsync();
                        await dbtransaction.CommitAsync();
                        return new Response() { Result = "added", KeyValue = driver.FirstName };
                    }
                }
                else
                {
                    return new Response() { Result = "fail", KeyValue = string.Empty };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Response> Update(DriverEntity driver)
        {
            try
            {
                string Result = string.Empty;

                if (driver != null)
                {
                    using (var dbtransaction = await this._appDBContext.Database.BeginTransactionAsync())
                    {
                        // check if driver exists
                        var _Driver = await this._appDBContext.Drivers.FirstOrDefaultAsync(item => item.Id == driver.Id);
                        if (_Driver != null)
                        {
                            _Driver.FirstName = driver.FirstName;
                            _Driver.LastName = driver.LastName;
                            _Driver.Email = driver.Email;
                            _Driver.PhoneNumber = driver.PhoneNumber;
                            await this._appDBContext.SaveChangesAsync();
                            await dbtransaction.CommitAsync();
                            return new Response() { Result = "updated", KeyValue = driver.FirstName };
                        }
                        else
                        {
                            return new Response() { Result = "fail", KeyValue = "Driver Not Exist" };
                        }
                    }
                }
                else
                {
                    return new Response() { Result = "fail", KeyValue = string.Empty };
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Response> Remove(int id)
        {
            try
            {
                using (var dbtransaction = await this._appDBContext.Database.BeginTransactionAsync())
                {
                    var _data = await this._appDBContext.Drivers.FirstOrDefaultAsync(item => item.Id == id);
                    if (_data != null)
                    {
                        this._appDBContext.Drivers.Remove(_data);
                    }
                    await this._appDBContext.SaveChangesAsync();
                    await dbtransaction.CommitAsync();

                }
                return new Response() { Result = "removed", KeyValue = string.Empty };
            }
            catch (Exception ex)
            {
                return new Response() { Result = "fail", KeyValue = string.Empty };
            }
        }

        public async Task<List<DriverEntity>> Getall()
        {
            try
            {
                var data = await this._appDBContext.Drivers.ToListAsync();
                if (data != null && data.Count > 0)
                {
                    return this.mapper.Map<List<TblDriver>, List<DriverEntity>>(data);
                }
                else
                {
                    return new List<DriverEntity>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<DriverEntity> GetById(int id)
        {
            try
            {
                var data = await this._appDBContext.Drivers.FirstOrDefaultAsync(item => item.Id == id);

                if (data != null)
                {
                    return this.mapper.Map<TblDriver, DriverEntity>(data);
                }
                else
                {
                    throw new Exception("Driver Not Exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }





    }
}
