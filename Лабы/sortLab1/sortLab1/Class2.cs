namespace LabArr

{
    internal class DisplaySort 
    {
       
        public void Display()
        {
            Console.Write("Write your size of array: ");
            byte number = byte.Parse(Console.ReadLine());
            int[] arr = new int[number];
            if (number > 15)
            {
                Console.WriteLine("It's too big Lenght array!");
            }
            else if (number < 4)
            {
                Console.WriteLine("It's too small Lenght array!");
            }
            else
            {
                Console.WriteLine("Choose:\n1)Random array\n2)Your array");
                byte num = byte.Parse(Console.ReadLine());
                if (num == RandInterface.RANDOM)
                {
                    Random rand = new Random();
                    for (int i = 0; i < arr.Length;)
                    {
                        bool exit = true;
                        int randElem = rand.Next(10, 99);
                        for (int j = 0; j < i; j++)
                        {
                            if (arr[j] == randElem)
                            {
                                exit = false;
                                break;
                            }
                        }
                        if (exit == true)
                        {
                            arr[i] = randElem;
                            i++;
                        }
                    }
                }
                else if (num == RandInterface.NOTRANDOM)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write("Position" + i + ": ");
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    throw new ArithmeticException("Incorrect number!");
                }
                Console.WriteLine("Your array: " + string.Join(", ", arr));
                Console.WriteLine("What type of sort, do you want use ?\n1)LinnearSort\n2)BubbleSort\n3)InsertionSort");
                byte arrNum = byte.Parse(Console.ReadLine());

                switch (arrNum)
                {
                    case 1:
                        Console.Write("Sorted array: " + string.Join(", ", Sort.LinearSort(arr)));
                        break;
                    case 2:
                        Console.Write("Sorted array: " + string.Join(", ", Sort.BubbleSort(arr)));
                        break;
                    case 3:
                        Console.Write("Sorted array: " + string.Join(", ", Sort.InsertionSort(arr)));
                        break;
                    default:
                        throw new ArithmeticException("Incorrect Number");

                }
            }
        }
    }
}
