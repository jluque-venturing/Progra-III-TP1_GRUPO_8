using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_8
{
    public partial class Ejercicio2 : Form
    {
        Index index;
        public Ejercicio2(Index index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            index.Show();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim(); // La explicacion esta en button1
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void lblApellido_Click(object sender, EventArgs e)
        {
            string apellido = textBox2.Text.Trim(); // La explicacion esta en button1
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Eliminamos los espacios en blanco al inicio y al final de los nombres y apellidos
            string nombre = textBox1.Text.Trim();
            string apellido = textBox2.Text.Trim();

            // Agregamos el nombre y apellido a la lista
            listBox1.Items.Add(nombre + " " + apellido);
        }
    }
}
