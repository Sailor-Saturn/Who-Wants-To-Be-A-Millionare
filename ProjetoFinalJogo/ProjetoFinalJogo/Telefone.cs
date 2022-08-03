using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinalJogo
{
    class Telefone : Ajuda
    {
        public Telefone(Boolean estado1, String caminhoImagem1) : base(estado1, caminhoImagem1)
        {

        }

        public override string ativarAjuda(Pergunta pergunta, bool[] visibilidadeRespostas)
        {
            string[] respostas = { pergunta.obterRespostaA(), pergunta.obterRespostaB(), pergunta.obterRespostaC(), pergunta.obterRespostaD() };

            Random rnd = new Random();
            int indexRandom = rnd.Next(0, 4);
            return "A ajuda telefónica acha que a resposta certa é: " + respostas[indexRandom] + ".";
        }
    }
}
