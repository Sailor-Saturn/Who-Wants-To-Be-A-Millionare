using System;
using System.Collections.Generic;
using System.IO;

namespace ProjetoFinalJogo
{
    public class Jogo
    {
        string[] array = File.ReadAllLines(@"perguntas.csv");//Retorna todas as linhas do arquivo num array. O csv indica que os dados estão separados por ponto e vírgula
        //podia ter posto @"C:\Users\Paula Cristina\Documents\PerguntasJogo.txt" se fosse um ficheiro de bloco de notas

        private List<Pergunta> listaPerguntas = new List<Pergunta>();
        private int index = 0;
        private bool aindaEstaEmJogo = true;
        private List<Pergunta> perguntasDificuldade1 = new List<Pergunta>();
        private List<Pergunta> perguntasDificuldade2 = new List<Pergunta>();
        private List<Pergunta> perguntasDificuldade3 = new List<Pergunta>();

        private List<Pergunta> perguntasJaRespondidasDificuldade1 = new List<Pergunta>();
        private List<Pergunta> perguntasJaRespondidasDificuldade2 = new List<Pergunta>();
        private List<Pergunta> perguntasJaRespondidasDificuldade3 = new List<Pergunta>();

        private int indexDificuldade1 = 0;
        private int indexDificuldade2 = 0;
        private int indexDificuldade3 = 0;
        private int NUMERO_MAXIMO_PERGUNTAS = 12;
        private int NUMERO_PERGUNTAS = 4;

        public void lerPerguntas()
        {
            string[] dados;

            for (int i = 0; i < array.Length; i++) //percorro o array e para cada linha
            {
                dados = array[i].Split(';'); //Uso o método Split e quebro cada linha num novo array dados, ou seja, cada
                                             //conteúdo do arquivo txt separado por ';' será uma nova linha neste array. 

                string Questao = dados[0]; //Aqui recupero os itens,
                string QuestaoCorreta = dados[1];
                string RespostaA = dados[2];
                string RespostaB = dados[3];
                string RespostaC = dados[4];
                string RespostaD = dados[5];
                int Dificuldade = Int32.Parse(dados[6]);

                Pergunta p = new Pergunta(Questao, QuestaoCorreta, RespostaA, RespostaB, RespostaC, RespostaD, Dificuldade);//crio a instância da Pergunta passando os valores no construtor
                                                                                                                            //crio um objeto do tipo Pergunta
                listaPerguntas.Add(p);//Adiciono a nova instância à lista


                // Console.WriteLine(@"----------------------------------------------------------");
                // Console.WriteLine(p.obterQuestao() + " - " + p.obterQuestaoCorreta() + " - " + p.obterRespostaA() + " - " + p.obterRespostaB() + "- " + p.obterRespostaC() + " - " + p.obterRespostaD() + " - " + p.obterDificuldade());
                
                //A linha de baixo não funciona aqui pois, para dividir em sublistas é necessario que a lista principal já tenha as perguntas todas (16 perguntas)
                // Antes nos estavamos a chamar o metodo dentro deste ciclo e isto estava a provocar a que as sublistas estivessem a serem preenchidas com dados repetidos
                // Ex: [p1d1, p2d1, p3d1, p4d2, p5d2]
                // Como o metodo de criar sublistas estava a ser chamadado dentro do for as listas ficavam como:
                // listaDif1: [p1d1,p1d1,p1d2,p1d1,p1d2,...]
                // Este metodo tem que ser chamado no fim 
                // criarSublistasDificuldade();
            }

            criarSublistasDificuldade();

            Pergunta h;

            //Console.WriteLine("DIFICULDADE 1");
            //for (int i = 0; i < perguntasDificuldade1.Count; i++) //percorro o array e para cada linha
            //{
            //    h = perguntasDificuldade1[i];
            //    Console.WriteLine(h.obterQuestao() + " - " + h.obterQuestaoCorreta() + " - " + h.obterRespostaA() + " - " + h.obterRespostaB() + "- " + h.obterRespostaC() + " - " + h.obterRespostaD() + " - " + h.obterDificuldade());
            //}

            //Console.WriteLine("DIFICULDADE 2");
            //for (int i = 0; i < perguntasDificuldade2.Count; i++) //percorro o array e para cada linha
            //{
            //    h = perguntasDificuldade2[i];
            //    Console.WriteLine(h.obterQuestao() + " - " + h.obterQuestaoCorreta() + " - " + h.obterRespostaA() + " - " + h.obterRespostaB() + "- " + h.obterRespostaC() + " - " + h.obterRespostaD() + " - " + h.obterDificuldade());
            //}

            //Console.WriteLine("DIFICULDADE 3");
            //for (int i = 0; i < perguntasDificuldade3.Count; i++) //percorro o array e para cada linha
            //{
            //    h = perguntasDificuldade3[i];
            //    Console.WriteLine(h.obterQuestao() + " - " + h.obterQuestaoCorreta() + " - " + h.obterRespostaA() + " - " + h.obterRespostaB() + "- " + h.obterRespostaC() + " - " + h.obterRespostaD() + " - " + h.obterDificuldade());
            //}
        }

        public Pergunta obterPerguntaAtual()
        {
            Random rnd = new Random();
            int indexRandom = rnd.Next(0, perguntasDificuldade1.Count);
            Pergunta pergunta = perguntasDificuldade1[indexRandom];
            perguntasJaRespondidasDificuldade1.Add(pergunta);
            indexDificuldade1++;
            index++;
            return pergunta;
        }

        public Pergunta obterProximaPergunta()
        {
            
            if (index == NUMERO_MAXIMO_PERGUNTAS) //Verificação do fim da lista de perguntas
            {
                throw new IndexOutOfRangeException(); // Lança exceção no caso de já não existir perguntas disponiveis
            }
            
            if(indexDificuldade1 < NUMERO_PERGUNTAS)
            {
                // O jogador ainda está na dificuldade 1
                Random rnd = new Random();
                int indexRandom = rnd.Next(0, perguntasDificuldade1.Count);

                Pergunta pergunta = perguntasDificuldade1[indexRandom];

                while (perguntasJaRespondidasDificuldade1.Contains(pergunta) == true)
                {
                    indexRandom = rnd.Next(0, perguntasDificuldade1.Count);

                    pergunta = perguntasDificuldade1[indexRandom];
                }

                perguntasJaRespondidasDificuldade1.Add(pergunta);
                indexDificuldade1++;
                index++;
                return pergunta;
            } else if (indexDificuldade2 < NUMERO_PERGUNTAS)
            {
                Random rnd = new Random();
                int indexRandom = rnd.Next(0, perguntasDificuldade2.Count);

                Pergunta pergunta = perguntasDificuldade2[indexRandom];
                while (perguntasJaRespondidasDificuldade2.Contains(pergunta) == true)
                {
                    indexRandom = rnd.Next(0, perguntasDificuldade2.Count);

                    pergunta = perguntasDificuldade2[indexRandom];
                }

                perguntasJaRespondidasDificuldade2.Add(pergunta);
                index++;
                indexDificuldade2++;
                return pergunta;
            }else
            {
                Random rnd = new Random();
                int indexRandom = rnd.Next(0, perguntasDificuldade3.Count);

                Pergunta pergunta = perguntasDificuldade3[indexRandom];

                while (perguntasJaRespondidasDificuldade3.Contains(pergunta) == true)
                {
                    indexRandom = rnd.Next(0, perguntasDificuldade3.Count);

                    pergunta = perguntasDificuldade3[indexRandom];
                }

                perguntasJaRespondidasDificuldade3.Add(pergunta);
                indexDificuldade3++;
                index++;
                return pergunta;
            }
         }

        public bool verificarRespostaCerta(String respostaEscolhida, String respostaCerta) 
        {
            if(respostaEscolhida == respostaCerta) // Verificar se a resposta certa é igual a resposta escolhida
            {
                return aindaEstaEmJogo; // retorna verdadeiro caso o seja (a variavel aindaEstaEmJogo é true por default)
            }

            // No caso de não entrar no if, significa que a resposta escolhida foi a resposta errada
            aindaEstaEmJogo = false; // é necessario alterar o valor da variavel aindaEstaEmJogo para falso
            return aindaEstaEmJogo; // E retornar este resultado (que é sempre falso neste ponto)
        }

        public bool jogoTerminado()
        {
            if (index == listaPerguntas.Count)
            {
                return true;
            }
            return !aindaEstaEmJogo; // O uso do ponto de exclamação permite negar a variavel aindaEstaEmJogo
        }

        // Método que divide a lista principal em 3 listas secundárias por dificuldade
        private void criarSublistasDificuldade()
        {
            Pergunta perguntaAnalisada;
            for (int i = 0; i < listaPerguntas.Count; i++) //percorro o array e para cada linha
            {
                perguntaAnalisada = listaPerguntas[i];
                if (perguntaAnalisada.obterDificuldade() == 1)
                {
                    perguntasDificuldade1.Add(perguntaAnalisada);
                }
                else if (perguntaAnalisada.obterDificuldade() == 2)
                {
                    perguntasDificuldade2.Add(perguntaAnalisada);
                }
                else
                {
                    perguntasDificuldade3.Add(perguntaAnalisada);
                }
            }
        }

        public void perdeu()
        {
            aindaEstaEmJogo = false;
        }
    }
    
}