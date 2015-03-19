using System;

//{}
//[]

class Task3
{

    static string DoDance(string dance)
    {
        int posX = 1;
        int posY = 1;
        int[,] directions = { { 0, 1 }, { -1, 0 }, { 0, -1 }, { 1, 0 } };
        int direction = 0;

        for (int i = 0; i < dance.Length; i++)
        {
            switch (dance[i])
            {
                case 'L':
                    if (direction == 0)
                    {
                        direction = 3;
                    }
                    else
                    {
                        direction = direction - 1;
                    }
                    break;
                case 'R':
                    direction = (direction + 1) % 4;
                    break;
                case 'W':
                    posX = posX + directions[direction, 0];
                    if (posX < 0)
                    {
                        posX = 2;
                    }
                    else if (posX > 2)
                    {
                        posX = 0;
                    }
                    posY = posY + directions[direction, 1];
                    if (posY < 0)
                    {
                        posY = 2;
                    }
                    else if (posY > 2)
                    {
                        posY = 0;
                    }
                    break;
            }
        }

        string[,] danceFloor = { { "RED", "BLUE", "RED" }, { "BLUE", "GREEN", "BLUE" }, { "RED", "BLUE", "RED" } };
        return danceFloor[posX, posY];
    }
    static void Main()
    {
        int dances = int.Parse(Console.ReadLine());

        string[] result = new string[dances];

        for (int i = 0; i < dances; i++)
        {
            string dance = Console.ReadLine();
            result[i] = DoDance(dance);
        }

        for (int i = 0; i < dances; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}