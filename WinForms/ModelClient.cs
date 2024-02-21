using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace MondoDBtest
{
    public class ModelClient
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        public int lSHET { get; set; }
        public string adress { get; set; }
        public int PeopleLive { get; set; }
        public decimal Sqmetr { get; set; } //площадь
        public List<ModelService> Services { get; set; }
        public decimal AllDebt
        {
            get
            {
                return Services?.Sum(service => service.Debt) ?? 0;
            }
        }
    }
}
