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
            Kund info1 = new Kund();
            info1.Namn = "kalle";
            infoList.Add(info1);

            Kund info2 = new Kund();
            info2.Namn = "lena";
            infoList.Add(info2);

            Kund info3 = new Kund();
            info3.Namn = "benjamin";
            infoList.Add(info3);

            for (int i = 0; i < infoList.Count; i++)
            {
                Console.WriteLine(infoList[i].ShowSaldoInfo());
            }

            foreach(Kund info in infoList)
            {
                Console.WriteLine(info.ShowSaldoInfo());
            }

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
            throw new NotImplementedException();
        }

        private static void Showbalance()
        {
            throw new NotImplementedException();
        }

        private static void ShowCustomer()
        {
            throw new NotImplementedException();
        }

        private static void RemoveCustomer()
        {
            throw new NotImplementedException();
        }

        private static void AddCustomer()
        {
            throw new NotImplementedException();
        }

        private static int GetChoiceFromUser()
        {

            Console.WriteLine("Välkommen till Banken!");
            Console.WriteLine("Ange vilket av följande alternativ du önskar att göra");
            Console.WriteLine("Lägga till användre");
            Console.WriteLine("ta bort användare");
            Console.WriteLine("Visa alla befintliga användare");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
