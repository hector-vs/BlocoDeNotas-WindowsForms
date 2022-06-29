namespace AtividadeWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tela_aplicativo = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.titulo_app = new System.Windows.Forms.Label();
            this.controls = new System.Windows.Forms.GroupBox();
            this.Título = new System.Windows.Forms.GroupBox();
            this.enviartitulo = new System.Windows.Forms.Button();
            this.butamarelo = new System.Windows.Forms.RadioButton();
            this.butazul = new System.Windows.Forms.RadioButton();
            this.butbranco = new System.Windows.Forms.RadioButton();
            this.butpreto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textotitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Imagem = new System.Windows.Forms.GroupBox();
            this.empalha = new System.Windows.Forms.RadioButton();
            this.emfeliz = new System.Windows.Forms.RadioButton();
            this.emrisos = new System.Windows.Forms.RadioButton();
            this.emfofo = new System.Windows.Forms.RadioButton();
            this.emamor = new System.Windows.Forms.RadioButton();
            this.emnada = new System.Windows.Forms.RadioButton();
            this.tema = new System.Windows.Forms.GroupBox();
            this.temaescuro = new System.Windows.Forms.CheckBox();
            this.Texto = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texto_conteudo = new System.Windows.Forms.TextBox();
            this.botao_conteudo = new System.Windows.Forms.Button();
            this.texto_app = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nome_box = new System.Windows.Forms.TextBox();
            this.visionname = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nome_app = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.tela_aplicativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.controls.SuspendLayout();
            this.Título.SuspendLayout();
            this.Imagem.SuspendLayout();
            this.tema.SuspendLayout();
            this.Texto.SuspendLayout();
            this.Nome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tela_aplicativo
            // 
            this.tela_aplicativo.BackColor = System.Drawing.Color.GhostWhite;
            this.tela_aplicativo.Controls.Add(this.nome_app);
            this.tela_aplicativo.Controls.Add(this.texto_app);
            this.tela_aplicativo.Controls.Add(this.pictureBox);
            this.tela_aplicativo.Controls.Add(this.titulo_app);
            this.tela_aplicativo.Location = new System.Drawing.Point(484, 1);
            this.tela_aplicativo.Name = "tela_aplicativo";
            this.tela_aplicativo.Size = new System.Drawing.Size(304, 437);
            this.tela_aplicativo.TabIndex = 0;
            this.tela_aplicativo.TabStop = false;
            this.tela_aplicativo.Text = "Aplicativo";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(212, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(76, 73);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // titulo_app
            // 
            this.titulo_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_app.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titulo_app.Location = new System.Drawing.Point(18, 28);
            this.titulo_app.Name = "titulo_app";
            this.titulo_app.Size = new System.Drawing.Size(188, 73);
            this.titulo_app.TabIndex = 0;
            this.titulo_app.Text = "Seu título";
            // 
            // controls
            // 
            this.controls.Controls.Add(this.sair);
            this.controls.Controls.Add(this.Nome);
            this.controls.Controls.Add(this.botao_conteudo);
            this.controls.Controls.Add(this.Texto);
            this.controls.Controls.Add(this.tema);
            this.controls.Controls.Add(this.Imagem);
            this.controls.Controls.Add(this.Título);
            this.controls.Location = new System.Drawing.Point(12, 1);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(466, 437);
            this.controls.TabIndex = 1;
            this.controls.TabStop = false;
            this.controls.Text = "Controles";
            // 
            // Título
            // 
            this.Título.Controls.Add(this.enviartitulo);
            this.Título.Controls.Add(this.butamarelo);
            this.Título.Controls.Add(this.butazul);
            this.Título.Controls.Add(this.butbranco);
            this.Título.Controls.Add(this.butpreto);
            this.Título.Controls.Add(this.label2);
            this.Título.Controls.Add(this.textotitulo);
            this.Título.Controls.Add(this.label1);
            this.Título.Location = new System.Drawing.Point(25, 28);
            this.Título.Name = "Título";
            this.Título.Size = new System.Drawing.Size(404, 92);
            this.Título.TabIndex = 1;
            this.Título.TabStop = false;
            this.Título.Text = "Título";
            // 
            // enviartitulo
            // 
            this.enviartitulo.Location = new System.Drawing.Point(311, 19);
            this.enviartitulo.Name = "enviartitulo";
            this.enviartitulo.Size = new System.Drawing.Size(75, 54);
            this.enviartitulo.TabIndex = 7;
            this.enviartitulo.Text = "Enviar";
            this.enviartitulo.UseVisualStyleBackColor = true;
            this.enviartitulo.Click += new System.EventHandler(this.enviartitulo_Click);
            // 
            // butamarelo
            // 
            this.butamarelo.AutoSize = true;
            this.butamarelo.Location = new System.Drawing.Point(229, 58);
            this.butamarelo.Name = "butamarelo";
            this.butamarelo.Size = new System.Drawing.Size(63, 17);
            this.butamarelo.TabIndex = 6;
            this.butamarelo.TabStop = true;
            this.butamarelo.Text = "Amarelo";
            this.butamarelo.UseVisualStyleBackColor = true;
            this.butamarelo.CheckedChanged += new System.EventHandler(this.butamarelo_CheckedChanged);
            // 
            // butazul
            // 
            this.butazul.AutoSize = true;
            this.butazul.Location = new System.Drawing.Point(178, 58);
            this.butazul.Name = "butazul";
            this.butazul.Size = new System.Drawing.Size(45, 17);
            this.butazul.TabIndex = 5;
            this.butazul.TabStop = true;
            this.butazul.Text = "Azul";
            this.butazul.UseVisualStyleBackColor = true;
            this.butazul.CheckedChanged += new System.EventHandler(this.butazul_CheckedChanged);
            // 
            // butbranco
            // 
            this.butbranco.AutoSize = true;
            this.butbranco.Location = new System.Drawing.Point(113, 58);
            this.butbranco.Name = "butbranco";
            this.butbranco.Size = new System.Drawing.Size(59, 17);
            this.butbranco.TabIndex = 4;
            this.butbranco.TabStop = true;
            this.butbranco.Text = "Branco";
            this.butbranco.UseVisualStyleBackColor = true;
            this.butbranco.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // butpreto
            // 
            this.butpreto.AutoSize = true;
            this.butpreto.Location = new System.Drawing.Point(57, 58);
            this.butpreto.Name = "butpreto";
            this.butpreto.Size = new System.Drawing.Size(50, 17);
            this.butpreto.TabIndex = 3;
            this.butpreto.TabStop = true;
            this.butpreto.Text = "Preto";
            this.butpreto.UseVisualStyleBackColor = true;
            this.butpreto.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cor:";
            // 
            // textotitulo
            // 
            this.textotitulo.Location = new System.Drawing.Point(57, 23);
            this.textotitulo.Name = "textotitulo";
            this.textotitulo.Size = new System.Drawing.Size(235, 20);
            this.textotitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            // 
            // Imagem
            // 
            this.Imagem.Controls.Add(this.emnada);
            this.Imagem.Controls.Add(this.emamor);
            this.Imagem.Controls.Add(this.empalha);
            this.Imagem.Controls.Add(this.emrisos);
            this.Imagem.Controls.Add(this.emfeliz);
            this.Imagem.Controls.Add(this.emfofo);
            this.Imagem.Location = new System.Drawing.Point(25, 132);
            this.Imagem.Name = "Imagem";
            this.Imagem.Size = new System.Drawing.Size(403, 49);
            this.Imagem.TabIndex = 2;
            this.Imagem.TabStop = false;
            this.Imagem.Text = "Imagem";
            // 
            // empalha
            // 
            this.empalha.AutoSize = true;
            this.empalha.Location = new System.Drawing.Point(182, 21);
            this.empalha.Name = "empalha";
            this.empalha.Size = new System.Drawing.Size(64, 17);
            this.empalha.TabIndex = 11;
            this.empalha.TabStop = true;
            this.empalha.Text = "Palhaço";
            this.empalha.UseVisualStyleBackColor = true;
            this.empalha.CheckedChanged += new System.EventHandler(this.empalha_CheckedChanged);
            // 
            // emfeliz
            // 
            this.emfeliz.AutoSize = true;
            this.emfeliz.Location = new System.Drawing.Point(131, 21);
            this.emfeliz.Name = "emfeliz";
            this.emfeliz.Size = new System.Drawing.Size(46, 17);
            this.emfeliz.TabIndex = 10;
            this.emfeliz.TabStop = true;
            this.emfeliz.Text = "Feliz";
            this.emfeliz.UseVisualStyleBackColor = true;
            this.emfeliz.CheckedChanged += new System.EventHandler(this.emfeliz_CheckedChanged);
            // 
            // emrisos
            // 
            this.emrisos.AutoSize = true;
            this.emrisos.Location = new System.Drawing.Point(74, 21);
            this.emrisos.Name = "emrisos";
            this.emrisos.Size = new System.Drawing.Size(51, 17);
            this.emrisos.TabIndex = 9;
            this.emrisos.TabStop = true;
            this.emrisos.Text = "Risos";
            this.emrisos.UseVisualStyleBackColor = true;
            this.emrisos.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // emfofo
            // 
            this.emfofo.AutoSize = true;
            this.emfofo.Location = new System.Drawing.Point(22, 21);
            this.emfofo.Name = "emfofo";
            this.emfofo.Size = new System.Drawing.Size(46, 17);
            this.emfofo.TabIndex = 8;
            this.emfofo.TabStop = true;
            this.emfofo.Text = "Fofo";
            this.emfofo.UseVisualStyleBackColor = true;
            this.emfofo.CheckedChanged += new System.EventHandler(this.emfofo_CheckedChanged);
            // 
            // emamor
            // 
            this.emamor.AutoSize = true;
            this.emamor.Location = new System.Drawing.Point(252, 21);
            this.emamor.Name = "emamor";
            this.emamor.Size = new System.Drawing.Size(49, 17);
            this.emamor.TabIndex = 12;
            this.emamor.TabStop = true;
            this.emamor.Text = "Amor";
            this.emamor.UseVisualStyleBackColor = true;
            this.emamor.CheckedChanged += new System.EventHandler(this.emamor_CheckedChanged);
            // 
            // emnada
            // 
            this.emnada.AutoSize = true;
            this.emnada.Location = new System.Drawing.Point(307, 21);
            this.emnada.Name = "emnada";
            this.emnada.Size = new System.Drawing.Size(51, 17);
            this.emnada.TabIndex = 13;
            this.emnada.TabStop = true;
            this.emnada.Text = "Nada";
            this.emnada.UseVisualStyleBackColor = true;
            this.emnada.CheckedChanged += new System.EventHandler(this.emnada_CheckedChanged);
            // 
            // tema
            // 
            this.tema.Controls.Add(this.temaescuro);
            this.tema.Location = new System.Drawing.Point(25, 199);
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(403, 46);
            this.tema.TabIndex = 3;
            this.tema.TabStop = false;
            this.tema.Text = "Tema";
            // 
            // temaescuro
            // 
            this.temaescuro.AutoSize = true;
            this.temaescuro.Location = new System.Drawing.Point(143, 19);
            this.temaescuro.Name = "temaescuro";
            this.temaescuro.Size = new System.Drawing.Size(88, 17);
            this.temaescuro.TabIndex = 0;
            this.temaescuro.Text = "Tema escuro";
            this.temaescuro.UseVisualStyleBackColor = true;
            this.temaescuro.CheckedChanged += new System.EventHandler(this.temaescuro_CheckedChanged);
            // 
            // Texto
            // 
            this.Texto.Controls.Add(this.texto_conteudo);
            this.Texto.Controls.Add(this.label3);
            this.Texto.Location = new System.Drawing.Point(28, 257);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(399, 94);
            this.Texto.TabIndex = 4;
            this.Texto.TabStop = false;
            this.Texto.Text = "Texto da página";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Texto:";
            // 
            // texto_conteudo
            // 
            this.texto_conteudo.AllowDrop = true;
            this.texto_conteudo.Location = new System.Drawing.Point(11, 41);
            this.texto_conteudo.Name = "texto_conteudo";
            this.texto_conteudo.Size = new System.Drawing.Size(372, 20);
            this.texto_conteudo.TabIndex = 8;
            // 
            // botao_conteudo
            // 
            this.botao_conteudo.Location = new System.Drawing.Point(39, 324);
            this.botao_conteudo.Name = "botao_conteudo";
            this.botao_conteudo.Size = new System.Drawing.Size(372, 21);
            this.botao_conteudo.TabIndex = 8;
            this.botao_conteudo.Text = "Enviar";
            this.botao_conteudo.UseVisualStyleBackColor = true;
            this.botao_conteudo.Click += new System.EventHandler(this.botao_conteudo_Click);
            // 
            // texto_app
            // 
            this.texto_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_app.Location = new System.Drawing.Point(26, 114);
            this.texto_app.Name = "texto_app";
            this.texto_app.Size = new System.Drawing.Size(261, 288);
            this.texto_app.TabIndex = 2;
            this.texto_app.Text = "Seu texto";
            // 
            // Nome
            // 
            this.Nome.Controls.Add(this.button1);
            this.Nome.Controls.Add(this.visionname);
            this.Nome.Controls.Add(this.nome_box);
            this.Nome.Controls.Add(this.label4);
            this.Nome.Location = new System.Drawing.Point(28, 357);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(249, 74);
            this.Nome.TabIndex = 9;
            this.Nome.TabStop = false;
            this.Nome.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            // 
            // nome_box
            // 
            this.nome_box.Location = new System.Drawing.Point(13, 39);
            this.nome_box.Name = "nome_box";
            this.nome_box.Size = new System.Drawing.Size(122, 20);
            this.nome_box.TabIndex = 1;
            // 
            // visionname
            // 
            this.visionname.AutoSize = true;
            this.visionname.Location = new System.Drawing.Point(147, 16);
            this.visionname.Name = "visionname";
            this.visionname.Size = new System.Drawing.Size(96, 17);
            this.visionname.TabIndex = 2;
            this.visionname.Text = "Nome invisível";
            this.visionname.UseVisualStyleBackColor = true;
            this.visionname.CheckedChanged += new System.EventHandler(this.visionname_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nome_app
            // 
            this.nome_app.AutoSize = true;
            this.nome_app.Location = new System.Drawing.Point(21, 418);
            this.nome_app.Name = "nome_app";
            this.nome_app.Size = new System.Drawing.Size(55, 13);
            this.nome_app.TabIndex = 3;
            this.nome_app.Text = "Seu nome";
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(296, 365);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(131, 66);
            this.sair.TabIndex = 8;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.tela_aplicativo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tela_aplicativo.ResumeLayout(false);
            this.tela_aplicativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.controls.ResumeLayout(false);
            this.Título.ResumeLayout(false);
            this.Título.PerformLayout();
            this.Imagem.ResumeLayout(false);
            this.Imagem.PerformLayout();
            this.tema.ResumeLayout(false);
            this.tema.PerformLayout();
            this.Texto.ResumeLayout(false);
            this.Texto.PerformLayout();
            this.Nome.ResumeLayout(false);
            this.Nome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tela_aplicativo;
        private System.Windows.Forms.Label titulo_app;
        private System.Windows.Forms.GroupBox controls;
        private System.Windows.Forms.GroupBox Título;
        private System.Windows.Forms.RadioButton butazul;
        private System.Windows.Forms.RadioButton butbranco;
        private System.Windows.Forms.RadioButton butpreto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textotitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enviartitulo;
        private System.Windows.Forms.RadioButton butamarelo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox Imagem;
        private System.Windows.Forms.RadioButton empalha;
        private System.Windows.Forms.RadioButton emrisos;
        private System.Windows.Forms.RadioButton emfeliz;
        private System.Windows.Forms.RadioButton emfofo;
        private System.Windows.Forms.RadioButton emnada;
        private System.Windows.Forms.RadioButton emamor;
        private System.Windows.Forms.GroupBox tema;
        private System.Windows.Forms.CheckBox temaescuro;
        private System.Windows.Forms.GroupBox Texto;
        private System.Windows.Forms.TextBox texto_conteudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label texto_app;
        private System.Windows.Forms.Button botao_conteudo;
        private System.Windows.Forms.Label nome_app;
        private System.Windows.Forms.GroupBox Nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox visionname;
        private System.Windows.Forms.TextBox nome_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sair;
    }
}

