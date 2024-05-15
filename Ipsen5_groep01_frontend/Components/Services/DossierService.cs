using Ipsen5_groep01_frontend.Models;
namespace Ipsen5_groep01_frontend.Components.Services
{
    public class DossierService{
        private List<Dossier> dossiers = new List<Dossier> {
            new Dossier(
            id: "12345",
            kandidaatId: "ABCDE",
            status: "In behandeling",
            date: DateTime.Now,
            inkoopTarief: 1000.0,
            verkoopTarief: 1500.0,
            betalingstermijn: DateTime.Now.AddDays(30),
            feepartij: "Voorbeeld Fee Partij",
            functieOmschrijving: "Een mooie functieonmschrijving",
            leverancierNotitie: "Voorbeeld leverancier notitie",
            interneMedewerkerNotitie: "Voorbeeld interne medewerker notitie"
            ),
            new Dossier(
            id: "123456789",
            kandidaatId: "ABCDEFGHIJ",
            status: "Afgerond",
            date: DateTime.Now,
            inkoopTarief: 2000.0,
            verkoopTarief: 2500.0,
            betalingstermijn: DateTime.Now.AddDays(35),
            feepartij: "Voorbeeld Fee Partij met een spin",
            functieOmschrijving: "Nog een mooie functieonmschrijving",
            leverancierNotitie: "Voorbeeld leverancier notitie",
            interneMedewerkerNotitie: "Voorbeeld interne medewerker notitie"
            ),
            new Dossier(
            id: "67890",
            kandidaatId: "FGHIJK",
            status: "In behandeling",
            date: DateTime.Now,
            inkoopTarief: 1500.0,
            verkoopTarief: 2000.0,
            betalingstermijn: DateTime.Now.AddDays(45),
            feepartij: "Voorbeeld Fee Partij 3",
            functieOmschrijving: "Nog een andere mooie functieonmschrijving",
            leverancierNotitie: "Voorbeeld leverancier notitie 3",
            interneMedewerkerNotitie: "Voorbeeld interne medewerker notitie 3"
            ),
            new Dossier(
            id: "13579",
            kandidaatId: "LMNOP",
            status: "Afgerond",
            date: DateTime.Now,
            inkoopTarief: 1800.0,
            verkoopTarief: 2300.0,
            betalingstermijn: DateTime.Now.AddDays(25),
            feepartij: "Voorbeeld Fee Partij 4",
            functieOmschrijving: "Nog een andere mooie functieonmschrijving 4",
            leverancierNotitie: "Voorbeeld leverancier notitie 4",
            interneMedewerkerNotitie: "Voorbeeld interne medewerker notitie 4"
            )
        };

        public List<Dossier> getDossiers(){
            return this.dossiers;
        }
    }
}