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
    public partial class Ejercicio1 : Form
    {
        Index index;
        public Ejercicio1(Index index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void Ejercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            index.Show();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtenemos lo escrito en el textBox.
            // Trim es para eliminar los espacios del principio y el final
            string nombre = textBox1.Text.Trim();

            // Comprobamos que el campo no este vacio.
            if (nombre == "")
            {
                // Mensaje para pedirle al usuario que ingrese su nombre.
                // Al escribir se reemplaza por lo que ingrese el usuario.
                MessageBox.Show(" Ingresa tu nombre ");
                return; ///CORRECCION 
            }

            bool estaRepetido = false;

            foreach (string nombre_Guardado in listNombre1.Items) //Recorro lo que se haya ingresado en la lista
            {
                if (nombre_Guardado.ToString().ToUpper() == nombre.ToUpper()) //Cambio el nombre a todo alfabetico y paso ambos nombres a mayusculas
                {
                    estaRepetido = true;
                    break; //Una vez encuentra el repetido, frena el ciclo

                }
            }

            if (estaRepetido)
            {
                MessageBox.Show("Este nombre ya se encuentra en la lista");
            }
            else
            {
                // Agregamos el nombre del usuario a la lista. 
                listNombre1.Items.Add(nombre);

                // Limpiamos el campo de texto
                textBox1.Clear();

                // Volvemos al poner el cursor en el campo de texto 
                textBox1.Focus();

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void redirect_Click(object sender, EventArgs e)
        {
            if (listNombre1.SelectedItem != null)
            {
                listNombre2.Items.Add(listNombre1.SelectedItem);
                listNombre1.Items.Remove(listNombre1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nombre de la lista.",
                                    "Atención",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }
    }
    }