Console.WriteLine("CALCULAR");
static void repete()
{
    try
    {


        char denovo = 's';

        do
        {
            double soma_a, soma_b, soma_tot;
            char fator;

            string[] vet = Console.ReadLine().Split(' ');
            soma_a = Convert.ToDouble(vet[0]);
            fator = Convert.ToChar(vet[1]);
            soma_b = Convert.ToDouble(vet[2]);

            soma_tot = calcula(soma_a, fator, soma_b);

            Console.WriteLine($"{soma_a} {fator} {soma_b} = {soma_tot}");
            Console.WriteLine("Calcula de novo ?  sim - s   não - n ");

            denovo = Convert.ToChar(Console.ReadLine());

            if (denovo == 's' && denovo != 'n')
            {
                calcula(soma_a, fator, soma_b);
            }



            while (denovo != 's' && denovo != 'n')
            {
                Console.WriteLine("Calcula de novo ?  sim - s   não - n ");
                denovo = Convert.ToChar(Console.ReadLine());
            }

        } while (denovo == 's');



    }

    catch (Exception exception)
    {
        Console.WriteLine($"Valor invalido.{exception.Message}");
    }
}





double calcula (double soma_a,char fator,double soma_b)
{
  
    double soma_tot = 0;

    switch (fator)
    {
        case '+':
            soma_tot = soma_a + soma_b;
            break;
        case '-':
            soma_tot = soma_a - soma_b;
            break;
        case '*':
        case 'x': 
            soma_tot = soma_a * soma_b;
            break;
        case '/':
            soma_tot = soma_a / soma_b;
            break;
        default:
            Console.WriteLine("Operador inválido. Digite novamente.");
            break;
    }

    while (fator != '+' && fator != '-' && fator != '*' && fator != '/' && fator != 'x')
    {
        Console.WriteLine("Não valido digite novamente");

        string[] vet = Console.ReadLine().Split(' ');
        vet = Console.ReadLine().Split(' ');
        soma_a = Convert.ToDouble(vet[0]);
        fator = Convert.ToChar(vet[1]);
        soma_b = Convert.ToDouble(vet[2]);
    }
    return soma_tot;
}