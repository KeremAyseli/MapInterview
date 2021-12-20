using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
namespace MapApi.Models{
    public class MatrisDTO{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
     public string Id{get;set;}
     [BsonElement("TabloId")]
     public int tabloId{get;set;}
     [BsonElement("x")]
     public int x{get;set;}
     [BsonElement("y")]
     public int y{get;set;}
     
     [BsonElement("layout")]
     public List<int[]>layout{get;set;}
    }
}