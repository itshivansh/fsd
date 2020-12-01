using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bulding_Api_DAL.Repository;
using Bulding_API_Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Building_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        readonly IBuildingRepo buildingRepo;
        public BuildingController(IBuildingRepo _buildingRepo)
        {
            buildingRepo = _buildingRepo;

        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(buildingRepo.GetBuildings());
        }
        [HttpPost]
        public IActionResult Create([FromBody] Building building)
        {
            buildingRepo.AddBuilding(building);
            return Created("api/Building", 201);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetBuilding(int id)
        {
            return Ok(buildingRepo.GetBuilding(id));
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            buildingRepo.DeleteBuilding(id);
            return Ok();
        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateBuilding(int id,Building b)
        {
            buildingRepo.UpdateBuilding(id,b);
            return Ok();
        }

    }
}
