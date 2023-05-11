namespace JogoDaForca
{
    public partial class FormForca : Form
    {
        public char palpite = ' ';

        public Forca forca = new Forca();
        public FormForca()
        {
            InitializeComponent();

        }

        private void ObterPalpite(object sender, EventArgs e)
        {
            bool ganhou = false;

            if (sender is Button btn)
                palpite = Convert.ToChar(btn.Text);

            ganhou = forca.JogadorAcertou(palpite);

            trocarImagem();

            if (forca.JogadorPerdeu())
                Recomecar();

            if (ganhou)
                Recomecar();

            tbLetra.Text = forca.PalavraParcial;
        }

        private void Recomecar()
        {
            this.forca = new Forca();
            imagemForca.Image = Properties.Resources._5;
        }

        private void caixaPalavra_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagem_Click(object sender, EventArgs e)
        {


        }

        private void trocarImagem()
        {
            if (forca.Erros == 1)
                imagemForca.Image = Properties.Resources._1;

            else if (forca.Erros == 2)
                imagemForca.Image = Properties.Resources._2;

            else if (forca.Erros == 3)
                imagemForca.Image = Properties.Resources._3;

            else if (forca.Erros == 4)
                imagemForca.Image = Properties.Resources._4;

            else if (forca.Erros == 5)
                imagemForca.Image = Properties.Resources._7;
        }

        private void botaoReset_Click(object sender, EventArgs e)
        {
            Recomecar();
        }
    }

}