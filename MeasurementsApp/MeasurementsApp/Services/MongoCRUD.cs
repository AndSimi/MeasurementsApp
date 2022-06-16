using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;


namespace MeasurementsApp
{
    public class MongoCRUD
    {
        string databaseName = "Measurements";
        string connectionString = "mongodb://192.168.87.163:27017";
        private IMongoDatabase db;
        string collectionName = "users";


        public MongoCRUD()
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(databaseName);

        }

        public void InsertRecord<T>(T record)
        {
            var collection = db.GetCollection<T>(collectionName);
            collection.InsertOne(record);

        }

        public bool CheckUserName(string username)
        {
            var collection = db.GetCollection<PersonModel>(collectionName);
            var filter = Builders<PersonModel>.Filter.Eq("Username", username);
            var user = collection.Find(filter).First();
            if(user == null)
            {
                return true;
            }
            else return false;

        }
       
        
        
        
        

    









    }
}
