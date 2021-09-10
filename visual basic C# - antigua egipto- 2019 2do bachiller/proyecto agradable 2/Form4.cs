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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Cambio = new Form2();
            Cambio.Show();
            Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            float sum, a, b;

            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);

            sum = a + b;


            textBox3.Text = Convert.ToString(sum);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            float  rest, a, b;

            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);

            
            rest = a - b;
         

       
            textBox3.Text = Convert.ToString(rest);
     
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            float mult, a, b;

            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);

            mult = a * b;
          
      
            textBox3.Text = Convert.ToString(mult);
         
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            float divi, a, b;

            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);

            divi = a / b;


            textBox3.Text = Convert.ToString(divi);

        }
    }
}
