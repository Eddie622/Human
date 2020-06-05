using System;

namespace Human
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        
        // add a public "getter" property to access health
        public int Health
        {
            get{ return health; }
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string NameArg) 
        {
            Name = NameArg;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string NameArg, int StrArg, int IntArg, int DexArg, int HealthArg)
        {
            Name = NameArg;
            Strength = StrArg;
            Intelligence = IntArg;
            Dexterity = DexArg;
            health = HealthArg;
        }

        // Build Attack method
        public int Attack(Human target)
        {   
            target.health -= this.Strength*5;
            return target.health;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human Player = new Human("Player");
            Human Enemy = new Human("Enemy", 5, 5, 5, 200);

            Console.WriteLine(Player.Health);
            Console.WriteLine(Enemy.Attack(Player));
            Console.WriteLine(Player.Health);
        }
    }
}
