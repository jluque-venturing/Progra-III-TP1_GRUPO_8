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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
