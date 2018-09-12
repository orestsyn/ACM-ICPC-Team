using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_ICPC_Team
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string[] numbers = new string[2];
            numbers = s.Split(' ');
            int number_of_attendees = Convert.ToInt32(numbers[0]);
            int number_of_topics = Convert.ToInt32(numbers[1]);
            char[,] array = new char[number_of_attendees, number_of_topics];
            for (int count = 0; count < number_of_attendees; count++)
            {
                string k = Console.ReadLine();
                char[] m = k.ToCharArray();
                for (int j = 0; j < number_of_topics; j++)
                {
                    int i = count;
                    array[i, j] = m[j];
                }
            }
            //work with array now
            int MaxAmount = 0;
            int TeamAmounts = 0;
            for (int i = 0; i < number_of_attendees - 1; i++)
            {
                for (int j = i + 1; j < number_of_attendees; j++)
                {
                    int topicks = 0;
                    for (int x = 0; x < number_of_topics; x++)
                    {
                        topicks += (array[i, x] == '1' || array[j, x] == '1') ? 1 : 0;
                        if (topicks > MaxAmount)
                        {
                            MaxAmount = topicks;
                            TeamAmounts = 1;
                        }
                        else if (topicks == MaxAmount)
                        {
                            TeamAmounts++;
                        }
                    }
                }
            }
            Console.WriteLine(MaxAmount);
            Console.WriteLine(TeamAmounts);
            Console.ReadKey();
        }
    }
}
