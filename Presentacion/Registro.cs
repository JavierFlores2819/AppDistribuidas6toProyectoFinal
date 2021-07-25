using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void buttonSopa_Click(object sender, EventArgs e)
        {

            Platos a = new Platos();
            a.labelPlato.Text = "Sopa";
            a.Show();

        }

        private void buttonSegund_Click(object sender, EventArgs e)
        {
            Platos a = new Platos();
            a.labelPlato.Text = "Segundo";
            a.Show();

        }

        private void buttonBebida_Click(object sender, EventArgs e)
        {
            Platos a = new Platos();
            a.labelPlato.Text = "Bebida";
            a.Show();

        }

        private void buttonPostre_Click(object sender, EventArgs e)
        {
            Platos a = new Platos();
            a.labelPlato.Text = "Postre";
            a.Show();

        }
    }
}
