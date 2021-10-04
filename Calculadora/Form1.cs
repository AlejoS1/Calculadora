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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BttMultiplicar_Click(object sender, EventArgs e)

        {
            listBox1.Items.Clear();
            int tabla = int.Parse(textBox1.Text);
            int limite = int.Parse(textBox2.Text);
            int resultado;

            for (int i = 1; i <= limite; i++)
            {
                resultado = tabla * i;
                listBox1.Items.Add(tabla + "x" + i + "=" + resultado);

                
                
                     
            }
        }

        private void Bttlimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            
        }

        private void Bttsumar_Click(object sender, EventArgs e)
        {
            sumador nuevoformulario = new sumador();
            nuevoformulario.Show();
            


        }
    }
}
