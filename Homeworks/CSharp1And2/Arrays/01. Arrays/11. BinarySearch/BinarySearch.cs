using System;

class BinarySearch
{
    static void Main()
    {
        //Initializing the array
        Console.Write("Number of elements of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        //populating the arrays
        for (int elements = 0; elements < array.Length; elements++)
        {
            Console.Write("Array, Element [{0}]: ", elements);
            int inputNumber = int.Parse(Console.ReadLine());
            array[elements] = inputNumber;
        }

        //sort the array
        int tempValue = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    tempValue = array[i];
                    array[i] = array[j];
                    array[j] = tempValue;
                }
            }
        }

        //binary search algo
        Console.Write("Enter the number you want to search for: ");
        int searchedNumber = int.Parse(Console.ReadLine());
        int startElement = 0;
        int endElement = array.Length - 1;
        int middleElement = 0;
        while (startElement <= endElement)
        {
            middleElement = (startElement + endElement) / 2;

            if (searchedNumber > array[middleElement])
            {
                startElement = middleElement + 1;
            }
            else if (searchedNumber < array[middleElement])
            {
                endElement = middleElement - 1;
            }
            else
            {
                break;
            }
        }
        //output
        Console.WriteLine("The searched value {0} is on position {1} !", array[middleElement], middleElement);
    }
}

