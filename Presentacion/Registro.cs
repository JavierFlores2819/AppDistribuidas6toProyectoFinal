﻿using System;
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
            llenarCombobox();
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
            EntidadMenu m = new EntidadMenu();
            m.ID_BEB_MEN = int.Parse(comboBoxBebida.SelectedValue.ToString());
            m.ID_POS_MEN = int.Parse(comboBoxPostre.SelectedValue.ToString());
            m.ID_SEG_MEN = int.Parse(comboBoxSegundo.SelectedValue.ToString());
            m.ID_SOP_MEN = int.Parse(comboBoxSopa.SelectedValue.ToString());
            m.FECHA_MEN = dateTimePickerFecha.Value;
            ws.ServiciosNuevoMenu(m);
            llenarCombobox();
            MessageBox.Show("hecho");
           
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            llenarCombobox();
        }

        private void llenarCombobox()
        {
            comboBoxSopa.DataSource = ws.ServicioCargarSopa();
            comboBoxSopa.DisplayMember = "NOM_SOP";
            comboBoxSopa.ValueMember = "ID_SOP";
            comboBoxSopa.Text = "Seleccione un opción:";
            comboBoxBebida.DataSource = ws.ServicioCargarBebida();
            comboBoxBebida.DisplayMember = "NOM_BEB";
            comboBoxBebida.ValueMember = "ID_BEB";
            comboBoxBebida.Text = "Seleccione un opción:";
            comboBoxPostre.DataSource = ws.ServicioCargarPostre();
            comboBoxPostre.DisplayMember = "NOM_POS";
            comboBoxPostre.ValueMember = "ID_POS";
            comboBoxPostre.Text = "Seleccione un opción:";
            comboBoxSegundo.DataSource = ws.ServicioCargarSegundo();
            comboBoxSegundo.DisplayMember = "NOM_SEG";
            comboBoxSegundo.ValueMember = "ID_SEG";
            comboBoxSegundo.Text = "Seleccione un opción:";
        }

        private void buttonCancelReg_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPostre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int a = int.Parse(comboBoxPostre.SelectedValue.ToString());
            textBoxPostreIngrediente.Text = $"POSTRE/ENTRADA: {ws.ServicioDetallePostreObtenerIngredientes(a)} {Environment.NewLine}";

        }

        private void comboBoxSopa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int b = int.Parse(comboBoxSopa.SelectedValue.ToString());
            textBoxSopaIngrediente.Text = $"SOPA: {ws.ServicioDetalleSopaObtenerIngredientes(b)} {Environment.NewLine }";

        }

        private void comboBoxBebida_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int c = int.Parse(comboBoxBebida.SelectedValue.ToString());
            textBoxBebidaIngrediente.Text = $"BEBIDA: {ws.ServicioDetalleBebidaObtenerIngredientes(c)} {Environment.NewLine }";

        }

        private void comboBoxSegundo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int d = int.Parse(comboBoxSegundo.SelectedValue.ToString());
            textBoxSegundoIngrediente.Text = $"SEGUNDO: {ws.ServicioDetalleSegundoObtenerIngredientes(d)} { Environment.NewLine }";

        }


    }
}
