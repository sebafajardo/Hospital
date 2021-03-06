﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico
    {
        string nombre;
        string apellido;
        int dni;
        string especialidad;

        public Medico(string nombre, string apellido, int dni, string especialidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.especialidad = especialidad;

        }

       
        public static bool operator +(Medico[] medicos, Medico medico)
        {
            //recorro buscando libres
            for (int i = 0; i < medicos.Length; i++)
            {
                if (medicos[i] == null)
                {
                    medicos[i] = medico;
                    return true;
                }
            }

            //si no encontre libres agrego un lugar
            Array.Resize<Medico>(ref medicos, medicos.Length  + 1);

            medicos[medicos.Length - 1] = medico;
            return true;

        }
    }
}
