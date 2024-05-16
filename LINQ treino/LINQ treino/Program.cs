using LINQ_treino.Entities;

static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach (var item in collection) Console.WriteLine(item);
    Console.WriteLine();
}

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 1 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 2 };
Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 3 };

List<Products> products = new List<Products>()
{
    new Products () { Id = 1,Name = "Computer",Price = 1100.0,Category = c2 },
    new Products () { Id = 2,Name = "Hammer",Price = 90.0,Category = c1 },
    new Products () { Id = 3,Name = "TV",Price = 1700.0,Category = c3 },
    new Products () { Id = 4,Name = "Notebook",Price = 1300.0,Category = c2 },
    new Products () { Id = 5,Name = "Saw",Price = 1100.0,Category = c3},
    new Products () { Id = 2,Name = "Driller",Price = 200.0,Category = c1 },
    new Products () { Id = 2,Name = "Maquita",Price = 600.0,Category = c1 }
};

var r1 = products.Where(W => W.Price < 900 && W.Category.Tier == 1);
Print("Tier 1 and Price < 900", r1);

var r2 = products.Where(W => W.Price < 1500 && W.Category.Name == "Tools")// FILTRO
                 .Select(p => p.Name); // SELEÇÃO QUE NEM NO SQL
Print("Names of products from tools", r2);

var r3 = products.Where(W => W.Name[0] == 'C')
                 .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
Print("NAMES WITH THE LETTER C  and Anonymous Function", r3);

var r4 = products.Where(w => w.Category.Tier == 1)
                 .OrderBy(w => w.Price)
                 .ThenBy(w => w.Name);
Print("Tier 1, Ordened by Price then by Names", r4);

//skip take é para paginação skip sendo para pular dados e take para pegar os resultados

var r5 = r4.Skip(2).Take(4);
Print("Tier 1, Ordened by Price then by Names", r5);

var r6 = products.FirstOrDefault();
Console.WriteLine("First or Default test 1 " + r6);

var r7 = products.Where(w => w.Price > 3000.0).FirstOrDefault(); //se não houver nada como first ele ira dar erro
Console.WriteLine("First or Default test 1 " + r7);              // então para não haver erro default é o padrão.
Console.WriteLine();

var r8 = products.Where(w => w.Id == 3).SingleOrDefault(); // se for single e não houver valores irá ocorrer erro
Console.WriteLine("Single or Default" + r8);                // por isso singleordefualt ai irá trazer o nada.
Console.WriteLine();

var r9 = products.Where(w => w.Id == 30).SingleOrDefault();
Console.WriteLine("Single or Default" + r9);

var r10 = products.Max(w => w.Price); //max necessita de uma função para chamada funcionar
Console.WriteLine("Max Price: " + r10);

var r11 = products.Min(w => w.Price); //min necessita de uma função para chamada funcionar
Console.WriteLine("Min Price: " + r11);

var r12 = products.Where(w => w.Category.Tier == 1).Sum(w => w.Price); //
Console.WriteLine("Category 1 Sum Price: " + r12);

var r13 = products.Where(w => w.Category.Tier == 1).Average(w => w.Price); //
Console.WriteLine("Category 1 Sum Price: " + r13);

var r14 = products.Where(w => w.Category.Tier == 5)
                  .Select(w =>w.Price)
                  .DefaultIfEmpty(0.0)
                  .Average(); // Não precisa passar average pois já esta no select
Console.WriteLine("Category 1 Sum Price: " + r14);

var r15 = products.Where(w => w.Category.Id == 1)
                  .Select(w => w.Price)
                  .Aggregate(0.0,(x, y) => x-y); // 0.0 é para indicar um valor inicial para não dar erros  
Console.WriteLine("agregate sum : " + r15);
Console.WriteLine();

var r16 = products.GroupBy(w => w.Category);
foreach (IGrouping<Category,Products> group in r16)
{
    Console.WriteLine("Category " + group.Key.Name + ":");
    
    foreach (var item in group)    
    Console.WriteLine(item);

    Console.WriteLine();
}

Console.WriteLine();