﻿namespace AddressBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            AddressBookMain addressBookMain = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to AddressBook");
                Console.WriteLine("\nEnter your choice \n1.Add Contacts \n2.View Contacts \n3.Exit");
                Console.WriteLine("\nEnter option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBookMain.AddContact();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        addressBookMain.ViewDetail();
                        Console.WriteLine("\n");
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}