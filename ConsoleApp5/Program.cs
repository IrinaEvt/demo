using System.IO;


Console.WriteLine("Please, give the path to the file.");

String path = @"C:\Users\irrae\Downloads\CustommerData.csv";

try
{
    using(StreamReader reader = new StreamReader(path))
    {
        var line = reader.ReadLine();
        while(line != null)
        {
            Console.WriteLine(line);
            line = reader.ReadLine();
        }
    }
}
catch (Exception ex)
{
     Console.WriteLine(ex.Message);
}
