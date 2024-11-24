using System;
using Xunit; // Necesario para xUnit
using ConsoleApp1; // Este es el espacio de nombres de tu proyecto principal

namespace ConsoleApp1.Tests
{
    public class StringValidatorTests
    {
        [Fact] // Este atributo indica que es una prueba unitaria
        public void KPalabrasMasFrecuentes_DeberiaRetornarLasPalabrasMasFrecuentes()
        {
            // Arrange: Establecer datos de entrada
            var palabras = new string[] { "microsoft", "azure", "developer", "azure", "microsoft", "teams", "developer", "azure" };
            var k = 2;
            var expected = new string[] { "azure", "developer" };

            // Act: Llamar a la función
            var resultado = Program.KPalabrasMasFrecuentes(palabras, k);

            // Assert: Validar que el resultado sea el esperado
            Assert.Equal(expected, resultado);
        }

        [Fact]
        public void KPalabrasMasFrecuentes_DeberiaDevolverSoloPalabrasUnicasSiHayMenosDeK()
        {
            // Arrange: Establecer datos de entrada
            var palabras = new string[] { "microsoft", "developer", "teams" };
            var k = 3;
            var expected = new string[] { "developer", "microsoft", "teams" };

            // Act: Llamar a la función
            var resultado = Program.KPalabrasMasFrecuentes(palabras, k);

            // Assert: Validar que el resultado sea el esperado
            Assert.Equal(expected, resultado);
        }

        [Fact]
        public void KPalabrasMasFrecuentes_DeberiaManejarEntradaVacia()
        {
            // Arrange: Establecer datos de entrada vacíos
            var palabras = new string[] { };
            var k = 2;
            var expected = new string[] { };

            // Act: Llamar a la función
            var resultado = Program.KPalabrasMasFrecuentes(palabras, k);

            // Assert: Validar que el resultado sea el esperado (vacío)
            Assert.Equal(expected, resultado);
        }

        [Fact]
        public void KPalabrasMasFrecuentes_DeberiaRetornarMenosDeKSiNoHaySuficientesPalabras()
        {
            // Arrange: Establecer datos de entrada
            var palabras = new string[] { "microsoft", "azure", "developer" };
            var k = 5; // Hay solo 3 palabras únicas
            var expected = new string[] { "azure", "developer", "microsoft" };

            // Act: Llamar a la función
            var resultado = Program.KPalabrasMasFrecuentes(palabras, k);

            // Assert: Validar que el resultado sea el esperado
            Assert.Equal(expected, resultado);
        }
    }
}
