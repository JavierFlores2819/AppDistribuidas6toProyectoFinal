using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadIngredientes
    {
        public int ID_ING { get; set; }
        public String NOM_ING { get; set; }

        public EntidadIngredientes()
        {
        }

        public EntidadIngredientes(int iD_ING, string nOM_ING)
        {
            ID_ING = iD_ING;
            NOM_ING = nOM_ING;
        }
    }
}
