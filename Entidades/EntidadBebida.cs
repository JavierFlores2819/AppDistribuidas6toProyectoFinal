using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class EntidadBebida
    {
        public int ID_BEB { get; set; }
        public String NOM_BEB { get; set; }
        public Byte[] IMG_BEBIDA { get; set; }

        public EntidadBebida()
        {
        }

        public EntidadBebida(int iD_BEB, string nOM_BEB, byte[] iMG_BEBIDA)
        {
            ID_BEB = iD_BEB;
            NOM_BEB = nOM_BEB;
            IMG_BEBIDA = iMG_BEBIDA;
        }
    }
}
