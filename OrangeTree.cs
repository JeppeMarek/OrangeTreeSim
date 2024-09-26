using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{

    public class OrangeTree
    {
        // Fields
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;
        // Getters and setters - properties
        public int Age
        {
            get {  return age; }
            set { age = value; }
        }
        public int Height
        { 
            get { return height; } 
            set { height = value; } 
        }
        public bool TreeAlive
        {
            get { return treeAlive; }
            set { treeAlive = value; }
        }
        public int NumOranges
        {
            get { return numOranges; }
        }
        public int GetOrangesEaten
        {
            get { return orangesEaten; }
        }
        // Methods
        // 1 gets added to age, height goes up by 2 for each year passed. numOranges is 5 times the age. In the first year no oranges grow
        // All of this happens if the treeAlive is true and the tree is under 80 years old
        public void OneYearPasses()
        {
            age+=1;
            height = age * 2;
            if (age < 80)
            {
                numOranges = 0;
                height += 2;
                treeAlive = true;
                while (age < 1) ;
                numOranges = (age - 1) * 5;
                Console.WriteLine($"The tree is {age} years old, it grew to {height} meters tall\nThe tree currently has: {numOranges} oranges on it");
            }
            else
            {
                treeAlive = false;
                Console.WriteLine("The tree is sadly dead.. may it become firewood instead");
            }
        }
        // Parameter count is the number of oranges you would like to eat - IF there are that many. 
        // The numOranges is redues by count and console prints out oranges eaten and how many are left
        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                numOranges -= count;
                orangesEaten = count;
                Console.WriteLine($"Oranges Consumed: {orangesEaten} There are: {numOranges} left");
            }
            else
            {
                Console.WriteLine("You want more oranges than there is avaiable. . .");
            }
        }   
    }
}
