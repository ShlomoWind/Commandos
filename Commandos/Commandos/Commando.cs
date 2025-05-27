public class Commando
{
    public string Name;
    public string CodeName;
    public string[] Tools;
    public string Status;

    public Commando(string name, string codeName, string[] tools, string status)
    {
        this.Name = name;
        this.CodeName = codeName;
        this.Tools = tools;
        this.Status = status;
    }
}