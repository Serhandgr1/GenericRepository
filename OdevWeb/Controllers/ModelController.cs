using BuisenessLayer;
using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OdevWeb.Migrations;

namespace OdevWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IBuiseneesCode<ModelsModel> _buisenees;
        public ModelController(IBuiseneesCode<ModelsModel> buiseneesCode)
        {
            _buisenees = buiseneesCode;

        }
        [HttpGet("get-all-model")]
        public IActionResult GetModel() 
        {
            return Ok(_buisenees.GetModel());

        }
        [HttpPost("insert-model")]
        public IActionResult InsertModel(ModelsModel modelmigration)
        {
            return Ok(_buisenees.InsertModel(modelmigration));
        }
        [HttpPut("update-model")]
        public IActionResult UpdateModel(ModelsModel modelmigration)
        {
            return Ok(_buisenees.UpdateModel(modelmigration));  
        }
        [HttpDelete("delete-model")]
        public IActionResult DeleteModel(int id)
        {
         return  Ok( _buisenees.DeleteModel(id));

        }
    }
}
