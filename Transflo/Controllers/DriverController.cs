using Microsoft.AspNetCore.Mvc;
using Transflo.DAL;
using Transflo.Models;

namespace Transflo.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly Driver_DAL _dal;
        public DriverController(Driver_DAL dal)
        {
            _dal = dal;
        }
       
        [HttpPost]
        public async Task<Response> Add([FromBody] Driver driver)
        {
            try
            {
                return await _dal.Add(driver);
            }
            catch (Exception ex)
            {
                return new Response() { Result = "fail", KeyValue = ex.Message };
            }
           
        }

        [HttpPost("AddBulk")]
        public async Task<List<Response>> AddBulk([FromBody] Driver[] drivers)
        {
            try
            {
                List<Response> Responses = new List<Response>();
                for (int d = 0; d <= drivers.Length; d++)
                {
                    Responses.Add(await _dal.Add(drivers[d]));
                }

                return Responses;
            }
            catch (Exception ex)
            {
                return new List<Response>() {new Response() { Result = "fail", KeyValue = ex.Message } };
            }

        }

        [HttpPut]
        public async Task<Response> Update([FromBody] Driver driver)
        {
            try
            {
                Driver _driver = await _dal.GetById(driver.Id);
                if(_driver == null)
                {
                    return new Response() { Result = "fail", KeyValue = "Driver Not Exist" };
                }
                else
                {
                    return await _dal.Update(driver);
                }
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
                return await _dal.Remove(id);
            }
            catch(Exception ex) 
            {
                return new Response() { Result = "fail", KeyValue = ex.Message };
            }
        }


        [HttpGet("GetAll")]
        public async Task<List<Driver>> GetAll()
        {
            List<Driver> drivers = new List<Driver>();
            try
            {
                drivers = _dal.GetAll();
                if (drivers != null && drivers.Count > 0)
                {
                    return drivers;
                }
                else
                {
                    return new List<Driver>();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpGet("GetById")]
        public async Task<Driver> GetById(int id)
        {
            try
            {
                var data = await _dal.GetById(id);
                if (data.Id == 0)
                {
                    throw new Exception("Driver Not Exist");
                }
                else
                {
                    return data;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
