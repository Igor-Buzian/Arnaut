﻿namespace LabArr
{
    internal class Sort
    {

        static void Swap(ref int elem1, ref int elem2)
        {
            int temp = elem1;
            elem1 = elem2;
            elem2 = temp;
        }
        /*//LinnearSort
        public static int[] LinnearSort(int[] arrNum)
        {
            for (int i = 0; i < arrNum.Length; i++)
            {
                for (int j = 0; j < arrNum.Length; j++)
                {
                    if (arrNum[j] > arrNum[i])
                    {
                        Swap(ref arrNum[j], ref arrNum[i]);
                    }
                }
            }
            return arrNum;
        }

        //BubbleSort
        public static int[] BubbleSort(int[] arrNum)
        {
            for (int i = 0; i < arrNum.Length; i++)
            {
                for (int j = 0; j < arrNum.Length - 1 - i; j++)
                {
                    if (arrNum[j] > arrNum[j + 1])
                    {
                        int temp = arrNum[j];
                        arrNum[j] = arrNum[j + 1];
                        arrNum[j + 1] = temp;
                    }
                }
            }
            return arrNum;
        }

        //QuickSort
       public static int FindPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int lastElem = array[maxIndex];//4 // 1 3 2 5 4
            int pivotIndex = minIndex - 1;//вне массива
            for (int i = minIndex; i < maxIndex; i++)//i=0; i<4; i++
            {
                if (array[i] < lastElem) // 1<4
                {
                    pivotIndex++;//2
                    Swap(ref array[i], ref array[pivotIndex]);//1
                }
            }
            pivotIndex++;//3
            Swap(ref array[maxIndex], ref array[pivotIndex]);//1 3 2 4 5
            return pivotIndex;
        }

        public static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        { 
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = FindPivotIndex(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1); // 1 3 2 
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        //InsertionSort
        public static int[] InsertionSort(int[] array)// 5, 2, 10, 3, 8, 1
        {
            int index;
            int currentElem;
            for (int i = 0; i < array.Length; i++)
            {
                index = i;
                currentElem = array[i];
                while (index > 0 && currentElem < array[index - 1])
                {
                    array[index] = array[index - 1];
                    index--;

                }
                array[index] = currentElem;
            }
            return array;

        }*/
        //all for animation


        static void AnimationSettings(int[] array, out string[] row1, out string[] row2, out string[] row3)
        {
            row1 = new string[array.Length];
            row2 = new string[array.Length];
            row3 = new string[array.Length];


            DefaultAnimationLines(array, ref row1, ref row2, ref row3);

            Console.Clear();
            Console.WriteLine("\n" + string.Join("  ", row1));
            Console.WriteLine(string.Join("  ", row2));
            Console.WriteLine(string.Join("  ", row3));
        }

        static void StringAnimationLines(string[] row1, string[] row2, string[] row3)
        {
            Console.WriteLine("\n" + string.Join("  ", row1));
            Console.WriteLine(string.Join("  ", row2));
            Console.WriteLine(string.Join("  ", row3));
        }

        static void DefaultAnimationLines(int[] array, ref string[] row1, ref string[] row2, ref string[] row3)
        {
            for (int i = 0; i < array.Length; i++)
            {
                row1[i] = "  ";
                row2[i] = array[i].ToString();
                row3[i] = "  ";
            }
        }

        public static int[] LinearSort(int[] array)//5 2 0 3 1 8 6
        {
            string[] row1;
            string[] row2;
            string[] row3;
            int Delay = 1000;
            Console.Clear();
            AnimationSettings(array, out row1, out row2, out row3);
            Console.WriteLine("\n\n     PRESS   ANYTHING   ");
            Console.ReadKey();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    bool BoolSwap = false;

                     Console.Clear();
                    DefaultAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[i] = array[i].ToString();
                    row2[i] = "  ";
                    row2[j] = "  ";
                    row3[j] = array[j].ToString();

                     //сравнение элементов
                    if (array[j] > array[i])
                    {
                        BoolSwap = true;
                    }

                     //замена цвета
                    Console.WriteLine("\n");
                    for (int c = 0; c < array.Length; c++)
                    {
                        if (c == i)
                        {
                            if (BoolSwap)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(row1[c] + "  ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(row1[c] + "  ");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.Write(row1[c] + "  ");
                        }
                    }
                    Console.WriteLine();

                    Console.WriteLine(string.Join("  ", row2));

                    for (int c = 0; c < array.Length; c++)
                    {
                        if (c == j)
                        {
                            if (BoolSwap)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(row3[c] + "  ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(row3[c] + "  ");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.Write(row3[c] + "  ");
                        }
                    }
                    Console.WriteLine();

                    System.Threading.Thread.Sleep(Delay);

                    if (BoolSwap)
                    {
                        Swap(ref array[j], ref array[i]);
                    }
                }
            }
            DefaultAnimationLines(array, ref row1, ref row2, ref row3);

            Console.Clear();
            StringAnimationLines(row1, row2, row3);
            Console.WriteLine("End of sort!\n");

            return array;
        }
        public static int[] BubbleSort(int[] array)
        {
            string[] row1;
            string[] row2;
            string[] row3;
            int Delay = 1000;
            Console.Clear();

            AnimationSettings(array, out row1, out row2, out row3);
            Console.WriteLine("\n\n   PRESS   ANYTHING   ");
            Console.ReadKey();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    bool BoolSwap = false;

                    Console.Clear();
                    DefaultAnimationLines(array, ref row1, ref row2, ref row3);

                     //сравнение элементов
                    if (array[j] > array[j + 1])
                    {
                        BoolSwap = true;
                    }
                    row1[j] = array[j].ToString();
                    row2[j] = "  ";
                    row2[j + 1] = "  ";
                    row3[j + 1] = array[j + 1].ToString();
                     //замена цвета
                    Console.WriteLine("\n");
                    for (int c = 0; c < array.Length; c++)
                    {
                        if (c == j)
                        {
                            if (BoolSwap)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(row1[c] + "  ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(row1[c] + "  ");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.Write(row1[c] + "  ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine(string.Join("  ", row2));

                    for (int c = 0; c < array.Length; c++)
                    {
                        if (c == j + 1)
                        {
                            if (BoolSwap)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(row3[c] + "  ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(row3[c] + "  ");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.Write(row3[c] + "  ");
                        }
                    }
                    Console.WriteLine();

                    System.Threading.Thread.Sleep(Delay);

                    if (BoolSwap)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            DefaultAnimationLines(array, ref row1, ref row2, ref row3);

            Console.Clear();
            StringAnimationLines(row1, row2, row3);
            Console.WriteLine("End of sort!\n");

            return array;
        }

        public static int[] InsertionSort(int[] array)// 5, 2, 10, 3, 8, 1
        {
            int index;
            int currentElem;
            string[] row1;
            string[] row2;
            string[] row3;
            bool BoolSwap = false;
            int Delay = 1000;

            Console.Clear();
            AnimationSettings(array, out row1, out row2, out row3);

            Console.WriteLine("\n\n   PRESS   ANYTHING   ");
            Console.ReadLine();

            for (int i = 0; i < array.Length; i++)
            {
                index = i;
                currentElem = array[i];

                if (index > 0 && currentElem >= array[index - 1])
                {
                     Console.Clear();
                    DefaultAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[i] = array[i].ToString();
                    row2[i] = "  ";
                    row2[index - 1] = "  ";
                    row3[index - 1] = array[index - 1].ToString();

                    //замена цвета
                    Console.WriteLine("\n");
                    for (int c = 0; c < array.Length; c++)
                    {
                        if (c == i)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(row1[c] + "  ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(row1[c] + "  ");
                        }
                    }
                    Console.WriteLine();

                    Console.WriteLine(string.Join("  ", row2));

                    for (int c = 0; c < array.Length; c++)
                    {
                        if (c == index - 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(row3[c] + "  ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(row3[c] + "  ");
                        }
                    }
                    Console.WriteLine();

                    System.Threading.Thread.Sleep(Delay);
                }

                //происходит сортировка
                while (index > 0 && currentElem < array[index - 1])
                {
                    array[index] = array[index - 1];
                    index--;

                     Console.Clear();
                    DefaultAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[i] = array[i].ToString();
                    row2[i] = "  ";
                    row2[index] = "  ";
                    row3[index] = array[index].ToString();
                     //замена цвета
                    Console.WriteLine("\n");
                    for (int c = 0; c < array.Length; c++)
                    {
                        if (c == i)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(row1[c] + "  ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(row1[c] + "  ");
                        }
                    }
                    Console.WriteLine();

                    Console.WriteLine(string.Join("  ", row2));

                    for (int c = 0; c < array.Length; c++)
                    {
                        if (c == index)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(row3[c] + "  ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(row3[c] + "  ");
                        }
                    }
                    Console.WriteLine();

                    System.Threading.Thread.Sleep(Delay);
                }
                array[index] = currentElem;
            }
            DefaultAnimationLines(array, ref row1, ref row2, ref row3);

            Console.Clear();
            StringAnimationLines(row1, row2, row3);
            Console.WriteLine("End of sort!\n");

            return array;
        }
    }
}
