using System;
using System.Collections.Generic;
using System.Text;

namespace ETEC.TDD.ContaBancaria
{
    public class ContaCorrente
    {
        public ContaCorrente(Cliente cliente)
        {
            Cliente = cliente;
        }

        public Cliente Cliente { get; set; }
        public decimal Saldo { get; set; }

        public void RealizarSaque(decimal valorSaque)
        {
            Saldo = Saldo - valorSaque;
        }

        public void RealizarDeposito(decimal valorDeposito)
        {
            Saldo = Saldo + valorDeposito;
        }
    }
}
