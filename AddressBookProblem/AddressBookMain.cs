using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    internal class AddressBookMain
    {
        public static List<Contact> AddressBook = new List<Contact>();
        public void AddContact()
        {
            Console.WriteLine("Enter how many contacts you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Contact contacts = new Contact();
                Console.Write("Enter the First Name : ");
                contacts.FName = Console.ReadLine();

                Console.Write("Enter the last Name  : ");
                contacts.LName = Console.ReadLine();

                Console.Write("Enter the address  : ");
                contacts.Address = Console.ReadLine();

                Console.Write("Enter the City  : ");
                contacts.City = Console.ReadLine();

                Console.WriteLine("Enter the state : ");
                contacts.State = Console.ReadLine();

                while (true)
                {
                    Console.Write("Enter Zip Code  : ");
                    string code = Console.ReadLine();

                    if (code.Length == 6)
                    {
                        contacts.Zip = code;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid 6 digit Zip Code.");
                    }
                }

                while (true)
                {
                    Console.Write("Enter Your Phone Number: ");
                    string number = Console.ReadLine();

                    if (number.Length == 10)
                    {
                        contacts.PhoneNumber = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid 10 digit Phone Number.");
                    }
                }

                while (true)
                {
                    Console.Write("Enter Your Email Address: ");
                    string mail = Console.ReadLine();

                    if (mail.Contains("@"))
                    {
                        contacts.Email = mail;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid Email Address.");
                    }
                }

                AddressBook.Add(contacts);
                Console.WriteLine("Contact added Successfully");
            }
        }


        public void ViewDetail()
        {
            if (AddressBook.Count > 0)
            {
                foreach (var item in AddressBook)
                {
                    Console.WriteLine("First Name :   " + item.FName);
                    Console.WriteLine("Last Name :    " + item.LName);
                    Console.WriteLine("Address :      " + item.Address);
                    Console.WriteLine("City    :      " + item.City);
                    Console.WriteLine("State   :      " + item.State);
                    Console.WriteLine("Zip     :      " + item.Zip);
                    Console.WriteLine("Phone Number  : " + item.PhoneNumber);
                    Console.WriteLine("email  :       " + item.Email);

                }
            }
            else
            {
                Console.WriteLine("Address book is empty! ");
            }
        }

        public void EditContact()
        {
            if (AddressBook.Count > 0)
            {
                Console.Write("Enter Name of the contact you want to edit: ");
                string editDetails = Console.ReadLine();



                foreach (var item in AddressBook)
                {
                    if (editDetails.ToLower() == item.FName.ToLower())
                    {
                        Console.WriteLine("\nChoice what you want to edit \n1.First name \n2.Last name \n3.Address" +
                            "\n4.City \n5.State \n6.Zip Code \n7.Phone Number \n8.Email");

                        int editChoice = int.Parse(Console.ReadLine());

                        switch (editChoice)
                        {
                            case 1:
                                Console.Write("Enter new First Name: ");
                                item.FName = Console.ReadLine();
                                break;

                            case 2:
                                Console.Write("Enter new Last Name: ");
                                item.LName = Console.ReadLine();
                                break;

                            case 3:
                                Console.Write("Enter Your new Address: ");
                                item.Address = Console.ReadLine();
                                break;

                            case 4:
                                Console.Write("Enter Your new City Name: ");
                                item.City = Console.ReadLine();
                                break;

                            case 5:
                                Console.Write("Enter new State Name: ");
                                item.State = Console.ReadLine();
                                break;

                            case 6:
                                while (true)
                                {
                                    Console.Write("Enter new Zip Code: ");
                                    string code = Console.ReadLine();

                                    if (code.Length == 6)
                                    {
                                        item.Zip = code;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a valid 6 digit Zip Code.");
                                    }
                                }
                                break;

                            case 7:
                                while (true)
                                {
                                    Console.Write("Enter Your new Phone Number: ");
                                    string number = Console.ReadLine();

                                    if (number.Length == 10)
                                    {
                                        item.PhoneNumber = number;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a valid 10 digit Phone Number.");
                                    }
                                }
                                break;

                            case 8:
                                while (true)
                                {
                                    Console.Write("Enter Your new Email Address: ");
                                    string mail = Console.ReadLine();

                                    if (mail.Contains("@"))
                                    {
                                        item.Email = mail;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a valid Email Address.");
                                    }
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} does not exists in Address Book.", editDetails);
                    }
                }
            }
        }


        public void DeleteContact()
        {
            if (AddressBook.Count > 0)
            {
                Console.Write("Enter name of contact you want to delete: ");
                string deleteName = Console.ReadLine();


                foreach (var item in AddressBook)
                {
                    if (deleteName.ToLower() == item.FName.ToLower())
                    {
                        AddressBook.Remove(item);
                        Console.WriteLine(deleteName + "'s contact is successfully deleted.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(deleteName + " does not exist in Address Book.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Address Book is empty.");
            }
        }
    }
}
