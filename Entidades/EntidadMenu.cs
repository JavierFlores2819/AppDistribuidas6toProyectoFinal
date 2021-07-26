using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadMenu
    {
        public int ID_MEN { get; set; }
        public int ID_SOP_MEN { get; set; }
        public int ID_SEG_MEN { get; set; }
        public int ID_BEB_MEN { get; set; }
        public int ID_POS_MEN { get; set; }
        public DateTime FECHA_MEN { get; set; }

        public EntidadMenu()
        {
        }

        public EntidadMenu(int iD_MEN, int iD_SOP_MEN, int iD_SEG_MEN, int iD_BEB_MEN, int iD_POS_MEN, DateTime fECHA_MEN)
        {
            ID_MEN = iD_MEN;
            ID_SOP_MEN = iD_SOP_MEN;
            ID_SEG_MEN = iD_SEG_MEN;
            ID_BEB_MEN = iD_BEB_MEN;
            ID_POS_MEN = iD_POS_MEN;
            FECHA_MEN = fECHA_MEN;
        }
    }
}
