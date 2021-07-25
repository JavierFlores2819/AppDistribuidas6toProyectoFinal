using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class EntidadPostre
    {
        public int ID_POS { get; set; }
        public String NOM_POS { get; set; }
        public Byte[] IMG_POSTRE { get; set; }

        public EntidadPostre()
        {
        }

        public EntidadPostre(int iD_POS, string nOM_POS, byte[] iMG_POSTRE)
        {
            ID_POS = iD_POS;
            NOM_POS = nOM_POS;
            IMG_POSTRE = iMG_POSTRE;
        }
    }
}
