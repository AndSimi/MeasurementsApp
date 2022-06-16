using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;


namespace MeasurementsApp
{
    //MongoCRUD is used to create a connection to the Mongo DB
    public class MongoCRUD
    {
        string databaseName = "Measurements";
        string connectionString = "mongodb://192.168.87.163:27017";
        private IMongoDatabase db;
        string collectionName = "users";

        //In constructor we create a new MongoClient an pass in the connection string to our database
        //Then we set it to db object and pass in the database name in GetDatabase methhod to get desired database
        public MongoCRUD()
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(databaseName);

        }
        //Insert Record is used to insert and save a new record to the database
        public void InsertRecord<T>(T record)
        {
            var collection = db.GetCollection<T>(collectionName);
            collection.InsertOne(record);

        }
        //CheckUserName method is used in order to check if the username already exist in the database
        //Returns true if the passed in username is available, otherwise returns false
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
