﻿using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace SUT23_Individuellt_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
 



        }

        public static void Loggin()
        {
            //Måste finnas ett smidigare sätt att göra detta på dock, det det blir orimligt mycket kod! Kan man kalla på varje 0 element på något sätt?
            string[] users = new string[5];
            users[0] = "Legolas";
            users[1] = "Madicken_";
            users[2] = "Ariel";
            users[3] = "Howl1337";
            users[4] = "Dracula_Forever";

            int[] pin = new int[5];
            pin[0] = 4445;
            pin[1] = 1234;
            pin[2] = 4888;
            pin[3] = 4023;
            pin[4] = 1666;

            int count = 3;
            int reset = 0;
            Console.WriteLine("Välkommen till Awesome Bank!");
            Console.WriteLine("Användarnamn:");
            string userName = Console.ReadLine();
            foreach (string item in users)
            {
                if (users.First && pin.First)

            }
            {

            }
            if userName == users[0] && userName != null)
            {
                Console.WriteLine("Pinkod:");
                int pincode = Convert.ToInt32(Console.ReadLine());
                while (count != 0)
                {
                    if (pincode == pin[0])
                    {
                        Console.WriteLine("Välkommen, " + users[0] + "!");
                    }
                    else if (pincode != pin[0])
                    {
                        count--;
                        Console.WriteLine("Du har skrivit fel pin. Du har {0} försök kvar.", count);
                        reset++;
                    }
                }
                if (count == 0)
                {
                    pin[0]++;
                    Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pin. Kontakta din bank för att låsa upp ditt konto igen.");
                    count ++;
                    count ++;
                    count ++;
                }
               

            }
            if userName == users[1] && userName != null)
            {
                Console.WriteLine("Pinkod:");
                int pincode = Convert.ToInt32(Console.ReadLine());
                while (count != 0)
                {
                    if (pincode == pin[1])
                    {
                        Console.WriteLine("Välkommen, " + users[0] + "!");
                    }
                    else if (pincode != pin[1])
                    {
                        count--;
                        Console.WriteLine("Du har skrivit fel pin. Du har {0} försök kvar.", count);
                        reset++;
                    }
                }
                if (count == 0)
                {
                    pin[1]++;
                    Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pin. Kontakta din bank för att låsa upp ditt konto igen.");
                    count++;
                    count++;
                    count++;
                }


            }
            if userName == users[2] && userName != null)
            {
                Console.WriteLine("Pinkod:");
                int pincode = Convert.ToInt32(Console.ReadLine());
                while (count != 0)
                {
                    if (pincode == pin[2])
                    {
                        Console.WriteLine("Välkommen, " + users[0] + "!");
                    }
                    else if (pincode != pin[2])
                    {
                        count--;
                        Console.WriteLine("Du har skrivit fel pin. Du har {0} försök kvar.", count);
                        reset++;
                    }
                }
                if (count == 0)
                {
                    pin[2]++;
                    Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pin. Kontakta din bank för att låsa upp ditt konto igen.");
                    count++;
                    count++;
                    count++;
                }


            }
            if userName == users[3] && userName != null)
            {
                Console.WriteLine("Pinkod:");
                int pincode = Convert.ToInt32(Console.ReadLine());
                while (count != 0)
                {
                    if (pincode == pin[3])
                    {
                        Console.WriteLine("Välkommen, " + users[3] + "!");
                    }
                    else if (pincode != pin[3])
                    {
                        count--;
                        Console.WriteLine("Du har skrivit fel pin. Du har {0} försök kvar.", count);
                        reset++;
                    }
                }
                if (count == 0)
                {
                    pin[3]++;
                    Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pin. Kontakta din bank för att låsa upp ditt konto igen.");
                    count++;
                    count++;
                    count++;
                }


            }
            if userName == users[4] && userName != null)
            {
                Console.WriteLine("Pinkod:");
                int pincode = Convert.ToInt32(Console.ReadLine());
                while (count != 0)
                {
                    if (pincode == pin[4])
                    {
                        Console.WriteLine("Välkommen, " + users[4] + "!");
                    }
                    else if (pincode != pin[4])
                    {
                        count--;
                        Console.WriteLine("Du har skrivit fel pin. Du har {0} försök kvar.", count);
                        reset++;
                    }
                }
                if (count == 0)
                {
                    pin[4]++;
                    Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pin. Kontakta din bank för att låsa upp ditt konto igen.");
                    count++;
                    count++;
                    count++;
                }


            }
            else
            {
                Console.WriteLine("Du måste skriva in ett användarnamn.");
            }

        }
        public static void Welcome()
        {

        }
        static void Meny()
        {
            Console.WriteLine("Välj vad du vill göra från menyn genom att ange korresponderande siffra:");
            Console.WriteLine("1. Se dina konton och saldo");
            Console.WriteLine("2. Överföringar mellan konton");
            Console.WriteLine("3. Ta ut pengar");
            Console.WriteLine("4. Logga ut");
            int result = 0;
            string choices = Console.ReadLine();
            bool loggedin = true;
            while (loggedin)
            {
                if (Int32.TryParse(choices, out result) || (result >= 1 && result < 5))
                {
                    switch (result)
                    {
                        case 1:
                            Program.UserAccInfo();
                            break;
                        case 2:
                            Program.Transfer();
                            break;
                        case 3:
                            Program.Withdraw();
                            break;
                        case 4:
                            loggedin = false;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Du måste skriva in en siffra mellan 1-4.");
                }

            }



        }
        public static void StoreUsers()
        {
            string[] LegolasAccounts = new string[] { "Lönekonto", "Sparkonto", "Räkningar" };
            string[] Madicken_ = new string[] { "Sparkonto", "Godiskonto" };
            string[] Ariel = new string[] { "Kungligt konto" };
            string[] Howl1337 = new string[] { "Pendragon", "Wizard Howl", "Wales", "Suits" };
            string[] Dracula_Forever = new string[] { "Offerpengar", "Tandläkare", "Sparpengar", "Slottsutgifter", "Sparande" };


        }
        public static void ValidateUserName()
        {
            if

        }
        public static void ValidatePin()
        {

        }
        public static void UserAccInfo()
        {

        }
        public static void Transfer()
        {

        }
        public static void Withdraw()
        {

        }

    }
}