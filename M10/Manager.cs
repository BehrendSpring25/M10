using System.Diagnostics;

public class Manager : RSupIF, PSSupIF, CEOSubIF
{

    private List<MSubIF> subs = new List<MSubIF>();
    private MSupIF superior;

    public void seeDanger(MSubIF sub)
    {
        Console.WriteLine(sub.provideInfo());

        contactBoss();
    }

    public void evacuate()
    {

    }

    public void contactBoss()
    {
        superior.seeDanger();
    }

    public Decision suggestedDecision()
    {
        Decision d = new Decision();

        return d;
    }

}