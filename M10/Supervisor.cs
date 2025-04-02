public class Supervisor : RSupIF, MSubIF, CEOSubIF
{
    private List<PSSubIF> subs = new List<PSSubIF>();
    private PSSupIF superior;
    private string name;

    public void seeDanger()
    {
        foreach (PSSubIF sub in subs)
        {
            sub.fixIt();
        }

        superior.seeDanger();

    }

    public string provideInfo()
    {
        return "Information from " + name;
    }

    public void evacuate()
    {
        foreach (PSSubIF sub in subs)
        {
            sub.evacuate(this);
        }
    }
}