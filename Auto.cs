using System.Reflection;

namespace CA24112601;

internal class Auto
{
    private List<Szemely> tulajdonosok;

    public string Rendszam { get; set; }
    public string Gyarto { get; set; }
    public string Modell { get; set; }
    public int Terfogat { get; set; }
    public int Teljesitmeny { get; set; }
    public float Fogyasztas { get; set; }

    public string TulajokLekerdezese() =>
        string.Join('\n', tulajdonosok);

    public void UjTulajokRogzitese(params string[] nevek)
    {
        foreach (var nev in nevek) tulajdonosok.Add(new(nev));
    }

    public override string ToString() =>
        $"[{Rendszam}] {Gyarto} {Modell} " +
        $"({Teljesitmeny}hp, {Terfogat}cc, {Fogyasztas}mpg)";

    //Rendszam = rendszam;
    //Gyarto = "Peugeto";
    //Modell = "206";
    //Terfogat = 1124;
    //Teljesitmeny = 60;
    //Fogyasztas = 41.27f;

    //DRY -> Don't Repeate Yourself!

    public Auto(string rendszam) : this(rendszam, "Peugeto", "206", 1124, 60, 41.27f)
    {
        tulajdonosok.Add(new("a feltételezett taxi-vállalat neve"));
    }

    public Auto(string rendszam, string gyarto, string modell, int terfogat, int teljesitmeny, float fogyasztas, params string[] nevek)
    {
        tulajdonosok = [];

        Rendszam = rendszam;
        Gyarto = gyarto;
        Modell = modell;
        Terfogat = terfogat;
        Teljesitmeny = teljesitmeny;
        Fogyasztas = fogyasztas;

        foreach (var nev in nevek) tulajdonosok.Add(new(nev));
    }


}
