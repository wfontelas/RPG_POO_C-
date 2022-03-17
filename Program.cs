using System;
using POO.src.Entities;

namespace POO
{
     class Program
    {
        static void Main(string[] args)
        {
                     
           Knight Arus = new Knight("Arus", 23, "Knight");
           Wizard wizard  = new Wizard("Jennica", 23, "White Wizard");
           Ninja Wedge = new Ninja("Wedge", 42, "Ninja");
           Wizard BlackWizard = new Wizard("Topapa",42,"Black Wizard");
                       

           Console.WriteLine(wizard.Attack(7));
           Console.WriteLine(wizard.Attack(1));
   
         
        }
    }
}
