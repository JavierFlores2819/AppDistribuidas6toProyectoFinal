using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.ServiciosWSLP;

namespace Presentacion
{
    public partial class Registro : Form
    {
        ServiciowsSoapClient ws = new ServiciowsSoapClient();
        public Registro()
        {
            InitializeComponent();
            llenarComboBebida();
            llenarComboPostre();
            llenarComboSegundo();
            llenarComboSopa();
        }

        private void buttonSopa_Click(object sender, EventArgs e)
        {

            Platos a = new Platos();
            a.labelPlato.Text = "Sopa";
            a.Show();
            this.Hide();
            a.FormClosed += new FormClosedEventHandler(form_FormClosed);
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            llenarComboBebida();
            llenarComboPostre();
            llenarComboSegundo();
            llenarComboSopa();
            this.Show();
        }
        private void buttonCancelReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSegund_Click(object sender, EventArgs e)
        {
            Platos a = new Platos();
            a.labelPlato.Text = "Segundo";
            a.Show();
            this.Hide();
            a.FormClosed += new FormClosedEventHandler(form_FormClosed);
        }

        private void buttonBebida_Click(object sender, EventArgs e)
        {
            Platos a = new Platos();
            a.labelPlato.Text = "Bebida";
            a.Show();
            this.Hide();
            a.FormClosed += new FormClosedEventHandler(form_FormClosed);
        }

        private void buttonPostre_Click(object sender, EventArgs e)
        {
            Platos a = new Platos();
            a.labelPlato.Text = "Postre";
            a.Show();
            this.Hide();
            a.FormClosed += new FormClosedEventHandler(form_FormClosed);
        }

        private void buttonRegistra_Click(object sender, EventArgs e)
        {
            crearMenu();

        }
        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePickerFecha.Value.Day < DateTime.Now.Day || dateTimePickerFecha.Value.Day > DateTime.Now.AddDays(3).Day)
            {
                MessageBox.Show("Seleccione una fecha entre hoy y 3 dias como máximo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerFecha.ResetText();
            }
        }

        private void comboBoxSopa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSopa.SelectedIndex > 0)
            {
                int a = comboBoxSopa.SelectedIndex;
                string b = ws.ServicioDetalleSopaObtenerIngredientes(a);
                textBoxSopaIngrediente.Text = $"SOPA: {b} {Environment.NewLine }";
            }
            else
            {
                textBoxSopaIngrediente.Text = "";
            }

        }

        private void comboBoxSegundo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSegundo.SelectedIndex > 0)
            {
                int a = comboBoxSegundo.SelectedIndex;
                string b = ws.ServicioDetalleSegundoObtenerIngredientes(a);
                textBoxSegundoIngrediente.Text = $"SEGUNDO: {b} { Environment.NewLine }";
            }
            else
            {
                textBoxSegundoIngrediente.Text = "";
            }

        }

        private void comboBoxBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBebida.SelectedIndex > 0)
            {
                int a = comboBoxBebida.SelectedIndex;
                string b = ws.ServicioDetalleBebidaObtenerIngredientes(a);
                textBoxBebidaIngrediente.Text = $"BEBIDA: {b} {Environment.NewLine }";
            }
            else
            {
                textBoxBebidaIngrediente.Text = "";
            }

        }

        private void comboBoxPostre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPostre.SelectedIndex > 0)
            {
                int a = comboBoxPostre.SelectedIndex;
                string b = ws.ServicioDetallePostreObtenerIngredientes(a);
                textBoxPostreIngrediente.Text = $"POSTRE/ENTRADA: {b} {Environment.NewLine}";
            }
            else
            {
                textBoxPostreIngrediente.Text = "";
            }

        }

        private void dateTimePickerFecha_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void crearMenu()
        {
            if (validarDatos())
            {
                DialogResult r = MessageBox.Show("¿DESEA REGISTRAR EL MENÚ?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    if (textBoxID.TextLength <= 0)
                    {
                        EntidadMenu m = new EntidadMenu();
                        m.FECHA_MEN = DateTime.Parse(dateTimePickerFecha.Value.ToShortDateString());

                        var a = ws.ServicioCargarMenuFecha(m.FECHA_MEN.ToShortDateString());
                        if (a.Count > 0)
                        {
                            MessageBox.Show("esta fecha ya tiene asignado un MENÚ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dateTimePickerFecha.ResetText();

                        }
                        else
                        {
                            m.CANTIDAD = 0;
                            m.ID_BEB_MEN = comboBoxBebida.SelectedIndex;
                            m.ID_POS_MEN = comboBoxPostre.SelectedIndex;
                            m.ID_SEG_MEN = comboBoxSegundo.SelectedIndex;
                            m.ID_SOP_MEN = comboBoxSopa.SelectedIndex;
                            ws.ServiciosNuevoMenu(m);
                            MessageBox.Show("Se completó satisfactoriamente", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        EntidadMenu m = new EntidadMenu();
                        m.ID_MEN = int.Parse(textBoxID.Text);
                        m.CANTIDAD = 0;
                        m.ID_BEB_MEN = comboBoxBebida.SelectedIndex;
                        m.ID_POS_MEN = comboBoxPostre.SelectedIndex;
                        m.ID_SEG_MEN = comboBoxSegundo.SelectedIndex;
                        m.ID_SOP_MEN = comboBoxSopa.SelectedIndex;
                        m.FECHA_MEN = DateTime.Now;
                        //cambiar entidad y servicio desde web
                        ws.ServicioModificarMenu(m);
                        MessageBox.Show("Se completo satisfactoriamente", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else if (r == DialogResult.Cancel)
                {
                    limpiarDatos();
                }
            }

        }

        public void llenarComboSopa()
        {
            comboBoxSopa.Items.Clear();
            comboBoxSopa.Items.Insert(0, "Seleccione un opción:");
            comboBoxSopa.SelectedIndex = 0;
            //llenarcombo sopa
            foreach (EntidadSopa i in ws.ServicioCargarSopa())
            {
                comboBoxSopa.Items.Insert(i.ID_SOP, i.NOM_SOP);
            }

        }
        private void llenarComboSegundo()
        {
            //llenar combo segundo

            comboBoxSegundo.Items.Clear();
            comboBoxSegundo.Items.Insert(0, "Seleccione un opción:");
            comboBoxSegundo.SelectedIndex = 0;
            foreach (EntidadSegundo i in ws.ServicioCargarSegundo())
            {
                comboBoxSegundo.Items.Insert(i.ID_SEG, i.NOM_SEG);
            }
        }
        private void llenarComboBebida()
        {
            //llenar combo bebida
            comboBoxBebida.Items.Clear();
            comboBoxBebida.Items.Insert(0, "Seleccione un opción:");
            comboBoxBebida.SelectedIndex = 0;
            foreach (EntidadBebida i in ws.ServicioCargarBebida())
            {
                comboBoxBebida.Items.Insert(i.ID_BEB, i.NOM_BEB);
            }
        }
        private void llenarComboPostre()
        {
            //llenar combo postre
            comboBoxPostre.Items.Clear();
            comboBoxPostre.Items.Insert(0, "Seleccione un opción:");
            comboBoxPostre.SelectedIndex = 0;
            foreach (EntidadPostre i in ws.ServicioCargarPostre())
            {
                comboBoxPostre.Items.Insert(i.ID_POS, i.NOM_POS);
            }
        }
        private void limpiarDatos()
        {
            comboBoxSopa.SelectedIndex = 0;
            comboBoxSegundo.SelectedIndex = 0;
            comboBoxBebida.SelectedIndex = 0;
            comboBoxPostre.SelectedIndex = 0;
            dateTimePickerFecha.Refresh();
        }
        private Boolean validarDatos()
        {
            if (comboBoxSopa.SelectedIndex == 0 || comboBoxSegundo.SelectedIndex == 0
                || comboBoxBebida.SelectedIndex == 0 || comboBoxPostre.SelectedIndex == 0)
            {
                MessageBox.Show("No puede enviar datos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
    }
}
