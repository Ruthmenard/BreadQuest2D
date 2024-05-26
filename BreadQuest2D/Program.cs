using BreadQuest2Dv2;
using System.Threading;

Game game;
#region Intro
Console.Title = "Bread Quest v0.13";
Console.WriteLine("                                         IN A WORLD");
Thread.Sleep(2000);
Console.WriteLine("                                    WHERE BREAD IS ILLEGAL");
Thread.Sleep(2000);
Console.WriteLine("                                  ONE MAN WHO CRAVES GLUTEN");
Thread.Sleep(2000);
Console.WriteLine("                                       PREPARES TO BAKE");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine(" _|_|_|    _|_|_|    _|_|_|_|    _|_|    _|_|_|          _|_|      _|    _|  _|_|_|_|    _|_|_|  _|_|_|_|_|  ");
Thread.Sleep(350);
Console.WriteLine(" _|    _|  _|    _|  _|        _|    _|  _|    _|      _|    _|    _|    _|  _|        _|            _|      ");
Thread.Sleep(350);
Console.WriteLine("_ |_|_|    _|_|_|    _|_|_|    _|_|_|_|  _|    _|      _|  _|_|    _|    _|  _|_|_|      _|_|        _|      ");
Thread.Sleep(350);
Console.WriteLine("_ |    _|  _|    _|  _|        _|    _|  _|    _|      _|    _|    _|    _|  _|              _|      _|      ");
Thread.Sleep(350);
Console.WriteLine("_ |_|_|    _|    _|  _|_|_|_|  _|    _|  _|_|_|          _|_|  _|    _|_|    _|_|_|_|  _|_|_|        _|      ");
Thread.Sleep(350);
Console.WriteLine();
Console.WriteLine("                                          A Game by JP                                "); Thread.Sleep(300);
Console.WriteLine("                                          Music by Max                                "); Thread.Sleep(300);
Console.WriteLine("                                          Art by Tyler                                "); Thread.Sleep(300);
Console.WriteLine("                                    Senior Editing by Aaron                           "); Thread.Sleep(500);
Console.WriteLine();
Console.WriteLine("                                                  ██████████████                      "); Thread.Sleep(200);
Console.WriteLine("                                         ████████▓▓▓▓██░░░░██▓▓████                   "); Thread.Sleep(200);
Console.WriteLine("                                ████████░░░░░░░░██▓▓██░░░░██▓▓▓▓▓▓██                  "); Thread.Sleep(200);
Console.WriteLine("                              ████░░██▓▓▓▓██░░░░░░██▓▓▓▓██░░██▓▓▓▓▓▓▓▓██              "); Thread.Sleep(200);
Console.WriteLine("                          ████░░░░░░░░██▓▓▓▓██░░░░██▓▓▓▓██░░██▓▓▓▓▓▓▓▓██              "); Thread.Sleep(200);
Console.WriteLine("                        ██▓▓▓▓██░░░░░░░░██▓▓▓▓██░░██▓▓▓▓██░░██▓▓▓▓▓▓██                "); Thread.Sleep(200);
Console.WriteLine("                      ██▓▓▓▓▓▓▓▓██░░░░░░██▓▓▓▓██░░██▓▓▓▓██░░██▓▓▓▓▓▓██                "); Thread.Sleep(200);
Console.WriteLine("                      ██▓▓▓▓▓▓▓▓▓▓██░░░░██▓▓▓▓██░░██▓▓▓▓▓▓██▓▓▓▓▓▓▓▓██                "); Thread.Sleep(200);
Console.WriteLine("                      ██▓▓▓▓▓▓▓▓▓▓▓▓██░░██▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██                  "); Thread.Sleep(200);
Console.WriteLine("                      ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████                    "); Thread.Sleep(200);
Console.WriteLine("                      ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████                        "); Thread.Sleep(200);
Console.WriteLine("                        ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████                            "); Thread.Sleep(200);
Console.WriteLine("                            ████████▓▓▓▓▓▓▓▓▓▓▓▓██████                                "); Thread.Sleep(200);
Console.WriteLine("                                    ████████████                                      "); Thread.Sleep(400);
Console.WriteLine();
Console.WriteLine("                                  PRESS ANY KEY TO BEGIN");
Console.ReadKey();
Console.Clear();
#endregion

//Initial Choice
Console.WriteLine("In a post-apocalyptic world dominated by AI robots, bread is banned.");
Console.WriteLine("You are Charles, a resilient human trying to revive the tradition of bread-making.");
Console.WriteLine("Your mission is to gather ingredients and bake bread to bring hope to your community.");
int userChoice = Helpers.GetUserChoice("Understand? ", "You didn't provide a valid option. Please try again.", ["Yes", "No"]);
Console.WriteLine();
switch (userChoice)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Good. Now, let's get down to business.");
        Thread.Sleep(1000);
        game = new Game(); // automatically gives us a new player with default stats
        // Inital Choice
        Console.WriteLine();
        game.ShowInitialChoice();
        break;
    case 2:
        Console.WriteLine("Then there is no use for you");
        Console.WriteLine("You are shot 37 times in the chest, leaving nothing but crumbs");
        Console.WriteLine("YOU ARE COOKED");
        break;
}
Console.ReadLine();
