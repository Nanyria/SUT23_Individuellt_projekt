using System.ComponentModel;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace SUT23_Individuellt_projekt
{
    public class Users
    {
        public string userName { get; set; }
        public int pinCode { get; set; }
        public int count { get; set; }

        public string[] accountName { get; set; }
        public double[] accountValue { get; set; }
        public Users()
        {

        }
    }

    internal class Program
    {
        public static List<Users> AllUsers = new List<Users>();
        Users loggedInUser = ValidateUser();
        static void Main(string[] args)
        {
 
            StoreUsers();
            Loggin();

            


        }
        
        public static void Loggin()
        {
            Users loggedInUser = ValidateUser();
            if (loggedInUser != null) 
            {
                Users foundPin = ValidatePassword();
                if (foundPin != null)
                {
                    Console.WriteLine("Välkommen, " + loggedInUser.userName + "!");
                    Console.Clear();
                    Meny();

                }
                else
                {
                    WrongPass();
                }
            }

        }

        public static Users ValidateUser()
        {
            while (true)
            {
                Console.WriteLine("Välkommen till Awesome Bank!");
                Console.WriteLine("Användarnamn:");
                string enteredName = Console.ReadLine();
                Users foundUser = AllUsers.FirstOrDefault(u => u.userName == enteredName);
                if (foundUser != null)
                {
                    return foundUser;
                    
                }
                else
                {
                    return null;

                }   
            }
        }
        public static Users ValidatePassword()
        {
            while (true)
            {
                
                if (loggedInUser != null)
                {
                    for (int attempts = 0; attempts < 3; attempts++)
                    {

                        Console.WriteLine("Pinkod:");
                        string enteredPin = Console.ReadLine();

                        if (int.TryParse(enteredPin, out int pincode))
                        {
                            Users foundPin = AllUsers.FirstOrDefault(u => u.pinCode == pincode);
                            if (foundPin != null)
                            {
                                return foundPin;

                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {

                            Console.WriteLine("Pinkod i fel format. Vänligen skriv pinkoden i siffror.");

                        }

                    }

                }
                
            }

        }
        public static void WrongPass()
        {
             else
            {
                loggedInUser.count++;
                Console.WriteLine("Du har skrivit fel pin. Du har {0} försök kvar.", (2 - attempts));
                if (loggedInUser.count >= 3)
                {
                    Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pin. Kontakta din bank för att låsa upp ditt konto igen.");
                    return null;
                }

            }
        }


        public static void Welcome()
        {

        }
        static void Meny()
        {
            while(loggedInUser)
            {

            }
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
                            Loggin();
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

            AllUsers.Add(new Users
            {
                userName = "Legolas",
                pinCode = 4445,
                accountName = new string[4] {"Lönekonto", "Sparkonto", "Räkningar", "Vapenkonto"},
                accountValue = new double[4] {152006.2, 666.865, 165589, 0.56},
            });
            AllUsers.Add(new Users
            {
                userName = "Madicken_",
                pinCode = 1234,
                accountName = new string[2] {"Sparkonto", "Godiskonto"},
                accountValue = new double[2] {215, 13.5},
            });
            AllUsers.Add(new Users
            {
                userName = "Ariel",
                pinCode = 4888,
                accountName = new string[3] { "Fiskkonto", "Kungligt konto", "Skeppskonto" },
                accountValue = new double[3] { 5999.2, 593272, 42832 },
            });
            AllUsers.Add(new Users
            {
                userName = "Howl1337",
                pinCode = 4023,
                accountName = new string[5] { "Pendragon", "Wizard Howl", "Wales", "Calcifer", "Suits" },
                accountValue = new double[5] { 5032.1, 50392, 12000, 314.43, 17502.5 },
            });
            AllUsers.Add(new Users
            {
                userName = "Dracula_Forever",
                pinCode = 1666,
                accountName = new string[6] { "Offerpengar", "Tandläkare", "Sparpengar", "Slottsutgifter", "Sparande", "Blodbanken" },
                accountValue = new double[6] { 1820, 12600, 16773219.32, 194230.134, 50431341.31, 4251 },
            });

        }
        public static void StoreUserInfo()
        {
 
        }
        public static void UserAccInfo()
        {
            //Console.WriteLine("Hej," + user.Username + "!");


        }
        public static void Transfer()
        {

        }
        public static void Withdraw()
        {

        }
        //public static void Loggin()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Välkommen till Awesome Bank!");
        //        Console.WriteLine("Användarnamn:");
        //        string enteredName = Console.ReadLine();
        //        Users foundUser = AllUsers.FirstOrDefault(u => u.userName == enteredName);
        //        if (foundUser != null)
        //        {
        //            for (int attempts = 0; attempts < 3; attempts++)
        //            {
        //                Console.WriteLine("Pinkod:");
        //                string enteredPin = Console.ReadLine();
        //                if (int.TryParse(enteredPin, out int pincode))
        //                {

        //                    if (pincode == foundUser.pinCode)
        //                    {
        //                        Console.WriteLine("Välkommen, " + enteredName + "!");
        //                        Console.Clear();
        //                        Meny();
        //                        return foundUser;
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        foundUser.count++;
        //                        Console.WriteLine("Du har skrivit fel pin. Du har {0} försök kvar.", (2 - attempts));
        //                        if (foundUser.count >= 3)
        //                        {
        //                            Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pin. Kontakta din bank för att låsa upp ditt konto igen.");
        //                            break;
        //                        }

        //                    }

        //                }
        //                else
        //                {

        //                    Console.WriteLine("Pinkod i fel format. Vänligen skriv pinkoden i siffror.");
        //                }

        //            }
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Detta användarnamn finns inte registrerat. Har du skrivit fel?");
        //        }
        //    }

        //}

    }
}