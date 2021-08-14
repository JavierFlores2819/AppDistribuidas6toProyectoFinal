using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadMenuAndroid
    {   public int ID_MEN { get; set; }

        public int ID_SOP_MEN { get; set; }
        public String NOM_SOP_MEN { get; set; }
        public Byte[] IMG_SOP_MEN { get; set; }

        public int ID_SEG_MEN { get; set; }
        public String NOM_SEG_MEN { get; set; }
        public Byte[] IMG_SEG_MEN { get; set; }

        public int ID_BEB_MEN { get; set; }
        public String NOM_BEB_MEN { get; set; }
        public Byte[] IMG_BEB_MEN { get; set; }

        public int ID_POS_MEN { get; set; }
        public String NOM_POS_MEN { get; set; }
        public Byte[] IMG_POS_MEN { get; set; }

        public string INGREDIENTES { get; set; }
        public DateTime FECHA_MEN { get; set; }

        public EntidadMenuAndroid()
        {
        }

        public EntidadMenuAndroid(int iD_MEN, int iD_SOP_MEN, string nOM_SOP_MEN, byte[] iMG_SOP_MEN, int iD_SEG_MEN, string nOM_SEG_MEN, byte[] iMG_SEG_MEN, int iD_BEB_MEN, string nOM_BEB_MEN, byte[] iMG_BEB_MEN, int iD_POS_MEN, string nOM_POS_MEN, byte[] iMG_POS_MEN, string iNGREDIENTES, DateTime fECHA_MEN)
        {
            ID_MEN = iD_MEN;
            ID_SOP_MEN = iD_SOP_MEN;
            NOM_SOP_MEN = nOM_SOP_MEN;
            IMG_SOP_MEN = iMG_SOP_MEN;
            ID_SEG_MEN = iD_SEG_MEN;
            NOM_SEG_MEN = nOM_SEG_MEN;
            IMG_SEG_MEN = iMG_SEG_MEN;
            ID_BEB_MEN = iD_BEB_MEN;
            NOM_BEB_MEN = nOM_BEB_MEN;
            IMG_BEB_MEN = iMG_BEB_MEN;
            ID_POS_MEN = iD_POS_MEN;
            NOM_POS_MEN = nOM_POS_MEN;
            IMG_POS_MEN = iMG_POS_MEN;
            INGREDIENTES = iNGREDIENTES;
            FECHA_MEN = fECHA_MEN;
        }
    }
}
