using System;

namespace ArraySelfPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = {"stella", "solana", "posey", "wade", "duggar"};
            int[] age = new int[5];
            age[0] = 20;
            age[2] = 32;
            age[1] = 18;
            age[4] = 21;
            age[3] = 25;
            Random random = new Random();
            
            Console.WriteLine($"{players[0]} is {age[2]}");
            Console.WriteLine($"{players[3]} is {age[4]}");
            Console.ReadLine();
            
            foreach (string i in players){
                int randomAge = random.Next(0, age.Length);
                Console.WriteLine($"{i} is {age[randomAge]}");
            }
            Console.ReadLine();
            
            
        }
    }
}
