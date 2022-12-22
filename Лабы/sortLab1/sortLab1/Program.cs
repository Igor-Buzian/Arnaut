using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace LabArr
{
    class Att1
    {

        static void Main(string[] args)
        {
            DisplaySort displaySort = new DisplaySort();
            displaySort.Display();

        }


    }

}
/* class Person
 {
     public string? Name { get; set; }
     public string? LName { get; set; }
     public int? Age { get; set; }
 string parseAge = Age.ToString();
 public override string? ToString()
     {
     if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(LName))
     {
         return base.ToString();
     }
     else
     {
         return $"Your First name and Last name is {Name} {LName} ";
     }
 }
 }*/


