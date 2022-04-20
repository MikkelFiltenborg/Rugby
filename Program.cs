namespace Rugby
{
    public class Rygby
    {
        public static void Main(string[] args)
        {
            //create string array from methos AddRugbyPlayers.
            string[] player = Rugby_Players.AddRugbyPlayers();
            
            //Call method PrintArray.
            Tools.PrintArray(player);
        }
    }
}