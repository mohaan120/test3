using System;

namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: Xogta laga codsado user-ka
            Console.Write("Fadlan geli magacaaga: ");
            string name = Console.ReadLine();

            Console.Write("Fadlan geli magaca hooyada: ");
            string motherName = Console.ReadLine();

            Console.Write("Fadlan geli taariikhda dhalashada (YYYY-MM-DD): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());


            Console.Write("Fadlan geli meesha aad ku dhalatay: ");
            string pob = Console.ReadLine();

            Console.Write("Fadlan geli emailkaaga: ");
            string email = Console.ReadLine();

            Console.Write("Fadlan geli jinsiga (M = Lab, F = Dhedig): ");
            char sex = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Fadlan geli lambarka telefoonka: ");
            string telephone = Console.ReadLine();

            Console.Write("Fadlan geli xaalada guurka (tusaale: Single, Married): ");
            string status = Console.ReadLine();

            // Output: Soo bandhig xogta la geliyey
            Console.WriteLine("\n--- Xogta Shaqsiga ah ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Mother's Name: {motherName}");
            Console.WriteLine($"Date of Birth: {dob.ToShortDateString()}");
            Console.WriteLine($"Place of Birth: {pob}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Sex: {sex}");
            Console.WriteLine($"Telephone: {telephone}");
            Console.WriteLine($"Status: {status}");

            // Sug in user-ka riixo key si program-ku u xirmo
            Console.WriteLine("\nRiix key si aad u xirtid...");
            Console.ReadKey();
        }
    }
}