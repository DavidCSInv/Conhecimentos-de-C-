using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using Xadrez.tabuleiro;
using Xadrez;
using Xadrez.Xadrez;
namespace tabuleiro
{
    class Tela
    {
        public static void  imprimirPartida(PartidaDeXadrez Partida)
        {
            ImprimirTabuleiro(Partida.tab);

            Console.WriteLine();
            
            ImprimirPecasCapturadas(Partida);
            Console.WriteLine();
            Console.WriteLine("Turno da Partida : " + Partida.Turno);
            Console.WriteLine("Aguardando a jogada : " + Partida.jogadorAtual);
            Console.WriteLine();
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas");
            Console.Write("Brancas :");
            ImprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();

            Console.Write("Azul :");
            ConsoleColor Aux= Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            ImprimirConjunto(partida.pecasCapturadas(Cor.Azul));
            Console.ForegroundColor= Aux;
            Console.WriteLine();
        }

        public static void ImprimirConjunto (HashSet<Peca> conjunto)
        {
            Console.Write(" [");
            foreach (Peca peca in conjunto)
            {
                Console.WriteLine( peca + " ");
            }
            Console.Write("] ");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linha; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.Colunas; j++)
                {
                    ImprimirPeca(tab.peca(i,j));
                }

             Console.WriteLine();
            }
             Console.WriteLine("   a  b  c  d  e  f  g  h");
        }






        public static void ImprimirTabuleiro(Tabuleiro tab,bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            
            ConsoleColor fundoAlterado = ConsoleColor.DarkRed;

            for (int i = 0; i < tab.Linha; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.Colunas; j++)
                {

                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor= fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                        ImprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }

                Console.WriteLine();
            }
            Console.WriteLine("   a  b  c  d  e  f  g  h");

        }

        public static PosicaoXadrez LerPosicaoXadrez ()
        {
            string s = Console.ReadLine ();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            return new PosicaoXadrez(coluna,linha);
        }

        public static void ImprimirPeca (Peca peca)
        {
            if (peca == null)
            {
                Console.Write(" - ");
            }

            else
            {
                if (peca.Cor == Cor.Branca)

                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor Cor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(peca);
                    Console.ForegroundColor = Cor;
                }
                Console.Write(" ");
            }
        }
    }
}
