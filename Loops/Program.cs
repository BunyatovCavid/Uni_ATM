namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 500.63;
            double amount = 0;

            Console.WriteLine("Zehmet deyilse seciminizi edin.");
            Console.WriteLine("[1] -  Balansi Goster.");
            Console.WriteLine("[2] - Pul Yukle.");
            Console.WriteLine("[3] - Pul Cixart.");
            Console.WriteLine("[4] - Proqramdan Cix.");

          
            string choose = "";



            while (choose!="4")
            {
                Console.Write("Secim : ");
                choose = Console.ReadLine();
                if (choose == "1")
                {
                    Console.WriteLine(balance);
                }
                else if (choose == "2")
                {
                    Console.Write("Yuklemek istediyiniz mebleg : ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    balance = balance + amount;
                    Console.WriteLine("Balans : " + balance);
                }
                else if (choose == "3")
                {
                    Console.Write("Cixartmaq istediyiniz mebleg: ");
                    amount = Convert.ToDouble(Console.ReadLine());

                    if (balance >= amount)
                        balance -= amount;
                    else
                        Console.WriteLine("Emeliyyat mumkun deyil");                
                }
                else if(choose=="4")
                {
                    Console.WriteLine("Cixilir.");
                }
                else
                {
                    Console.WriteLine("Gosterilen secimlerden birini edin.");
                }
            }

            Console.ReadLine();


        }
    }
}