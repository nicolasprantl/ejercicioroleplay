using RoleplayGame.Scenarios;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IScenario scenario = new ConsoleScenario();
            scenario.Setup();
            scenario.Run();
        }
    }
}
