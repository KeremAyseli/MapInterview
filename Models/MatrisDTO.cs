using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
namespace MapApi.Models{
    public class MatrisDTO{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
     public string Id;
     [BsonElement("x")]
     public int x;
     [BsonElement("y")]
     public int y;
     
     [BsonElement("layout")]
     public List<Npoint[]>layout;
    }
}