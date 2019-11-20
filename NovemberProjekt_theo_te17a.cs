using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theodore_TE17A_Novemberprojektet
{


    class Dater
    {
        public Gender gender; //enum

        public string name;

        public int age;

        public String hobby;

        // En  kontruktor är en metod som körs när en klass instansieras tex kör (dater)
        public Dater(Gender gender, string name, int age, string hobby)
        {
            this.gender = gender; // detta kodstycke refererar till gender variabeln utanför metoden och ger ett värde till klassens gender istället för att loopa internt.
            this.name = name;
            this.age = age;
            this.hobby = hobby;


        }

        public void Print() //glöm inte att ha parenteser efter metoder
        {

            Console.WriteLine(gender.ToString() +" "+ name); // denna rad skriver ut kön och namn. för att convertera en enums måste man skriva ".ToString)
            Console.WriteLine(age);
            Console.WriteLine(hobby);

        }



    }

    enum Gender // basically if satser
    {
        neutral,
        Male,
        Female

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("jag lärde wood att använda git, nu testar jag bara om allt fungerar");

            Dater d = new Dater(Gender.neutral,"Sasha",22, "Tumlbr scrolling and cat videos");

            d.Print();
            

            Console.ReadLine();
        }
    }
}
