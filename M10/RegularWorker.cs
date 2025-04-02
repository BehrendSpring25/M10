public class RegularWorker : MSubIF, CEOSubIF, PSSubIF
{
    private RSupIF superior;
    private string name;

    public void seeDanger()
    {
        superior.seeDanger();
    }

    public void fixIt()
    {
        Console.WriteLine("The person " + name + " is fixing it.");
    }
}