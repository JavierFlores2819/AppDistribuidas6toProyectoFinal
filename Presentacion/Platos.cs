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
    public partial class Platos : Form
    {
        ServiciowsSoapClient ws = new ServiciowsSoapClient();
        public Platos()
        {
            InitializeComponent();
        }



        private void buttonIngredientes_Click(object sender, EventArgs e)
        {
            Ingredientes a = new Ingredientes();
            a.Show();
            this.Hide();
            a.FormClosed += new FormClosedEventHandler(form_FormClosed);
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            checkedListBoxIngrediente.Items.Clear();
            llenarCheckBox();

        }

        public void llenarCheckBox()
        {
            List<EntidadIngredientes> a = ws.ServicioCargarIngredientes();
            foreach (var item in a)
            {
                checkedListBoxIngrediente.Items.Add(item.NOM_ING);
            }

        }



        private void Platos_Load(object sender, EventArgs e)
        {
            llenarCheckBox();
        }


        private void imgPlato_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            DialogResult d = o.ShowDialog();
            if (d == DialogResult.OK)
            {
                imgPlato.Image = Image.FromFile(o.FileName);
            }
        }

        private void buttonGuarPla_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("Compruebe que el campo plato e imagen no esten vacíos y halla seleccionado como mínimo 1 ingrediente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show("¿DESEA REGISTRAR EL PLATO?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    guardar();
                    this.Close();
                }
            }

        }
        private Boolean validarDatos()
        {
            string a = textBoxNombrePlato.Text;

            if (!Regex.IsMatch(a ?? "", @"^[A-Za-z0-9][A-Za-z0-9\s]*[A-Za-z0-9]|[A-Za-z0-9]") || imgPlato.Image == null || textBoxNombrePlato.Text == "" || checkedListBoxIngrediente.CheckedItems.Count <= 0)
            {
                return false;
            }
            return true;
        }

        private void guardar()
        {
            System.IO.MemoryStream m = new System.IO.MemoryStream();
            imgPlato.Image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);

            if (labelPlato.Text == "Sopa")
            {
                EntidadSopa s = new EntidadSopa();
                s.NOM_SOP = textBoxNombrePlato.Text.ToUpper();
                s.IMG_SOPA = m.GetBuffer();
                int b = ws.ServicioNuevaSopa(s);
                int a;
                foreach (var item in checkedListBoxIngrediente.CheckedIndices)
                {
                    a = int.Parse(item.ToString()) + 1;
                    EntidadDetalleSopa es = new EntidadDetalleSopa();
                    es.ID_ING_USA = a;
                    es.ID_REC_PER = b;
                    Boolean c = ws.ServicioNuevoDetalleSopa(es);
                }
            }
            else if (labelPlato.Text == "Segundo")
            {
                EntidadSegundo s = new EntidadSegundo();
                s.NOM_SEG = textBoxNombrePlato.Text.ToUpper();
                s.IMG_Segundo = m.GetBuffer();
                int b = ws.ServicioNuevoSegundo(s);
                int a;
                foreach (var item in checkedListBoxIngrediente.CheckedIndices)
                {
                    a = int.Parse(item.ToString()) + 1;
                    EntidadDetalleSegundo es = new EntidadDetalleSegundo();
                    es.ID_ING_USA = a;
                    es.ID_REC_PER = b;
                    Boolean c = ws.ServicioNuevoDetalleSegundo(es);
                }
            }
            else if (labelPlato.Text == "Bebida")
            {
                EntidadBebida s = new EntidadBebida();
                s.NOM_BEB = textBoxNombrePlato.Text.ToUpper();
                s.IMG_BEBIDA = m.GetBuffer();
                int b = ws.ServicioNuevoBebida(s);
                int a;
                foreach (var item in checkedListBoxIngrediente.CheckedIndices)
                {
                    a = int.Parse(item.ToString()) + 1;
                    EntidadDetalleBebida es = new EntidadDetalleBebida();
                    es.ID_ING_USA = a;
                    es.ID_REC_PER = b;
                    Boolean c = ws.ServicioNuevoDetalleBebida(es);
                }
            }
            else if (labelPlato.Text == "Postre")
            {
                EntidadPostre s = new EntidadPostre();
                s.NOM_POS = textBoxNombrePlato.Text.ToUpper();
                s.IMG_POSTRE = m.GetBuffer();
                int b = ws.ServiciosNuevoPostre(s);
                int a;
                foreach (var item in checkedListBoxIngrediente.CheckedIndices)
                {
                    a = int.Parse(item.ToString()) + 1;
                    EntidadDetallePostre es = new EntidadDetallePostre();
                    es.ID_ING_USA = a;
                    es.ID_REC_PER = b;
                    Boolean c = ws.ServicioNuevoDetallePostre(es);
                }

            }
            MessageBox.Show("se guardo correctamente", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information);



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

        private void textBoxNombrePlato_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlLetras(e);
        }

        private void buttonCancelP_Click(object sender, EventArgs e)
        {
            textBoxNombrePlato.ResetText();
            imgPlato.Image = null;
            checkedListBoxIngrediente.Items.Clear();
            llenarCheckBox();

        }
    }
}
