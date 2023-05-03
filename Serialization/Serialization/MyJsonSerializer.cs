using Serialization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public static class MyJsonSerializer
    {
        public static string Serialize(Student student)
        {
            string json = "{";
            json += $"\"FirstName\":\"{student.FirstName}\",";
            json += $"\"LastName\":\"{student.LastName}\",";
            json += $"\"Age\":{student.Age},";
            json += $"\"IsPartTime\":{student.IsPartTime}";
            json += "}";

            return json;
        }

        public static Student Deserialize(string json)
        {
            string content = json
                .Substring(json.IndexOf("{")+1, json.IndexOf("}")-1)
                .Replace("\r", "").Replace("\n", "")
                .Replace("\"", "");
            string[] properties = content.Split(',');
            Dictionary<string, string> props = new Dictionary<string, string>();
            foreach(var property in properties)
            {
                string[] pair = property.Split(':');
                props.Add(pair[0].Trim(), pair[1].Trim());
            }
            return new Student() { FirstName = props["FirstName"], LastName = props["LastName"], Age = int.Parse(props["Age"]), IsPartTime = bool.Parse(props["IsPartTime"]) };
        }
    }
}
