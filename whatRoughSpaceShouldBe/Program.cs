namespace RoughSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days you want to simulate");

            int days = int.Parse(Console.ReadLine());

            int[] temparature = new int[days];

            string[] conditions = { "Snowy", "Rainy", "Windy", "Cloudy" };

            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temparature[i] = random.Next(-10, 40);

                if (temparature[i] <= 0)
                {
                    weatherConditions[i] = conditions[0];
                }
                else
                {

                    weatherConditions[i] = conditions[random.Next(conditions.Length)];
                }

            }
            Console.WriteLine($" The most common condition was {CalculateAverage(temparature)}");
            Console.WriteLine($"The most common weather is { MostCommonCondition(weatherConditions)}");
        }
        static double CalculateAverage(int[] temparature)
        {
            double sum = 0;
            for (int i = 0; i < temparature.Length; i++)
            {
                sum += temparature[i];
            }
            double average = sum / temparature.Length;
            return average;
        }
        //If you love stress don't use .Min just write a WHOLE method to do just that
        static int MinimumTemparature(int[] temparature)
        {
            int mini = 0;
            for(int i = 0; i<temparature.Length; i++)
            {
                if (temparature[i] < mini)
                {
                    mini = temparature[i];
                }
            }
            return mini;
        }
        static string MostCommonCondition(string[] condition)
        {
            int count = 0;
            string mostCommon = condition[0];
            for (int i = 0; i<condition.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < condition.Length; j++)
                {
                    if (condition[j] == condition[i])
                    {
                        tempCount++;
                    }
                    if (tempCount > count)
                    {
                        condition[j] = mostCommon;
                    }
                }
            }
            
            return mostCommon;
        }

    }
}
