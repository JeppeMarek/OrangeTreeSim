namespace OrangeTreeSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
         OrangeTree myTree = new OrangeTree();
            myTree.SetAge(0);
            Console.WriteLine(myTree.GetAge());
            myTree.OneYearPasses();
            Console.WriteLine("One year has passed");
            myTree.OneYearPasses();

        }
    }
}
