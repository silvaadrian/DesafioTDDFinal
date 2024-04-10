using Desafio.Services;

namespace TesteDesafio
{
    public class TesteCalculadora
    {
        private readonly Calculadora _calc;
    
        public TesteCalculadora()
        {
            _calc = new Calculadora();
        }


        [Theory]
        [InlineData(1,2,3)]
        public void TesteSoma(int val1, int val2, int resultado)
        {
            int resultadoCalculo = _calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculo);

        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void TesteSubtracao(int val1, int val2, int resultado)
        {
            int resultadoCalculo = _calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculo);

        }

        [Theory]
        [InlineData(1, 2, 2)]
        public void TesteMultiplicacao(int val1, int val2, int resultado)
        {
            int resultadoCalculo = _calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculo);

        }

        [Theory]
        [InlineData(1, 2, 0.5)]
        public void TesteDivisao(int val1, int val2, int resultado)
        {
            int resultadoCalculo = _calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculo);

        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(() =>  _calc.Dividir(3, 0) );
        }

        [Fact]
        public void TestarHistorico()
        {
            _calc.Somar(1, 2);
            _calc.Somar(3, 2);
            _calc.Somar(4, 2);
            _calc.Somar(5, 2);

            var lista = _calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}