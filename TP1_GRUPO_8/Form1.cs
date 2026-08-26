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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1(this);
            ejercicio1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2(this);
            ejercicio2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3(this);
            ejercicio3.Show();
            this.Hide();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }
}
