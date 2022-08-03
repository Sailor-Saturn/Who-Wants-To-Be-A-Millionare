
namespace ProjetoFinalJogo
{
    partial class FormPontuacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPontuacao));
            this.labelPontuacao = new System.Windows.Forms.Label();
            this.primeiroLugarLabel = new System.Windows.Forms.Label();
            this.segundoLugarLabel = new System.Windows.Forms.Label();
            this.terceiroLugarLabel = new System.Windows.Forms.Label();
            this.quartoLugarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPontuacao
            // 
            this.labelPontuacao.AutoSize = true;
            this.labelPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.labelPontuacao.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPontuacao.ForeColor = System.Drawing.Color.White;
            this.labelPontuacao.Location = new System.Drawing.Point(573, 497);
            this.labelPontuacao.Name = "labelPontuacao";
            this.labelPontuacao.Size = new System.Drawing.Size(391, 86);
            this.labelPontuacao.TabIndex = 0;
            this.labelPontuacao.Text = "Hall of Fame";
            // 
            // primeiroLugarLabel
            // 
            this.primeiroLugarLabel.AutoSize = true;
            this.primeiroLugarLabel.BackColor = System.Drawing.Color.Transparent;
            this.primeiroLugarLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.primeiroLugarLabel.ForeColor = System.Drawing.Color.White;
            this.primeiroLugarLabel.Location = new System.Drawing.Point(240, 647);
            this.primeiroLugarLabel.Name = "primeiroLugarLabel";
            this.primeiroLugarLabel.Size = new System.Drawing.Size(214, 65);
            this.primeiroLugarLabel.TabIndex = 1;
            this.primeiroLugarLabel.Text = "1o Lugar";
            // 
            // segundoLugarLabel
            // 
            this.segundoLugarLabel.AutoSize = true;
            this.segundoLugarLabel.BackColor = System.Drawing.Color.Transparent;
            this.segundoLugarLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.segundoLugarLabel.ForeColor = System.Drawing.Color.White;
            this.segundoLugarLabel.Location = new System.Drawing.Point(901, 646);
            this.segundoLugarLabel.Name = "segundoLugarLabel";
            this.segundoLugarLabel.Size = new System.Drawing.Size(214, 65);
            this.segundoLugarLabel.TabIndex = 2;
            this.segundoLugarLabel.Text = "2o Lugar";
            // 
            // terceiroLugarLabel
            // 
            this.terceiroLugarLabel.AutoSize = true;
            this.terceiroLugarLabel.BackColor = System.Drawing.Color.Transparent;
            this.terceiroLugarLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.terceiroLugarLabel.ForeColor = System.Drawing.Color.White;
            this.terceiroLugarLabel.Location = new System.Drawing.Point(236, 748);
            this.terceiroLugarLabel.Name = "terceiroLugarLabel";
            this.terceiroLugarLabel.Size = new System.Drawing.Size(214, 65);
            this.terceiroLugarLabel.TabIndex = 3;
            this.terceiroLugarLabel.Text = "3o Lugar";
            // 
            // quartoLugarLabel
            // 
            this.quartoLugarLabel.AutoSize = true;
            this.quartoLugarLabel.BackColor = System.Drawing.Color.Transparent;
            this.quartoLugarLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quartoLugarLabel.ForeColor = System.Drawing.Color.White;
            this.quartoLugarLabel.Location = new System.Drawing.Point(897, 750);
            this.quartoLugarLabel.Name = "quartoLugarLabel";
            this.quartoLugarLabel.Size = new System.Drawing.Size(214, 65);
            this.quartoLugarLabel.TabIndex = 4;
            this.quartoLugarLabel.Text = "4o Lugar";
            // 
            // FormPontuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1551, 896);
            this.Controls.Add(this.quartoLugarLabel);
            this.Controls.Add(this.terceiroLugarLabel);
            this.Controls.Add(this.segundoLugarLabel);
            this.Controls.Add(this.primeiroLugarLabel);
            this.Controls.Add(this.labelPontuacao);
            this.DoubleBuffered = true;
            this.Name = "FormPontuacao";
            this.Text = "FormPontuacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPontuacao;
        private System.Windows.Forms.Label primeiroLugarLabel;
        private System.Windows.Forms.Label segundoLugarLabel;
        private System.Windows.Forms.Label terceiroLugarLabel;
        private System.Windows.Forms.Label quartoLugarLabel;
    }
}