public class CEO : MSupIF, RSupIF, PSSupIF
{
    private CEOSubIF[] subs;
    private List<Decision> da = new List<Decision>();

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
    }

    private Decision grant(Decision[] da)
    {
        return null;
    }
}