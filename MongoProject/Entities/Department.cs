﻿using MongoDB.Bson.Serialization.Attributes;

namespace MongoProject.Entities
{
    public class Department
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string DeptName { get; set; }
    }
}
