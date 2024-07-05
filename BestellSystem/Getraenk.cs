// See https://aka.ms/new-console-template for more information



class Getraenk : Posten
{
    public bool Alkoholisch { get; private set; }
    public bool Happyhour { get; private set; }
    public Getraenk(Bestellpostentyp name, double preis, bool alkoholisch, bool happyhour) : base(name, preis) //Verkettung mit Basiskonstruktor
    {
        Alkoholisch = alkoholisch;
        Happyhour = happyhour;
    }

    public override double Berechnepreis()
    {
        return Happyhour && Alkoholisch ? Preis * 0.75 : Preis;
    }
}
