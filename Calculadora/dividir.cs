using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacion
{
    public partial class dividir : Form
    {
        public dividir()
        {
            InitializeComponent();
        }

        private void Bttsumar_Click(object sender, EventArgs e)
        {

            int numero1;
            int numero2;
            int resultado;

            numero1 = System.Convert.ToInt32(textBox1.Text);
            numero2 = System.Convert.ToInt32(textBox2.Text);

            if (numero2!=0)
            {
                resultado = numero1 / numero2;
                LblResultado.Text = System.Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Error, no se puede dividir un numero entre cero");
            }
            

            
        }

        private void Bttlimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            LblResultado.Text = string.Empty;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bttlimpiar_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            LblResultado.Text = string.Empty;
        }
    }
}
