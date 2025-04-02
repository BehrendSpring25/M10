public class CEO : MSupIF, RSupIF, PSSupIF
{
    private CEOSubIF[] subs;
    private List<Decision> da = new List<Decision>();
    private string name;

    public CEO(string name)
    {
        this.name = name;
    }

    public void seeDanger()
    {

        foreach (Manager m in subs.OfType<Manager>())
        {
            da.Add(m.suggestedDecision());
        }

        Decision[] d = da.ToArray();

        Decision choice  = grant(d);

        doIt();

    }

    public void doIt()
    {
        Console.WriteLine("The city's environmental department is notified.");

        foreach (CEOSubIF m in subs.OfType<RegularWorker>())
        {
            m.evacuate();
        }

        foreach (CEOSubIF m in subs.Except(subs.OfType<RegularWorker>()))
        {
            m.evacuate();
        }

        evacuate();
    }

    private Decision grant(Decision[] da)
    {
        return null;
    }

    public void evacuate()
    {
        Console.WriteLine("The CEO is evacuating the building.");
    }
}