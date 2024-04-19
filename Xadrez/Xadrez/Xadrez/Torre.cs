using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using tabuleiro;
using Xadrez;
using Xadrez.tabuleiro;

namespace Xadrez.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return " T";
        }
        private bool podeMover(Posicao pos)
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

            while (Tab.posicaoValida(pos) && podeMover(pos) ) 
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            //baixo

            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            //Direita

            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);

            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            //ESQUERDA 

            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);

            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;

            }

            return mat;
        }

    }
}
