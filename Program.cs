namespace OrangeTreeSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
         OrangeTree myTree = new OrangeTree();
            myTree.SetAge(3);
            Console.WriteLine(myTree.GetAge());
            myTree.OneYearPasses();
            Console.WriteLine("One year has passed");
            myTree.OneYearPasses();
            Console.WriteLine("How many oranges would you like to eat?");
            int eatOranges = int.Parse(Console.ReadLine());
            myTree.EatOrange(eatOranges);
        }
    }
}
