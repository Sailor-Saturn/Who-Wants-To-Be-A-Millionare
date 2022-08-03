using System;
using System.Windows.Forms;

namespace ProjetoFinalJogo
{
    class Pontuacao
    {
        private String pontuacao;
        private String nome;

        public Pontuacao(String nome1, String pontuacao1)
        {
            pontuacao = pontuacao1;
            nome = nome1;
        }

        public String obterPontuacao()
        {
            return pontuacao;
        }

        public String obterNome()
        {
            return nome;
        }
    }
}
