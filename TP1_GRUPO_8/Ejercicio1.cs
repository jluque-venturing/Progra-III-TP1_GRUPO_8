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
    }
}
