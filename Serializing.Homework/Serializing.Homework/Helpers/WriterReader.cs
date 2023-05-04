using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializing.Homework.Helpers
{
    public class WriterReader<T>
    {
        private string _fileDirectory;
        private string _file;
        public WriterReader()
        {
            _fileDirectory = @"..\..\..\Db";
            _file = $"{_fileDirectory}\\{typeof(T).Name}sDb.json";

            if (!Directory.Exists(_fileDirectory))
                Directory.CreateDirectory(_fileDirectory);

            if (!File.Exists(_file))
            {
                using (StreamWriter sw = new StreamWriter(_file))
                {
                    sw.Write("[]");
                }
            }
        }

        public void WriteFile(string data)
        {
            using (StreamWriter writer = new StreamWriter(_file))
            {
                writer.Write(data);
            }
        }

        public string ReadFile()
        {
            using (StreamReader reader = new StreamReader(_file))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
