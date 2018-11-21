using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stations;
using Stations.Services;

namespace Stations.Controllers
{
    public class StationsController : Controller
    {
        private readonly StationsContext _context;
        private readonly IStationsService service;

        public StationsController(IStationsService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("api/stations")]
        public IActionResult Index()
        //public IActionResult<IEnumerable<Station>> Index()
        {
            var stations = service.GetStations();
            return Ok(stations.ToList());
        }
    }
}
        
     