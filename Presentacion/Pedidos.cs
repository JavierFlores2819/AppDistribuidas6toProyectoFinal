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
       

        ServiciowsSoapClient ws = new ServiciowsSoapClient();
        public Pedidos(string id)
        {
            InitializeComponent();
            cargarDatos(id);
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarDatos(string id)
        {
            dataGridView1.DataSource = ws.ServicioCargarPedidos(id);
        }
    }
}
