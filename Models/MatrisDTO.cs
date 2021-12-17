using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
namespace MapApi.Models{
    public class MatrisDTO{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
     public string Id;
     [BsonElement("TabloId")]
     public int tabloId;
     [BsonElement("x")]
     public int x;
     [BsonElement("y")]
     public int y;
     
     [BsonElement("layout")]
     public List<int[]>layout;
    }
}