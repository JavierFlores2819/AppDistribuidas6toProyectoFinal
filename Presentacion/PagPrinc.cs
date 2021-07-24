using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PagPrinc : Form
    {
        public PagPrinc()
        {
            InitializeComponent();
        }

        private void buttonRegisMenu_Click(object sender, EventArgs e)
        {
           
            Registro a = new Registro();
            a.Show();

        }
    }
}
