﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected long dni;

        public Persona(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string MostrarPersona() 
        {
            return string.Format("Nombre: {0}, Apellido {1} , Dni {2}", this.nombre, this.apellido, this.dni);
        }
    }
}
