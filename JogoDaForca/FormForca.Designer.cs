namespace JogoDaForca
{
    partial class FormForca
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
            jogodaforca = new Label();
            label2 = new Label();
            btnComecar = new Button();
            btnTentar = new Button();
            tbLetra = new TextBox();
            lbErros = new Label();
            lbTentativas = new Label();
            lbPalavra = new Label();
            lbpalavrasecreta = new Label();
            labelErros = new Label();
            labelTentativas = new Label();
            imagemForca = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagemForca).BeginInit();
            SuspendLayout();
            // 
            // jogodaforca
            // 
            jogodaforca.AutoSize = true;
            jogodaforca.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            jogodaforca.ForeColor = Color.Bisque;
            jogodaforca.Location = new Point(278, 22);
            jogodaforca.Name = "jogodaforca";
            jogodaforca.Size = new Size(198, 33);
            jogodaforca.TabIndex = 0;
            jogodaforca.Text = "Jogo Da Forca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 169);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 2;
            label2.Text = "Digite uma Letra";
            // 
            // btnComecar
            // 
            btnComecar.Location = new Point(26, 125);
            btnComecar.Name = "btnComecar";
            btnComecar.Size = new Size(75, 23);
            btnComecar.TabIndex = 3;
            btnComecar.Text = "Começar";
            btnComecar.UseVisualStyleBackColor = true;
            // 
            // btnTentar
            // 
            btnTentar.Location = new Point(166, 208);
            btnTentar.Name = "btnTentar";
            btnTentar.Size = new Size(75, 23);
            btnTentar.TabIndex = 4;
            btnTentar.Text = "Tentar";
            btnTentar.UseVisualStyleBackColor = true;
            // 
            // tbLetra
            // 
            tbLetra.Location = new Point(26, 208);
            tbLetra.Name = "tbLetra";
            tbLetra.Size = new Size(111, 23);
            tbLetra.TabIndex = 6;
            // 
            // lbErros
            // 
            lbErros.AutoSize = true;
            lbErros.Location = new Point(26, 349);
            lbErros.Name = "lbErros";
            lbErros.Size = new Size(33, 15);
            lbErros.TabIndex = 7;
            lbErros.Text = "Erros";
            // 
            // lbTentativas
            // 
            lbTentativas.AutoSize = true;
            lbTentativas.Location = new Point(26, 316);
            lbTentativas.Name = "lbTentativas";
            lbTentativas.Size = new Size(59, 15);
            lbTentativas.TabIndex = 8;
            lbTentativas.Text = "Tentativas";
            // 
            // lbPalavra
            // 
            lbPalavra.AutoSize = true;
            lbPalavra.Location = new Point(26, 385);
            lbPalavra.Name = "lbPalavra";
            lbPalavra.Size = new Size(45, 15);
            lbPalavra.TabIndex = 9;
            lbPalavra.Text = "Palavra";
            // 
            // lbpalavrasecreta
            // 
            lbpalavrasecreta.AutoSize = true;
            lbpalavrasecreta.Location = new Point(77, 385);
            lbpalavrasecreta.Name = "lbpalavrasecreta";
            lbpalavrasecreta.Size = new Size(22, 15);
            lbpalavrasecreta.TabIndex = 10;
            lbpalavrasecreta.Text = "---";
            // 
            // labelErros
            // 
            labelErros.AutoSize = true;
            labelErros.Location = new Point(65, 349);
            labelErros.Name = "labelErros";
            labelErros.Size = new Size(13, 15);
            labelErros.TabIndex = 11;
            labelErros.Text = "0";
            // 
            // labelTentativas
            // 
            labelTentativas.AutoSize = true;
            labelTentativas.Location = new Point(95, 317);
            labelTentativas.Name = "labelTentativas";
            labelTentativas.Size = new Size(22, 15);
            labelTentativas.TabIndex = 12;
            labelTentativas.Text = "---";
            // 
            // imagemForca
            // 
            imagemForca.Image = Properties.Resources._7;
            imagemForca.Location = new Point(451, 91);
            imagemForca.Name = "imagemForca";
            imagemForca.Size = new Size(290, 385);
            imagemForca.SizeMode = PictureBoxSizeMode.Zoom;
            imagemForca.TabIndex = 30;
            imagemForca.TabStop = false;
            // 
            // FormForca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1059, 651);
            Controls.Add(imagemForca);
            Controls.Add(labelTentativas);
            Controls.Add(labelErros);
            Controls.Add(lbpalavrasecreta);
            Controls.Add(lbPalavra);
            Controls.Add(lbTentativas);
            Controls.Add(lbErros);
            Controls.Add(tbLetra);
            Controls.Add(btnTentar);
            Controls.Add(btnComecar);
            Controls.Add(label2);
            Controls.Add(jogodaforca);
            ForeColor = Color.Black;
            MinimumSize = new Size(1075, 690);
            Name = "FormForca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JogoForca";
            ((System.ComponentModel.ISupportInitialize)imagemForca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label jogodaforca;
        private Label label2;
        private Button btnComecar;
        private Button btnTentar;
        private TextBox tbLetra;
        private Label lbErros;
        private Label lbTentativas;
        private Label lbPalavra;
        private Label lbpalavrasecreta;
        private Label labelErros;
        private Label labelTentativas;
        private PictureBox imagemForca;
    }
}