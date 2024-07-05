using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellSystem;

internal static class Preisgestaltung
{
    public static Dictionary<Bestellpostentyp, double> Preisliste = new()
    {
        {Bestellpostentyp.Bier,2.0 },
        {Bestellpostentyp.Pizza, 10 },
        {Bestellpostentyp.Cola,1 },
        {Bestellpostentyp.Fanta,1 }
    };
}
