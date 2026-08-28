using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_8
{
    public partial class Ejercicio3 : Form
    {
        Index index;
        public Ejercicio3(Index index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void Ejercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            index.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        { // Validamos que el usuario haya seleccionado un sexo y un estado civil
            if ((genderMasc.Checked || genderFem.Checked) && (radioButton1.Checked || radioButton2.Checked))
            { //en la siguiente hacemos la salida y hacemos las verificaciones de las seleciones en las cajas
                string salida = "Usted seleccionó los siguientes elementos:\r\n";
                salida += "Sexo: " + (string)(genderMasc.Checked ? "Masculino" : "Femenino") + "\r\n";
                salida += "Estado Civil: " + (string)(radioButton1.Checked ? "Casado" : "Soltero") + "\r\n";

                salida += "Oficios:\r\n";

               foreach (string item in checkListCargo.CheckedItems) //Recorro los items de la lista seleccionados
                {
                    salida += " - " + item.ToString() + "\r\n"; //Muestra los oficios seleccionados uno a uno

                }

                label_mostrar.Text = salida;
            }
            else //este else es por si no se eligio nada
            {

              label_mostrar.Text = "";

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
