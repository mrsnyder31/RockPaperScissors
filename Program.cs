using System;

int PlScore = 0;
int CoScore = 0;

Main();
void Main()
{

    Console.WriteLine("---------------------------");
    Console.WriteLine($"| Player: {PlScore} | Computer: {CoScore} |");
    Console.WriteLine("---------------------------");
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");


    Console.Write("");
    var answer = Console.ReadLine().ToLower();

    if (answer == "1")
    {
        Rock();
    }
    else if (answer == "2")
    {
        Paper();
    }
    else
    {
        Scissors();
    }

    Console.WriteLine("vs");

    Random r = new Random();
    int result = r.Next(1, 4);

    if (result == 1)
    {
        Rock();
    }
    else if (result == 2)
    {
        Paper();
    }
    else
    {
        Scissors();
    }


    if (answer == "1" && result == 2)
    {
        CoScore++;
    }
    if (answer == "1" && result == 3)
    { PlScore++; }

    if (answer == "2" && result == 1)
    { PlScore++; }
    if (answer == "2" && result == 3)
    { CoScore++; }

    if (answer == "3" && result == 1)
    { CoScore++; }
    if (answer == "3" && result == 2)
    { PlScore++; }


    if (PlScore == 3)
    {
        Console.WriteLine("YOU WIN");
        Environment.Exit(0);
    }
    else if (CoScore == 3)
    {
        Console.WriteLine("YOU LOSE");
        Environment.Exit(0);
    }
    else
    {
        Main();
    }

}

// void BattleModeEngage()
// {

// };

void Rock()
{
    Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____) 
      (____)
---.__(___)
    ");

}

void Paper()
{
    Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
    ");
    ;
}

void Scissors()
{
    Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
    ");

}
