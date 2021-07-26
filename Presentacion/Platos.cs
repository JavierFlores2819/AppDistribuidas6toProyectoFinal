using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class Platos : Form
    {

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
            List<EntidadIngredientes> a = NegocioIngredientes.CargarIngredientesNegocio();
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
            guardar();
        }

        private void guardar()
        {
            if (imgPlato.Image != null)
            {
                System.IO.MemoryStream m = new System.IO.MemoryStream();
                imgPlato.Image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);

                if (labelPlato.Text == "Sopa")
                {
                    EntidadSopa s = new EntidadSopa();
                    s.NOM_SOP = textBoxNombrePlato.Text;
                    s.IMG_SOPA = m.GetBuffer();
                    int b = NegocioSopa.NuevaSopaNegocio(s);
                    int a;
                    foreach (var item in checkedListBoxIngrediente.CheckedIndices)
                    {
                        a = int.Parse(item.ToString()) + 1;
                        EntidadDetalleSopa es = new EntidadDetalleSopa();
                        es.ID_ING_USA = a;
                        es.ID_REC_PER = b;
                        Boolean c = NegocioDetalleSopa.NuevoDetalleSopaNegocio(es);
                    }
                }
                else if (labelPlato.Text == "Segundo")
                {
                    EntidadSegundo s = new EntidadSegundo();
                    s.NOM_SEG = textBoxNombrePlato.Text;
                    s.IMG_Segundo = m.GetBuffer();
                    int b = NegocioSegundo.NuevSegundoNegocio(s);
                    int a;
                    foreach (var item in checkedListBoxIngrediente.CheckedIndices)
                    {
                        a = int.Parse(item.ToString()) + 1;
                        EntidadDetalleSegundo es = new EntidadDetalleSegundo();
                        es.ID_ING_USA = a;
                        es.ID_REC_PER = b;
                        Boolean c = NegocioDetalleSegundo.NuevoDetalleSegundoNegocio(es);
                    }
                }
                else if (labelPlato.Text == "Bebida")
                {
                    EntidadBebida s = new EntidadBebida();
                    s.NOM_BEB = textBoxNombrePlato.Text;
                    s.IMG_BEBIDA = m.GetBuffer();
                    int b = NegocioBebida.NuevoBebidaNegocio(s);
                    int a;
                    foreach (var item in checkedListBoxIngrediente.CheckedIndices)
                    {
                        a = int.Parse(item.ToString()) + 1;
                        EntidadDetalleBebida es = new EntidadDetalleBebida();
                        es.ID_ING_USA = a;
                        es.ID_REC_PER = b;
                        Boolean c = NegocioDetalleBebida.NuevoDetalleBebidaNegocio(es);
                    }
                }
                else if (labelPlato.Text == "Postre")
                {
                    EntidadPostre s = new EntidadPostre();
                    s.NOM_POS = textBoxNombrePlato.Text;
                    s.IMG_POSTRE = m.GetBuffer();
                    int b = NegocioPostre.NuevoPostreNegocio(s);
                    int a;
                    foreach (var item in checkedListBoxIngrediente.CheckedIndices)
                    {
                        a = int.Parse(item.ToString()) + 1;
                        EntidadDetallePostre es = new EntidadDetallePostre();
                        es.ID_ING_USA = a;
                        es.ID_REC_PER = b;
                        Boolean c = NegocioDetallePostre.NuevoDetallePostreNegocio(es);
                    }

                }
                MessageBox.Show("se guardo correctamente", "hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
