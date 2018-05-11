using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneBookDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[1];
            var families = new string[1];
            var phones = new string[1];
            InitializePhoneBook();
            while (true)
            {
                Console.Clear();
                var SelectedMenuItem = ShowMenu();
                Console.Clear();
                switch (SelectedMenuItem)
                {
                    case 1:
                        ShowContactList(names, families, phones);
                        break;
                    case 2:
                        AddToContactList(ref names, ref families, ref phones);
                        break;

                    case 3:
                        EditLFromContactList(ref names, ref families, ref phones);

                        break;

                    case 4:
                        RemoveFromContactList(ref names, ref families, ref phones);

                        break;

                }
            }
        }
        static void InitializePhoneBook()
        {
            Console.WriteLine("Welcome To PhoneBook");
            Thread.Sleep(2000);
            Console.Clear();
        }
        static int ShowMenu()
        {
            Console.WriteLine($"1.ShowContactList\n2.AddNewContact\n3.EditContact\n4.RemoveContact\n5.Exit");
            return int.Parse(Console.ReadLine());
        }

        static void ShowInvalidPhoneNotification()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Phone Number Is Not Valid!");
            Console.CursorVisible = false;
            Thread.Sleep(3000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = true;
        }

        static bool AddToContactList(ref String[] names, ref String[] families, ref string[] phones)
        {
            Console.Write("Name:");
            var name = Console.ReadLine();
            Console.Write("Family:");
            var family = Console.ReadLine();
            Console.Write("Phone:");
            var phone = Console.ReadLine();
            if (Regex.IsMatch(phone, @"^09\d{9}$"))
            {
                AddToStringArray(ref names, name);
                AddToStringArray(ref families, family);
                AddToStringArray(ref phones, phone);

                return true;
            }
            else
            {
                return false;

            }
        }
        static void AddToStringArray(ref String[] array, string newvalue)
        {
            string[] NewArray;
            if (array[0] != null)
            {
                NewArray = new string[array.Length + 1];
            }
            else
            {
                NewArray = new string[array.Length];
            }

            for (int i = 0; i < array.Length; i++)
            {
                NewArray[i] = array[i];

            }
            NewArray[NewArray.Length - 1] = newvalue;
            array = NewArray;

        }

        static void ShowContactList(string[] names, string[] families, string[] phones)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] != null)
                {
                    Console.WriteLine($"{names[i]}\t{families[i]}\t{phones[i]}\t");
                }
            }

            Console.WriteLine("-------------------------------");
            Console.ReadKey();

        }

        static bool RemoveFromContactList(ref string[] names, ref string[] families, ref string[] phones)
        {


            int i = 0;
            for (; i < names.Length; i++)

                RemoveFromArray(ref names, i);
            RemoveFromArray(ref families, i);
            RemoveFromArray(ref phones, i);
            Console.Clear();
            Console.WriteLine("list removed");
            Thread.Sleep(3000);
            return true;
        }
        static void RemoveFromArray(ref string[] array1, int oldvalue)
        {


            String[] OldArray = new string[array1.Length - 1];

            int i = 0;
            int j = 0;
            while (i < OldArray.Length)
            {
                if (i != oldvalue)
                {
                    OldArray[j] = array1[i];
                    j++;
                }

                i++;
            }

            array1 = OldArray;

        }

        static bool EditLFromContactList(ref string[] names, ref string[] families, ref string[] phones)
        {
              int j = 0;

            ShowContactList(names, families,  phones);
            for (; j < names.Length; j++)
            {
                EditArray(  ref names, j);
                EditArray(  ref families, j);
                EditArray(ref   phones, j);
             }
            return true;

        }
        static void EditArray(  ref string[] array2, int editvalue)
        {
            String[] OldArray = new string[array2.Length];
            int i = 0;
            for (; i < array2.Length; i++)
            {
                if (i == editvalue)
                    array2[i] = Console.ReadLine();
                OldArray[i] = array2[i];

            }
            array2 = OldArray;
        }


    }

}

