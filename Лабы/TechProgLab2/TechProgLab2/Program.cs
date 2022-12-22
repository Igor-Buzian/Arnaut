/*
- Сбор инфы о студенческой группе
- 3 массива: одномерный для имен, одномерный для предметов, трехмерный нерегулярный для оценок по каждому предмету каждого студента
- имена и предметы считываются с клавы
- количество оценок и сами оценки - генерируются рандомом
- 7 запросов по собранной инфе
*/
using System;
using System.Reflection.Emit;

namespace TP_Lab2
{
    internal class Program
    {
        static void Main(string[] args) {
            bool mainExit = true;
            while (mainExit)
            {
                Console.WriteLine("\nChoose point of lab\n1)Lab 2 (point A)\n2)Lab 2 (point B)\n3)Exit");
                int mainChoose = int.Parse(Console.ReadLine());
                switch (mainChoose) {
                    case 1:
                        lab2PontA lab2PontA = new lab2PontA();
                        lab2PontA.SystemCreatingAndCalculation();
                        break;
                    case 2:
                        Lab2 lab = new Lab2();
                        lab.Display();
                        break;
                    case 3:
                        mainExit = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect number!\n");
                        break;
                }
            }            
        }
    }
}

