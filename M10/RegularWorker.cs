public class RegularWorker : MSubIF, CEOSubIF, PSSubIF
{
    private RSupIF superior;
    private string name;
    public RegularWorker(string name)
    {
        this.name = name;
    }
    public void setSuperior(RSupIF superior)
    {
        this.superior = superior;
    }

    public void seeDanger()
    {
        superior.seeDanger();
    }

    public void fixIt()
    {
        Console.WriteLine("The person " + name + " is fixing it.");
    }

    public void evacuate()
    {
        Console.WriteLine(name + " has evacuated.");
    }
}