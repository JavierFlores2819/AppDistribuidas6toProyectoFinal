using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            dataGridViewIngredeintes.Columns[0].HeaderText = "#";
            dataGridViewIngredeintes.Columns[1].HeaderText = "NOMBRE";
        }
        private Boolean guardarIngrediente()
        {
            EntidadIngredientes a = new EntidadIngredientes();
            a.NOM_ING = textBox1.Text;
            return ws.ServicioNuevoIngrediente(a);
        }
        private void buttonGuardarIngrediente_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("No envie campos vacios o cadenas de espacios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show("¿DESEA REGISTRAR EL INGREDIENTE?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
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
            }
        }

        private void Ingredientes_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlLetras(e);
        }
        private Boolean validarDatos()
        {
            string a = textBox1.Text;
            if (!Regex.IsMatch(a ?? "", @"^[A-Za-z0-9][A-Za-z0-9\s]*[A-Za-z0-9]|[A-Za-z0-9]") || textBox1.Text == "")
            {
                return false;
            }
            return true;
        }
        private void ControlLetras(KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
                if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                DialogResult r = MessageBox.Show("¿DESEA ELIMINAR EL INGREDIENTE?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    if (ws.ServicioEliminarIngrediente(textBoxID.Text))
                    {
                        cargar();
                        MessageBox.Show("Se eliminó satisfactoriamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cargar();
                        MessageBox.Show("No se pudo eliminar este ingrediente pertenece a un plato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else {
                MessageBox.Show("Seleccione un ingrediente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void dataGridViewIngredeintes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxID.Text = dataGridViewIngredeintes.Rows[e.RowIndex].Cells["ID_ING"].Value.ToString();
            }
        }
    }
}
