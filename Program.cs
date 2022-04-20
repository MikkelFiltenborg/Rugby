namespace Rugby
{
    public class Rygby
    {
        public static void Main(string[] args)
        {
            //Array.
            Console.WriteLine("\nArray.");
            //create string array from methos AddRugbyPlayersArray.
            string[] playerA = Rugby_Players.AddRugbyPlayersArray();
            
            //Call method PrintArray.
            Tools.PrintArray(playerA);

            //List.
            Console.WriteLine("\n\nList.");

            //create string array from methos AddRugbyPlayersList.
            List<string> playerL = Rugby_Players.AddRugbyPlayersList();

            //Call method PrintAList.
            Tools.PrintList(playerL);
        }
    }
}