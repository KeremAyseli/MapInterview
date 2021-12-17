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
        [HttpGet("GetTable")]
        public List<int[]> Matris(int tabloId)
        {
            Console.WriteLine("service"+tabloId);
            return _spiralServices.GetLayouts(tabloId).layout;
        }
        [HttpPost("add")]
        public void AddNewLayout(int x, int y)
        {
            _spiralServices.InsertLayout(x, y);
        }
    }
}