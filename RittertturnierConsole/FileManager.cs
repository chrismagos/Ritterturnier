using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace Ritterturnier
{
    public class FileManager
    {
        public void toFile(Teilnehmerliste teilnehmerliste)
        {
            List<Ritter> ritterliste = new List<Ritter>();
            foreach(Teilnehmer teilnehmer in teilnehmerliste._teilnehmerListe)
            {
                ritterliste.Add((Ritter) teilnehmer);
            }
            File.WriteAllText("teilnehmerliste.json", JsonSerializer.Serialize(ritterliste));
        }
        public void fromFile()
        {
            string jsonString = File.ReadAllText("teilnehmerliste.json");
            List<Ritter> ritterliste = JsonSerializer.Deserialize<List<Ritter>>(jsonString);
        }
    }
}
