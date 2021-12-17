using MapApi.Models;
using MapApi.DB;
using MongoDB.Driver;
namespace MapApi.Services.Concreate
{
    public class SpiralServices : ISpiralServices
    {
        private readonly IMongoCollection<MatrisDTO> _matris;
        private MatrisService _MatrisService; 
        private Random rnd = new Random();
        public SpiralServices(IIntegerSpiralDatabaseSettings settings){
             var client =new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _matris=database.GetCollection<MatrisDTO>(settings.CollectionName);
            
        }
        public MatrisDTO GetLayouts(int layoutId)
        {
           return _matris.Find<MatrisDTO>(matris=>matris.tabloId==tabloİd).FirstOrDefault();
        }

        public List<MatrisDTO> GetLayouts()
        {
           return _matris.Find(matris=>true).ToList<MatrisDTO>();
        }

        public int GetValueOfLayout(string layoutId, int x, int y)
        {
            throw new NotImplementedException();
        }

        public int InsertLayout(int x, int y)
        {
            _MatrisService=new MatrisService(x,y);
            MatrisDTO data = new MatrisDTO();
            data.tabloId=rnd.Next(1,100000);
            data.layout=_MatrisService.GetRow();
            data.x=x;
            data.y=y;
            _matris.InsertOne(data);
            return data.tabloId;
        }
    }
}