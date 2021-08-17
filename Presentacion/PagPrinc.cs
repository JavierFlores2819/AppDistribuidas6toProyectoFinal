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
    public partial class PagPrinc : Form
    {
        ServiciowsSoapClient ws = new ServiciowsSoapClient();
        EntidadMenu menuA = new EntidadMenu();
        public PagPrinc()
        {
            InitializeComponent();
            dataGridViewMenu.Columns.Add(
            new DataGridViewButtonColumn()
            {
                HeaderText = "PEDIDOS",
                Text = "VER",
                UseColumnTextForButtonValue = true
            });
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
        }

        private void cargarMenu()
        {
            dataGridViewMenu.DataSource = ws.ServicioCargarMenu();
            dataGridViewMenu.Columns[1].HeaderText = "DEMANDA";
            dataGridViewMenu.Columns[2].HeaderText = "#";
            dataGridViewMenu.Columns[3].HeaderText = "SOPA";
            dataGridViewMenu.Columns[4].HeaderText = "SEGUNDO";
            dataGridViewMenu.Columns[5].HeaderText = "BEBIDA";
            dataGridViewMenu.Columns[6].HeaderText = "POSTRE";
            dataGridViewMenu.Columns[7].HeaderText = "FECHA";
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            modificarMenu();
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != 0)
            {
                var id = dataGridViewMenu.Rows[e.RowIndex].Cells["ID_MEN"].Value.ToString();
                textBoxID.Text = id;
            }
        }
        private void modificarMenu()
        {
            if (textBoxID.Text != "")
            {
                menuA = ws.ServicioObtenerMenuporId(int.Parse(textBoxID.Text));
                if (menuA.FECHA_MEN.Day <= DateTime.Now.Day)
                {
                    MessageBox.Show($"Menú con fecha {menuA.FECHA_MEN.ToShortDateString()}, no puede modificar menú del día de hoy o anteriores al dia de hoy.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Registro a = new Registro();
                    a.textBoxID.Text = textBoxID.Text;
                    a.comboBoxBebida.SelectedIndex = menuA.ID_BEB_MEN;
                    a.comboBoxSopa.SelectedIndex = menuA.ID_SOP_MEN;
                    a.comboBoxSegundo.SelectedIndex = menuA.ID_SEG_MEN;
                    a.comboBoxPostre.SelectedIndex = menuA.ID_POS_MEN;
                    a.dateTimePickerFecha.Value = menuA.FECHA_MEN;
                    a.dateTimePickerFecha.Enabled = false;
                    a.Show();
                    this.Hide();
                    a.FormClosed += new FormClosedEventHandler(form_FormClosed);
                }
            }
            else {
                MessageBox.Show("seleccione un menú", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var id = dataGridViewMenu.Rows[e.RowIndex].Cells["ID_MEN"].Value.ToString();
                Pedidos a = new Pedidos(id);
                a.Show();
                this.Hide();
                a.FormClosed += new FormClosedEventHandler(form_FormClosed);
            }

        }

        private void ActualizarData_Tick(object sender, EventArgs e)
        {
            cargarMenu();
        }
    }
}
