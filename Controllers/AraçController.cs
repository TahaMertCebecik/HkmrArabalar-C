using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Microsoft.AspNetCore.Mvc;

namespace HkmrArabalar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AraçController : ControllerBase



    {
        private readonly IAraçServis _araçServis;

        public AraçController(IAraçServis araçServis)
        {
            _araçServis = araçServis;
        }

        [HttpPost]
        public IActionResult Add(CreateAraçRequest createAraçRequest)
        {
            CreatedAraçResponse createdAraçResponse = _araçServis.Add(createAraçRequest);
            return Ok(createdAraçResponse);
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_araçServis.GetAll());
        }



    }
}