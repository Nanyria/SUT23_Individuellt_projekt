using System.ComponentModel;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace SUT23_Individuellt_projekt
{
  

    internal class Program
    {
        public static string[] users;
        public static int[] pin;
        public static string currentUser;
        static void Main(string[] args)
        {
 
            StoreUsers();
            Loggin();
            UserAccInfo();


        }

        public static void Loggin()
        {

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
                                currentUser = userName;
                                Console.Clear();
                                Meny();
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
            int currentUser = 0;
            int currentPin = 0;
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
            users = new string[5];
            users[0] = "Legolas";
            users[1] = "Madicken_";
            users[2] = "Ariel";
            users[3] = "Howl1337";
            users[4] = "Dracula_Forever";


            pin = new int[5];
            pin[0] = 4445;
            pin[1] = 1234;
            pin[2] = 4888;
            pin[3] = 4023;
            pin[4] = 1666;




            string[] Madicken_ = new string[2];
            Madicken_[0] = "Sparkonto";
            Madicken_[1] = "Godiskonto";

            string[] Ariel = new string[1];
            Ariel[0] = "Kungligt konto";

            string[] Howl1337 = new string[4];
            Howl1337[0] = "Pendragon";
            Howl1337[1] = "Wizard Howl";
            Howl1337[2] = "Wales";
            Howl1337[3] = "Suits";

            string[] Dracula_Forever = new string[5];
            Dracula_Forever[0] = "Offerpengar";
            Dracula_Forever[1] = "Tandläkare";
            Dracula_Forever[2] = "Sparpengar";
            Dracula_Forever[3] = "Slottsutgifter";
            Dracula_Forever[4] = "Sparande";


        }
        public static void Legolas()
        {
            string[] Legolas = new string[3];
            Legolas[0] = "Lönekonto";
            Legolas[1] = "Sparkonto";
            Legolas[2] = "Räkningar";
        }
        public static void Ariel

        public static void UserAccInfo()
        {
            Console.WriteLine("Hej," + currentUser + "!");
        }
        public static void Transfer()
        {

        }
        public static void Withdraw()
        {

        }

    }
}