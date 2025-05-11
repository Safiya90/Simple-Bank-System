namespace SimpleBankSystem
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Username = new string[] { "Marwa", "Malak", "Salwa" };
            int[] Password = new int[] { 1001, 2002, 3002 };
            double[] balance = new double[] { 10000, 20000, 30000 };
            Console.Write($"Enter Username:");
            string username =Convert.ToString(Console.ReadLine());
            Console.Write($"Enter Password:");
            int password= int.Parse( Console.ReadLine() );

            for ( int i = 0; i < Username.Length; i++ )
            {
                if (username == Username[i] && password == Password[i])
                {
                    Console.WriteLine("Login succeeds");
                    {
                        Console.WriteLine("Please select services:\n1-Check Balance\r\n2-Deposit\r\n3-Withdraw\r\n4-Transfer\r\n5-Exit");
                        string service = Console.ReadLine();
                        switch (service)
                        {
                            case "1":
                                Console.WriteLine($"Your Balance: {balance[i]}");
                            return;

                            case "2":
                            Console.WriteLine("Please enter Amount:");
                            int deposit = int.Parse(Console.ReadLine());
                            balance[i] = balance[i] + deposit;
                            Console.WriteLine($"Your Balance: {balance[i]}");
                            break;

                            case "3":
                            Console.WriteLine("Please enter Amount:");
                            int withdraw = int.Parse(Console.ReadLine());
                            if (withdraw <= balance[i])
                            {
                                balance[i] = balance[i] - withdraw;
                                Console.WriteLine($"Your Balance: {balance[i]}");
                            }
                            else
                            {
                                Console.WriteLine("You exceed the limit of your balance");
                            }
                            break;

                            case "4":
                                Console.WriteLine("Please enter Amount:");
                            int transfer = int.Parse(Console.ReadLine());
                            balance[i] = balance[i] - transfer;
                            Console.WriteLine($"Your Balance: {balance[i]}");
                            break;

                            case "5":
                                Console.WriteLine("Thank you!");
                                return;
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Username and Password.\nPlease try again!");
                    break;
                }
            }

        }
    }
}
