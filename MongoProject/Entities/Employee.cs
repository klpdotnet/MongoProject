﻿using MongoDB.Bson.Serialization.Attributes;

namespace MongoProject.Entities
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        [BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public decimal Salary { get; set; }
    }
}
