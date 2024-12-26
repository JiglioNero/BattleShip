using System;
namespace BattleShip
{
    public class ConsoleHelper
    {
        public static void DrawBattlegrounds(int[,] field1, int[,] field2)
        {

            int rows1 = field1.GetLength(0);
            int cols1 = field1.GetLength(1);
            int rows2 = field2.GetLength(0);
            int cols2 = field2.GetLength(1);

            if (rows1 != rows2 || cols1 != cols2)
            {
                throw new ArgumentException("Sizes of Battlegrounds are not equal");
            }


            Console.Write("   ");
            for (int c = 0; c < cols1; c++)
                Console.Write($"{c+1,2} ");
            Console.Write("     ");
            for (int c = 0; c < cols2; c++)
                Console.Write($"{c+1,2} ");
            Console.WriteLine();

            for (int row = 0; row < rows1; row++)
            {
                Console.Write($"{NumberToLetter(row)} | ");

                for (int col = 0; col < cols1; col++)
                {
                    Console.Write($"{CellToChar(field1[row, col])}  ");
                }

                Console.Write("  |  ");

                for (int col = 0; col < cols2; col++)
                {
                    Console.Write($"{CellToChar(field2[row, col])}  ");
                }

                Console.WriteLine();
            }
        }

        public static (int, int) ReadCoordinates(uint maxValue)
        {
            int first;
            int second;
            do
            {
                first = -1;
                second = -1;

                Console.WriteLine("Input coordinates (ex. B4):");

                string line = Console.ReadLine();
                if (line != null && line.Length > 1)
                {
                    char letterPart = line[0];
                    string numberPart = line.Substring(1);
                    try
                    {
                        int firstNumber = LetterToNumber(letterPart);
                        if (firstNumber >= maxValue || firstNumber < 0)
                        {
                            Console.WriteLine("Incorrect first part of point");
                            continue;
                        }
                        first = firstNumber;

                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine("Incorrect first part of point");
                        continue;
                    }

                    int secondNumber = -1;
                    int.TryParse(numberPart, out secondNumber);
                    secondNumber--;

                    if (secondNumber >= maxValue || secondNumber < 0)
                    {
                        Console.WriteLine("Incorrect second part of point");
                        continue;
                    }
                    second = secondNumber;
                }
                else
                {
                    continue;
                }
            } while (first == -1 || second == -1);

            return (first, second);
        }

        private static char CellToChar(int cellValue)
        {
            switch(cellValue)
            {
                case -1: return '.';
                case 0: return 'O';
                case 1: return 'X';
                default: return '?';
            }
        }

        public static char NumberToLetter(int number)
        {
            if (number < 0 || number > 25)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 0 and 25.");
            }

            char letter = (char)('A' + number);
            return letter;
        }

        public static int LetterToNumber(char letter)
        {
            if (letter < 'A' || letter > 'Z')
            {
                throw new ArgumentOutOfRangeException(nameof(letter), "Letter must be between 'A' and 'Z'.");
            }

            return (letter - 'A');
        }
    }
}

