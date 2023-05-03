using Serialization;
using Serialization.FileSystemHelper;
using Serialization.Models;
using Newtonsoft;
using Newtonsoft.Json;

string folderPath = @"..\..\..\CustomData";
string filePath = folderPath + "\\newtonsoftData.json";

if (!Directory.Exists(folderPath))
    Directory.CreateDirectory(folderPath);


#region CustomSerial
//Student bob = new Student() { FirstName = "Bob", LastName = "Bobski", Age = 25, IsPartTime = false};
//ReaderWriter.WriteFile(filePath, MyJsonSerializer.Serialize(bob));

//string readName = MyJsonSerializer.Deserialize(ReaderWriter.ReadFile(filePath)).FirstName;

//Console.WriteLine(readName);
#endregion

#region Nuget
//Student john = new Student()
//{
//    FirstName = "John",
//    LastName = "Doe",
//    Age = 22,
//    IsPartTime = true,
//};

//string jsonData = JsonConvert.SerializeObject(john);
//ReaderWriter.WriteFile(filePath, jsonData);

//Student readStudent = JsonConvert.DeserializeObject<Student>(ReaderWriter.ReadFile(filePath));
//Console.WriteLine(readStudent.LastName);
#endregion

#region ApiCall
//string jsonData = string.Empty;

//using (HttpClient client = new HttpClient())
//{
//    var response = client.GetAsync("https://jsonplaceholder.typicode.com/users").Result;
//    var content = response.Content.ReadAsStringAsync().Result;
//    jsonData = content;
//}

//List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);
//users.ForEach(x => Console.WriteLine(x.FullName));
#endregion