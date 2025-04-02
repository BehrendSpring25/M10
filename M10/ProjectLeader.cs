public class ProjectLeader : RSupIF, MSubIF, CEOSubIF
{
    private List<PSSubIF> subs = new List<PSSubIF>();
    private PSSupIF superior;
    private String name;

    public ProjectLeader(String name)
    {
        this.name = name;
    }

    public string provideInfo()
    {
        return "Information from " + name;
    }

    public void evacuate()
    {
        foreach(PSSubIF sub in subs)
        {
            sub.evacuate();
        }
    }

    public void seeDanger()
    {
        foreach(PSSubIF sub in subs)
        {
            sub.fixIt();
        }

        superior.seeDanger(this);
    }
}