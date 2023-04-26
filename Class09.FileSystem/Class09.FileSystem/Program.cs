#region Directory
string currentDirectory = Directory.GetCurrentDirectory();
string appPath = @"..\..\..\";

if (!Directory.Exists($"{appPath}\\Demo1"))
{
    Directory.CreateDirectory($"{appPath}\\Demo1");
}
else
{
    Console.WriteLine("Folder exists");
}

//Directory.Delete($"{appPath}\\Demo1");

bool isFolderExistsOnAbsolutePath = Directory.Exists("C:\\Users\\janku\\Desktop\\ACADEMY\\cs-advanced\\Class09.FileSystem\\Class09.FileSystem\\Demo1");
if (!isFolderExistsOnAbsolutePath)
{
    Directory.CreateDirectory("C:\\Users\\janku\\Desktop\\ACADEMY\\cs-advanced\\Class09.FileSystem\\Class09.FileSystem\\Demo1");
}
else
{
    Console.WriteLine("Folder on absolute path exists");
}

Console.WriteLine(currentDirectory);
#endregion

#region Files

string folderPath = Path.Combine(appPath, @"Demo1\");
string filePath = Path.Combine(folderPath, "Test.txt");

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
    Console.WriteLine("A file was created");
}
else
{
    Console.WriteLine("File exists");
}

if (File.Exists(filePath))
{
    File.WriteAllText(filePath, "Hello SEDC! this is a test file\n");
    File.AppendAllLines(filePath, new List<string> { "This is another line" });
}

Console.WriteLine("=============================");
string fileContent = File.ReadAllText(filePath);
Console.WriteLine(fileContent);

//File.Delete(filePath);
//File.Move(filePath, $"{appPath}\\Test.txt");

#endregion