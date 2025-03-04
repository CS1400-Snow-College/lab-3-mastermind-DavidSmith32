Console.Clear();
Console.WriteLine("I have chosen 4 letters between 'a' and 'g' and have arranged them in a particular order. Your job is to guess the letters and put them in the right order.");
string secret = "";
Random rand = new Random();
for (int i = 0; i < 4; i++)
{
    char temp = (char) rand.Next(97,104);
    while(true)
    {
        if (secret.Contains(temp))
            temp = (char) rand.Next(97,104);
        else
        {
            secret += temp;
            break;
        }
    }  
}
int guessNumber = 0;
do 
{
    guessNumber++;
    Console.WriteLine($"Guess #{guessNumber}: Please guess a sequence of 4 lowercase letters with no repeats.");
    string? guess = Console.ReadLine();
    if (secret[0] == guess[0] && secret[1] == guess[1] && secret[2] == guess[2] && secret[3] == guess[3])
    {   
        break;
    }
    else 
    {
        int correctPositions = 0;
        int incorrectPostiions = 0;
        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i])
            {
                correctPositions++;
            }
            if (secret.Contains(guess[i]) && secret[i] != guess[i])
            {
                incorrectPostiions++;
            }
        }
        Console.WriteLine($"    -{correctPositions} letters in the correct positions\n    -{incorrectPostiions} letters in the incorrect positions");
    }
}
while (true);

Console.Write($"You did it! You guessed my secret ({secret}) in {guessNumber} guesses.");