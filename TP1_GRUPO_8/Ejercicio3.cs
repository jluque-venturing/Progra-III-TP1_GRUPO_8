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



      
    }
}
