namespace Algoritmos_Graficacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormDDA formDDA = new FormDDA();
            formDDA.Show();
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBresenham FormBresenham = new FormBresenham();
            FormBresenham.Show();
        }

        private void incrementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIncremento FormIncremento = new FormIncremento();
            FormIncremento.Show();
        }

        private void octantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPuntoMedio FormPuntoMedio = new FormPuntoMedio();
            FormPuntoMedio.Show();
        }

        private void bresenhamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBresenhamCirculos formBresenhamCirculos = new FormBresenhamCirculos();
            formBresenhamCirculos.Show();
        }

        private void parametricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametrico formParametrico = new FormParametrico();
            formParametrico.Show();
        }

        private void cohenShuterlandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCohenSutherland formCohenSutherland = new FormCohenSutherland();
            formCohenSutherland.Show();
        }

        private void puntoMedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPuntoMedioRecorte formPuntoMedioRecorte = new FormPuntoMedioRecorte();
            formPuntoMedioRecorte.Show();
        }

        private void liangBarskyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLiangBarsky formLiangBarsky = new FormLiangBarsky();
            formLiangBarsky.Show();
        }

        private void shuterlandHodgmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSutherlandHodgman formSutherlandHodgman = new FormSutherlandHodgman();
            formSutherlandHodgman.Show();
        }
    }
}
