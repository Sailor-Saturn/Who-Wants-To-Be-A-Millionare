using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalJogo
{
    public class Pergunta
    {
        private string Questao, QuestaoCorreta, RespostaA, RespostaB, RespostaC, RespostaD;
        private int Dificuldade;
        public Pergunta(string questao, string questaoCorreta, string respostaA, string respostaB, string respostaC, string respostaD, int dificuldade)
        {
            Questao = questao;
            RespostaA = respostaA;
            RespostaB = respostaB;
            RespostaC = respostaC;
            RespostaD = respostaD;
            QuestaoCorreta = questaoCorreta;
            Dificuldade = dificuldade;
        }
        public string obterQuestao()
        {
            return Questao;
        }
        public string obterQuestaoCorreta()
        {
            return QuestaoCorreta;
        }
        public string obterRespostaA()
        {
            return RespostaA;
        }
        public string obterRespostaB()
        {
            return RespostaB;
        }
        public string obterRespostaC()
        {
            return RespostaC;
        }
        public string obterRespostaD()
        {
            return RespostaD;
        }
        public int obterDificuldade()
        {
            return Dificuldade;
        }

    }

}