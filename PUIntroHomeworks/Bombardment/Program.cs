using System;
using System.Linq;

namespace Bombardment
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                string text = Console.ReadLine();
                int length = text.Length;
                int width = int.Parse(Console.ReadLine());
                int height = (length / width);
                height += text.Length % width == 0 ? 0 : 1;

                string bombs = Console.ReadLine();
                int[] bombCols = bombs.Split(' ').Select(int.Parse).ToArray();

                int[] nbombCols = bombCols.Distinct().ToArray();



                char[,] arr = new char[height, width];

                int index = 0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        arr[i, j] = text[index++];

                        if (index >= length)
                        {
                            break;
                        }
                    }
                }
                for (int i = 0; i < bombCols.Length; i++)
                {
                    int bomb = int.Parse(bombCols[i].ToString());
                    for (int b = 0; b < height; b++)
                    {
                        int row = b;
                        int col = bomb;
                        if (arr[b, bomb] == ' ')
                        {
                            continue;
                        }

                        arr[b, bomb] = ' ';

                        if (b + 1 < height)
                        {
                            if (arr[b + 1, bomb] == ' ')
                            {
                                break;
                            }
                        }
                    }
                }


                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        char letter = arr[i, j];
                        if (letter != '\0')
                        {
                            Console.Write(arr[i, j]);
                        }
                    }
                }
                Console.WriteLine();
            }


            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

    }
