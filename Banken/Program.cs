using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Banken
{
    class Program
    {
        static List<Kund> infoList = new List<Kund>();

        public static void Main(string[] args)
        {
            string filepath = @"C:\test\";
            string filename = @"data.txt";

            Kund ui1 = new Kund("Micke");
            Kund ui2 = new Kund("Carola");
            listOfUser.Add(ui1);
            listOfUser.Add(ui2);
            string users = "";
            foreach (UserInfo u in listOfUser)
            {
                users += u.name + ";";
            }
            WriteFile(filepath, filename, users);

            string text = ReadFile(filepath + filename);
            string[] items = text.Split(';');
            Kund ui1 = new Kund(items[0]);
            Kund ui2 = new Kund(items[1]);
            listOfUser.Add(ui1);
            listOfUser.Add(ui2);
            Console.WriteLine(text);
            Console.ReadKey();


            int choice = 0;
            while (choice != 7)
            {
                choice = GetChoiceFromUser();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Du valde att lägga in en ny kund");
                        AddCustomer();
                        break;
                    case 2:
                        Console.WriteLine("Du valde att ta bort en kund");
                        RemoveCustomer();
                        break;
                    case 3:
                        Console.WriteLine("Du valde att se alla befintliga kunder");
                        ShowCustomer();
                        break;
                    case 4:
                        Console.WriteLine("Du valde att se ens kunds saldo");
                        Showbalance();
                        break;
                    case 5:
                        Console.WriteLine("Du valde att göra en insättning för en kund");
                        Addbalance();
                        break;
                    case 6:
                        Console.WriteLine("Du valde att göra ett uttag från en kund");
                        Removebalance();
                        break;
                    case 7:
                        Console.WriteLine("Du valde att avsluta programet. klicka enter för att avsluta.");
                        Console.WriteLine("Ha en bra dag!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Du gjorde ett felaktigt val");
                        break;
                }
            }








        }

        private static void Removebalance()
        {
            throw new NotImplementedException();
        }

        private static void Addbalance()
        {
            ShowCustomer();
            Console.WriteLine("Vem vill sätta in");
            int costumerindex = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket vill du sätta");
            int cash = int.Parse(Console.ReadLine());
            infoList[costumerindex].Saldo += cash;
         }

        private static void Showbalance()
        {
           
        }

        private static void ShowCustomer()
        {

            for (int i = 0; i < infoList.Count; i++)
            {
                Console.WriteLine(i+" "+infoList[i].ShowSaldoInfo());
            }
        }

        private static void RemoveCustomer()
        {
            ShowCustomer();
            Console.WriteLine("Vilken kund vill du ta bort?");
            int choice = int.Parse(Console.ReadLine());
            infoList.RemoveAt(choice);
        }

        private static void AddCustomer()
        {
            Kund info1 = new Kund();
            Console.WriteLine("Vad ska kunden heta?");
            info1.Namn = Console.ReadLine();
            infoList.Add(info1);
        }

        private static int GetChoiceFromUser()
        {

            Console.WriteLine("Välkommen till Banken!");
            Console.WriteLine("Ange vilket av följande alternativ du önskar att göra");
            Console.WriteLine("1. Lägga till användare");
            Console.WriteLine("2. Ta bort användare");
            Console.WriteLine("3. Visa alla befintliga användare");
            Console.WriteLine("4. Visa saldo för en användare");
            Console.WriteLine("5. Gör en insättning åt en användare");
            Console.WriteLine("6. Gör ett uttag för en användare");
            Console.WriteLine("7. Avsluta programmet");

            Console.WriteLine("Skriv ditt val här");
            int choice = int.Parse(Console.ReadLine());
            return choice ;


        }
    }
}
