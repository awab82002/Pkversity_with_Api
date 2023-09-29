using ClassLibraryDAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
       
       private readonly ICityController _cityController;
        public CityController(ICityController cityController)
        {
            _cityController = cityController;
        }
        
        [HttpGet]
        [Route("GetCities")]
        public IActionResult GetCities()
        {
            var cities = _cityController.GetCities();
            return Ok(cities);
        }
    }
}
