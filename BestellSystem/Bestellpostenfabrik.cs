

using System.Xml.Linq;

namespace BestellSystem;

internal class Bestellpostenfabrik
{
    public static Posten ErzeugePosten(Bestellpostentyp name)
    {
        
        Posten posten = name switch
        {
            Bestellpostentyp.Cola => new Getraenk(name, Preis(name), alkoholisch: false, happyhour: false),
            Bestellpostentyp.Bier => new Getraenk(name, Preis(name), alkoholisch: true, happyhour: false),
            Bestellpostentyp.Fanta => new Getraenk(name, Preis(name), alkoholisch: false, happyhour: false),
            Bestellpostentyp.Pizza => new Essen(name, Preis(name), extragross: false)
        };
        return posten;
    }
    private static double Preis (Bestellpostentyp name)=>Preisgestaltung.Preisliste[name];
}
