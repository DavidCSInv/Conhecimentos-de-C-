using System;
using System.Collections.Generic;
using System.IO;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,int> set = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = Convert.ToInt32(line[1]);

                        if (!set.ContainsKey(name))
                        {
                            set[name] = votes;
                        }
                        else
                        {
                            set[name] += votes;
                        }
                    }
                    foreach (var entry in set)
                    {
                        Console.WriteLine(entry.Key + ": " + entry.Value);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}