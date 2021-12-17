using MapApi.Models;
namespace MapApi.Services
{
    interface ISpiralServices
    {
        public MatrisDTO GetLayouts(int x, int y, int layoutId);
        public int GetValueOfLayout(string layoutId,int x,int y);
        public int InsertLayout(int x,int y);
        public List<MatrisDTO> GetLayouts();
    }
}