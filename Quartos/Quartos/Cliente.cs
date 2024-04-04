public class Cliente
{
    class program
    {
        static void Main(string[] args)
        {
            Quartos[] Quarto = new Quartos[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Aluguel :");
                
                Console.WriteLine();

                Console.Write("Nome :");
                string estudante = Console.ReadLine();

                Console.Write("Email :");
                string email = Console.ReadLine();

                Console.Write("Quarto :");
                int numero_quarto = Convert.ToInt16(Console.ReadLine());

                Quarto[numero_quarto] = new Quartos(estudante, email);

            }

            for (int i = 0; i < 10; i++)
            {
                if (Quarto[i] != null)
                {
                    Console.WriteLine(i + ":" + Quarto[i]);
                }
            }

        }
    }
}

