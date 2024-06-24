namespace RPSGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Player player = new Player("Player");
                Player ai = new Player("AI");

                RPSGame game = new RPSGame(player , ai);
                game.PlayGAme();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred : {ex.Message}");
            }
        }
    }
}
