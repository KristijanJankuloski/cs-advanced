string appPath = @"..\..\..\";
string folderPath = appPath + @"MyFolder\";
string filePath = folderPath + "MyFile.txt";

if(!Directory.Exists(folderPath))
    Directory.CreateDirectory(folderPath);
else
    Console.WriteLine("Directory exists");

using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine("This is the start of the file");
    sw.WriteLine("This is a new line");
}

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    sw.WriteLine("Working on it");
}

using (StreamReader sr = new StreamReader(filePath))
{
    string text = sr.ReadToEnd();
    Console.WriteLine(text);
}