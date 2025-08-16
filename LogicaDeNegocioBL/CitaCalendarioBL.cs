﻿using EntidadDeNegocioEN;
using LogicaDeAccesoADatosDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocioBL
{
    public static class CitaCalendarioBL
    {
        public static List<CitaCalendarioEN> ObtenerCitas()
        {
            return CitaCalendarioDAL.ObtenerCitasConClientes();
        }
    }
}


