using System;

namespace AddressBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            Contact contact = new Contact();
            AddressBookMain addressBookMain = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter your choice \n1.Add Contacts \n2.View Contacts \n3.Edit Contact " +
                    "\n4.Delete Contact \n5.Add Multiple Address \n6.Check for Duplicate Contact \n7.Search Person by City or State" +
                    "\n8.View Person by City or State \n9.Count Person \n10.Order By Name \n11.Sort by Zip Code \n12.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBookMain.AddContact();
                        break;
                    case 2:
                        addressBookMain.ViewDetail();
                        break;
                    case 3:
                        addressBookMain.EditContact();
                        break;
                    case 4:
                        addressBookMain.DeleteContact();
                        break;
                    case 5:
                        addressBookMain.AddDictionary();
                        break;
                    case 6:
                        addressBookMain.DuplicateContact();
                        break;
                    case 7:
                        addressBookMain.SearchPersonByCityOrState();
                        break;
                    case 8:
                        addressBookMain.ViewPersonByCityOrState();
                        break;
                    case 9:
                        addressBookMain.CountPerson();
                        break;
                    case 10:
                        addressBookMain.SortContactByName();
                        break;
                    case 11:
                        addressBookMain.SortContactByZipCode();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}