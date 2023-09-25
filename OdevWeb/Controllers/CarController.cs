using BuisenessLayer;
using DataAccess;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OdevWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IBuiseneesCode<Car> _buisenees;
        public CarController(IBuiseneesCode<Car> buiseneesCode)
        {
            _buisenees = buiseneesCode;

        }
        [HttpGet("get-all-model")]
        public IActionResult GetModel()
        {
            return Ok(_buisenees.GetModel());

        }
        [HttpPost("insert-model")]
        public IActionResult InsertModel(Car modelmigration)
        {
            return Ok(_buisenees.InsertModel(modelmigration));
        }
        [HttpPut("update-model")]
        public IActionResult UpdateModel(Car modelmigration)
        {
            return Ok(_buisenees.UpdateModel(modelmigration));
        }
        [HttpDelete("delete-model")]
        public IActionResult DeleteModel(int id)
        {
            return Ok(_buisenees.DeleteModel(id));

        }
    }
}
