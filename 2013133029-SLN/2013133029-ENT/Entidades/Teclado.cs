﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013133029_ENT.Entidades
{
    public class Teclado
    {
        public int TecladoId { get; set; }
        private int _NumeroCuenta;
        private int _Pin;
        public ATM ATM { get; set; }
        public Retiro Retiro { get; set; }

        public int NumeroCuenta
        {
            get { return _NumeroCuenta; }
            set { _NumeroCuenta = value; }
        }

        public int Pin
        {
            get { return _Pin; }
            set { _Pin = value; }
        }

        public Teclado()
        {

        }
        public Teclado(int numeroCuenta, int pin)
        {
            NumeroCuenta = numeroCuenta;
            Pin = pin;
        }
    }
}

