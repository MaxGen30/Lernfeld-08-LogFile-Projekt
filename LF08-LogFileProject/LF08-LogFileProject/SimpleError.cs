using System.Text;
using LF08_LogFileProject.Models.Ips;

namespace LF08_LogFileProject
{
    public partial class SimpleError : UserControl
    {
        public SimpleError()
        {
            InitializeComponent();
        }

        public void DisplayError(Errors error)
        {
            if (error != Errors.NoError)
            {
                Visible = true;
                DisplayHeader(error);
                DisplayInfo(error);
            }
        }

        private void DisplayHeader(Errors error)
        {
            var header = new StringBuilder("");
            switch (error)
            {
                case Errors.InvalidBegin:
                    header.Append("Ungültiges Startdatum");
                    break;
                case Errors.InvalidEnd:
                    header.Append("Ungültiges Enddatum");
                    break;
                case Errors.NoCodes:
                    header.Append("Keine Statuscodes");
                    break;
                case Errors.NoIps:
                    header.Append("Keine Ips");
                    break;
                case Errors.StartBiggerThanEnd:
                    header.Append("Start und Ende vertauscht");
                    break;
                case Errors.FailedToRead:
                    header.Append("Fehler beim Auslesen");
                    break;
                case Errors.InvalidIp:
                    header.Append("Ungültige Ip");
                    break;
                case Errors.DeleteIpError:
                    header.Append("Problem beim löschen");
                    break;
                case Errors.NoAttributesSelected:
                    header.Append("Keine Attribute");
                    break;
                case Errors.InvalidCode:
                    header.Append("Ungültiger Code");
                    break;
                case Errors.DeleteCodeError:
                    header.Append("Problem beim löschen");
                    break;
            }

            HeaderL.Text = header.ToString();
        }

        private void DisplayInfo(Errors error)
        {
            var info = new StringBuilder("");;
            switch (error)
            {
                case Errors.InvalidBegin:
                    info.Append("Das Startdatum ist invalide. Bitte passen Sie es an.");
                    break;
                case Errors.InvalidEnd:
                    info.Append("Das Endatum ist invalide. Bitte passen Sie es an.");
                    break;
                case Errors.NoCodes:
                    info.Append("Wenn Sie nach Statuscodes filtern wollen, so müssen Sie auch welche hinzufügen.");
                    break;
                case Errors.NoIps:
                    info.Append("Wenn Sie nach Ips filtern wollen, so müssen Sie auch welche hinzufügen.");
                    break;
                case Errors.StartBiggerThanEnd:
                    info.Append("Das Startdatum liegt hinter dem Enddatum. Das ist nicht erlaubt.");
                    break;
                case Errors.FailedToRead:
                    info.Append("Es ging irgendetwas schief. Es konnten keine Daten ausgelesen werden.");
                    break;
                case Errors.InvalidIp:
                    info.Append("Die eingegebene Ip ist ungültig. Min: 0, Max: 255");
                    break;
                case Errors.DeleteIpError:
                    info.Append("Es konnte keine Ip gelöscht werden. Es wurde keine ausgewählt.");
                    break;
                case Errors.NoAttributesSelected:
                    info.Append("Wenn sie nach Attributen filtern wollen, so müssen Sie auch welche auswählen.");
                    break;
                case Errors.InvalidCode:
                    info.Append("Der eingegebene Code ist ungültig. Min: 0, Max: 999");
                    break;
                case Errors.DeleteCodeError:
                    info.Append("Es konnte kein Code gelöscht werden. Es wurde keiner ausgewählt.");
                    break;
            }

            DesL.Text = info.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}