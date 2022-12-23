using System;

namespace AddressBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            AddressBookMain addressBookMain = new AddressBookMain();
            int count = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to AddressBook");
                Console.WriteLine("\nEnter your choice \n1.Add Contacts \n2.View Contacts \n3.Edit Contact \n4.Delete Contact \n5.Add Multiple Address \n6.Exit");
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
                    case 3:
                        addressBookMain.EditContact();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        addressBookMain.DeleteContact();
                        break;
                    case 5:
                        Console.WriteLine("\nHow many Address Book you want to create ?");
                        int addCount = Convert.ToInt32(Console.ReadLine());

                        Dictionary<int, string> dictionary = new Dictionary<int, string>();
                
                        for (int i = 1; i <= addCount; i++)
                        {
                            count++;
                            List<AddressBookMain> newAdd = new List<AddressBookMain>();
                            dictionary.Add(i, "New Dictionary");
                        }
                        Console.WriteLine("Address Book Created "+count);
                        addressBookMain.AddContact();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}