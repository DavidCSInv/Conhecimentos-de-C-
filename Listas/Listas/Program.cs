

// se instancia a lista com a classe List se passa o parametros e o seu tipo

List<string> Lista = new List<string>();


//chama-se a variavel primeiro

Lista.Add("Maria"); // este tipo de variavel se coloca no ULTIMO LUGAR DA LISTA
Lista.Add("Ana");
Lista.Add("Banana");
Lista.Add("Banana");
Lista.Add("Banana");
Lista.Add("Que");
Lista.Add("Samuel");

Lista.Insert(1, "David"); // No insert se passa a variavel e na variavel se passa o INDEX (a posição e o valor)


foreach (string list in Lista)
{
    Console.WriteLine(list);
}
Console.WriteLine("Lista Count :" + Lista.Count);

// isso é uma expressão lambda esta referenciando parametro X e a condição de x[] seja igual ao parametro

string s1 = Lista.Find(x => x[0] == 'D');
Console.WriteLine("Primeiro D :" + s1);

string s2 = Lista.FindLast(x => x[0] == 'A');
Console.WriteLine("Ultimo A :" + s2);

int Posicao1 = Lista.FindIndex(x => x[0] == 'D');
Console.WriteLine("O elemento D se encontra na posição : " + Posicao1);

int Posicao2 = Lista.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("O elemento A se encontra na posição : " + Posicao2);

List <string> Lista2 = Lista.FindAll(x => x.Length == 5);

Console.WriteLine("--------------");

foreach (string list in Lista2)
{
    Console.WriteLine("Pessoas com 5 caracteres : " + list);
}

Console.WriteLine();
Lista.RemoveRange(3, 3);
foreach (string removeat in Lista)
{
    Console.WriteLine("Removendo pela posição 2 a 4 : " + removeat);
}


Lista.Remove("Banana");

foreach (string remove in Lista)
{
    Console.WriteLine("Remove simples banana : " + remove);
}

Console.WriteLine();
Lista.RemoveAll(x => x[0] == 'M');

foreach (string removeall in Lista)
{
    Console.WriteLine("Remove ALL : " + removeall);
}

Console.WriteLine();
Lista.RemoveAt(2);
foreach (string removeall in Lista)
{
    Console.WriteLine("Removendo pela posição 2 : " + removeall);
}

Console.WriteLine();



