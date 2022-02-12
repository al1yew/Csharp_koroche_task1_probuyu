using System;

namespace Feb12_doma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salam, sizi IsPrime saytinda xosh gorduk");
            Console.WriteLine("Her hansi deyeri daxil edin, biz size sade ya murekkeb oludugunu deyek!");

            string inputuser = Console.ReadLine();
            int value = int.Parse(inputuser);

            if (value <= 0)
            {
                Console.WriteLine("Musbet eded daxil edin.");
            }
            else if(IsPrime(value) == true)
            {
                Console.WriteLine("Murekkeb ededdir.");
            }
            else
            {
                Console.WriteLine("Sade ededdir.");
            }
        }
        static bool IsPrime(int a)
        {
            if (a < 0)
            {
                return false;
            }
            else if (a == 1 || a == 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void FindCharIndex(string a, char b)
        { 
            
        
        
        
        
        
        
        
        
        }

    }
}
