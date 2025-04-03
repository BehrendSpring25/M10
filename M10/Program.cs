public class Program
{
    public static void Main(string[] args)
    {
        // Create instances
        CEO ceo = new CEO("CEO");
        Manager manager = new Manager("Manager");
        ProjectLeader leader = new ProjectLeader("Leader");
        RegularWorker john = new RegularWorker("John");

        // Setup hierarchy
        john.setSuperior(leader);
        leader.setSuperior(manager);
        manager.setSuperior(ceo);
        leader.addSub(john);
        manager.addSub(leader);
        ceo.addSub(manager);

        // Scenario
        Console.WriteLine("John observes a gas leak and reports it.");
        john.seeDanger(); // John observes danger

        Console.WriteLine("\nLeader handles the danger.");
        leader.seeDanger(); // Leader handles danger

        Console.WriteLine("\nManager handles the danger.");
        manager.seeDanger(leader); // Manager handles danger

        Console.WriteLine("\nCEO handles the danger.");
        ceo.seeDanger(); // CEO handles danger
    }
}