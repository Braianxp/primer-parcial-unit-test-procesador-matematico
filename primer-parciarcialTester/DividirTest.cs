using Xunit;
using primer_parcial_unit_test_procesador_matematico;

namespace primer_parciarcialTester
{
    public class DividirTest
    {
        [Fact]
        public void dividirDosNumerosPositivos()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 4;

            int resultadoOptenido = procesadorMatematico.Dividir(20, 5);

            Assert.Equal(resultadoEsperado, resultadoOptenido);
        }

        [Fact]
        public void dividirResultadoNegativo()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 0;

            int resultadoOptenido = procesadorMatematico.Dividir(20, -5);

            Assert.Equal(resultadoEsperado, resultadoOptenido);
        }

        [Fact]
        public void dividirPorCero()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = -1;

            int resultadoOptenido = procesadorMatematico.Dividir(20, 0);

            Assert.Equal(resultadoEsperado, resultadoOptenido);
        }
    }
}