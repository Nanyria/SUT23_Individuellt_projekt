using System.ComponentModel;
using System.Linq.Expressions;

namespace SUT23_Individuellt_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
 



        }

        public static void Loggin()
        {
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
            Console.WriteLine("Välkommen till Awesome Bank!");
            Console.WriteLine("Användarnamn:");
            string userName = Console.ReadLine();
            if userName == users[0])
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
                    }
                }
                if (count == 0)
                {
                    pin[0]++;
                    Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pin. Kontakta din bank för att låsa upp ditt konto igen.");
                }
               

            }
            if userName == users[1])
            {
                Console.WriteLine("Pinkod:");
                int pincode = Convert.ToInt32(Console.ReadLine());

            }
            if userName == users[2])
            {
                Console.WriteLine("Pinkod:");
                int pincode = Convert.ToInt32(Console.ReadLine());

            }
            if userName == users[3])
            {
                Console.WriteLine("Pinkod:");
                int pincode = Convert.ToInt32(Console.ReadLine());

            }
            if userName == users[4])
            {
                Console.WriteLine("Pinkod:");
                int pincode = Convert.ToInt32(Console.ReadLine());

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