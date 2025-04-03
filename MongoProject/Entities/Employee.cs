using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoProject.Entities
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [BsonRepresentation(BsonType.Double)]
        public decimal Salary { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string DeptId { get; set; }
    }
}
