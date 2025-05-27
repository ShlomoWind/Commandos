public class SeaCommando : Commando
{
    private int TotalKilometers = 0;
    SeaCommando(string name, string codeName) :base(name, codeName) { }
    public void AddKilometers(int kilometers)
    {
        this.TotalKilometers += kilometers;
    }
}