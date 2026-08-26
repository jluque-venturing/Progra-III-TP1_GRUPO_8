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

        private void button1_Click(object sender, EventArgs e)
        {
            // Eliminamos los espacios en blanco al inicio y al final de los nombres y apellidos
            string nombre = textBox1.Text.Trim();
            string apellido = textBox2.Text.Trim();
            
            if (nombre.Length == 0) // Validamos que el usuario haya cargado algo en el campo "nombre"
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            if (apellido.Length == 0) // Validamos que el usuario haya cargado algo en el campo "apellido"
            {
                MessageBox.Show("Debe ingresar un apellido");
                return;
            }
            foreach (string item in listBox1.Items) // Validamos que no hayan personas repetidas con o sin distinta indentación
            {
                if (item.ToString().ToLower() == (nombre + " " + apellido).ToLower())
                {
                    MessageBox.Show("Los datos de esa persona ya habían sido ingresados");
                    return;
                }
            }

            // Agregamos el nombre y apellido a la lista
            listBox1.Items.Add(nombre + " " + apellido);

            // Ordenamos la lista alfabéticamente
            listBox1.Sorted = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) //con esto verifico si hay elementos en la listbox
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); //removemos el elemento seleccionado usando el indice
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista para eliminarlo");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Boton para vaciar toda la lista.
            if (listBox1.Items.Count > 0) // Verificamos que haya elementos en la lista
            {
                listBox1.Items.Clear(); // Vaciamos la lista
            }
            else
            {
                MessageBox.Show("Ya se borraron todos los nombres de la lista");
            }
        }
        private void Ejercicio2_Load(object sender, EventArgs e)
        {
        }
    }
}
