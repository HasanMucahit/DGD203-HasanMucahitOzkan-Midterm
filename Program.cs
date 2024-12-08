using System;

namespace dgd203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            int karadenizliPoint = 0;

            Console.WriteLine("Enter your name :");
            name = Console.ReadLine();
            Console.WriteLine("This test will declare how much karadenizli you are.");

            Console.WriteLine("First Question :");
            Console.WriteLine("How many glasses of tea you drink everyday?");
            Console.WriteLine("1 - 0 ");
            Console.WriteLine("2 - 1-2");
            Console.WriteLine("3 - 3-4");
            Console.WriteLine("4 - 5+");
            string answer1 = Console.ReadLine();
            if (answer1 == "1")
            {
                karadenizliPoint += 0;
            }
            else if (answer1 == "2")
            {
                karadenizliPoint += 5;
            }
            else if (answer1 == "3")
            {
                karadenizliPoint += 10;
            }
            else if (answer1 == "4")
            {
                karadenizliPoint += 20;
            }


            Console.WriteLine("Second Question :");
            Console.WriteLine("How many centimeters is your nose ?");
            Console.WriteLine("1 - 2 ");
            Console.WriteLine("2 - 3.5");
            Console.WriteLine("3 - 5");
            Console.WriteLine("4 - 5+");
            string answer2 = Console.ReadLine();
            if (answer2 == "1")
            {
                karadenizliPoint += 0;
            }
            else if (answer2 == "2")
            {
                karadenizliPoint += 8;
            }
            else if (answer2 == "3")
            {
                karadenizliPoint += 12;
            }
            else if (answer2 == "4")
            {
                karadenizliPoint += 20;
            }

            Console.WriteLine("Third Question :");
            Console.WriteLine("Choose a name for your children.");
            Console.WriteLine("1 - Temel ");
            Console.WriteLine("2 - Dursun");
            Console.WriteLine("3 - Mete");
            Console.WriteLine("4 - Recep");
            string answer3 = Console.ReadLine();
            if (answer3 == "1")
            {
                karadenizliPoint += 12;
            }
            else if (answer3 == "2")
            {
                karadenizliPoint += 12;
            }
            else if (answer3 == "3")
            {
                karadenizliPoint += 2;
            }
            else if (answer3 == "4")
            {
                karadenizliPoint += 25;
            }
            Console.WriteLine("Fourth Question :");
            Console.WriteLine("Who sow the first tea in Turkey?");
            Console.WriteLine("1 - Temel and Dursun ");
            Console.WriteLine("2 - Şakir Zümre");
            Console.WriteLine("3 - Zihni Derin");
            Console.WriteLine("4 - Çaycı Hüseyin");
            string answer4 = Console.ReadLine();
            if (answer4 == "1")
            {
                karadenizliPoint += 25;

            }
            else if (answer4 == "2")
            {
                karadenizliPoint += 2;

            }
            else if (answer4 == "3")
            {
                karadenizliPoint += 3;

            }
            else if (answer4 == "4")
            {
                karadenizliPoint += 32;

            }

            Console.WriteLine("Fifth Question :");
            Console.WriteLine("Which one of them does not belong to Rize?");
            Console.WriteLine("1 - Kemençe ");
            Console.WriteLine("2 - Tea");
            Console.WriteLine("3 - Hamsi");
            Console.WriteLine("4 - Hazelnuts");
            string answer5 = Console.ReadLine();
            if (answer5 == "1")
            {
                karadenizliPoint += 2;
            }
            else if (answer5 == "2")
            {
                karadenizliPoint += 2;
            }
            else if (answer5 == "3")
            {
                karadenizliPoint += 2;
            }
            else if (answer5 == "4")
            {
                karadenizliPoint += 20;
            }



            Console.WriteLine("Test results came dear " + name);

            Console.WriteLine("You are % " + karadenizliPoint + " karadenizli.");


            Console.ReadLine();
        }
    }
}