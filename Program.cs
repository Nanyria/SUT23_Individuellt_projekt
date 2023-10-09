using System.ComponentModel;
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
            string[] users = new string[5];
            users[0] = "Legolas";
            users[1] = "Madicken_";
            users[2] = "ariel";
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
            while (true)
            {
                Console.WriteLine("Välkommen till Awesome Bank!");
                Console.WriteLine("Användarnamn:");
                string userName = Console.ReadLine();
                Console.WriteLine("Pinkod:");
                string enteredPin = Console.ReadLine();
                if (int.TryParse(enteredPin, out int pincode))
                {
                    int index = Array.IndexOf(users, userName);

                    if (index >= 0 && index < pin.Length)
                    {
                        int expectedPin = pin[index];

                        {
                            if (pincode == expectedPin)
                            {
                                Console.WriteLine("Välkommen, " + userName + "!");
                                break;
                            }
                            else if (pincode != expectedPin && count > 1)
                            {
                                count--;
                                Console.WriteLine("Du har skrivit fel pin. Du har {0} försök kvar.", count);
                                reset++;

                            }
                            else if (pincode != expectedPin && count <= 1)
                            {
                                Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pin. Kontakta din bank för att låsa upp ditt konto igen.");
                                count++;
                                count++;
                                break;

                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Detta användarnamn finns inte registrerat. Har du skrivit fel?");
                    }
                }
                else
                {
                    Console.WriteLine("Pinkod i fel format. Vänligen skriv pinkoden i siffror.");
                }
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
                            UserAccInfo();
                            break;
                        case 2:
                            Transfer();
                            break;
                        case 3:
                            Withdraw();
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


            //string[] LegolasAccounts = new string[] { "Lönekonto", "Sparkonto", "Räkningar" };
            //string[] Madicken_ = new string[] { "Sparkonto", "Godiskonto" };
            //string[] Ariel = new string[] { "Kungligt konto" };
            //string[] Howl1337 = new string[] { "Pendragon", "Wizard Howl", "Wales", "Suits" };
            //string[] Dracula_Forever = new string[] { "Offerpengar", "Tandläkare", "Sparpengar", "Slottsutgifter", "Sparande" };


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
            Console.WriteLine("Hej," users;
        }
        public static void Transfer()
        {

        }
        public static void Withdraw()
        {

        }

    }
}