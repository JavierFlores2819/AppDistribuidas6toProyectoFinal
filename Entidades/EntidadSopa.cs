using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadSopa
    {
        public int ID_SOP { get; set; }
        public String NOM_SOP { get; set; }
        public Byte[] IMG_SOPA { get; set; }
       
        public EntidadSopa()
        {
        }

        public EntidadSopa(int iD_SOP, string nOM_SOP, byte[] iMG_SOPA)
        {
            ID_SOP = iD_SOP;
            NOM_SOP = nOM_SOP;
            IMG_SOPA = iMG_SOPA;
        }
    }
}
