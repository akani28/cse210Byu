using System.IO;
class Journal
{
    string _fileName;
    public Journal(string fileName)
    {
        _fileName = fileName;
    }
    public void createFile(string line)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(line);
        }
    }
    public void readFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);


        }

    }
    public void file(string fileName, string line)
    {
        string path = fileName;

        File.AppendAllLines(path, new String[] { line });
    }
}

