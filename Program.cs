namespace OrangeTreeSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            OrangeTree myTree = new OrangeTree();
            myTree.Age = 3;
            Console.WriteLine("The tree is : {0} years old",myTree.Age);
            myTree.OneYearPasses();
            Console.WriteLine("One year has passed");
            myTree.OneYearPasses();
            Console.WriteLine("How many oranges would you like to eat?");
            int eatOranges = int.Parse(Console.ReadLine());
            myTree.EatOrange(eatOranges);
            
        }
    }
}
