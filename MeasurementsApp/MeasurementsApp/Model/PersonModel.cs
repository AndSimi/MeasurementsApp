using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeasurementsApp
{
    //PersonModel is used to create a User object
    public class PersonModel
    {
        //We set the id to BsonId in order to auto generate it in MongoDB
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string Username { get; set; }
        public string Password { get; set; }


    }
}
