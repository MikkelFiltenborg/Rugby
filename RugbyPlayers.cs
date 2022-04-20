namespace Rugby
{
    public class Rugby_Players
    {
        //Array.
        public static string[] AddRugbyPlayersArray()
        {
            //create string array size 5
            string[] player = new string[5];

            //add array elements.
            player[0] = "Maro Itoje";
            player[1] = "Beauden Barrett";
            player[2] = "Cheslin Kolbe";
            player[3] = "Antoine Dupont";
            player[4] = "Owen Farrell";

            //return value player.
            return player;
        }

        //List.
        public static List<string> AddRugbyPlayersList()
        {
            //create a List.
            List<string> player = new List<string>();

            //add elements to List.
            player.Add("Faf de Klerk");
            player.Add("Eben Etzebeth");
            player.Add("Michael Hooper");
            player.Add("Jonah Lomu");
            player.Add("Brian O'Driscoll");

            //return value player.
            return player;
        }
    }
}
