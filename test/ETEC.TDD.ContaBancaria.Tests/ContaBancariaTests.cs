using System;
using Xunit;

namespace ETEC.TDD.ContaBancaria.Tests
{
    public class ContaBancariaTests
    {
        [Fact(DisplayName = "Realização do saque da conta bancária deve retornar sucesso")]
        [Trait("Categoria", "Conta bancária")]
        public void ContaBancaria_Saque_DeveRetornarSucesso()
        {
            //Arange
            var cliente = new Cliente("Bruce Wayne");
            var contaCorrente = new ContaCorrente(cliente);
            contaCorrente.Saldo = 5000m;

            var valorSaque = 1500m;

            //Act
            contaCorrente.RealizarSaque(valorSaque);

            //Assert
            Assert.Equal(3500M, contaCorrente.Saldo);
        }

        [Fact(DisplayName = "Realização do depósito da conta bancária deve retornar sucesso")]
        [Trait("Categoria", "Conta bancária")]
        public void ContaBancaria_Deposito_DeveRetornarSucesso()
        {
            //Arrange
            var cliente = new Cliente("Tony Stark");
            var contaCorrente = new ContaCorrente(cliente);
            contaCorrente.Saldo = 5000m;

            var valorDeposito = 2000m;

            //Act
            contaCorrente.RealizarDeposito(valorDeposito);

            //Arrange
            Assert.Equal(7000, contaCorrente.Saldo);
        }

    }
}
