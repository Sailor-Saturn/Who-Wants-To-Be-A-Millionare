
namespace ProjetoFinalJogo
{
    partial class JogoPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JogoPrincipalForm));
            this.pictureBox5050 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAudiencia = new System.Windows.Forms.PictureBox();
            this.pictureBoxTelefone = new System.Windows.Forms.PictureBox();
            this.novoJogoLabel = new System.Windows.Forms.Label();
            this.premioLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.perguntaLabel = new System.Windows.Forms.Label();
            this.respostaALabel = new System.Windows.Forms.Label();
            this.respostaCLabel = new System.Windows.Forms.Label();
            this.respostaBLabel = new System.Windows.Forms.Label();
            this.respostaDLabel = new System.Windows.Forms.Label();
            this.tempoLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5050)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudiencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5050
            // 
            this.pictureBox5050.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5050.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5050.BackgroundImage")));
            this.pictureBox5050.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5050.Location = new System.Drawing.Point(41, 48);
            this.pictureBox5050.Name = "pictureBox5050";
            this.pictureBox5050.Size = new System.Drawing.Size(148, 128);
            this.pictureBox5050.TabIndex = 0;
            this.pictureBox5050.TabStop = false;
            this.pictureBox5050.Click += new System.EventHandler(this.pictureBox5050_Click);
            // 
            // pictureBoxAudiencia
            // 
            this.pictureBoxAudiencia.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAudiencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAudiencia.BackgroundImage")));
            this.pictureBoxAudiencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAudiencia.Location = new System.Drawing.Point(41, 197);
            this.pictureBoxAudiencia.Name = "pictureBoxAudiencia";
            this.pictureBoxAudiencia.Size = new System.Drawing.Size(148, 128);
            this.pictureBoxAudiencia.TabIndex = 1;
            this.pictureBoxAudiencia.TabStop = false;
            this.pictureBoxAudiencia.Click += new System.EventHandler(this.pictureBoxAudiencia_Click);
            // 
            // pictureBoxTelefone
            // 
            this.pictureBoxTelefone.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTelefone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTelefone.BackgroundImage")));
            this.pictureBoxTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTelefone.Location = new System.Drawing.Point(41, 348);
            this.pictureBoxTelefone.Name = "pictureBoxTelefone";
            this.pictureBoxTelefone.Size = new System.Drawing.Size(148, 128);
            this.pictureBoxTelefone.TabIndex = 2;
            this.pictureBoxTelefone.TabStop = false;
            this.pictureBoxTelefone.Click += new System.EventHandler(this.pictureBoxTelefone_Click);
            // 
            // novoJogoLabel
            // 
            this.novoJogoLabel.AutoSize = true;
            this.novoJogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.novoJogoLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.novoJogoLabel.ForeColor = System.Drawing.Color.White;
            this.novoJogoLabel.Location = new System.Drawing.Point(687, 9);
            this.novoJogoLabel.Name = "novoJogoLabel";
            this.novoJogoLabel.Size = new System.Drawing.Size(213, 54);
            this.novoJogoLabel.TabIndex = 3;
            this.novoJogoLabel.Text = "Novo Jogo";
            // 
            // premioLabel
            // 
            this.premioLabel.AutoSize = true;
            this.premioLabel.BackColor = System.Drawing.Color.Transparent;
            this.premioLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.premioLabel.ForeColor = System.Drawing.Color.White;
            this.premioLabel.Location = new System.Drawing.Point(1126, 92);
            this.premioLabel.Name = "premioLabel";
            this.premioLabel.Size = new System.Drawing.Size(130, 50);
            this.premioLabel.TabIndex = 4;
            this.premioLabel.Text = "0, 00 €";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            // 
            // perguntaLabel
            // 
            this.perguntaLabel.AutoSize = true;
            this.perguntaLabel.BackColor = System.Drawing.Color.Transparent;
            this.perguntaLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.perguntaLabel.ForeColor = System.Drawing.Color.White;
            this.perguntaLabel.Location = new System.Drawing.Point(225, 526);
            this.perguntaLabel.Name = "perguntaLabel";
            this.perguntaLabel.Size = new System.Drawing.Size(78, 32);
            this.perguntaLabel.TabIndex = 6;
            this.perguntaLabel.Text = "label2";
            // 
            // respostaALabel
            // 
            this.respostaALabel.AutoSize = true;
            this.respostaALabel.BackColor = System.Drawing.Color.Transparent;
            this.respostaALabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.respostaALabel.ForeColor = System.Drawing.Color.White;
            this.respostaALabel.Location = new System.Drawing.Point(256, 672);
            this.respostaALabel.Name = "respostaALabel";
            this.respostaALabel.Size = new System.Drawing.Size(97, 41);
            this.respostaALabel.TabIndex = 7;
            this.respostaALabel.Text = "label3";
            this.respostaALabel.Click += new System.EventHandler(this.respostaALabel_Click);
            // 
            // respostaCLabel
            // 
            this.respostaCLabel.AutoSize = true;
            this.respostaCLabel.BackColor = System.Drawing.Color.Transparent;
            this.respostaCLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.respostaCLabel.ForeColor = System.Drawing.Color.White;
            this.respostaCLabel.Location = new System.Drawing.Point(256, 775);
            this.respostaCLabel.Name = "respostaCLabel";
            this.respostaCLabel.Size = new System.Drawing.Size(97, 41);
            this.respostaCLabel.TabIndex = 8;
            this.respostaCLabel.Text = "label4";
            this.respostaCLabel.Click += new System.EventHandler(this.respostaCLabel_Click);
            // 
            // respostaBLabel
            // 
            this.respostaBLabel.AutoSize = true;
            this.respostaBLabel.BackColor = System.Drawing.Color.Transparent;
            this.respostaBLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.respostaBLabel.ForeColor = System.Drawing.Color.White;
            this.respostaBLabel.Location = new System.Drawing.Point(919, 672);
            this.respostaBLabel.Name = "respostaBLabel";
            this.respostaBLabel.Size = new System.Drawing.Size(97, 41);
            this.respostaBLabel.TabIndex = 9;
            this.respostaBLabel.Text = "label5";
            this.respostaBLabel.Click += new System.EventHandler(this.respostaBLabel_Click);
            // 
            // respostaDLabel
            // 
            this.respostaDLabel.AutoSize = true;
            this.respostaDLabel.BackColor = System.Drawing.Color.Transparent;
            this.respostaDLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.respostaDLabel.ForeColor = System.Drawing.Color.White;
            this.respostaDLabel.Location = new System.Drawing.Point(919, 775);
            this.respostaDLabel.Name = "respostaDLabel";
            this.respostaDLabel.Size = new System.Drawing.Size(97, 41);
            this.respostaDLabel.TabIndex = 10;
            this.respostaDLabel.Text = "label6";
            this.respostaDLabel.Click += new System.EventHandler(this.respostaDLabel_Click);
            // 
            // tempoLabel
            // 
            this.tempoLabel.AutoSize = true;
            this.tempoLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempoLabel.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempoLabel.ForeColor = System.Drawing.Color.White;
            this.tempoLabel.Location = new System.Drawing.Point(1126, 187);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(153, 59);
            this.tempoLabel.TabIndex = 11;
            this.tempoLabel.Text = "Tempo";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // JogoPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1590, 911);
            this.Controls.Add(this.tempoLabel);
            this.Controls.Add(this.respostaDLabel);
            this.Controls.Add(this.respostaBLabel);
            this.Controls.Add(this.respostaCLabel);
            this.Controls.Add(this.respostaALabel);
            this.Controls.Add(this.perguntaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.premioLabel);
            this.Controls.Add(this.novoJogoLabel);
            this.Controls.Add(this.pictureBoxTelefone);
            this.Controls.Add(this.pictureBoxAudiencia);
            this.Controls.Add(this.pictureBox5050);
            this.DoubleBuffered = true;
            this.Name = "JogoPrincipalForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5050)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudiencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5050;
        private System.Windows.Forms.PictureBox pictureBoxAudiencia;
        private System.Windows.Forms.PictureBox pictureBoxTelefone;
        private System.Windows.Forms.Label novoJogoLabel;
        private System.Windows.Forms.Label premioLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label perguntaLabel;
        private System.Windows.Forms.Label respostaALabel;
        private System.Windows.Forms.Label respostaCLabel;
        private System.Windows.Forms.Label respostaBLabel;
        private System.Windows.Forms.Label respostaDLabel;
        private System.Windows.Forms.Label tempoLabel;
        private System.Windows.Forms.Timer timer;
    }
}

