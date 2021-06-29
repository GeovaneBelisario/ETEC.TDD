using System;
using Xunit;

namespace ETEC.TDD.ContaBancaria.Tests
{
    public class ContaBancariaTests
    {
        [Fact(DisplayName = "Realiza��o do saque da conta banc�ria deve retornar sucesso")]
        [Trait("Categoria", "Conta banc�ria")]
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

        [Fact(DisplayName = "Realiza��o do dep�sito da conta banc�ria deve retornar sucesso")]
        [Trait("Categoria", "Conta banc�ria")]
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
