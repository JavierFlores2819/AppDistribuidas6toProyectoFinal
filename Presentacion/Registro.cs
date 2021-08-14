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
    public partial class Registro : Form
    {
        ServiciowsSoapClient ws = new ServiciowsSoapClient();
        public Registro()
        {
            InitializeComponent();
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

        private void crearMenu()
        {
            if (validarDatos())
            {
                EntidadMenu m = new EntidadMenu();
                m.CANTIDAD = 0;
                m.ID_BEB_MEN = int.Parse(comboBoxBebida.Text);
                m.ID_POS_MEN = int.Parse(comboBoxPostre.Text);
                m.ID_SEG_MEN = int.Parse(comboBoxSegundo.Text);
                m.ID_SOP_MEN = int.Parse(comboBoxSopa.Text);
                m.FECHA_MEN = DateTime.Parse(dateTimePickerFecha.Value.ToShortDateString());
                ws.ServiciosNuevoMenu(m);
                MessageBox.Show("hecho");
                this.Close();
            }

        }
        private Boolean validarDatos()
        {
            if (comboBoxSopa.SelectedIndex != 0 && comboBoxSegundo.SelectedIndex != 0
                && comboBoxBebida.SelectedIndex != 0 && comboBoxPostre.SelectedIndex != 0)
            {

            }
            MessageBox.Show("selecione un valor", "hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            llenarComboBebida();
            llenarComboPostre();
            llenarComboSegundo();
            llenarComboSopa();
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

        private void buttonCancelReg_Click(object sender, EventArgs e)
        {
            comboBoxSopa.SelectedIndex = 0;
            comboBoxSegundo.SelectedIndex = 0;
            comboBoxBebida.SelectedIndex = 0;
            comboBoxPostre.SelectedIndex = 0;
            dateTimePickerFecha.Refresh();
        }

        private void comboBoxPostre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int a = comboBoxPostre.SelectedIndex;
            string b = ws.ServicioDetallePostreObtenerIngredientes(a);
            textBoxPostreIngrediente.Text = $"POSTRE/ENTRADA: {b} {Environment.NewLine}";
        }

        private void comboBoxSopa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int a = comboBoxSopa.SelectedIndex;
            string b = ws.ServicioDetalleSopaObtenerIngredientes(a);
            textBoxSopaIngrediente.Text = $"SOPA: {b} {Environment.NewLine }";
        }

        private void comboBoxBebida_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int a = comboBoxBebida.SelectedIndex;
            string b = ws.ServicioDetalleBebidaObtenerIngredientes(a);
            textBoxBebidaIngrediente.Text = $"BEBIDA: {b} {Environment.NewLine }";
        }

        private void comboBoxSegundo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int a = comboBoxSegundo.SelectedIndex;
            string b = ws.ServicioDetalleSegundoObtenerIngredientes(a);
            textBoxSegundoIngrediente.Text = $"SEGUNDO: {b} { Environment.NewLine }";
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFecha.Value.Day < DateTime.Now.Day || dateTimePickerFecha.Value > DateTime.Now.AddDays(3))
            {
                MessageBox.Show("Por favor seleccione una fecha entre el dia de hoy o 3 dias como maximo", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerFecha.ResetText();
            }
        }
    }
}
