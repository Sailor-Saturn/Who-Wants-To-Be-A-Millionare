using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjetoFinalJogo
{

    public partial class JogoPrincipalForm : Form
    {
        public int[] premio = {
            50,
            125,
            250,
            500,
            750,
            1250,
            2500,
            5000,
            10000,
            50000,
            125000,
            250000
        };

        Jogo jogo = new Jogo();

        private Metade metade = new Metade(true, "50riscado.png");
        private Audiencia audiencia = new Audiencia(true, "audienciariscado.png");
        private Telefone telefone = new Telefone(true, "telefoneriscado.png");

        private bool[] respostasAtivadas = { false, false, false, false };

        private static int TEMPO_CADA_PERGUNTA = 30;
        private int tempoPergunta = TEMPO_CADA_PERGUNTA;

        private String nomeJogador;
        private Pergunta perguntaAtual;

        private int indexPontuacao = 0;
        private int pontuacaoAtual = 0;

        public JogoPrincipalForm(String nomeJogador1)
        {
            InitializeComponent();

            jogo.lerPerguntas();

            perguntaAtual = jogo.obterPerguntaAtual();

            perguntaLabel.Text = perguntaAtual.obterQuestao();
            respostaALabel.Text = perguntaAtual.obterRespostaA();
            respostaBLabel.Text = perguntaAtual.obterRespostaB();
            respostaCLabel.Text = perguntaAtual.obterRespostaC();
            respostaDLabel.Text = perguntaAtual.obterRespostaD();

            timer.Start();
            tempoLabel.Text = "00:" + tempoPergunta.ToString();

            nomeJogador = nomeJogador1;

            novoJogoLabel.Text = "Boa sorte jogador " + nomeJogador;

            // Testar para ver se o nome do jogador esta a ser bem recebido
            //MessageBox.Show(nomeJogador);
        }

        private void pictureBox5050_Click(object sender, EventArgs e)
        {
            if(metade.obterEstado() == true)
            {
                string caminhoImagem = metade.desativarEstado();
                pictureBox5050.Image = Image.FromFile(caminhoImagem);
                pictureBox5050.SizeMode = PictureBoxSizeMode.StretchImage;

                string mensagem = metade.ativarAjuda(perguntaAtual, respostasAtivadas);

                MessageBox.Show(mensagem);

                respostaALabel.Visible = respostasAtivadas[0];
                respostaBLabel.Visible = respostasAtivadas[1];
                respostaCLabel.Visible = respostasAtivadas[2];
                respostaDLabel.Visible = respostasAtivadas[3];
            }else
            {
                MessageBox.Show("Já não há mais 50/50!");
            }
        }

        private void pictureBoxAudiencia_Click(object sender, EventArgs e)
        {
            if (audiencia.obterEstado() == true)
            {
                string caminhoImagem = audiencia.desativarEstado();
                pictureBoxAudiencia.Image = Image.FromFile(caminhoImagem);
                pictureBoxAudiencia.SizeMode = PictureBoxSizeMode.StretchImage;

                string mensagem = audiencia.ativarAjuda(perguntaAtual, respostasAtivadas);

                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Já não há mais ajuda da audiência.");
            }
        }

        private void pictureBoxTelefone_Click(object sender, EventArgs e)
        {
            if (telefone.obterEstado() == true)
            {
                string caminhoImagem = telefone.desativarEstado();
                pictureBoxTelefone.Image = Image.FromFile(caminhoImagem);
                pictureBoxTelefone.SizeMode = PictureBoxSizeMode.StretchImage;

                string mensagem = telefone.ativarAjuda(perguntaAtual, respostasAtivadas);

                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Já não há mais ajuda pelo telefone.");
            }
        }

        private void respostaALabel_Click(object sender, EventArgs e)
        {
            continuarJogo(respostaALabel.Text);
        }

        private void respostaBLabel_Click(object sender, EventArgs e)
        {
            continuarJogo(respostaBLabel.Text);
        }

        private void respostaCLabel_Click(object sender, EventArgs e)
        {
            continuarJogo(respostaCLabel.Text);
        }

        private void respostaDLabel_Click(object sender, EventArgs e)
        {
            continuarJogo(respostaDLabel.Text);
        }

        private void continuarJogo(string respostaDada) 
        {
            bool isRespostaCerta = jogo.verificarRespostaCerta(respostaDada, perguntaAtual.obterQuestaoCorreta());
            if (isRespostaCerta)
            {
                // Vou mostrar as labels novamente e mudar o array de boolean
                prepararParaAProximaPergunta();

                // Pergunta novaPergunta = jogo.obterProximaPergunta(); -> Esta era a linha que tinhamos anteriormente mas nao existia progresso do index -> nao avançava para alem da prox pergunta. 
                try
                {
                    Pergunta novaPergunta = jogo.obterProximaPergunta();
                    perguntaLabel.Text = novaPergunta.obterQuestao();
                    respostaALabel.Text = novaPergunta.obterRespostaA();
                    respostaBLabel.Text = novaPergunta.obterRespostaB();
                    respostaCLabel.Text = novaPergunta.obterRespostaC();
                    respostaDLabel.Text = novaPergunta.obterRespostaD();

                    perguntaAtual = novaPergunta;
                    tempoPergunta = TEMPO_CADA_PERGUNTA;
                    tempoLabel.Text = "00:" + tempoPergunta.ToString();

                    pontuacaoAtual = premio[indexPontuacao];
                    indexPontuacao++;

                    premioLabel.Text = pontuacaoAtual + "€";

                    // Verificar que a pontuacao funciona
                    // MessageBox.Show("Pontuacao atual = " + pontuacaoAtual);
                } catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Já não há perguntas. Venceu o jogo.");
                    pontuacaoAtual = premio[indexPontuacao];
                    terminarJogo();
                }
            }
            else
            {
                MessageBox.Show("Perdeu o jogo.");
                // O jogador nesta altura perdeu o jogo
                // Significa que temos que abrir o ficheiro pontuacao e adicionar uma nova pontuacao
                terminarJogo();
            }
        }
        private void terminarJogo()
        {
            StreamWriter sw = File.AppendText("pontuacao.csv");
            sw.WriteLine(nomeJogador + ";" + pontuacaoAtual);
            sw.Close();
            this.Close();
        }

        private void prepararParaAProximaPergunta()
        {
            respostaALabel.Visible = true;
            respostaBLabel.Visible = true;
            respostaCLabel.Visible = true;
            respostaDLabel.Visible = true;

            respostasAtivadas = new bool[] { false, false, false, false};
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            tempoPergunta--;
            if(tempoPergunta == 0) // timer acabou
            {
                timer.Stop();
                jogo.perdeu();
                terminarJogo();
            }
            tempoLabel.Text = "00:" + tempoPergunta.ToString();
        }

    }
}
