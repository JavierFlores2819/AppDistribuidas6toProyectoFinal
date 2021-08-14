using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadPedido
    {
        public int ID_PED { get; set; }
        public string CLI_PED { get; set; }
        public int MENU_PED { get; set; }
        public int CANT_PED { get; set; }

        public EntidadPedido()
        {
        }

        public EntidadPedido(int iD_PED, string cLI_PED, int mENU_PED, int cANT_PED)
        {
            ID_PED = iD_PED;
            CLI_PED = cLI_PED;
            MENU_PED = mENU_PED;
            CANT_PED = cANT_PED;
        }

    }
}
