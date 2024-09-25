using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public void SetAge (int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight() 
        { 
            return this.height;
        }
        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }
        public bool GetTreeAlive()
        {
            return this.treeAlive;
        }
        public int getNumOranges()
        {
            return numOranges;
        } 
        public int GetOrangesEaten()
        {
            return orangesEaten;
        }
        public void OneYearPasses()
        {
            age+=1;
            if (age < 80)
            {
                numOranges = 0;
                height += 2;
                treeAlive = true;/*
                while (age < 1)
                {
                    numOranges = age * 5;
                }
                */
                numOranges = (age - 1) * 5;
                Console.WriteLine($"The tree is {age} years old, it grew to {height} meters tall\nThe tree currently has: {numOranges} oranges on it");
            }
            else
            {
                treeAlive = false;
                Console.WriteLine("The tree is sadly dead.. may it become firewood instead");
            }
        }
        /*
        public void EatOrange(int count)
        {

        }
        */
    }
}
