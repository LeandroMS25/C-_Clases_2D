﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas) 
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador()
            : this(0)
        {

        }

        public long Sumar(long num1, long num2)
        {
            this.cantidadSumas++;
            return num1 + num2;
        }

        public string Sumar(string num1, string num2)
        {
            this.cantidadSumas++;
            return num1 + num2;
        }

        public static explicit operator int (Sumador dato)
        {
            return (int)dato.cantidadSumas;
        }

        public static long operator + (Sumador s1, Sumador s2)
        {
            long suma = s1.cantidadSumas + s2.cantidadSumas;
            return suma;
        }

        public static bool operator | (Sumador s1, Sumador s2)
        {
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
