﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encuesta Enviada ");
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 cambio = new Form2();
            cambio.Show();
            Hide();
        }
    }
}
