namespace SUT23_Individuellt_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Awesome Bank!");
            Console.WriteLine("Användarnamn:");
            string userName = Console.ReadLine();
            if userName == null || userName.Length == 0 )
            {

            }
            Console.WriteLine("Pinkod:");
            int pin = Convert.ToInt32(Console.ReadLine());



        }
        static void Meny()
        {
            Console.WriteLine("Välj vad du vill göra från menyn:");
            Console.WriteLine("1. Se dina konton och saldo");
            Console.WriteLine("2. Se dina konton och saldo");
            Console.WriteLine("3. Ta ut pengar");
            Console.WriteLine("4. Logga ut");
            switch (userMeny)
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
    }
}