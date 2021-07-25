using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class EntidadDetalleSopa
    {
        public int ID_DET_REC { get; set; }
        public int ID_REC_PER { get; set; }
        public int ID_ING_USA { get; set; }

        public EntidadDetalleSopa()
        {
        }

        public EntidadDetalleSopa(int ID_DET_REC,int iD_REC_PER, int iD_ING_USA)
        {
            this.ID_DET_REC = ID_DET_REC;
            ID_REC_PER = iD_REC_PER;
            ID_ING_USA = iD_ING_USA;
        }
    }
}
