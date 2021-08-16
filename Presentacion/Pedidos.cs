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

namespace Presentacion
{
    public partial class Pedidos : Form
    {

        string a;
       ServiciowsSoapClient ws = new ServiciowsSoapClient();
        public Pedidos(string id)
        {
            InitializeComponent();
          a = id;
           
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            cargarDatos(a);
        }

        private void cargarDatos(string id)
        {
            dataGridView1.DataSource = ws.ServicioCargarPedidos(id);
            dataGridView1.Columns[0].HeaderText = "#";
            dataGridView1.Columns[1].HeaderText = "CLIENTE";
            dataGridView1.Columns[2].HeaderText = "MENU";
            dataGridView1.Columns[3].HeaderText = "CANTIDAD";
        }

        private void timerData_Tick(object sender, EventArgs e)
        {
            cargarDatos(a);
        }
    }
}
