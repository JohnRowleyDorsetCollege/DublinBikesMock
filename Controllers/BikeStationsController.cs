using AutoMapper;
using DublinBikesMock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DublinBikesMock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeStationsController : ControllerBase
    {
        private readonly IMapper _mapper;

        public BikeStationsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<BikeStation> stations = new()
            {


                new BikeStation { number = 1,  contractName="Dublin", name="Stand 1", banking=false},
                new BikeStation { number = 2,  contractName="Dublin", name="Stand 2", banking=false},
                new BikeStation { number = 3,  contractName="Dublin", name="Stand 3", banking=false},
            };

            return Ok(stations.Select(station=>_mapper.Map<BikeStationDto>(station)));

        }
    }
}
