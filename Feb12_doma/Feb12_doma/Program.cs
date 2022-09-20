using System;

namespace Feb12_doma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region(IsPrime)
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
            #endregion(IsPrime)

            #region(CalcAvg)

            int[] myArr = { 20, 40, 30, 50 };
            if (CalcAvg(myArr) > 60)
            {
                Console.WriteLine("Imtahannan kecdiniz!");
            }
            else
            {
                Console.WriteLine("Imtahannan kesildiz!");
            }

            #endregion(CalcAvg)
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
        static int FindCharIndex(string word, char letter)
        {
            if (word.IndexOf(letter) == 1)   //IndexOf methodunu internetde tapdim research zamani
            {
                return -1;
            }
            else
            {
                return word.IndexOf(letter);
            }
        }
        static int CalcAvg(params int[] arr)
        {
            int Sum = 0;
            foreach (int item in arr)
            {
                Sum += item;
            }
            return Sum / arr.Length;
        }
    }
}