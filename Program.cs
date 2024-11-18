using berek2020;
using System.Text;

List<Ber> berek = [];
using StreamReader sr = new("..\\..\\..\\src\\berek2020.txt", Encoding.UTF8);
sr.ReadLine();
while (!sr.EndOfStream) berek.Add(new(sr.ReadLine()));

Console.WriteLine($"3. Feladat: Dolgozók száma: {berek.Count} fő");

var f4 = berek.Average(b => b.Bere);
Console.WriteLine($"4. Feladat: Bérek átlaga: {f4/1000:0.00} eFt");

Console.Write("5. Feladat: Kérem a részleg nevét: ");
string resz = Console.ReadLine();

int max = 0;
int db = 0;
for (int i = 0; i<berek.Count; i++)
{
    if (resz.ToLower() == berek[i].Reszleg)
    {
        if (berek[i].Bere > berek[max].Bere) { max = i; }
    }
    else { db++; }
}
if (db == berek.Count)
{
    Console.WriteLine("A megadott részleg nem létezik a cégnél!");
}
else
{
    Console.WriteLine($"6. Feladat: A legtöbbet kereső dolgozó a megadott részlegen\n" +
        $"\tNév: {berek[max].Nev}\n" +
        $"\tNem: {berek[max].Neme}\n" +
        $"\tBelépés: {berek[max].Belepes}\n" +
        $"\tBér: {berek[max].Bere} forint");
}

var f7 = berek.GroupBy(b => b.Reszleg);
foreach (var f in f7)
{
    Console.WriteLine($"\t{f.Key} - {f.Count()} fő");
}
