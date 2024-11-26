namespace CA24112601;

internal class Szemely
{
    public Guid Guid { get; }
    public string Nev { get; set; }

    public override string ToString() =>
        $"{Nev} (GUID: {Guid})";

    public Szemely(string nev)
    {
        Guid = Guid.NewGuid();
        Nev = nev;
    }
}
