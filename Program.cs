namespace SUT23_Individuellt_projekt
{
    public class Users
    {
        //Klass för att lagra information om användare.
        public string userName { get; set; }
        public int pinCode { get; set; }
        public int count { get; set; }
        public string[] accountName { get; set; }
        public double[] accountValue { get; set; }

    }
    internal class Program
    {
        public static List<Users> AllUsers = new List<Users>();
        static void Main(string[] args)
        {

            StoreUsers(); //Kallar på de lagrade användarna.
            Login(); //Kallar på Inloggningssidan.

        }

        public static Users Login()
        {
            Console.WriteLine("Välkommen till Awesome Bank!");
            Users LoggedIn = null; 
            while (LoggedIn == null) 
            {
                Console.WriteLine("Användarnamn:");
                string enteredName = Console.ReadLine();
                Users foundUser = AllUsers.FirstOrDefault(u => u.userName == enteredName); //Söker efter användaren i listan AllUsers. 
                if (foundUser != null)
                {
                    if (foundUser.count < 3) //Om användaren inte redan använt sina tre inloggningsförsök så - 
                    {
                        Console.WriteLine("Pinkod:");
                        string enteredPin = Console.ReadLine();

                        if (int.TryParse(enteredPin, out int pincode) && foundUser.pinCode == pincode) //Om pinkoden är i siffror och koden stämmer överens med koden som är inmatad för användaren
                        {
                            Console.Clear();
                            Console.WriteLine("Välkommen, " + foundUser.userName + "!");
                            foundUser.count = 0; //Antal försök att logga in resettas.
                            Meny(foundUser);
                            LoggedIn = foundUser;
                        }
                        else
                        {
                            foundUser.count++;
                            Console.Clear();
                            Console.WriteLine("Du har skrivit fel pinkod. Du har {0} försök kvar.", (3 - foundUser.count));
                            if (foundUser.count >= 3)
                            {
                                Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pinkod. Kontakta din bank för att låsa upp ditt konto igen.");
                                Login();
                                return null;

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pinkod. Kontakta din bank för att låsa upp ditt konto igen.");
                        Login();
                        return null;

                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Användaren hittades inte.");
                }
            }
            return LoggedIn;
            
        }
        public static void Logout(ref Users LoggedIn) //Ändrar LoggedIn till null i Login-metoden så att anvvändaren loggas ut.
        {
            Console.WriteLine("Du har nu loggat ut.");
            Console.WriteLine("Tryck på Enter för att återgå till startsidan.");
            Console.ReadKey();
            LoggedIn = null;
            Console.Clear();
            Login();
        }
        static void Meny(Users LoggedIn) //Meny med switch där användaren väljer vad hen vill göra.
        {
            while (true)
            {

                Console.WriteLine("Välj vad du vill göra från menyn genom att ange korresponderande siffra:");
                Console.WriteLine("1. Se dina konton och saldo");
                Console.WriteLine("2. Överföringar mellan konton");
                Console.WriteLine("3. Ta ut pengar");
                Console.WriteLine("4. Logga ut");
                int choices;
                try
                {
                    choices = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Felaktigt inmatning. Ange en siffra mellan 1-4.");
                    continue;
                }
                if (choices >= 1 && choices < 5)
                {
                    switch (choices)
                    {
                        case 1:
                            Console.Clear();
                            UserAccInfo(LoggedIn);
                            break;
                        case 2:
                            Console.Clear();
                            Transfer(LoggedIn);
                            break;
                        case 3:
                            Console.Clear();
                            Withdraw(LoggedIn);
                            break;
                        case 4:
                            Console.Clear();
                            Logout(ref LoggedIn);
                            break;

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Felaktigt inmatning. Ange en siffra mellan 1-4.");
                    continue;
                }
                continue;
            }



        }
        public static void StoreUsers()
        {
            //Lagrar användarnas information i klassen Users. 
            AllUsers.Add(new Users
            {
                userName = "Legolas",
                pinCode = 4445,
                accountName = new string[4] { "Lönekonto", "Sparkonto", "Räkningar", "Vapenkonto" },
                accountValue = new double[4] { 152006.2, 666.865, 165589, 0.56 },
            });
            AllUsers.Add(new Users
            {
                userName = "Madicken_",
                pinCode = 1234,
                accountName = new string[2] { "Sparkonto", "Godiskonto" },
                accountValue = new double[2] { 215, 13.5 },
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
        public static string[] UserLists(Users LoggedIn)
        {
            //Slår ihop användarnas account-namn och account-värde och lagrar dem i en ny array.
            var UserAccounts = LoggedIn.accountName.Select((str, index) => str + ": " + LoggedIn.accountValue[index].ToString()).ToArray();
            UserAccounts.GetEnumerator();

            return UserAccounts;



        }
        public static void UserAccInfo(Users LoggedIn) //Visar upp användarens konton.
        {
            string[] UserAcc = UserLists(LoggedIn);
            int counter = 0;
            Console.WriteLine("Översikt av konton för {0}:", LoggedIn.userName);
            foreach (string element in UserAcc)
            {
                counter++;
                Console.WriteLine("\n{0}. {1} kr", counter, element);
            }
            Console.WriteLine("Tryck på enter för att komma tillbaka till menyn.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { } //Om användaren trycker på enter återgår hen till menyn.
            Console.Clear();
            Meny(LoggedIn);
        }
        public static void Transfer(Users LoggedIn) 
        {
            string[] UserAcc = UserLists(LoggedIn);
            Console.WriteLine("Här är dina konton:");
            for (int i = 0; i < UserAcc.Length; i++) //Skriver ut användarens konton
            {
                Console.WriteLine("\n {0}. " + UserAcc[i], i+1); //i+1 för att första kontot ska stå som konto 1 och inte 0.
            }

            Console.WriteLine("\nVilket konto vill du överföra från? Slå in siffran för kontot.");
            Console.WriteLine("Tryck på enter för att komma tillbaka till menyn.");

            while (true)
            {
                int transferFrom;
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) //Om användaren trycker på enter återgår hen till menyn.
                {
                    Console.Clear();
                    Meny(LoggedIn);
                    return;
                }

                try
                {
                    transferFrom = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Felaktig inmatning. Ange ett heltal.");
                    continue;
                }

                if (transferFrom < 1 || transferFrom > UserAcc.Length)
                {
                    Console.WriteLine("Ogiltigt kontonummer. Ange ett giltigt kontonummer.");
                    continue; 
                }

                if (transferFrom >= 1 && transferFrom <= UserAcc.Length)
                {
                    int sourceAccIndex = transferFrom - 1; //letar reda på vilken index-plats kontot har
                    string sourceAcc = UserAcc[sourceAccIndex]; //skriver ut kontot från arrayen med användarkonton genom att leta reda på rätt konto med sourceAccIndex

                    Console.WriteLine("Du vill överföra från kontot {0}", sourceAcc + ", stämmer det?");
                    Console.WriteLine("[1]. Ja.");
                    Console.WriteLine("[2]. Nej.");
                    int confirm;
                    try
                    {
                        confirm = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Felaktigt inmatning. Ange 1 eller 2.");
                        continue; 
                    }

                    if (confirm == 1)
                    {
                        Console.WriteLine("Vilket konto vill du överföra pengar till?");
                        int transferTo;
                        try
                        {
                            transferTo = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Felaktigt inmatning. Ange ett heltal.");
                            continue;
                        }

                        if (transferTo >= 1 && transferTo <= UserAcc.Length && transferTo != transferFrom)
                        {
                            int targetAccIndex = transferTo - 1;
                            string targetAcc = UserAcc[targetAccIndex]; //Se koden ovan för sourceAcc för mer info

                            Console.WriteLine("Du vill överföra till kontot {0}", targetAcc + ", stämmer det?");
                            Console.WriteLine("[1]. Ja.");
                            Console.WriteLine("[2]. Nej.");
                            int confirm2;
                            try
                            {
                                confirm2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Felaktigt inmatning. Ange 1 eller 2.");
                                continue;
                            }

                            if (confirm2 == 1)
                            {
                                Console.WriteLine("Hur mycket pengar vill du överföra från {0} till {1}?", sourceAcc, targetAcc);
                                double amount;
                                try
                                {
                                    amount = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Felaktigt inmatning. Ange ett numeriskt värde.");
                                    continue;
                                }
                                double sourceBalance = double.Parse(sourceAcc.Split(':')[1]); //Delar upp den kombinerade arrayen i två, och kommer åt delen som är double som den sen konverterar till double
                                double targetBalance = double.Parse(targetAcc.Split(":")[1]); //-"-
                                if (sourceBalance >= amount)
                                {
                                    sourceBalance -= amount;
                                    targetBalance += amount;

                                    LoggedIn.accountValue[sourceAccIndex] = sourceBalance; //Ser till att det lagrade värdet för det specifika kontot balanseras 
                                    LoggedIn.accountValue[targetAccIndex] = targetBalance; //-"-
                                    Console.Clear();
                                    Console.WriteLine("Överföring av {0} kr från konto {1} till konto {2} lyckades.",amount, sourceAcc.Split(':')[0], targetAcc.Split(':')[0]);
                                    UserAccInfo(LoggedIn);
                                }
                                else
                                {
                                    Console.WriteLine("Otillräckligt saldo för överföringen.");
                                    Console.Clear();
                                    Transfer(LoggedIn);
                                    return;

                                }
                            }
                            else if (confirm2 == 2)
                            {
                                Console.Clear();
                                Transfer(LoggedIn);
                                return;
 
                            }

                        }


                    }
                    else if (confirm == 2)
                    {
                        Console.Clear();
                        Transfer(LoggedIn);
                        return;
                    }
                }


            }

        }
        public static void Withdraw(Users LoggedIn)
        {
            string[] UserAcc = UserLists(LoggedIn);
            Console.WriteLine("Här är dina konton:");
            for (int i = 0; i < UserAcc.Length; i++)
            {
                Console.WriteLine("\n {0}. " + UserAcc[i], i + 1);
            }

            Console.WriteLine("\nVilket konto vill du ta ut pengar från? Slå in siffran för kontot.");
            Console.WriteLine("Tryck på enter för att komma tillbaka till menyn.");

            while (true)
            {
                int transferFrom;
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.Clear();
                    Meny(LoggedIn);
                    return;
                }

                try
                {
                    transferFrom = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Felaktig inmatning. Ange ett heltal.");
                    continue;
                }

                if (transferFrom < 1 || transferFrom > UserAcc.Length)
                {
                    Console.WriteLine("Ogiltigt kontonummer. Ange ett giltigt kontonummer.");
                    continue;
                }

                if (transferFrom >= 1 && transferFrom <= UserAcc.Length)
                {
                    int sourceAccIndex = transferFrom - 1;
                    string sourceAcc = UserAcc[sourceAccIndex];

                    Console.WriteLine("Du vill ta ut pengar från kontot {0}", sourceAcc + ", stämmer det?");
                    Console.WriteLine("[1]. Ja.");
                    Console.WriteLine("[2]. Nej.");
                    int confirm;
                    try
                    {
                        confirm = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Felaktigt inmatning. Ange 1 eller 2.");
                        continue;
                    }

                    if (confirm == 1)
                    {

                        Console.WriteLine("Hur mycket pengar vill du ta ut från {0}", sourceAcc);
                        double amount;
                        try
                        {
                            amount = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Felaktigt inmatning. Ange ett numeriskt värde.");
                            continue;
                        }
                        double sourceBalance = double.Parse(sourceAcc.Split(':')[1]);
                        if (sourceBalance >= amount)
                        {
                            while (true)
                            {
                                Console.WriteLine("Ange pinkod för att ta ut pengar:");
                                string enteredPin = Console.ReadLine();
                                if (int.TryParse(enteredPin, out int pincode) && LoggedIn.pinCode == pincode) //Om pinkoden stämmer
                                {
                                    sourceBalance -= amount;

                                    LoggedIn.accountValue[sourceAccIndex] = sourceBalance;
                                    Console.Clear();
                                    Console.WriteLine("Uttag av {0} kr från konto {1} lyckades.", amount, sourceAcc.Split(':')[0]);
                                    LoggedIn.count = 0;
                                    UserAccInfo(LoggedIn);
                                }
                                else
                                {
                                    LoggedIn.count++; //Se Login för mer info
                                    Console.WriteLine("Du har skrivit fel pinkod. Du har {0} försök kvar.", (3 - LoggedIn.count));
                                    if (LoggedIn.count >= 3)
                                    {
                                        Console.WriteLine("Du har använt dina tre försök men inte skrivit in rätt pinkod. Kontakta din bank för att låsa upp ditt konto igen.");
                                        Logout(ref LoggedIn);
                                        break;
                                    }
                                    continue;
                                }

                            }
                            

                        }
                        else
                        {
                            Console.WriteLine("Otillräckligt saldo för överföringen.");
                            Console.Clear();
                            Transfer(LoggedIn);
                            return;

                        }


                    }
                    else if (confirm == 2)
                    {
                        Console.Clear();
                        Transfer(LoggedIn);
                        return;
                    }
                }


            }
        }


    }
}