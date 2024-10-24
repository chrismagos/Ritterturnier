using Ritterturnier;

namespace RitterturnierConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Waffe waffe = new Waffe("Waffe1", Waffenart.S);
            Knappe knappe = new Knappe("Knappe1", "93839473", 2);
            Ritter ritter = new Ritter("Ritter1", "97837492", "Herb");
            Ritter ritter2 = new Ritter("Ritter2", "97837492", "Herb");
            ritter.addWaffe(waffe);
            ritter2.addWaffe(waffe);
            ritter.addKnappe(knappe);
            ritter2.addKnappe(knappe);
            Teilnehmerliste teilnehmerliste = new Teilnehmerliste();
            teilnehmerliste.addTeilnehmer(ritter);
            teilnehmerliste.addTeilnehmer(ritter2);
            Console.WriteLine(teilnehmerliste.listeAlleTeilnehmer());
            FileManager fileManager = new FileManager();
            //fileManager.toFile(teilnehmerliste);
            //fileManager.fromFile();
        }
    }
}
