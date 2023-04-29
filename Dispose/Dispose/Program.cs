using Dispose;
using static System.Net.Mime.MediaTypeNames;

string appPath = "..\\..\\..\\Text";
string filePath = appPath + "\\text.txt";

void createFolder()
{
    if (!Directory.Exists(appPath))
        Directory.CreateDirectory(appPath);
}

void createFile()
{
    if (!File.Exists(filePath))
        File.Create(filePath).Close();
}

string ReadInput(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

#region Manual dispose
void AppentText(string text, string file)
{
    StreamWriter sw = new StreamWriter(file, true);
    if (text == "break")
        throw new Exception("Something broke");
    sw.WriteLine(text);
    sw.Dispose();
}

void ManualExample()
{
    try
    {
        string text1 = ReadInput("Enter text to write");
        AppentText(text1, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
#endregion

#region Dispose using block
void AppendTextSafe(string text, string file)
{
    using (StreamWriter sw = new StreamWriter(file, true))
    {
        if (text == "break")
            throw new Exception("Something broke");
        sw.WriteLine(text);
    }
}

void UsingExample()
{
    try
    {
        string text1 = ReadInput("Enter something");
        AppendTextSafe(text1, filePath);

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
#endregion

#region Custom Dispose
void AppendTextCustom(string text, string file)
{
    using (MyWriter writer = new MyWriter(file))
    {
        writer.Write(text);
    }
}

string ReadAllFileCustom(string file)
{
    using(MyReader reader = new MyReader(file))
    {
        return reader.Read();
    }
}

void CustomExample()
{
    try
    {
        string text1 = ReadInput("Enter Text");
        AppendTextCustom(text1, filePath);
        Console.WriteLine(ReadAllFileCustom(filePath));


    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
#endregion

createFolder();
createFile();
//ManualExample();
//UsingExample();
CustomExample();