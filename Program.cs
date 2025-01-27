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
    Console.WriteLine($"Updated playfield[{row}, {col}] to {playerSign}"); // Debug print
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

while (gameOver == null)
{

    TicTacToeBoard tcb = new TicTacToeBoard();

    tcb.PrintBoard(playfield);

    //Welcome the user to the game
    Console.WriteLine("Welcome to the game!");

    Console.WriteLine("Player 1 which space would you like to take?");



    string input = Console.ReadLine();

    if (!int.TryParse(input, out int position) || position < 1 || position > 9)
    {
        Console.WriteLine("Please enter a valid number between 1 and 9.");
        continue; // Skip the rest of the loop for invalid input
    }

    if (!IsInPlayfield(playfield, position))
    {
        Console.WriteLine("That spot is already taken. Please choose another.");
        continue; 
    }

    //else
    //{
    //    Console.WriteLine("Invalid input or the number does not exist in the playfield.");
    //}
    string playerSign1 = "X";
    string playerSign2 = "O";

    switch (player1)
    {
        case 1:
            playfield[0, 0] = playerSign1; break;
        case 2:
            playfield[0, 1] = playerSign1; break;
        case 3:
            playfield[0, 2] = playerSign1; break;
        case 4:
            playfield[1, 0] = playerSign1; break;
        case 5:
            playfield[1, 1] = playerSign1; break;
        case 6:
            playfield[1, 2] = playerSign1; break;
        case 7:
            playfield[2, 0] = playerSign1; break;
        case 8:
            playfield[2, 1] = playerSign1; break;
        case 9:
            playfield[2, 2] = playerSign1; break;

    }

    turns++;

    tcb.PrintBoard(playfield);
    gameOver = tcb.Winner(playfield, turns);

    UpdatePlayfield(playfield, position, "X");

    if (gameOver != null)
    {
        break;
    }

    Console.WriteLine("Player 2 which space would you like to take?");
    input = Console.ReadLine();

    if (int.TryParse(input, out player2) && IsInPlayfield(playfield, player2))
    {
        Console.WriteLine($"{player2} is a valid number and exists in the playfield.");
    }
    else
    {
        Console.WriteLine("Invalid input or the number does not exist in the playfield.");
    }
    switch (player2)
    {
        case 1:
            playfield[0, 0] = playerSign2; break;
        case 2:
            playfield[0, 1] = playerSign2; break;
        case 3:
            playfield[0, 2] = playerSign2; break;
        case 4:
            playfield[1, 0] = playerSign2; break;
        case 5:
            playfield[1, 1] = playerSign2; break;
        case 6:
            playfield[1, 2] = playerSign2; break;
        case 7:
            playfield[2, 0] = playerSign2; break;
        case 8:
            playfield[2, 1] = playerSign2; break;
        case 9:
            playfield[2, 2] = playerSign2; break;

    }
    turns++;

    tcb.PrintBoard(playfield);
    gameOver = tcb.Winner(playfield, turns);

    if (gameOver != null)
    {
        break;
    }


}

Console.WriteLine(gameOver);




//Ask each player in turn for their choice and update the game board array

//Print the board by calling the method in the supporting class

/* Check for a winner by calling the method in the supporting class, and notify the players
 When a win has occurred and which player won the game */

