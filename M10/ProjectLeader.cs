public class ProjectLeader : RSupIF, MSubIF, CEOSubIF
{
    private List<PSSubIF> subs = new List<PSSubIF>();
    private PSSupIF superior;
    private String name;

    public ProjectLeader(String name)
    {
        this.name = name;
    }

    public void addSub(PSSubIF sub)
    {
        this.subs.Add(sub);
    }
    public void setSuperior(PSSupIF superior)
    {
        this.superior = superior;
    }

    public string provideInfo()
    {
        return "Information from " + name;
    }

    public void evacuate()
    {
        Console.WriteLine(name + " is evacuating the building.");
    }

    public void seeDanger()
    {
        foreach(PSSubIF sub in subs)
        {
            RegularWorker s = (RegularWorker) sub;
            s.fixIt();
        }

        Manager m = (Manager) superior;
        m.seeDanger(this);
        
    }
}