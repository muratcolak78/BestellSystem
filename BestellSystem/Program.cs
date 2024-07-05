//Testprogramm
Bestellung bestellung = new Bestellung();
bestellung.AddPosten(Bestellpostentyp.Cola);
bestellung.AddPosten(Bestellpostentyp.Cola);
bestellung.AddPosten(Bestellpostentyp.Bier);
bestellung.AddPosten(Bestellpostentyp.Bier);
bestellung.AddPosten(Bestellpostentyp.Bier);
bestellung.AddPosten(Bestellpostentyp.Pizza);
//bestellung.BitAndByteCard = true;
double expected2 = 6.0;
double expected = bestellung.Bestellposten.Sum(x => x.Preis);
Console.WriteLine(expected);
if (bestellung.BerechneBestellung() == expected)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Test bestanden");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Test nicht bestanden: erwartet war {expected}, Ergebnis aber lieferte {bestellung.BerechneBestellung()}");
}

Console.ResetColor();