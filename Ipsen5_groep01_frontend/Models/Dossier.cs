using System.Xml.Linq;

namespace Ipsen5_groep01_frontend.Models
{
    public class Dossier
    {
        private string id;
        public string Id
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }
        private string kandidaatId;
        public string KandidaatId
        {
            get { return kandidaatId; }
            set { kandidaatId = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private double inkoopTarief;
        public double InkoopTarief
        {
            get { return inkoopTarief; }
            set { inkoopTarief = value; }
        }
        private double verkoopTarief;
        public double VerkoopTarief
        {
            get { return verkoopTarief; }
            set { verkoopTarief = value; }
        }
        private DateTime betalingstermijn;
        public DateTime Betalingstermijn
        {
            get { return betalingstermijn; }
            set { betalingstermijn = value; }
        }
        private string feePartij;
        public string FeePartij
        {
            get { return feePartij; }
            set { feePartij = value; }
        }
        private string functieOmschrijving;
        public string FunctieOmschrijving
        {
            get { return functieOmschrijving; }
            set { functieOmschrijving = value; }
        }
        private string leverancierNotitie;
        public string LeverancierNotitie
        {
            get { return leverancierNotitie; }
            set { leverancierNotitie = value; }
        }
        private string interneMedewerkerNotitie;
        public string InterneMedewerkerNotitie
        {
            get { return interneMedewerkerNotitie; }
            set { interneMedewerkerNotitie = value; }
        }

        public Dossier(string id, string kandidaatId, string status, DateTime date, double inkoopTarief, double verkoopTarief, DateTime betalingstermijn, string feepartij, string functieOmschrijving, string leverancierNotitie, string interneMedewerkerNotitie)
        {
            this.id = id;   
            this.kandidaatId = kandidaatId; 
            this.status = status;   
            this.date = date;   
            this.inkoopTarief = inkoopTarief;   
            this.verkoopTarief = verkoopTarief; 
            this.betalingstermijn = betalingstermijn;   
            this.feePartij = feepartij; 
            this.functieOmschrijving = functieOmschrijving; 
            this.leverancierNotitie = leverancierNotitie;   
            this.interneMedewerkerNotitie = leverancierNotitie;
        }

    }
}
