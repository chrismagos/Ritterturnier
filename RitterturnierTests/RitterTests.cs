using Ritterturnier;
using RitterturnierConsole;

namespace RitterturnierTests
{
    public class RitterTests
    {
        Ritter ritter;
        Knappe knappe;
        Waffe waffe;
        public RitterTests() {
            ritter = new Ritter();
            knappe = new Knappe("TestKnappe", "14141414", 2);
            waffe = new Waffe("TestWaffe", Waffenart.S);
        }
        [Fact]
        public void addKnappeTest()
        {
            ritter.addKnappe(knappe);
            Assert.Equal(knappe, ritter._knappe);
        }
        [Fact]
        public void addWaffeTest()
        {
            ritter.addWaffe(waffe);
            Assert.Equal(waffe, ritter._waffe);
        }
    }
}