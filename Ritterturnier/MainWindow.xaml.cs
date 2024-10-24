using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ritterturnier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    partial class MainWindow : Window
    {
        private Teilnehmerliste teilnehmerliste;
        public MainWindow()
        {
            InitializeComponent();
            teilnehmerliste = new Teilnehmerliste();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            actionOutputLabel.Text = String.Empty;
            try
            {
                addRitter();
            }catch(NameSchonVorhandenException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            teilnehmerlisteOutput.Content = teilnehmerliste.listeAlleTeilnehmer();
        }
        private void addRitter()
        {
            if (ritterNameBox.Text.Length != 0) {
                try
                {
                    if (ritterTelefonnummerBox.Text.Length != 0 && ritterRufnameBox.Text.Length != 0)
                    {
                        if (isValidPhoneNumber(ritterTelefonnummerBox.Text))
                        {
                            teilnehmerliste.addTeilnehmer(new Ritter(ritterNameBox.Text, ritterTelefonnummerBox.Text, ritterRufnameBox.Text));
                        }
                        else {
                            MessageBox.Show("Ungültige Ritter-Telefonnummer.");
                        }
                    }
                    actionOutputLabel.Text = $"Der Ritter {ritterNameBox.Text} wurde der Teilnehmerliste hinzugefügt.\n";
                    if (waffeBezeichnungBox.Text.Length != 0 && waffeArt.Text.Length != 0)
                    {
                        addWaffe();
                    }
                    if (knappeNameBox.Text.Length != 0 && knappeTelefonnummerBox.Text.Length != 0)
                    {
                        if (isValidPhoneNumber(knappeTelefonnummerBox.Text))
                        {
                            addKnappe();
                        }
                        else
                        {
                            MessageBox.Show("Ungültige Knappen-Telefonnummer.");
                        }
                    }
                }
                catch (NameSchonVorhandenException)
                {
                    bool addedToRitter = false;
                    if (waffeBezeichnungBox.Text.Length != 0 && waffeArt.Text.Length != 0)
                    {
                        addWaffe();
                        addedToRitter = true;
                    }
                    if (knappeNameBox.Text.Length != 0)
                    {
                        if (isValidPhoneNumber(knappeTelefonnummerBox.Text))
                        {
                            addKnappe();
                        }
                        else
                        {
                            MessageBox.Show("Ungültige Knappen-Telefonnummer.");
                        }
                        addedToRitter = true;
                    }
                    if (addedToRitter == false)
                    {
                        throw new NameSchonVorhandenException(ritterNameBox + " ist schon vorhanden.");
                    }
                }
            }
        }
        private void addWaffe()
        {
            Waffenart waffenart = new Waffenart();
            if (waffeArt.Text == "Lanze") { waffenart = Waffenart.L; }
            else if (waffeArt.Text == "Keule") { waffenart = Waffenart.K; }
            else if (waffeArt.Text == "Schwert") { waffenart = Waffenart.S; }
            foreach (Ritter teilnehmer in teilnehmerliste._teilnehmerListe)
            {
                if (teilnehmer._name == ritterNameBox.Text)
                {
                    if(teilnehmer._waffe == null)
                    {
                        teilnehmer.addWaffe(new Waffe(waffeBezeichnungBox.Text, waffenart));
                        if (waffenart == Waffenart.S)
                        {
                            actionOutputLabel.Text += $"Das Schwert {waffeBezeichnungBox.Text}, wurde dem Ritter {ritterNameBox.Text} hinzugefügt.\n";
                        }
                        else
                        {
                            actionOutputLabel.Text += $"Die {waffeArt.Text} {waffeBezeichnungBox.Text}, wurde dem Ritter {ritterNameBox.Text} hinzugefügt.\n";
                        }
                    }
                    break;
                }
            }
        }
        private void addKnappe()
        {
            foreach (Ritter teilnehmer in teilnehmerliste._teilnehmerListe)
            {
                if (teilnehmer._name == ritterNameBox.Text)
                {
                    if(teilnehmer._knappe == null)
                    {
                        teilnehmer.addKnappe(new Knappe(knappeNameBox.Text, knappeTelefonnummerBox.Text, Convert.ToInt32(knappeGradSlider.Value)));
                        actionOutputLabel.Text += $"Der Knappe {knappeNameBox.Text} wurde dem Ritter {ritterNameBox.Text} hinzugefügt.";
                    }
                    break;
                }
            }
        }
        private bool isValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\+(?:[0-9]⋅?){6,14}[0-9]$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}