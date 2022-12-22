using System;

namespace TechProgLab3
{
    using mystring = MyString;
    internal class Program
    {
        static void Main(string[] args)
        {
            //string creating
            Console.WriteLine("Constructors:\n----------------------");
            mystring string1 = new MyString('a', 6);
            mystring string2 = new MyString(new char[] { 'a', 'b' });
            mystring string3 = new MyString(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' }, 1, 8);
            mystring string4 = new MyString("hello world!".ToCharArray());
            Console.WriteLine("\nstring1: " + string1.Result);
            Console.WriteLine("\nstring2: " + string2.Result);
            Console.WriteLine("\nstring3: " + string3.Result);
            Console.WriteLine("\nstring4: " + string4.Result);



            //funtion-indexator
            Console.WriteLine("\n\n\nIndex:\n----------------------");
            Console.WriteLine("{0}[1]: {1}", string2.Result, string2.Result[1]);

            //get length
            Console.WriteLine("\n\n\nLength:\n----------------------");
            Console.WriteLine("string length of {0}: {1}", string1.Result, string1.Length);

            //operator +
            mystring newString = string1 + string4;
            Console.WriteLine("\n\n\nOperator + :\n----------------------");
            Console.WriteLine("{0} + {1} = {2}", string1.Result, string4.Result, newString.Result);

            //1)Join
            char[][] stringArray = { "string1".ToCharArray(), "string2".ToCharArray(), "string3".ToCharArray(), "string4".ToCharArray(), "string5".ToCharArray(), "string6".ToCharArray() };
            mystring string5 = new MyString(MyString.Join(", ".ToCharArray(), stringArray));
            mystring string6 = new MyString(MyString.Join(',', stringArray));
            Console.WriteLine("\n\n\nJoin:\n----------------------");
            Console.WriteLine("\nstring5: " + string5.Result);
            Console.WriteLine("\nstring6: " + string6.Result);



            //2)Concat
            mystring string7 = new MyString(MyString.Concat("str1".ToCharArray(), "str2".ToCharArray(), "str3".ToCharArray(), "str4".ToCharArray()));
            Console.WriteLine("\n\n\nConcat:\n----------------------");
            Console.WriteLine("string7: " + string7.Result);



            //3)Spaces counter
            Console.WriteLine("\n\n\nSpace Counter:\n----------------------");
            Console.WriteLine("count of spaces in \"{0}\": {1} ", string4.Result, string4.SpacesCounter());



            //4)Equals
            Console.WriteLine("\n\n\nEquals:\n----------------------");
            Console.WriteLine("\nis {0} equal to \"Buzian\"? {1}", string3.Result, string3.Equals("Buzian"));
            Console.WriteLine("\nis {0} equal to \"Igor\"? {1}", string3.Result, string3.Equals("Igor"));
            Console.WriteLine("\nare strings \"string1\" and \"string2\" equals? " + MyString.Equals("string1", "string2"));



            //5)Contains
            Console.WriteLine("\n\n\nContains:\n----------------------");
            Console.WriteLine("is string \"{0}\" contains \"{1}\"? {2} ", string4.Result, "hello world", string4.Contains("hello world".ToCharArray()));



            //6)StartsWith
            Console.WriteLine("\n\n\nStart With:\n----------------------");
            Console.WriteLine("is string \" " + string4.Result + "\" starts with substring \"hello\"? " + string4.StartsWith("hello".ToCharArray()));

            //7)EndsWith
            Console.WriteLine("\n\n\nEnds on:\n----------------------");
            Console.WriteLine("is string \" " + string4.Result + "\" ends with substring \"Всё идёт по плану\"? " + string4.EndsWith("Всё идёт по плану".ToCharArray()));



            //8)IndexOf
            Console.WriteLine("\n\n\nIndexOf:\n----------------------");
            if (string4.IndexOf("See".ToCharArray()) != -1)
            {
                Console.WriteLine("first occurance of substring \"See\" in string " + string4.Result + " has index: " + string4.IndexOf("See".ToCharArray()));
            }
            else
            {
                Console.WriteLine("string " + string4.Result + "has not substring \"See\"");
            }

            //9)LastIndexOf
            Console.WriteLine("\n\n\nLastIndexOf:\n----------------------");
            if (string4.LastIndexOf("See ya".ToCharArray()) != -1)
            {
                Console.WriteLine("last occurance of substring \"See ya\" in string " + string4.Result + " has index: " + string4.LastIndexOf("See".ToCharArray()));
            }
            else
            {
                Console.WriteLine("string " + string4.Result + "has not substring \"See ya\"");
            }



            //10)Split
            Console.WriteLine("\n\n\nSplit:\n----------------------");
            Console.Write(string4.Result + " => ");
            Console.WriteLine(MyString.Join("; ".ToCharArray(), string4.Split(' ')));

            //11)Trim
            MyString string8 = new MyString("Моя Оборона".ToCharArray());
            Console.WriteLine("\n\n\nTrim:\n----------------------");
            Console.Write("New string: ");
            Console.WriteLine(string8.Trim('a', 'f', ' '));
            Console.Write("Old string: ");
            Console.WriteLine(string8.Result);

            //12)Left
            Console.WriteLine("\n\n\nLeft:\n----------------------");
            Console.WriteLine(string8.Left(8));
            Console.WriteLine(string8.Left(8, 'o'));

            //13)Right
            Console.WriteLine("\n\n\nRight:\n----------------------");
            Console.WriteLine(string8.Right(8));
            Console.WriteLine(string8.Right(8, 'а'));


            //15)Remove
            Console.WriteLine("\n\n\nRemove:\n----------------------");
            Console.Write("remove all elements from index 3 in \"" + string8.Result + "\": ");
            Console.WriteLine(string8.Remove(3));
            Console.Write("remove 3 next elements from index 3 in \"" + string8.Result + "\": ");
            Console.WriteLine(string8.Remove(3, 3));

            Console.ReadLine();
        }
    }
}
