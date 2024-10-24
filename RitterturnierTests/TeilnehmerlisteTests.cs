using Ritterturnier;
using RitterturnierConsole;

namespace RitterturnierTests
{
    public class TeilnehmerlisteTests
    {
        Teilnehmerliste teilnehmerliste;
        Ritter ritter;
        public TeilnehmerlisteTests() {
            teilnehmerliste = new Teilnehmerliste();
            ritter = new Ritter("TestRitter", "14141414", "Hons");
        }
        [Fact]
        public void addTeilnehmerTest()
        {
            teilnehmerliste.addTeilnehmer(ritter);
            Assert.Equal(ritter, teilnehmerliste._teilnehmerListe[0]);
        }
        public void listeAlleTeilnehmerTest()
        {
            string correctOutput = "Ritter 1\tName: TestRitter";
        }
    }
}