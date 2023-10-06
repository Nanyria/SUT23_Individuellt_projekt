namespace SUT23_Individuellt_projekt
{
    internal class Program
    {
        static void Main(string[] args)
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
            if (Int32.TryParse(choices, out result) || (result >= 1 && result < 5))
            {
                switch (result)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;

                }
            }
            else
            {
                Console.WriteLine("Du måste skriva in en siffra mellan 1-4.");
            }


        }
        public static void Loggin()
        {
            Console.WriteLine("Välkommen till Awesome Bank!");
            Console.WriteLine("Användarnamn:");
            string userName = Console.ReadLine();
            if userName == null || userName.Length == 0)
            {

            }
            Console.WriteLine("Pinkod:");
            int pin = Convert.ToInt32(Console.ReadLine());
        }
        public static void UserAcc()
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