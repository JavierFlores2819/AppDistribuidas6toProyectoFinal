﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegocioSegundo
    {

        public static int NuevSegundoNegocio(EntidadSegundo e)
        {
            try
            {
                return DatosSegundo.NuevoSegundo(e);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<EntidadSegundo> NegocioCargarSegundo()
        {
            try
            {
                return DatosSegundo.DatosCargarSegundo();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static EntidadSegundo NegocioObtenerSegundo(int id)
        {
            try
            {
                return DatosSegundo.DatosObtenerSegundo(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static EntidadSegundo NegocioObtenerSegundoWindows(int id)
        {
            try
            {
                return DatosSegundo.DatosObtenerSegundoWindows(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
