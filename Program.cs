using System;
using System.Collections.Generic;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int Loop = 0;
            int rolls = 0;
            int total = 0;
            int tot2 = 0;
            
            List<int> rollList = new List<int>();

            Console.WriteLine("would you like to role a dice? ");
            string response = Console.ReadLine();
            if(response == "yes") {
                while(Loop < 1) {
                    Random random = new Random();
                    int roll = random.Next(1,7);
                    
                    rollList.Add(roll);
                    total = total + roll;
                    rolls++;
                    
                    
                    Console.WriteLine("you rolled a " + roll);
                    Console.WriteLine("would you like to roll again? ");
                    if(Console.ReadLine() == "no"){
                         Loop++;
                    }
                }
            }

            Console.WriteLine("you made " + rolls + " roles in total");
            Console.WriteLine("your total is " + total);
            Console.WriteLine("your average role was " + (total/rolls));

            Console.WriteLine("how many rolls would you like to examine");
            string sNum = Console.ReadLine();
            int iNum = int.Parse(sNum);
            Console.WriteLine("you rolled these numbers in " + iNum + " roles");
            for (int i = 0; i < iNum; i++)
            {
                Console.WriteLine(rollList[i]);
                tot2 = tot2 + rollList[i];
            }
            Console.WriteLine("total: " + tot2);
            Console.WriteLine("average: " + (tot2/iNum));
        }
    }
}
