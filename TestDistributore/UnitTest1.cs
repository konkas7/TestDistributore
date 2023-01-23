using Distributore_Numeri;
namespace TestDistributore
{
    public class UnitTest1
    {


        [Fact]
        public void TestId()
        {
            Distributore distributore = new Distributore("01", "", 0, 0, 0);
            Assert.Equal("01", distributore.Id);
        }

        [Fact]
        public void TestDitta()
        {
            Distributore distributore = new Distributore("01", "Test", 0, 0, 0);
            Assert.Equal("Test", distributore.Ditta);
        }

        [Fact]
        public void TestNumPartenza()
        {
            Distributore distributore = new Distributore("01", "", 5, 0, 0);
            Assert.Equal(5, distributore.NumPartenza);
        }

        [Fact]
        public void TestNumCorrente()
        {
            Distributore distributore = new Distributore("01", "", 0, 10, 0);
            Assert.Equal(10, distributore.NumCorrente);
        }

        [Fact]
        public void TestMassimo()
        {
            Distributore distributore = new Distributore("01", "", 0, 0, 100);
            Assert.Equal(100, distributore.Massimo);
        }

        [Fact]
        public void TestClone()
        {
            Distributore distributore = new Distributore("01", "Test", 5, 0, 0);
            Distributore clone = distributore.Clone();
            Assert.Equal(5, clone.NumPartenza);

        }

        
    
        [Fact]
        public void Test_PrendiBiglietto()
        {
            var distributore = new Distributore("01", "ACME", 1, 1, 10);
            distributore.funzioneSuccessivo();

            var biglietto = distributore.PrendiBiglietto();

            Assert.Equal(1, biglietto);
            Assert.Equal(2, distributore.NumeroCorrente());
        }

        [Fact]
        public void Test_Reset()
        {
            var distributore = new Distributore("01", "ACME", 1, 5, 10);
            distributore.funzioneSuccessivo();
            distributore.PrendiBiglietto();
            distributore.PrendiBiglietto();

            distributore.Reset();

            Assert.Equal(1, distributore.NumeroCorrente());
            Assert.Empty(distributore.OttieniPresi());
        }

        [Fact]
        public void Test_VerificaSequenza()
        {
            var distributore = new Distributore("01", "ACME", 1, 1, 10);
            distributore.funzioneSuccessivo();
            distributore.PrendiBiglietto();
            distributore.PrendiBiglietto();

            var isValid = distributore.VerificaSequenza(new[] { 1, 2 });

            Assert.True(isValid);
        }

    }
}