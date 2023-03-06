namespace Usando_Classes___Aula_06._03
{
    public partial class frmCalculaMediaAluno : Form
    {
        public frmCalculaMediaAluno()
        {
            InitializeComponent();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            // instancie classe
            Aluno aluno = new Aluno();
            // atribui as propriedades
            aluno.Nome = txtNome.Text;
            aluno.RA = txtRA.Text;
            aluno.P1 = float.Parse(txtP1.Text);
            aluno.P2 = float.Parse(txtP2.Text);

            aluno.CalcularMedia();
            txtMediaSaida.Visible = true;
            lbMedia.Visible = true;

            txtMediaSaida.Text = aluno.Media.ToString();
        }

        private void frmCalculaMediaAluno_Load(object sender, EventArgs e)
        {
            txtMediaSaida.Visible = false;
            lbMedia.Visible = false;
        }
    }
}