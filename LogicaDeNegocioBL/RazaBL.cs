﻿using EntidadDeNegocioEN;
using LogicaDeAccesoADatosDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocioBL
{
    public class RazaBL
    {
            public List<RazaEN> MostrarRaza()
            {
                return RazaDAL.MostrarRazaEN();
            }

            public int GuardarRaza(RazaEN pRazaEN)
            {
                return RazaDAL.AgregarRaza(pRazaEN);
            }

            public int EliminarRaza(RazaEN pRazaEN)
            {
                return RazaDAL.EliminarRaza(pRazaEN);
            }

            public int ModificarRaza(RazaEN pRazaEN)
            {
                return RazaDAL.ModificarRaza(pRazaEN);
            }
    }
}

