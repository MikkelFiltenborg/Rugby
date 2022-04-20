namespace Rugby
{
    public class Tools
    {
        public static void PrintArray(string[] player)
        {
            //counter.
            int count = 0;

            //for loop.
            Console.WriteLine("For loop");
            for (int i = 0; i < player.Length; i++)
            {
                //add +1 to i, then white player.
                Console.WriteLine($"{i + 1} {player[i]}");
            }

            //foreach loop.
            Console.WriteLine("\noreach loop");
            foreach (var item in player)
            {
                //add +1 to count, then write item.
                Console.WriteLine($"{count + 1} {item}");
                count++;
            }

            //set count to = 0.
            count = 0;
            //while loop.
            Console.WriteLine("\nWhile loop");
            while (count < player.Length)
            {
                //add +1 to count, then write player count.
                Console.WriteLine($"{count + 1} {player[count]}");
                count++;
            }
        }
    }
}
