// See https://aka.ms/new-console-template for more information


public abstract class Posten
{
    public Bestellpostentyp Name { get; protected set; }
    public double Preis { get; protected set; }
    public Posten(Bestellpostentyp name, double preis)
    {
        Name = name;
        Preis = preis;
    }
    public abstract double Berechnepreis();
}
