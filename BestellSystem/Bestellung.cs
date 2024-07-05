// See https://aka.ms/new-console-template for more information
using BestellSystem;
using System.Collections.ObjectModel;

public class Bestellung
{
    // Bu klass tüm islemlerin yapildigi yani lsteye veri eklendigi silindigi liste olusturuldugu klass
    // biz bunu ara class olan viewModels te üretilen orderViewModels ile yürütecegiz.
    // burdaki metotlari dogrudan view deki classlardan degil viewModels teki claslar üzerinden yapacagiz.


    public List<Posten> Bestellposten { get; private set; } 
    public Bestellung()
    {
        Bestellposten=new List<Posten>();
    }
    public bool BitAndByteCard { get; set; }
    public Posten AddPosten(Bestellpostentyp name) //Burda add metodu var metot parametre olarak ürün ismi aliyor
    {
        var posten = Bestellpostenfabrik.ErzeugePosten(name); // burda isme göre nesne olusturuluyor ki Listeye eklenebilsin
        Bestellposten.Add(posten); // nesne olusturulduktan sonra burdaki listeye ekliyoruz.
        return posten;
    }

    public double BerechneBestellung() // burda listedeki elementlerin fiyatlari toplanarak taoplam maliyet cikariliyor
    {
        double ergebnis = 0;
        foreach (var item in Bestellposten)
        {
            ergebnis += item.Berechnepreis();
        }
        // eger kisinin karti varsa maliyet 0.95 ile carpiliyor yoksa oldugu gibi return ediliyor
        return BitAndByteCard ? Math.Round(ergebnis * 0.95, 2) : ergebnis;
    }

    // burda ise verilen post listeden siliniyor.
    public bool DeletePosten(Posten posten)
      => Bestellposten.Remove(posten);
}
