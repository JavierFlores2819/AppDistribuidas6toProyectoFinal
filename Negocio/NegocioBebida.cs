﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
  public class NegocioBebida
    {
        public static int NuevoBebidaNegocio(EntidadBebida e)
        {
            try
            {
                return DatosBebida.NuevoDatosBebida(e);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntidadBebida> NegocioCargarBebida()
        {
            try
            {
                return DatosBebida.DatosCargarBebida();
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
