
string sourcepath = @"c:\Temp\file1.txt";
string targetpah = @"c:\Temp\file2.txt";

try
{
    FileInfo fileinfo = new FileInfo(sourcepath);
    fileinfo.CopyTo(targetpah);

    string[] lines = File.ReadAllLines(sourcepath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error has ocurred"); 
    Console.WriteLine(e.Message);
}