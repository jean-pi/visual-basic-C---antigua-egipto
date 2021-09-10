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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usua;
            int clav;

            usua = Convert.ToString(textBox1.Text);
            clav = int.Parse(textBox2.Text);
            if (usua == "jeanpierre" && clav == 16)
            {
                progressBar1.Value = 100;
                MessageBox.Show("clave correcta");

                Form2 Cambio = new Form2();
                Cambio.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("clave incorrecta");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
