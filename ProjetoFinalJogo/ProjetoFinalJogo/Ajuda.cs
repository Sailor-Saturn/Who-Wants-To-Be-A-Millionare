using System;

namespace ProjetoFinalJogo
{
    abstract class Ajuda
    {
        private Boolean estado;
        private String caminhoImagem;

        public Boolean obterEstado()
        {
            return estado;
        }
        public abstract string ativarAjuda(Pergunta pergunta, Boolean[] visibilidadeRespostas);
        
        public String desativarEstado ()
        {
            estado = false;
            return caminhoImagem;
        }

        public Ajuda (Boolean estado1, String caminhoImagem1)
        {
            estado = estado1;
            caminhoImagem = caminhoImagem1;
        }

    }
}
