using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFinalJogo
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void novoJogoLabel_Click(object sender, EventArgs e)
        {
            JogoPrincipalForm form = new JogoPrincipalForm(nameTextBox.Text);
            form.Show();
        }

        private void pontuacoesLabel_Click(object sender, EventArgs e)
        {
            FormPontuacao form = new FormPontuacao();
            form.Show();
        }
    }
}
