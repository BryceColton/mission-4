// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;
using System.Linq;
using mission_4;



// initializing the player 1 and player 2 values
int player1 = 0;
int player2 = 0;

//Create a game board array to store the players' choices
 string[,] playfield =
{
    {"1", "2", "3" },
    {"4", "5", "6" },
    {"7", "8", "9" }
};

 int turns = 0;


void UpdatePlayfield(string[,] playfield, int position, string playerSign)
{
    int row = (position - 1) / 3;
    int col = (position - 1) % 3;

    // Ensure the position is updated
    playfield[row, col] = playerSign;
    //Console.WriteLine($"{playerSign}"); // Debug print
}



// declaring GameOver Tuple
string gameOver = null;

bool IsInPlayfield(string[,] playfield, int number)
{
    // Calculate the row and column based on the input number
    int row = (number - 1) / 3;
    int col = (number - 1) % 3;

    // Check if the position is already taken by "X" or "O"
    if (playfield[row, col] == "X" || playfield[row, col] == "O")
    {
        return false; // Spot is taken
    }

    return true; // Spot is available
}
string currentPlayer = "Player 1"; // Track the current player
string currentSign = "X";         // Track the current player's sign

while (gameOver == null)
{
    TicTacToeBoard tcb = new TicTacToeBoard();
    tcb.PrintBoard(playfield);

    Console.WriteLine($"{currentPlayer}, which space would you like to take?");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out int position) || position < 1 || position > 9)
    {
        Console.WriteLine("Please enter a valid number between 1 and 9.");
        continue; // Retry the same player's turn
    }

    if (!IsInPlayfield(playfield, position))
    {
        Console.WriteLine("That spot is already taken. Please choose another.");
        continue; // Retry the same player's turn
    }

    // Update the playfield
    UpdatePlayfield(playfield, position, currentSign);
    turns++;

    // Check if the current player wins
    gameOver = tcb.Winner(playfield, turns);
    if (gameOver != null)
        break;

    // Switch to the other player
    if (currentPlayer == "Player 1")
    {
        currentPlayer = "Player 2";
        currentSign = "O";
    }
    else
    {
        currentPlayer = "Player 1";
        currentSign = "X";
    }
}

//tcb.PrintBoard(playfield);
Console.WriteLine(gameOver);

