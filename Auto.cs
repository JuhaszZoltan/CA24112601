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

    /// <summary>
    /// az autó tulajdonosainak lekérdezése
    /// </summary>
    /// <returns>az autó korábbi tulajdonosainak listája egetlen stringben, sortörésekkel elválasztva</returns>
    public string TulajokLekerdezese() =>
        string.Join('\n', tulajdonosok);

    /// <summary>
    /// új tulajdonos rögzítése (automatikus GUID)
    /// </summary>
    /// <param name="nevek">egyetlen vagy több strign vesszővel elválasztva, ami az autó korábbi tulajdonosainak nevét/neveit jelöli</param>
    public void UjTulajokRogzitese(params string[] nevek)
    {
        foreach (var nev in nevek) tulajdonosok.Add(new(nev));
    }

    public override string ToString() =>
        $"[{Rendszam}] {Gyarto} {Modell} " +
        $"({Teljesitmeny}hp, {Terfogat}cc, {Fogyasztas}mpg)";

    /// <summary>
    /// Inicializál egy Peugeto 206-os modellt (1124cc, 60hp, 41.3mpg), csk a rendszámot kell paraméterben megadni
    /// </summary>
    /// <param name="rendszam">az autó rendszáma</param>
    public Auto(string rendszam) : this(rendszam, "Peugeto", "206", 1124, 60, 41.27f)
    {
        tulajdonosok.Add(new("a feltételezett taxi-vállalat neve"));
    }

    /// <summary>
    /// Inicializál egy autó példányt úgy, hogy minden egyes tulajdonságát a paraméterekben kell megadni.
    /// </summary>
    /// <param name="rendszam">az autó rendszáma</param>
    /// <param name="gyarto">az autó gyártója</param>
    /// <param name="modell">a modell megnevezése</param>
    /// <param name="terfogat">a hengertérfogat köbcentiméterben</param>
    /// <param name="teljesitmeny">a teljesítmény lóerőben</param>
    /// <param name="fogyasztas">a fogyasztás mpg-ben</param>
    /// <param name="nevek">az autó korábbi és jelenlegi tulajdonosainak nevei</param>
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
