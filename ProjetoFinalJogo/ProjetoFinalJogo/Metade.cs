using System;

namespace ProjetoFinalJogo
{
    class Metade : Ajuda
    {

        public Metade(Boolean estado1, String caminhoImagem1) : base(estado1, caminhoImagem1)
        {

        }

        public override string ativarAjuda(Pergunta pergunta, bool[] visibilidadeRespostas)
        {
            string respostaCorreta = pergunta.obterQuestaoCorreta();
            string [] respostas = { pergunta.obterRespostaA(), pergunta.obterRespostaB(), pergunta.obterRespostaC(), pergunta.obterRespostaD() };

            int indexRespostaVerdadeira = 0;
            for (int i = 0; i < 4; i++)
            {
                if (respostaCorreta == respostas[i]) {
                    visibilidadeRespostas[i] = true;
                    indexRespostaVerdadeira = i;
                }
            }

            Random rnd = new Random();

            int indexRandom = rnd.Next(0, 4);
            while (indexRandom == indexRespostaVerdadeira)
            {
                indexRandom = rnd.Next(0, 4);
            }

            visibilidadeRespostas[indexRandom] = true;

            return "De acordo com a ajuda 50/50, as possiveis respostas são" + respostas[indexRespostaVerdadeira] + " ou " + respostas[indexRandom] + ".";
        }
    }
}
