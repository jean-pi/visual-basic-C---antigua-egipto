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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Cambio = new Form2();
            Cambio.Show();
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form13 Cambio = new Form13();
            Cambio.Show();
            Hide();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Form14 Cambio = new Form14();
            Cambio.Show();
            Hide();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Form15 Cambio = new Form15();
            Cambio.Show();
            Hide();
        }
    }
}
