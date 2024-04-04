

namespace Exercicio_de_Classe_3
{
    public class Calcula_nota
    {
        static void Main(string[] args)
        {
            nota aluno = new nota();

            Console.Write("Nome do Aluno : ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno :");
            aluno.prova1 = Convert.ToDouble(Console.ReadLine());
            aluno.prova2 = Convert.ToDouble(Console.ReadLine());
            aluno.prova3 = Convert.ToDouble(Console.ReadLine());

            if (aluno.soma() > 60)
            {
                Console.WriteLine("Nota Final = " + aluno.soma().ToString("F2"));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("Nota Final = " + aluno.soma().ToString("F2"));
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + aluno.reprova().ToString("F2") + " Pontos");
            }


        }
    }
}
