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
    public partial class sumador : Form
    {
        public sumador()
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
            resultado = numero1 + numero2;

            Lblresultado.Text = System.Convert.ToString(resultado);
        }

        private void Bttlimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            Lblresultado.Text = string.Empty;
        }

        private void Bttrestar_Click(object sender, EventArgs e)
        {
            restar nuevoformulario = new restar();
            nuevoformulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


   
       




















