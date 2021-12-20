using MapApi.Models;
using MapApi.Services.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
namespace MapApi.Controllers
{
    [Route("/spiral")]
    [ApiController]
[Produces("application/json")]
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
            try{
            return _spiralServices.GetLayouts(tabloId).layout;
            }
            catch(Exception e){
                throw e;
            }
        }
        [HttpGet("add")]
        public void AddNewLayout(int MatrisX, int MatrisY)
        {
            Console.WriteLine("x:{0} ve y:{1} controllerdan",MatrisX,MatrisY);
            _spiralServices.InsertLayout(MatrisX, MatrisY);
        }
        [HttpGet("GetAll")]
        public List<MatrisDTO> GetAll(){
           return _spiralServices.GetLayouts();
        }
         [HttpGet("DeleteAll")]
        public void deleteAll(){
           _spiralServices.deleteData();
        }
    }
}