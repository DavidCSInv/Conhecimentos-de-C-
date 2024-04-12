using Exercicio2Enumarete.Entities;

Comment C1 = new Comment("Have a nice trip");
Comment C2 = new Comment("Wow that's awesome");

Post P1 = new Post(DateTime.Parse("21/06/2018"),"Traveling to New Zeland","I'm going to visit this wonderful country",12);

P1.AddComment(C1);
P1.AddComment(C2);

Comment C3 = new Comment("Good night Guys");
Comment C4 = new Comment("May the force be with you");

Post P2 = new Post(DateTime.Parse("28/07/2018"),"Good Night guys","See you tomorrow",5);

P2.AddComment(C3);
P2.AddComment(C4);

Console.WriteLine(P1);
Console.WriteLine(P2);


