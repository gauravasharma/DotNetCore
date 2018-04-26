using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample2.Models;
using sample2.Services.Interface;

namespace sample2.Controllers
{
    [Route("api/[controller]")]
    public class DataElementController : Controller
    {
        private IDataElementRepository _dataElementRepository;

        public DataElementController(IDataElementRepository dataElementRepository)
        {
            _dataElementRepository=dataElementRepository;
        }

        // GET api/dataelement
        [HttpGet]
        public IActionResult Get()
        {
            try{
                 var data=_dataElementRepository.GetAll().ToList();
                 return new OkObjectResult(data);
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
                return new NoContentResult();
            }
           
            
           // return new string[] { "Element1", "Element2" };`
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
