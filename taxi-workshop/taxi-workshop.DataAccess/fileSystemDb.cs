using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxi_workshop.DomainModels.Models;
using Newtonsoft;
using Newtonsoft.Json;

namespace taxi_workshop.DataAccess
{
    public class fileSystemDb<T> : IDb<T> where T : BaseEntity
    {
        private string _directoryPath;
        private string _file;
        private int IdCount;
        public fileSystemDb()
        {
            _directoryPath = "..\\..\\..\\db";
            _file = $"{_directoryPath}\\{typeof(T).Name}sDb.json";

            if(!Directory.Exists(_directoryPath))
                Directory.CreateDirectory(_directoryPath);

            if (!File.Exists(_file))
            {
                IdCount = 1;
                using (StreamWriter sw = new StreamWriter(_file))
                {
                    sw.Write("[]");
                }
            }
            else
            {
                using (StreamReader sr = new StreamReader(_file))
                {
                    List<T> list = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
                    IdCount = list.LastOrDefault().Id + 1;
                }
            }
        }
        public void DeleteById(int id)
        {
            List<T> list;
            using (StreamReader sr = new StreamReader(_file))
            {
                list = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
            T itemToRemove = list.FirstOrDefault(x => x.Id == id);
            list.Remove(itemToRemove);
            using (StreamWriter sw = new StreamWriter(_file))
            {
                sw.Write(JsonConvert.SerializeObject(list));
            }
        }

        public List<T> GetAll()
        {
            using(StreamReader sr = new StreamReader(_file))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
        }

        public T GetById(int id)
        {
            List<T> list;
            using (StreamReader sr = new StreamReader(_file))
            {
                list = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
            return list.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(T item)
        {
            item.Id = IdCount++;
            List<T> list;
            using(StreamReader sr = new StreamReader(_file))
            {
                list = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
            list.Add(item);

            using(StreamWriter sw = new StreamWriter(_file))
            {
                sw.Write(JsonConvert.SerializeObject(list));
            }

            return item.Id;
        }

        public void Update(T item)
        {
            List<T> list;
            using (StreamReader sr = new StreamReader(_file))
            {
                list = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
            T itemToEdit = list.FirstOrDefault(x => x.Id == item.Id);
            itemToEdit = item;
            using (StreamWriter sw = new StreamWriter(_file))
            {
                sw.Write(JsonConvert.SerializeObject(list));
            }
        }
    }
}
