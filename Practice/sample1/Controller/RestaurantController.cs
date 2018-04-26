using sample1.Model;
using sample1.Service.Interface;
using sample1.Service.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace sample1.Controller
{

 [Route("api/restaurant")]
  public class RestaurantController
  {
        private IRestaurantRepository _restaunrantRepository;
        public RestaurantController(IRestaurantRepository restaunrantRepository)
        {
            _restaunrantRepository=restaunrantRepository;
        }
        
        [HttpGet]
        [Route("get/{id?}")]
        public IActionResult Get(int? id)
        {
          var data=_restaunrantRepository.GetAll(id);
          return new OkObjectResult(data);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateOrUpdate([FromBody]Restaurant restaurant)
        { 
           return new OkResult();
        }

  }
}