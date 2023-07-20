namespace CSharpSummary.Tests
{
    enum hola
    {
        mundo,
        ejemplo3,

    }

    public class UnitTest1
    {
        

        [Fact]
        public void Test1()
        {
            float flotante = 10.5f;
            float flotante2 = 10.99f;
            float flotante3 = 10.01f;
            int entero = (int)flotante;
            int entero2 = (int)flotante2;
            int entero3 = (int)flotante3;
            var data = hola.mundo.ToString();
        }
    }
}