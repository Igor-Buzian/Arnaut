/*
- Сбор инфы о студенческой группе
- 3 массива: одномерный для имен, одномерный для предметов, трехмерный нерегулярный для оценок по каждому предмету каждого студента
- имена и предметы считываются с клавы
- количество оценок и сами оценки - генерируются рандомом
- 7 запросов по собранной инфе
*/

using Microsoft.VisualBasic;
using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace TP_Lab2
{
    class Lab2
    {
        void InfoAboutStudents(int studentId, int subject, string[] nameOfsubjects, int[][][] arr)
        {

            for (int i = 0; i < subject; i++)
            {
                Console.WriteLine();
                Console.Write("\n" + (i + 1) + ") " + nameOfsubjects[i]);
                for (int note = 0; note < arr[studentId][i].Length; note++)
                {
                    Console.Write(" " +  arr[studentId][i][note] + "  ");
                }
            }
        }

        void InfoAboutSubjects(int subjectId, int student, string[] nameOfStudents, int[][][] arr)
        {
            for(int i = 0; i < student; i++)
            {
                Console.Write("\n" + (i+1)+") " + nameOfStudents[i]);
                for (int note = 0; note < arr[subjectId][i].Length; note++) {
  
                Console.Write(" " + arr[subjectId][i][note] + "  ");
                }
            }
        }
        void AverageGroupMark(string[] nameOfStudents, string[] nameOfsubjects, int[][][] arr) {
            int result = 0;
            int count = 0;
            for (int i = 0; i < nameOfStudents.Length; i++)
            {
                for (int j = 0; j < nameOfsubjects.Length; j++)
                {
                    for (int k = 0; k < arr[i][j].Length; k++)
                    {
                        int amountMark = arr[i][j][k];
                        result += amountMark;
                        count++;
                    }
                }
            }
            double meddiumMark = (double)result / (double)count;
            Console.WriteLine("Medium mark of group is " + meddiumMark);
        }
        void HighestGrades(string[] nameOfStudents, string[] nameOfsubjects, int[][][] arr) {
            int highetGrades = 0;
            int studentIndex = 0;
            for (int i = 0; i < nameOfStudents.Length; i++) {
                 int score = 0;
                for (int j = 0; j < nameOfsubjects.Length; j++ ) {
                    for (int k = 0; k < arr[i][j].Length; k++) {
                            score += arr[i][j][k];

                        if (score > highetGrades)
                        {
                            highetGrades = score;
                            studentIndex = i;
                        }
                    }
                }
            }  
            Console.WriteLine("Student with highest mark is "+ nameOfStudents[studentIndex]); 
        }
        void LowestGrades(string[] nameOfStudents, string[] nameOfsubjects, int[][][] arr)
        {
            int lowestGrades = 10000;
            int studentIndex = 0;
            for (int i = 0; i < nameOfsubjects.Length; i++)
            {
                int score = 0;
                for (int j = 0; j < nameOfStudents.Length; j++)
                {
                    for (int k = 0; k < arr[i][j].Length; k++)
                    {
                        score += arr[i][j][k];

                        if (score < lowestGrades)
                        {
                            lowestGrades = score;
                            studentIndex = i;
                        }
                    }
                }
            }
            Console.WriteLine("Student with highest mark is " + nameOfsubjects[studentIndex]);
        }
        int count = 0;
        bool randExit = true;
        void RandomLeader(int student, string[] nameOfStudents,  ref bool  randExit, ref int  count) {

            int a = 0;
            while (randExit) {
                if (count > 0)
                {

                    randExit = false;
                    break;
                }
                else {
                    Random random = new Random();
                    a = random.Next(1, student - 1);
                    ++count;
                }
                
                 
                
            }
            Console.WriteLine("Group leader is " + nameOfStudents[a]);
        }
        void AmountOfStudentsAndSubjects(int student, int subject)
        { Console.WriteLine("Amount of students: " + student + "\nAmount of subjects: " + subject); }

        public void Display()
        {
                Console.Write("Write your amount of students: ");
                int student = int.Parse(Console.ReadLine());
                Console.Write("Write your amount of subjects: ");
                int subject = int.Parse(Console.ReadLine());
            if (student > 1 && subject > 1)
            {
                string[] nameOfStudents = new string[student];
                string[] nameOfsubjects = new string[subject];

                Random random = new Random();
                int[][][] arr = new int[student][][];

                for (int stud = 0; stud < student; stud++)
                {
                    arr[stud] = new int[5][];
                    for (int subj = 0; subj < subject; subj++)
                    {
                        int notesNum = random.Next(5, 11);
                        arr[stud][subj] = new int[notesNum];

                        for (int n = 0; n < notesNum; n++)
                        {
                            arr[stud][subj][n] = random.Next(5, 11);
                        }
                    }
                }


                for (int i = 0; i < student; i++)
                {
                    Console.Write("Write {" + (i + 1) + "} name of student ");
                    nameOfStudents[i] = Console.ReadLine();
                }

                for (int i = 0; i < subject; i++)
                {
                    Console.Write("Write {" + (i + 1) + "} name of subject ");
                    nameOfsubjects[i] = Console.ReadLine();
                }

                bool exit = true;

                while (exit)
                {
                    Console.WriteLine("\n\nWhat type info, do you want check?\n1)Amount of students and subjects\n2)Info about students\n3)Info about subject mark" +
                        "\n4)Average group mark\n5)Student with the highest grades.\n6)Student with the lowest grades.\n7)Group leader\n8)Exit");
                    int chooseNum = int.Parse(Console.ReadLine());
                    switch (chooseNum)
                    {
                        case 1:
                            AmountOfStudentsAndSubjects(student, subject);
                            break;

                        case 2:
                            Console.WriteLine("how person do you want check ?");
                            for (int i = 0; i < student; i++)
                            {
                                Console.WriteLine((i + 1) + ")" + nameOfStudents[i]);
                            }
                            Console.Write("\n\nWrite number: ");
                            int studentId = int.Parse(Console.ReadLine());
                            InfoAboutStudents(studentId-1, subject, nameOfsubjects, arr);
                            break;

                        case 3:
                            Console.WriteLine("What subject do you want choose? ");
                            for (int s = 0; s < subject; s++)
                            {
                                Console.WriteLine((s + 1) + ")" + nameOfsubjects[s]);
                            }
                            Console.Write("\n\nWrite number: ");
                            int subjectId = int.Parse(Console.ReadLine());
                            InfoAboutSubjects(subjectId-1, student, nameOfStudents, arr);
                            break;

                        case 4:
                            AverageGroupMark(nameOfStudents, nameOfsubjects, arr);
                            break;

                        case 5:
                            HighestGrades(nameOfStudents, nameOfsubjects, arr);
                            break;

                        case 6:
                            LowestGrades(nameOfStudents, nameOfsubjects, arr);
                            break;

                        case 7:
                            RandomLeader(student, nameOfStudents, ref randExit, ref count);
                            break;
                        case 8:
                            exit = false;
                            break;
                        default:
                            Console.WriteLine("Incorrect Number!");
                            break;


                    }
                }
            }
            else { Console.WriteLine("Incorrect Number!");}
        }
    }
}

