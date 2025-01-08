using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] persons = new string[10,5];
            Persons(persons);
        }

        public static string[,] AddUser(string id, string name, string surname, string age, string profession, string[,] persons)
        {
            for (int i = 0; i < persons.GetLength(0); i++)
            {
                if (persons[i, 0] == null) 
                {
                    persons[i, 0] = id;
                    persons[i, 1] = name;
                    persons[i, 2] = surname;
                    persons[i, 3] = age;
                    persons[i, 4] = profession;
                    Console.WriteLine();
                    Console.WriteLine("New person added");
                    Console.WriteLine();
                    return persons; 
                }
            }
            return persons;
        }


        public static void GetUsersList(string[,] users) 
        {
            for (int i = 0; i < users.GetLength(0); i++) 
            {
                if (users[i, 0] != null)
                {
                    for (int j = 0; j < users.GetLength(1); j++)
                    {
                        Console.Write(users[i, j] + " ");
                    }
                    Console.WriteLine();
                }else
                {
                    Console.WriteLine("First you must add the person to the list"); 
                    Console.WriteLine("Please enter 1");
                }
                  
            }
        }

        public static string[,] UpdateList(string id,  string[,] persons)
        {
            for (int i = 0; i < persons.GetLength(0); i++)
            {
                if (persons[i, 0] == id)
                {
                    persons[i, 1] = Console.ReadLine();
                    persons[i, 2] = Console.ReadLine();
                    persons[i, 3] = Console.ReadLine();
                    persons[i, 4] = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("List Changed");
                    Console.WriteLine();
                    return persons;
                }
            }
            return persons;
        }

        public static string[,] DeletePerson(string id, string[,] persons)
        {
            for (int i = 0; i < persons.GetLength(0); i++)
            {
                if (persons[i, 0] == id)
                {
                    persons[i, 0] = null;
                    persons[i, 1] = null;
                    persons[i, 2] = null;
                    persons[i, 3] = null;
                    persons[i, 4] = null;
                    Console.WriteLine();
                    Console.WriteLine("Person deleted");
                    Console.WriteLine();
                    return persons;
                }
            }
            return persons;
        }

        public static void GetUserByID(string id, string[,] users)
        {
            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (users[i, 0] == id)
                {
                    for (int j = 0; j < users.GetLength(1); j++)
                    {
                        Console.Write(users[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }


        public static void Persons(string[,] person)
        {
           bool flag = true;

            while (flag)
            {
                Console.WriteLine(
               $"Press 1 : Add person" +
               $"| Press 2 : Get person " +
               $"| Press 3 : Update person " +
               $"| Press 4 : Delete person " +
               $"| Press 5 : Get person by ID " +
               $"| Press 6 : Exit ");

                int option = int.Parse(Console.ReadLine());
                if(option >= 1 && option <= 6)
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please enter ID");
                            string id = Console.ReadLine();
                            Console.WriteLine("Please enter Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Please enter Surname");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Please enter Age");
                            string age = Console.ReadLine();
                            Console.WriteLine("Please enter Profession");
                            string profession = Console.ReadLine();
                            string[,] newPersons = AddUser(id, name, surname, age, profession, person);
                            break;
                        case 2:
                            GetUsersList(person);
                            break;
                        case 3:
                            Console.WriteLine("Please enter ID");
                            id = Console.ReadLine();    
                            UpdateList(id, person);
                            break;
                        case 4:
                            Console.WriteLine("Please enter ID");
                            id = Console.ReadLine();
                            DeletePerson(id, person);
                            break;
                        case 5:
                            Console.WriteLine("Please enter ID");
                            id = Console.ReadLine();
                            GetUserByID(id, person);
                            break;
                        case 6:
                            flag = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You enter wrong option");
                    continue;
                }
            }
           

        }
    }
}
