using MapApi.Models;
using MapApi.Services.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace MapApi.Controllers
{
    [Route("/spiral")]
    [ApiController]

    public class SpiralController : ControllerBase
    {
        private readonly SpiralServices _spiralServices;
        public SpiralController(SpiralServices spiral)
        {
            _spiralServices = spiral;
        }
        [HttpPost()]
        public List<int[]> Matris(int id)
        {
            return _spiralServices.GetLayouts(id).layout;
        }
        [HttpPost("add")]
        public void AddNewLayout(int x, int y)
        {
            _spiralServices.InsertLayout(x, y);
        }
    }
}