﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013133029_ENT.Entidades
{
    public class Pantalla
    {
        public int PantallaId { get; set; }
        private string _Texto;
        public ATM ATM { get; set; }
        public Retiro Retiro { get; set; }

        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public Pantalla()
        {

        }
        public Pantalla(string texto)
        {
            Texto = texto;
        }
    }
}

