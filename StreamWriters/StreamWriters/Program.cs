
string sourcepath = @"c:\Temp\file1.txt";
string targetpah = @"c:\Temp\file2.txt";

try
{   
    string[] lines = File.ReadAllLines(sourcepath); // abriu o arquivo e leu ele todo

    using (StreamWriter sw = new StreamWriter(targetpah))
    {
        foreach (string line in lines)
        sw.WriteLine(line.ToUpper());
        
    }
}
catch (IOException e)
{
    Console.WriteLine("An error has ocurred");
    Console.WriteLine(e.Message);
}