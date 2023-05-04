using Newtonsoft.Json;
using Serializing.Homework.Helpers;
using Serializing.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializing.Homework.Services
{
    public static class DogService
    {
        private static WriterReader<Dog> _dogDb;

        static DogService()
        {
            _dogDb = new WriterReader<Dog>();
        }
        public static List<Dog> GetDogs()
        {
            List<Dog> _db = JsonConvert.DeserializeObject<List<Dog>>(_dogDb.ReadFile());
            if (_db == null)
                throw new Exception("Someting went worng");
            return _db;
        }
        public static void SaveDog(Dog newDog) {
            List<Dog> _db = JsonConvert.DeserializeObject<List<Dog>>(_dogDb.ReadFile());
            _db.Add(newDog);
            _dogDb.WriteFile(JsonConvert.SerializeObject(_db));
        }
    }
}
