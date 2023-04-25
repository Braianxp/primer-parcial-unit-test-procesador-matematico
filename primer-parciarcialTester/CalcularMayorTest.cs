using Xunit;
using primer_parcial_unit_test_procesador_matematico;

namespace primer_parciarcialTester
{
    public class CalcularMayorTest
    {
        [Fact]
        public void CalcularMayorPrimeroMayor()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 20;

            int resultadoOptenido = procesadorMatematico.CalcularMayor(20, 5);

            Assert.Equal(resultadoEsperado, resultadoOptenido);
        }

        [Fact]
        public void CalcularMayorSegundoMayor()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 32;

            int resultadoOptenido = procesadorMatematico.CalcularMayor(10, 32);

            Assert.Equal(resultadoEsperado, resultadoOptenido);
        }

        [Fact]
        public void CalcularMayorIguales()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 2;

            int resultadoOptenido = procesadorMatematico.CalcularMayor(2, 2);

            Assert.Equal(resultadoEsperado, resultadoOptenido);
        }
    }
}