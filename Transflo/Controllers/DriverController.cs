using Microsoft.AspNetCore.Mvc;
using Transflo.Entity;
using Transflo.Entity.Driver;
using Transflo.Repository.Driver;

namespace Transflo.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverRepository _Driver;
        public DriverController(IDriverRepository Driver)
        {
            _Driver = Driver ?? throw new ArgumentNullException(nameof(Driver));
        }
       
        [HttpPost]
        public async Task<Response> Add([FromBody] DriverEntity driver)
        {
            try
            {
                return await _Driver.Add(driver);
            }
            catch (Exception ex)
            {
                return new Response() { Result = "fail", KeyValue = ex.Message };
            }
           
        }

        [HttpPut]
        public async Task<Response> Update([FromBody] DriverEntity driver)
        {
            try
            {
                return await _Driver.Update(driver);
            }
            catch(Exception ex) 
            {
                return new Response() { Result = "fail", KeyValue = ex.Message };
            }
           
        }

        [HttpDelete]
        public async Task<Response> Remove(int id)
        {
            try
            {
                return await _Driver.Remove(id);
            }
            catch(Exception ex) 
            {
                return new Response() { Result = "fail", KeyValue = ex.Message };
            }
        }


        [HttpGet("GetAll")]
        public async Task<List<DriverEntity>> GetAll()
        {
            try
            {
                var driverslist = await _Driver.Getall();
                if (driverslist != null && driverslist.Count > 0)
                {
                    return driverslist;
                }
                else
                {
                    return new List<DriverEntity>();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpGet("GetById")]
        public async Task<DriverEntity> GetById(int id)
        {
            try
            {
                return await _Driver.GetById(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
