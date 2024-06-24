using RPSGame;

namespace RPSGameTest
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData("rock", "scissors", 1)]
        [InlineData("scissors", "paper", 1)]
        [InlineData("paper", "rock", 1)]
        [InlineData("scissors", "rock", -1)]
        [InlineData("paper", "scissors", -1)]
        [InlineData("rock", "paper", -1)]
        [InlineData("rock", "rock", 0)]
        [InlineData("scissors", "scissors", 0)]
        [InlineData("paper", "paper", 0)]
        public void CompareMoves_ShouldReturnCorrectResult(string playerMove, string aiMove, int expected)
        {
            // Arrange
            Player player = new Player("Player");
            Player ai = new Player("AI");
            RPSGamee game = new RPSGamee(player, ai);

            // Act
            int result = game.CompareMoves(playerMove, aiMove);
            

            // Assert
            Assert.Equal(expected, result);
        }
    }
}