﻿namespace TheGiraffeGame
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Security;
    using System.Text;
    using System.Threading;
    using TheGiraffeGame;
using WMPLib;

    class StartingPoint
    {
        private static string savePath = Path.Combine(Environment.CurrentDirectory, "Score.txt"); //save to current directory

        public static string playerName = "Anonymous";
        public static GiraffesHead GiraffesHead;

        private static List<Particle> Particles;

        public static bool isHit = false;

        private static int Score = 0;
        private static int ApplesEaten = 0;

        private static int level = GlobalConstants.DefaultLevel;
        private static String currentLevel = GlobalConstants.LevelOneName;

        private static string timeAlive;
        private static Stopwatch stopwatch;

        private static string giraffesColor = "Yellow";
        private static ConsoleColor defaultColor = ConsoleColor.Yellow;

        private static MusicPlayer BackgroundPlayer;
        private static MusicPlayer EatApplePlayer;
        private static MusicPlayer GameOverPlayer;

        private static void ShowMainMenu()
        {
            Console.Clear();
            SetDefaultForegroundColor();

            var menuOptions = new string[]{ "New Game",
                                            "Choose difficulty",
                                            "Leaderbord",
                                            "Customize giraffe",
                                            "Exit"};

            PrintMenu("Menu: ", menuOptions);

            int choice = InteractiveMenu(menuOptions.Length);

            Console.Clear();
            switch (choice + 1)
            {
                case 1: PlayGame(); break;
                case 2: ChooseLevel(); break;
                case 3: ShowLeaderbord(); break;
                case 4: ShowCustomizeGiraffeMenu(); break;
                case 5: Exit(); break;
                default:
                    break;
            }
        }

        private static void ShowLeaderbord()
        {
            Dictionary<string, int> leaderboard = new Dictionary<string, int>();
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                using (StreamReader streamReader = new StreamReader(@savePath))
                {
                    while (streamReader.Peek() >= 0)
                    {
                        var playerScore = streamReader.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                        try
                        {
                            leaderboard.Add(playerScore[1], int.Parse(playerScore[3]));
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Score and player names are not in the correct format!");
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path contains a directory that cannot be found!");
                Thread.Sleep(2000);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file '{0}' was not found!", @savePath);
                Thread.Sleep(2000);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
                Thread.Sleep(2000);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is incorrect!");
                Thread.Sleep(2000);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is over the 248 characters maximum!");
                Thread.Sleep(2000);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
                Thread.Sleep(2000);
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have the required permission to access this file!");
                Thread.Sleep(2000);
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
                Thread.Sleep(2000);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
                Thread.Sleep(2000);
            }
            finally
            {
                SetDefaultForegroundColor();
            }

            var top10Players = leaderboard.OrderByDescending(s => s.Value).Take(10).ToArray();
            string[] top10 = new string[top10Players.Length];

            for (int i = 0; i < top10.Length; i++)
            {
                top10[i] = string.Format("{0}. {1} - {2}", i + 1, top10Players[i].Key, top10Players[i].Value);
            }

            PrintMenu("Highscores", top10);

            Console.ReadKey();
            ShowMainMenu();
        }

        private static void ShowCustomizeGiraffeMenu()
        {
            string[] colorOptions = new string[] { "Yellow", "Cyan", "Blue", "Green", "Red", "Gray" };
            PrintMenu("Choose your favorite color from all these :", colorOptions);

            int choice = InteractiveMenu(colorOptions.Length);

            giraffesColor = colorOptions[choice];
            SetForegroundColor(giraffesColor);
            Console.Clear();
            ShowMainMenu();
        }

        private static void ChooseLevel()
        {
            Console.Clear();
            var levelOptions = new string[] { "Easy", "Medium", "Hard", "Impossibru" };
            PrintMenu("Choose Level: ", levelOptions);
            int choice = InteractiveMenu(levelOptions.Length);

            switch (choice + 1)
            {
                case 1: level = 250; currentLevel = GlobalConstants.LevelOneName; break;
                case 2: level = 150; currentLevel = GlobalConstants.LevelTwoName; break;
                case 3: level = 100; currentLevel = GlobalConstants.LevelThreeName; break;
                case 4: level = 0; currentLevel = GlobalConstants.LevelSixName; break;
                default: break;
            }

            ShowMainMenu();
        }

        private static void Exit()
        {
            Console.Clear();
            Console.SetCursorPosition(10, Console.WindowHeight / 2);
            Console.CursorVisible = true;

            Console.Write("Are you sure you want to exit the game (y/n)? ");

            string answer = Console.ReadLine();
            if (answer.ToLower() == "y" || answer.ToLower() == "yes")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.CursorVisible = false;
                ShowMainMenu();
            }
        }

        private static void LevelScoring(int level)
        {
            if (level <= 0)
            {
                level = 0;

                if (level == 0)
                {
                    currentLevel = GlobalConstants.LevelSixName;
                    Score += GlobalConstants.LevelSixScore;
                }

            }
            else if (level < 50)
            {
                currentLevel = GlobalConstants.LevelFiveName;
                Score += GlobalConstants.LevelFiveScore;
            }
            else if (level < 100)
            {
                currentLevel = GlobalConstants.LevelFourName;
                Score += GlobalConstants.LevelFourScore;
            }
            else if (level < 150)
            {
                currentLevel = GlobalConstants.LevelThreeName;
                Score += GlobalConstants.LevelThreeScore;
            }
            else if (level < 200)
            {
                currentLevel = GlobalConstants.LevelTwoName; ;
                Score += GlobalConstants.LevelTwoScore;
            }
            else
            {
                currentLevel = GlobalConstants.LevelOneName;
                Score += GlobalConstants.LevelOneScore;
            }
        }

        private static void PrintMenu(string menuMessage, string[] menuOptions)
        {
            int cursorRow = 8;
            Console.SetCursorPosition(25, cursorRow);
            Console.WriteLine(menuMessage);
            cursorRow++;

            Console.SetCursorPosition(25, cursorRow);
            Console.WriteLine();
            cursorRow++;
            foreach (var option in menuOptions)
            {
                Console.SetCursorPosition(25, cursorRow);
                Console.WriteLine(option);
                cursorRow++;
            }
        }

        private static int InteractiveMenu(int menuOptionsCount)
        {
            char arrowSymbol = '*';
            int consoleCol = 23;
            int startConsoleRow = 10;
            int endConsoleRow = startConsoleRow + menuOptionsCount - 1;
            int consoleRow = startConsoleRow;

            while (true)
            {

                Console.CursorVisible = false;
                Console.SetCursorPosition(consoleCol, consoleRow);
                Console.WriteLine(arrowSymbol);
                Console.SetCursorPosition(consoleCol, consoleRow);
                ConsoleKeyInfo arrow = Console.ReadKey();

                if (consoleRow > startConsoleRow || consoleRow < endConsoleRow)
                {

                    if (arrow.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(consoleCol, consoleRow);
                        Console.WriteLine(" ");

                        consoleRow--;
                    }
                    else if (arrow.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(consoleCol, consoleRow);
                        Console.WriteLine(" ");
                        consoleRow++;
                    }
                }
                if (consoleRow < startConsoleRow)
                {
                    consoleRow = endConsoleRow;
                }
                if (consoleRow > endConsoleRow)
                {
                    consoleRow = startConsoleRow;
                }
                if (arrow.Key == ConsoleKey.Enter)
                {
                    return consoleRow - startConsoleRow;
                }
            }
        }

        private static void MoveHead(ConsoleKeyInfo keyinfo)
        {

            switch (keyinfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (GiraffesHead.Row > 3)
                    {
                        DrawMovedHead(-1);
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (GiraffesHead.Row < GlobalConstants.rows - 1)
                    {
                        DrawMovedHead(1);
                    } break;
                default:
                    break;
            }
        }

        private static void DrawMovedHead(int movement)
        {
            Console.SetCursorPosition(GiraffesHead.Col, GiraffesHead.Row);
            Console.Write(' ');

            GiraffesHead.Row += movement;
            Console.SetCursorPosition(GiraffesHead.Col, GiraffesHead.Row);
            Console.Write(GlobalConstants.giraffesMouthChar);
            Console.SetCursorPosition(GiraffesHead.Col - 6, GiraffesHead.Row - 2);
            Console.Write(GlobalConstants.giraffesHead);
        }

        private static void MoveNeck()
        {
            SetForegroundColor(giraffesColor);

            for (int i = GiraffesHead.Row + 1; i < GlobalConstants.rows; i++)
            {
                Console.SetCursorPosition(GiraffesHead.Col - 3, i);
                Console.Write(GlobalConstants.giraffesNeckChar);
                Console.Write(GlobalConstants.giraffesNeckChar);
            }

            Console.SetCursorPosition(GiraffesHead.Col - 6, GiraffesHead.Row - 3);
            Console.Write("      ");
            Console.SetCursorPosition(GiraffesHead.Col - 1, GiraffesHead.Row - 1);
            Console.Write(" ");
            Console.SetCursorPosition(GiraffesHead.Col - 1, GiraffesHead.Row + 1);
            Console.Write(" ");

            SetDefaultForegroundColor();
        }

        private static void DrawGiraffesHead()
        {
            Console.SetCursorPosition(GiraffesHead.Col, GiraffesHead.Row);
            Console.Write(GlobalConstants.giraffesMouthChar);
            Console.SetCursorPosition(GiraffesHead.Col - 6, GiraffesHead.Row - 2);
            Console.Write(GlobalConstants.giraffesHead);
        }

        private static void DrawGiraffesBody()
        {
            SetForegroundColor(giraffesColor);
            Console.SetCursorPosition(20, 19);
            Console.WriteLine(GlobalConstants.GiraffesBody);
            SetDefaultForegroundColor();
        }

        private static void MoveParticles(List<Particle> particles)
        {
            particles.Add(Particle.GenerateParticle());

            for (int i = 0; i < particles.Count; i++)
            {

                if (particles[i].Col > GiraffesHead.Col - 1)
                {
                    Console.SetCursorPosition(particles[i].Col, particles[i].Row);
                    Console.Write(' ');

                    particles[i].Col--;

                    if (particles[i].Row == GiraffesHead.Row && particles[i].Col == GiraffesHead.Col)
                    {
                        if (particles[i].IsGood)
                        {
                            ApplesEaten++;
                            level -= 5;
                            if (level < 0)
                            {
                                level = 0;
                            }

                            LevelScoring(level);
                            particles.Remove(particles[i]);

                            // blinking green to notify that the score raised
                            Console.BackgroundColor = ConsoleColor.Green;
                            ShowRealtimeScore(ApplesEaten);
                            Console.ResetColor();
                        }
                        else
                        {
                            isHit = true;
                            break;
                        }
                    }

                    DrawParticle(particles[i]);
                }
                else
                {
                    Console.SetCursorPosition(particles[i].Col, particles[i].Row);
                    Console.Write(' ');
                    particles.Remove(particles[i]);
                }
            }
        }

        private static void DrawParticle(Particle particle)
        {
            Console.SetCursorPosition(particle.Col, particle.Row);

            // If the particle is good it will be green, else it will be red
            Console.ForegroundColor = particle.IsGood ? ConsoleColor.Green : ConsoleColor.Red;
            Console.Write(particle.Symbol);
            SetDefaultForegroundColor();
        }

        private static void ShowRealtimeScore(int apples)
        {
            SetDefaultForegroundColor();
            Console.SetCursorPosition(45, 22);
            Console.WriteLine(">>>  {0}  <<<", currentLevel);
            Console.SetCursorPosition(45, 23);
            Console.WriteLine(">>>  Score: {0}  <<<", Score);
            Console.SetCursorPosition(45, 24);
            Console.WriteLine(">>>  Apples eaten: {0}  <<<", apples);

        }

        static void Main()
        {
            SetupConsole();
            ShowMainMenu();
        }

        private static void SetupConsole()
        {
            Console.SetWindowSize(70, 27);
            SetForegroundColor("Yellow");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
        }

        private static void PlayGame()
        {
            Particles = new List<Particle>();
            GiraffesHead = new GiraffesHead(5, 20);

            //Creating and starting a stopwatch as a way to get score
            stopwatch = new Stopwatch();
            stopwatch.Start();
            //// Uncomment to enable Player
            //BackgroundPlayer = new MusicPlayer();
            //BackgroundPlayer.open(GlobalConstants.BackgroundSong);
            //BackgroundPlayer.play();

            //GameOverPlayer = new MusicPlayer();
            //GameOverPlayer.open(GlobalConstants.GameOverSong, false);

            bool isMute = false;

            while (true)
            {
                if (Console.KeyAvailable) // true if a key press is available in the input stream
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true); // reads the next key
                    while (Console.KeyAvailable) // flushes the input stream(the pressed keys are inserted in a queue
                    {                            // and readKey empties the queue
                        Console.ReadKey(true);
                    }
                    //// Uncomment to enable Player
                    //if (pressedKey.Key == ConsoleKey.M)
                    //{
                    //    isMute = !isMute;
                    //    if (isMute)
                    //    {
                    //        BackgroundPlayer.pause();
                    //    }
                    //    else
                    //    {
                    //        BackgroundPlayer.play();
                    //    }
                    //}

                    MoveHead(pressedKey);
                }


                SetForegroundColor(giraffesColor);
                DrawGiraffesHead();
                MoveParticles(Particles);
                MoveNeck();
                DrawGiraffesBody();
                ShowRealtimeScore(ApplesEaten);

                if (isHit) // Game over
                {
                    stopwatch.Stop();
                    //// Uncomment to enable Player
                    //BackgroundPlayer.stop();
                    //GameOverPlayer.play();
                    

                    Console.Clear();
                    Console.WriteLine("Game over");
                    Console.WriteLine("You reached {0}", currentLevel);
                    Console.WriteLine("Your score is {0}", Score);
                    Console.WriteLine("You ate {0} apples!", ApplesEaten);

                    timeAlive = ReturnFormatedTimeString(stopwatch);

                    SaveScoreToTextFile();
                    ResetAllVariables();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    //// Uncomment to enable Player
                    // GameOverPlayer.stop();
                    ShowMainMenu();

                    return;
                }

                Thread.Sleep(level);
            }
        }

        private static void ResetAllVariables()
        {
            isHit = false;
            EmptyParticlesList();
            stopwatch.Reset();
            ApplesEaten = 0;
            Score = 0;
            level = GlobalConstants.DefaultLevel;
        }

        private static string ReturnFormatedTimeString(Stopwatch stopwatch)
        {
            return string.Format("{0}{1}{2}",
               stopwatch.Elapsed.Hours == 0 ? string.Empty : (stopwatch.Elapsed.Hours == 1 ? "1 hour" : stopwatch.Elapsed.Hours + " hours"),
               stopwatch.Elapsed.Minutes == 0 ? string.Empty : (stopwatch.Elapsed.Hours == 1 ? "1 minute" : stopwatch.Elapsed.Minutes + " minutes"),
               stopwatch.Elapsed.Seconds == 0 ? string.Empty : (stopwatch.Elapsed.Hours == 1 ? "1 second" : stopwatch.Elapsed.Seconds + " seconds"));
        }

        private static void EmptyParticlesList()
        {
            Particles = new List<Particle>();
        }

        private static void SaveScoreToTextFile()
        {
            //Saving the score to text file ->>>
            Console.WriteLine("You managed to stay alive for: {0}", timeAlive);
            Console.WriteLine(@"What is your name, you brave GiraffeWarrior? (score will be saved in TheGiraffeGame\bin\Debug directory)");
            Console.Write("Your name: ");
            Console.CursorVisible = true;
            playerName = Console.ReadLine();
            Console.CursorVisible = false;
            
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;

                using (StreamWriter Writer = new StreamWriter(@savePath, true))
                {
                    Writer.WriteLine("PlayerName: " + (playerName == string.Empty ? "Anonymous" : playerName) + " Score: " + Score);
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path contains a directory that cannot be found!"); 
                Thread.Sleep(2000);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file '{0}' was not found!", @savePath);
                Thread.Sleep(2000);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
                Thread.Sleep(2000);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is incorrect!");
                Thread.Sleep(2000);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is over the 248 characters maximum!");
                Thread.Sleep(2000);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
                Thread.Sleep(2000);
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have the required permission to access this file!");
                Thread.Sleep(2000);
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
                Thread.Sleep(2000);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
                Thread.Sleep(2000);
            }
            finally
            {
                SetDefaultForegroundColor();
            }

            Console.WriteLine(@"Your score has been saved on your TheGiraffeGame\bin\Debug directory - {0}.txt", playerName);
        }

        private static void SetDefaultForegroundColor()
        {
            Console.ForegroundColor = defaultColor;
        }

        private static void SetForegroundColor(string color)
        {
            switch (color.ToLower())
            {
                case "yellow": Console.ForegroundColor = ConsoleColor.Yellow; break;
                case "Green": Console.ForegroundColor = ConsoleColor.Green; break;
                case "red": Console.ForegroundColor = ConsoleColor.Red; break;
                case "blue": Console.ForegroundColor = ConsoleColor.Blue; break;
                case "cyan": Console.ForegroundColor = ConsoleColor.Cyan; break;
                case "gray": Console.ForegroundColor = ConsoleColor.Gray; break;

                default: break;
            }
        }
    }
}
