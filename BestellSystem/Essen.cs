// See https://aka.ms/new-console-template for more information



class Essen : Posten
{
    private bool _extragross;
    public Essen(Bestellpostentyp name, double preis, bool extragross) : base(name, preis)
    {
        _extragross = extragross;
    }
    public override double Berechnepreis()
    {
        return _extragross ? Preis * 1.20 : Preis;
    }
}
