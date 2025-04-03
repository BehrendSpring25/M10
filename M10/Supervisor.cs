public class Supervisor : RSupIF, MSubIF, CEOSubIF
{
    private List<PSSubIF> subs = new List<PSSubIF>();
    private PSSupIF superior;
    private string name;
    public void addSub(PSSubIF sub)
    {
        this.subs.Add(sub);
    }
    public void setSuperior(PSSupIF superior)
    {
        this.superior = superior;
    }

    public void seeDanger()
    {
        foreach (PSSubIF sub in subs)
        {
            RegularWorker s = (RegularWorker) sub;
            s.fixIt();
        }

        superior.seeDanger();

    }

    public Supervisor(string name)
    {
        this.name = name;
    }

    public string provideInfo()
    {
        return "Information from " + name;
    }

    public void evacuate()
    {
        Console.WriteLine(name + " is evacuating the building.");
    }
}