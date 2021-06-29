using System;
using System.Collections.Generic;
using System.Text;

namespace ETEC.TDD.ContaBancaria
{
    public class Cliente
    {
        public string Titular { get; set; }

        public Cliente(string titular)
        {
            Titular = titular;
        }
    }
}
