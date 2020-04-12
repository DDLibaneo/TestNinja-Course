using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        //Lembrando: NomeDoMetodo_Cenario_ComportamentoEsperado
        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var math = new Fundamentals.Math();
            var result = math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}
