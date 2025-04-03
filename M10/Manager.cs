using System.Diagnostics;

public class Manager : RSupIF, PSSupIF, CEOSubIF
{
    public void seeDanger()
    {
        Console.WriteLine("Danger seen by PSSupIF.");
    }

    private List<MSubIF> subs = new List<MSubIF>();
    private MSupIF superior;
    private string name;


    public void addSub(MSubIF sub)
    {
        this.subs.Add(sub);
    }
    public void setSuperior(MSupIF superior)
    {
        this.superior = superior;
    }
    public void seeDanger(ProjectLeader sub)
    {
        Console.WriteLine(sub.provideInfo());

        contactBoss();
    }

    public void seeDanger(Supervisor sub)
    {
        Console.WriteLine(sub.provideInfo());

        contactBoss();
    }

    public Manager(string name)
    {
        this.name = name;
    }
    public void evacuate()
    {
        Console.WriteLine(name + " evacuates the building.");
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