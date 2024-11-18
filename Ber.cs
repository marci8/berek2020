using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek2020;

internal class Ber
{
    private string nev;
    private string neme;
    private string reszleg;
    private int belepes;
    private int bere;

    public string Nev { get => nev; set => nev = value; }
    public string Neme { get => neme; set => neme = value; }
    public string Reszleg { get => reszleg; set => reszleg = value; }
    public int Belepes { get => belepes; set => belepes = value; }
    public int Bere { get => bere; set => bere = value; }

    public Ber(string sor)
    {
        string[] s = sor.Split(";");
        nev = s[0];
        neme = s[1];
        reszleg = s[2];
        belepes = int.Parse(s[3]);
        bere = int.Parse(s[4]);
    }
}
