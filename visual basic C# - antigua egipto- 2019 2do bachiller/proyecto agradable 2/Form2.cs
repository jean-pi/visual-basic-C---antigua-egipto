using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_agradable_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Cambio = new Form1();
            Cambio.Show();
            Hide();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vorverAPortadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Cambio = new Form1();
            Cambio.Show();
            Hide();
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 Cambio = new Form8();
            Cambio.Show();
            Hide();
        }

        private void navegadorWedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Cambio = new Form3();
            Cambio.Show();
            Hide();
        }

        private void encuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sumaRestaMultiplicacionYDivicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Cambio = new Form4();
            Cambio.Show();
            Hide();
        }

        private void encuestaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 Cambio = new Form5();
            Cambio.Show();
            Hide();
        }

        private void losIniciosDeLaCivilizaciónEgipciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Cambio = new Form6();
            Cambio.Show();
            Hide();
        }

        private void periodoArcaicoc31002686ACToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void periodoHelenístico33230ACToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 
        }

        private void periodosDeLaHistoriaDeEgiptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 Cambio = new Form7();
            Cambio.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void escrituraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 Cambio = new Form9();
            Cambio.Show();
            Hide();
        }

        private void literaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 Cambio = new Form10();
            Cambio.Show();
            Hide();
        }

        private void predinasticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 Cambio = new Form11();
            Cambio.Show();
            Hide();
        }

        private void dinasticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 Cambio = new Form12();
            Cambio.Show();
            Hide();
        }
    }
}
