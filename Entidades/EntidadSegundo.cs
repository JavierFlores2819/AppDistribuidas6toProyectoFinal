using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadSegundo
    {
        public int ID_SEG { get; set; }
        public String NOM_SEG { get; set; }
        public Byte[] IMG_Segundo { get; set; }

        public EntidadSegundo()
        { }

        public EntidadSegundo(int iD_SEG, string nOM_SEG, byte[] iMG_Segundo)
        {
            ID_SEG = iD_SEG;
            NOM_SEG = nOM_SEG;
            IMG_Segundo = iMG_Segundo;
        }
    }
}
