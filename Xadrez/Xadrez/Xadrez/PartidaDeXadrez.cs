using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using Xadrez.tabuleiro;

namespace Xadrez.Xadrez
{
     class PartidaDeXadrez
    {
        public  Tabuleiro tab {  get; private set; }

        public int Turno { get; private set; }

        public bool Terminada { get; private set; }

        public Cor jogadorAtual { get; private set; }

        private HashSet<Peca> pecas;

        private HashSet<Peca> Capturadas;

        public PartidaDeXadrez ()
        {
            tab = new Tabuleiro(8, 8);
            Turno = 1;
            jogadorAtual = Cor.Branca;
            Terminada = false;
            pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            ColocarPeca();
        }

        public void executaMovimento (Posicao origem,Posicao destino)
        
        {
            Peca p = tab.retirarPeca (origem);
            p.IncrementaQuantidadeMovimentos();
            
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca (p,destino);
            if (pecaCapturada != null)
            {
                Capturadas.Add(pecaCapturada);
            }

        }
        public void realizaJogada (Posicao origem,Posicao destino)
        {
            executaMovimento(origem, destino);
            Turno ++;
            mudaJogador();
        }
        public void validarPosicaodeOrigem (Posicao pos)
        {
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida");
            }
            if (jogadorAtual != tab.peca(pos).Cor)
            {
                throw new TabuleiroException("A peca de origem escolhida não é sua!");
            }
            if (!tab.peca(pos).existeMovimentoPossivel())
            {
                throw new TabuleiroException("Não há movimento possíveis para a peça de origem escolhida");
            }
        }
        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Azul;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }
        public HashSet<Peca> pecasCapturadas (Cor cor)
        {
            HashSet<Peca> Aux = new HashSet<Peca>();
            foreach (Peca pec in Capturadas)
            {
                if (pec.Cor == cor)
                {
                    Aux.Add(pec);  
                }
            }
            return Aux;
        }
        public HashSet<Peca> pecasEmJogo (Cor cor)
        {
            HashSet<Peca> Aux = new HashSet<Peca>();
            foreach (Peca pec in pecas)
            {
                if (pec.Cor == cor)
                {
                    Aux.Add(pec);  
                }
            }
            Aux.ExceptWith(pecasCapturadas(cor)); 
        
            return Aux;
        }
        public void validarPosicaoDestino (Posicao origem ,Posicao destino)
        {
            if (!tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        public void colocarNovaPeca(char coluna, int linha,Peca peca)
        {
            tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            pecas.Add(peca);
        }

        private Cor Adversario (Cor cor)
        {
            if (Cor.Branca == cor) {
                return Cor.Branca;
            }
            else
            {
                return Cor.Azul;
            }
        }

        private Peca rei (Cor cor)
        {
            foreach (Peca pec in pecasEmJogo(cor))
            {
                if (pec is Rei)
                {
                    return pec;
                }
            }
            return null;
        }
        
        public bool estaEmXeque (Cor cor)
        {
            Peca R = rei(cor);
            if (R == null)
            {
                throw new TabuleiroException("Não tem Rei no tabuleiro");
            }
            foreach (Peca x in pecasEmJogo(Adversario(cor)))
            {                
                bool[,] mat = x.movimentoPossivel();

                if (mat[R.Posicao.Linha,R.Posicao.Coluna])
                {

                    return true;
                }
            }
                return false;
        }

        private void ColocarPeca()
        {
            colocarNovaPeca('c', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('c', 2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('d', 1, new Rei(tab, Cor.Branca));
            colocarNovaPeca('d', 2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('e', 2, new Torre(tab, Cor.Branca));


            colocarNovaPeca('c', 7, new Torre(tab, Cor.Azul));
            colocarNovaPeca('c', 8, new Torre(tab, Cor.Azul));
            colocarNovaPeca('d', 7, new Torre(tab, Cor.Azul));
            colocarNovaPeca('e', 7, new Torre(tab, Cor.Azul));
            colocarNovaPeca('d', 8, new Torre(tab, Cor.Azul));

        }
    }
}
