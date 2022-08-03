using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProjetoFinalJogo
{
    public partial class FormPontuacao : Form
    {
        private List<Pontuacao> pontuacoes = new List<Pontuacao>();
        public FormPontuacao()
        {
            InitializeComponent();

            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("pontuacao.csv"))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    String[] array = line.Split(";");
                    pontuacoes.Add(new Pontuacao(array[0], array[1]));
                }
            }
            // Verificação para ter a certeza que as pontuacoes do ficheiro estao a ser bem lidas
            // MessageBox.Show("Teste123" + pontuacoes[0].obterNome() + " " + pontuacoes[0].obterPontuacao() +  " " + pontuacoes[6].obterNome());

            ordenarArray();

            primeiroLugarLabel.Text = pontuacoes[0].obterNome() + " ->" + pontuacoes[0].obterPontuacao() + "€";
            segundoLugarLabel.Text = pontuacoes[1].obterNome() + " ->" + pontuacoes[1].obterPontuacao() + "€";
            terceiroLugarLabel.Text = pontuacoes[2].obterNome() + " ->" + pontuacoes[2].obterPontuacao() + "€";
            quartoLugarLabel.Text = pontuacoes[3].obterNome() + " ->" + pontuacoes[3].obterPontuacao() + "€";
        }

        private void ordenarArray()
        { 
            for (int i = 0; i < pontuacoes.Count; i++)
            {
                for (int j = 1; j < pontuacoes.Count - i; j++)
                {
                    if (int.Parse(pontuacoes[j - 1].obterPontuacao()) < int.Parse(pontuacoes[j].obterPontuacao()))
                    {
                        Pontuacao temp = pontuacoes[j - 1];
                        pontuacoes[j - 1] = pontuacoes[j];
                        pontuacoes[j] = temp;
                    }
                }
            }
        }

    }
}
