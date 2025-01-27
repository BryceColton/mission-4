// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;
using System.Linq;
using mission_4;
Console.WriteLine("Hello, World!");

//Welcome the user to the game
Console.WriteLine("Welcome to the game!");


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


// declaring GameOver Tuple
string gameOver = null;

bool IsInPlayfield(string[,] playfield, int number)
{
    string stringNumber = number.ToString(); // Convert number to its char representation
    for (int i = 0; i < playfield.GetLength(0); i++)
    {
        for (int j = 0; j < playfield.GetLength(1); j++)
        {
            if (playfield[i, j] == stringNumber)
            {
                return true;
            }
        }
    }
    return false;
}

do
{
    Console.WriteLine("Player 1 which space would you like to take?");

    string input = Console.ReadLine();

    if (int.TryParse(input, out player1) && IsInPlayfield(playfield, player1))
    {
        Console.WriteLine($"{player1} is a valid number and exists in the playfield.");
    }
    else
    {
        Console.WriteLine("Invalid input or the number does not exist in the playfield.");
    }
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
    Supporting.printBoard(playfield);
    gameOver = Winner(playfield, turns);

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

    ticTacToe(playfield);
    gameOver = ticTacToeWinner(playfield, turns);

    
} while (gameOver is null);



if (gameOver == "X")
{
    Console.WriteLine("Player 1 Congratulations you won the game!");
}
else if (gameOver == "O")
{
    Console.WriteLine("Player 2 Congratulations you won the game!");
}
else if (gameOver == "Draw")
{
    Console.WriteLine("Draw!!!!!!");
}



//Ask each player in turn for their choice and update the game board array

//Print the board by calling the method in the supporting class

/* Check for a winner by calling the method in the supporting class, and notify the players
 When a win has occurred and which player won the game */

