using tabuleiro;
using Xadrez.tabuleiro;

namespace Xadrez.Xadrez
{
    class Rei : Peca
    {
        public Rei (Tabuleiro tabuleiro,Cor cor) : base (tabuleiro, cor) { 
        }
        public override string ToString()
        {
            return " R";
        }

        private bool podeMover (Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
        }
        public override bool[,] movimentoPossivel()
        {
            bool[,] mat = new bool[Tab.Linha, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            // acima

            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);

            if (Tab.posicaoValida (pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }


            // NE 
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Direita

            pos.definirValores(Posicao.Linha , Posicao.Coluna + 1);

            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //se

            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //baixo

            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);

            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //SO

            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //ESQUERDA 

            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);

            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //NO

            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

            if (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}
