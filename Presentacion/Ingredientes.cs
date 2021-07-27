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
    public partial class Ingredientes : Form
    {
        ServiciowsSoapClient ws = new ServiciowsSoapClient();
        public Ingredientes()
        {
            InitializeComponent();

        }

        private void cargar()
        {
            dataGridViewIngredeintes.DataSource = ws.ServicioCargarIngredientes();
        }
        private void buttonGuardarIngrediente_Click(object sender, EventArgs e)
        {
            if (guardarIngrediente())
            {
                cargar();
                MessageBox.Show("Se guardo correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                cargar();
                MessageBox.Show("No se pudo guardar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private Boolean guardarIngrediente()
        {
            EntidadIngredientes a = new EntidadIngredientes();
            a.NOM_ING = textBox1.Text;
            return ws.ServicioNuevoIngrediente(a);
        }

        private void buttonCnacelarIngrediente_Click(object sender, EventArgs e)
        {

        }

        private void Ingredientes_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
