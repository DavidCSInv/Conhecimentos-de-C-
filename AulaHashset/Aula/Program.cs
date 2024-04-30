HashSet<int> AlunosA = new HashSet<int>();
HashSet<int> AlunosB = new HashSet<int>();
HashSet<int> AlunosC = new HashSet<int>();
HashSet<int> Total = new HashSet<int>();

Console.WriteLine("How many students for course A?");
int x= Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < x; i++)
{
    int aluA = Convert.ToInt16(Console.ReadLine());
    AlunosA.Add(aluA);

foreach (int a in AlunosA)
    {
        Total.Add(a);
    }
}

Console.WriteLine("How many students for course C?");
int Y = Convert.ToInt16(Console.ReadLine());

for (int i = 0;i < Y; i++)
{
    int aluB = Convert.ToInt16(Console.ReadLine());
    AlunosB.Add(aluB);

    foreach (int a in AlunosB)
    {
        Total.Add(a);
    }
}

Console.WriteLine("How many students for course A?");
int Z = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < Z; i++)
{
    int aluC = Convert.ToInt16(Console.ReadLine());
    AlunosC.Add(aluC);

    foreach (int a in AlunosC)
    {
        Total.Add(a);
    }
}


/*
            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);*/

Console.WriteLine(Total.Count);