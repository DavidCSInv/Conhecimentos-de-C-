
string path = @"c:\Temp\file1.txt";

using (FileStream fs = new FileStream (path,FileMode.Open))
{
    using (StreamReader sr = new StreamReader(fs))
    {
        while(!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
    
}