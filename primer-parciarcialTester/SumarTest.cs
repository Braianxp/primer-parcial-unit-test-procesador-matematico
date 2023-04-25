using Xunit;
using primer_parcial_unit_test_procesador_matematico;

namespace primer_parciarcialTester
{
    public class SumarTest
    {
        [Fact]
        public void sumarDosValoresPositivos()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 10;

            int resultadoOptenido = procesadorMatematico.Sumar(6, 4);

            Assert.Equal(resultadoEsperado, resultadoOptenido);
        }

        [Fact]

        public void sumarDevuelveValorCeroEsNegativo()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 0;

            int resultadoOptenido = procesadorMatematico.Sumar(6, -8);

            Assert.Equal(resultadoEsperado, resultadoOptenido);
        }
    }
}