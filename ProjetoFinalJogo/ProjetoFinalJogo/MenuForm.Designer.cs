
namespace ProjetoFinalJogo
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.novoJogoLabel = new System.Windows.Forms.Label();
            this.pontuacoesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomeLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeLabel.ForeColor = System.Drawing.Color.White;
            this.nomeLabel.Location = new System.Drawing.Point(137, 427);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(163, 50);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Jogador:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(110, 495);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 56);
            this.nameTextBox.TabIndex = 0;
            // 
            // novoJogoLabel
            // 
            this.novoJogoLabel.AutoSize = true;
            this.novoJogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.novoJogoLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.novoJogoLabel.ForeColor = System.Drawing.Color.White;
            this.novoJogoLabel.Location = new System.Drawing.Point(103, 601);
            this.novoJogoLabel.Name = "novoJogoLabel";
            this.novoJogoLabel.Size = new System.Drawing.Size(201, 50);
            this.novoJogoLabel.TabIndex = 1;
            this.novoJogoLabel.Text = "Novo Jogo";
            this.novoJogoLabel.Click += new System.EventHandler(this.novoJogoLabel_Click);
            // 
            // pontuacoesLabel
            // 
            this.pontuacoesLabel.AutoSize = true;
            this.pontuacoesLabel.BackColor = System.Drawing.Color.Transparent;
            this.pontuacoesLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pontuacoesLabel.ForeColor = System.Drawing.Color.White;
            this.pontuacoesLabel.Location = new System.Drawing.Point(103, 700);
            this.pontuacoesLabel.Name = "pontuacoesLabel";
            this.pontuacoesLabel.Size = new System.Drawing.Size(212, 50);
            this.pontuacoesLabel.TabIndex = 2;
            this.pontuacoesLabel.Text = "Pontuações";
            this.pontuacoesLabel.Click += new System.EventHandler(this.pontuacoesLabel_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 873);
            this.Controls.Add(this.pontuacoesLabel);
            this.Controls.Add(this.novoJogoLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nomeLabel);
            this.DoubleBuffered = true;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label novoJogoLabel;
        private System.Windows.Forms.Label pontuacoesLabel;
    }
}