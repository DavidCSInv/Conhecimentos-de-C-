using tabuleiro;
using Xadrez.tabuleiro;
using Xadrez.Xadrez;
using tabuleiro;

try
{
    PartidaDeXadrez Partida = new PartidaDeXadrez();

    Tela.ImprimirTabuleiro(Partida.tab);

    while (!Partida.Terminada)
    {
        try
        {
            Console.Clear();
            
            Tela.imprimirPartida(Partida);

            Console.Write("Origem : ");
            Posicao Origem = Tela.LerPosicaoXadrez().toPosicao();

            Partida.validarPosicaodeOrigem(Origem);

            bool[,] posicoesPossivel = Partida.tab.peca(Origem).movimentoPossivel();


            Console.Clear();
            Tela.ImprimirTabuleiro(Partida.tab, posicoesPossivel);

            Console.Write("Destino: ");
            Posicao Destino = Tela.LerPosicaoXadrez().toPosicao();
            Partida.validarPosicaoDestino (Origem,Destino);

            Partida.realizaJogada(Origem, Destino);

        }
        catch (TabuleiroException TabEx)
        {
            Console.WriteLine (TabEx.Message);
            Console.ReadLine();
        }
    }

}
catch (TabuleiroException ex)
{
    Console.WriteLine(ex.Message);
}