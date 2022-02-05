using System;
using System.Collections.Generic;

namespace names_menu
{
    
    class Program
    {
        static void Main(string[] args)
        {
            

            for (; ; ) //Menu 
            {
                Console.WriteLine(@"Welcome to name menu progrem please choose option :
1..... add person and his  number. 
2..... delete person and his number.
3..... show persons information list .
4..... find person by his name .
5..... find person by his number.
6..... Quit the app..");

                string option = Console.ReadLine();
                option = option.Trim().ToLower();

                if (option == "1")
                    AddPersonInformations();


                else if (option == "2")
                    DeletePersonInformations();


                else if (option == "3")

                    ShowPersonsList();

                else if (option == "4")
                    FindPersonByHisName();
                else if (option == "5")
                    FindPersonByHisNumber();


                else if (option == "Quit")
                    break;



                else Console.WriteLine("you enterd a invaild number......");



                Console.WriteLine("progrem is finshed press enter to return.....");
                Console.ReadLine();

            }
            


        }
        /// <summary>
        /// (This Persons List)
        /// </summary>

        public static List<person> Persons = new List<person>();

        /// <summary>
        /// Options 
        /// </summary>
       


        //Option To Add Information of Person
        static void AddPersonInformations() 
        {
                

                Console.WriteLine("add person name");
                string PersonName = Console.ReadLine();


                Console.WriteLine("add person number");
                string PersonNumber = Console.ReadLine();
               

                Persons.Add(new person
                {
                    Name = $"{PersonName }",

                    PhoneNumber = $"{PersonNumber }"
                });



            

        }
/// <summary>
/// Delete info
/// </summary>
        static void DeletePersonInformations()
            {
                
                Console.WriteLine("add person number to remove");
                string n = Console.ReadLine();
            int.TryParse(n, out int PersonNumber);



            Persons.Remove(Persons[PersonNumber]);
               
            }

        //Option To show Information of Persons

        static void ShowPersonsList()
            {



                for (int i = 0; i < Persons.Count; i++)
                {
                    Console.WriteLine($"{i} => ${Persons[i]}");

                }
            }
/// <summary>
/// Find by Name
/// </summary>
        static void FindPersonByHisName()
        {
           
            string Search;
            

            Console.WriteLine("Who do you want to find?");
            Search = Console.ReadLine();

            for (int iCount = 0; iCount  < Persons.Count; iCount++)
            {
                if (Persons[iCount].Name.Equals(Search))

                {
                    Console.WriteLine("Found it");
                    Console.WriteLine(Persons[iCount].getName());

                }
            }
            

        }
        /// <summary>
        /// Find By number
        /// </summary>
        static void FindPersonByHisNumber()
        {

            string Search;


            Console.WriteLine("What number do you want to find?");
            Search = Console.ReadLine();

            for (int iCount = 0; iCount < Persons.Count; iCount++)
            {
                if (Persons[iCount].PhoneNumber.Equals(Search))

                {
                    Console.WriteLine("Found it");
                    Console.WriteLine(Persons[iCount].getNumber());

                }
            }
        }
    }           
}
