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

                RPSGamee game = new RPSGamee(player , ai);
                game.PlayGAme();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
