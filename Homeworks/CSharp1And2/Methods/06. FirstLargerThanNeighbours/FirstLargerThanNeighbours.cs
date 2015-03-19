using System;

class FirstBiggerThanTheNeighbours
{
    //Write a method that returns the index of 
    //the first element in array that is bigger 
    //than its neighbors, or -1, if there’s no such element.

    static int[] array = new int[20];
    private static void GenerateRandomArray()
    {
        Random randomNumber = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomNumber.Next(11); //generate random number between 0 and 10
        }
    }

    private static void PrintGeneratedArray() // this method prints the array.
    {
        Console.Write("The array that has been generated is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    private static int FirstElementCheckTheNeighbours() // checks which is the first element and returns its position if such an element exists.
    {
        for (int position = 1; position < array.Length - 1; position++)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return position;
            }

        }
        return -1;
    }
    static void Main(string[] args)
    {
        GenerateRandomArray();
        PrintGeneratedArray();
        if (FirstElementCheckTheNeighbours() > 0)
        {
            Console.WriteLine("Position [{0}] = {1} is the first element in array that is bigger than its neighbours", FirstElementCheckTheNeighbours(), array[FirstElementCheckTheNeighbours()]);    
        }
        else
        {
            Console.WriteLine("No such element !");
        }
        
    }
}
