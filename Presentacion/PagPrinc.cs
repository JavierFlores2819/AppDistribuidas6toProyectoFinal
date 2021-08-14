using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Presentacion.ServiciosR;


namespace Presentacion
{
    public partial class PagPrinc : Form
    {
        ServiciowsSoapClient ws = new ServiciowsSoapClient();
        List<ServiciosR.EntidadMenu> entidadMenuDatos = new List<ServiciosR.EntidadMenu>();
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
            List<EntidadMenuNombres> e = new List<EntidadMenuNombres>();
            entidadMenuDatos = ws.ServicioCargarMenu();
            
            dataGridViewMenu.DataSource =e;
            dataGridViewMenu.Columns[1].HeaderText = "DEMANDA";
            dataGridViewMenu.Columns[2].HeaderText = "ID";
            dataGridViewMenu.Columns[3].HeaderText = "SOPA";
            dataGridViewMenu.Columns[4].HeaderText = "SEGUNDO";
            dataGridViewMenu.Columns[5].HeaderText = "BEBIDA";
            dataGridViewMenu.Columns[6].HeaderText = "POSTRE";
            dataGridViewMenu.Columns[7].HeaderText = "FECHA";
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != 0)
            {
                var id = Convert.ToInt32(dataGridViewMenu.Rows[e.RowIndex].Cells["ID_MEN"].Value.ToString());
                MessageBox.Show(id.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var id =dataGridViewMenu.Rows[e.RowIndex].Cells["ID_MEN"].Value.ToString();
                Pedidos a = new Pedidos(id);
                a.Show();
                this.Hide();
                a.FormClosed += new FormClosedEventHandler(form_FormClosed);
            }

        }
    }
}
