using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using Xadrez.tabuleiro;
using Xadrez;
using System.Runtime.ExceptionServices;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }

        public Cor Cor {  get; set; }

        public int QteMovimentos { get; protected set; }

        public Tabuleiro Tab {  get; protected set; }


        public Peca (Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            this.QteMovimentos = 0;
        }

        public void IncrementaQuantidadeMovimentos()
        {
            QteMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            QteMovimentos--;
        }

        public bool existeMovimentoPossivel()
        {
            bool[,] mat = movimentoPossivel();

            for (int i = 0; i <Tab.Linha; i++)
            {
                for (int j = 0; j<Tab.Colunas; j++) 

                if (mat[i, j])
                {
                    return true;
                }
            }
            return false;
        }

        public bool podeMoverPara (Posicao pos)
        {
            return movimentoPossivel()[pos.Linha, pos.Coluna];
        }
        public abstract bool[,] movimentoPossivel();
        
    }
}
