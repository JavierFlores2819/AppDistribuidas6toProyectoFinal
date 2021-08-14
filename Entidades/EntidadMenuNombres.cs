using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class EntidadMenuNombres
    {
        public int CANTIDAD { get; set; }
        public int ID_MEN { get; set; }
        public String NOM_SOP_MEN { get; set; }
        public String NOM_SEG_MEN { get; set; }
        public String NOM_BEB_MEN { get; set; }
        public String NOM_POS_MEN { get; set; }
        public DateTime FECHA_MEN { get; set; }

        public EntidadMenuNombres()
        {
        }

        public EntidadMenuNombres(int cANTIDAD ,int iD_MEN, String nOM_SOP_MEN, String nOM_SEG_MEN, String nOM_BEB_MEN, String nOM_POS_MEN, DateTime fECHA_MEN)
        {
            ID_MEN = iD_MEN;
            NOM_SOP_MEN = nOM_SOP_MEN;
            NOM_SEG_MEN = nOM_SEG_MEN;
            NOM_BEB_MEN = nOM_BEB_MEN;
            NOM_POS_MEN = nOM_POS_MEN;
            FECHA_MEN = fECHA_MEN;
            CANTIDAD = cANTIDAD;
        }
    }
}
