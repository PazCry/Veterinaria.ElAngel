﻿using EntidadDeNegocioEN;
using LogicaDeAccesoADatosDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocioBL
{
    public class EspecieBL
    {
        public List<EspecieEN> MostrarEspecie()
            {
                return EspecieDAL.MostrarEspecie();
            }

            public int GuardarEspecie(EspecieEN pEspecieEN)
            {
                return EspecieDAL.AgregarEspecie(pEspecieEN);
            }

            public int EliminarEspecie(EspecieEN pEspecieEN)
            {
                return EspecieDAL.EliminarEspecie(pEspecieEN);
            }

            public int ModificarEspecie(EspecieEN pEspecieEN)
            {
                return EspecieDAL.ModificarEspecie(pEspecieEN);
            }
    }
}

