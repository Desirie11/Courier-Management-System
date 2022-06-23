using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourierManagementSystem
{
         class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login Type please select an option\n");

            Console.WriteLine("1.User" +
                              "\n2.Admin" +
                              "\n3.Branch\n");

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Input an Option: ");
            String SystemOptions = Console.ReadLine();
            int DisplayMenu = Int32.Parse(SystemOptions);

            if (DisplayMenu == 1)
                 {

                    Validation validation = new Validation();
                    validation.validator1();
                 }
            if (DisplayMenu == 2)

                {

                    Validation validation2 = new Validation();
                    validation2.validator2();

                }


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if (DisplayMenu == 3)
                {
                    Validation validation3 = new Validation();
                    validation3.validator3();
                }

                Console.ReadKey();

            }
        }
    }

