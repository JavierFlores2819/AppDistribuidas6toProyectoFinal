using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.ServiciosR;
using Negocio;

namespace Presentacion
{
    public partial class PagPrinc : Form
    {
        ServiciowsSoapClient ws = new ServiciowsSoapClient();
        public PagPrinc()
        {
            InitializeComponent();
        }

        private void buttonRegisMenu_Click(object sender, EventArgs e)
        {

            Registro a = new Registro();
            a.Show();
            this.Hide();
            a.FormClosed += new FormClosedEventHandler(form_FormClosed);

        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarMenu();
            this.Show();
        }

        private void PagPrinc_Load(object sender, EventArgs e)
        {
           cargarMenu();
            cargarMenuF();
        }

        private void cargarMenuF()
        {
            dataGridView1.DataSource = ws.NegocioCargarMenuFecha("15/08/2021");
        }

        private void cargarMenu()
        {
            dataGridViewMenu.DataSource = ws.ServicioCargarMenu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
