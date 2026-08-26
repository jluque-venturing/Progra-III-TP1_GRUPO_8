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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void genderMasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { // Validamos que el usuario haya seleccionado un sexo y un estado civil
            if ((genderMasc.Checked || genderFem.Checked) && (radioButton1.Checked || radioButton2.Checked))
            { //en la siguiente hacemos la salida y hacemos las verificaciones de las seleciones en las cajas
                string salida = "Usted seleccionó los siguientes elementos:\r\n";
                salida += "Sexo: " + (string)(genderMasc.Checked ? "Masculino" : "Femenino") + "\r\n";
                salida += "Estado Civil: " + (string)(radioButton1.Checked ? "Casado" : "Soltero") + "\r\n";

                ñ.Text = salida;
            }
            else //este else es por si no se eligio nada
            {

              ñ.Text = "";

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
