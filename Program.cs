using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem
{
         class Program
    {
        static void Main(string[] args)
        {
         
                String Username, Password;


                Console.WriteLine("Login Type please select an option\n");

                Console.WriteLine("1.User" +
                                  "\n2.Admin" +
                                  "\n3.Branch\n");

                Console.WriteLine("---------------------------------");
                Console.WriteLine("Input an Option: ");
                String Option = Console.ReadLine();
                int DisplayOption = Int32.Parse(Option);

                if (DisplayOption == 1)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("\nUSER LOGIN");

                    Console.WriteLine("\nUsername: ");
                    Username = Console.ReadLine();

                    Console.WriteLine("\nPassword: ");
                    Password = Console.ReadLine();

                    if (Username.Equals("User") && Password.Equals("User123"))
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("\nLogin Successfully ");

                        Console.WriteLine("\nMenu/Option");

                        Console.WriteLine("1.Pick-up Request" +
                                          "\n2.View my Pick-up Request" +
                                          "\n3.Contuct us");

                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("\nInput an Option");
                        String UserMenu = Console.ReadLine();
                        int UserSelection = Int32.Parse(UserMenu);
                        Console.WriteLine("---------------------------------");

                        if (UserSelection == 1)
                        {
                            Console.WriteLine("Pick-up Request Option\n");
                            Console.WriteLine("//////////SENDERS INFO///////////\n");
                            Console.WriteLine("Senders name: ");
                            String SendersName = Console.ReadLine();

                        Console.WriteLine("\nAddress: ");
                        String SendersAddress = Console.ReadLine();

                            Console.WriteLine("\nPhone number: ");
                            String Pnumber = Console.ReadLine();
                            long SendersPhoneNumber = long.Parse(Pnumber);

                            Console.WriteLine("\nEmail: ");
                            String SenderEmail = Console.ReadLine();

                            Console.WriteLine("\nState: ");
                            String SendersState = Console.ReadLine();

                            Console.WriteLine("\nCity: ");
                            String SendersCity = Console.ReadLine();

                            Console.WriteLine("\nZipcode: ");
                            String Zipcode = Console.ReadLine();
                            int SendersZipcode = Int32.Parse(Zipcode);

                            ///////////////////Recievers info/////////////////

                            Console.WriteLine("//////////RECIEVERS INFO///////////\n");

                            Console.WriteLine("\nRecievers name: ");
                            String RecieversName = Console.ReadLine();

                            Console.WriteLine("\nAddress: ");
                            String RecieversAddress = Console.ReadLine();

                            Console.WriteLine("\nPhone number: ");
                            String Pnum = Console.ReadLine();
                            long RecieversPhoneNumber = long.Parse(Pnum);

                            Console.WriteLine("\nEmail: ");
                            String RecieversEmail = Console.ReadLine();

                            Console.WriteLine("\nState: ");
                            String RecieverState = Console.ReadLine();

                            Console.WriteLine("\nCity: ");
                            String RecieversCity = Console.ReadLine();

                            Console.WriteLine("\nZipcode: ");
                            String rZipcode = Console.ReadLine();
                            long RecieversZipcode = long.Parse(rZipcode);

                            Console.WriteLine("----------PACKAGE OPTION----------\n");

                            Console.WriteLine("\nPackage Type:");
                            Console.WriteLine("\n1.Documents" +
                                              "\n2.Parcel\n");

                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("Input an Option");
                            String PackageOption = Console.ReadLine();
                            long PackageSelection = long.Parse(PackageOption);
                            Console.WriteLine("----------------------------------");

                            if (PackageSelection == 1)
                            {
                                int Documents = 20;
                                int Chargefee = 30;
                                int total;

                                Console.WriteLine("weight (kg): ");
                                String kg = Console.ReadLine();
                                int knum = Int32.Parse(kg);
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("------------RECIEPT----------------");

                                total = Documents * knum + Chargefee;




                            string path = @"C:\Users\MyPC\source\repos\CourierManagementSystem\CourierManagementSystem\Reciept.txt";

                                File.WriteAllText(path, "Senders Info\n\n" + "Senders Name: " + SendersName + "\n" + "Address: " + SendersAddress + "\n" + "Phone Number: " + SendersPhoneNumber + "\n" + "Email: " + SenderEmail + "\n" + "State: " + SendersState + "\n" + "City: " + SendersCity + "\n" + "Zipcode: " + SendersZipcode + "\n\n" +
                                                        "Recievers Info\n\n" + "Recievers Name: " + RecieversName + "\n" + "Address" + RecieversAddress + "\n" + "Phone Number: " + RecieversPhoneNumber + "\n" + "Email: " + RecieversEmail + "\n" + "State: " + RecieverState + "\n" + "City: " + RecieversCity + "\n" + "Zipcode: " + RecieversZipcode + "\n" + "Weight (kg): " + PackageSelection +
                                                        "\nTotal cost\n" + total);

                                Console.WriteLine("Senders Info\n" + SendersName + "\n" + SendersAddress + "\n" + SendersPhoneNumber + "\n" + SenderEmail + "\n" + SendersState + "\n" + SendersCity + "\n" + SendersZipcode);
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine("Reciecers Info\n" + RecieversName + "\n" + RecieversAddress + "\n" + RecieversPhoneNumber + "\n" + RecieversEmail + "\n" + RecieverState + "\n" + RecieversCity + "\n" + RecieversZipcode);

                                Console.WriteLine("Final Cost " + total);

                                File.AppendAllText(path, File.ReadAllText(path));
                            }

                            if (PackageSelection == 2)
                            {

                                int parcel = 50;
                                int Chargefee = 30;
                                int total;

                                Console.WriteLine("weight (kg): ");
                                String kg = Console.ReadLine();
                                int knum = Int32.Parse(kg);
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("------------RECIEPT----------------");

                                total = parcel * knum + Chargefee;

                                string path = @"C:\Users\MyPC\source\repos\CourierManagementSystem\CourierManagementSystem\Reciept.txt";

                                File.WriteAllText(path, "Senders Info\n" + "Senders Name: " + SendersName + "\n" + "Address: " + SendersAddress + "\n" + "Phone Number: " + SendersPhoneNumber + "\n" + "Email: " + SenderEmail + "\n" + "State: " + SendersState + "\n" + "City: " + SendersCity + "\n" + "Zipcode: " + SendersZipcode + "\n\n" +
                                                        "Recievers Info\n" + "Recievers Name: " + RecieversName + "\n" + "Address" + RecieversAddress + "\n" + "Phone Number: " + RecieversPhoneNumber + "\n" + "Email: " + RecieversEmail + "\n" + "State: " + RecieverState + "\n" + "City: " + RecieversCity + "\n" + "Zipcode: " + RecieversZipcode + "\n" + "Weight (kg): " + PackageSelection +
                                                        "\nTotal cost\n" + total);

                                Console.WriteLine("Senders Info\n" + SendersName + "\n" + SendersAddress + "\n" + SendersPhoneNumber + "\n" + SenderEmail + "\n" + SendersState + "\n" + SendersCity + "\n" + SendersZipcode);
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine("Reciecers Info\n" + RecieversName + "\n" + RecieversAddress + "\n" + RecieversPhoneNumber + "\n" + RecieversEmail + "\n" + RecieverState + "\n" + RecieversCity + "\n" + RecieversZipcode);

                                Console.WriteLine("Final Cost " + total);

                            }
                        }
                        if (UserSelection == 2)
                        {
                            String filePath = @"C:\Users\MyPC\source\repos\CourierManagementSystem\CourierManagementSystem\Reciept.txt";
                            //String[] lines = File.

                            List<string> lines = new List<string>();
                            lines = File.ReadAllLines(filePath).ToList();

                            foreach (String line in lines)
                            {
                                Console.WriteLine(line);
                            }
                            Console.ReadLine();
                        }
                        if (UserSelection == 3)
                        {
                            Console.WriteLine("--------CONTUCT US OPTION--------\n");
                            Console.WriteLine("\nName: ");
                            String name = Console.ReadLine();

                            Console.WriteLine("\nEmail: ");
                            String email = Console.ReadLine();

                            Console.WriteLine("\nPhone number: ");
                            String Phonenumber = Console.ReadLine();
                            long number3 = long.Parse(Phonenumber);

                            Console.WriteLine("\nQuery: ");
                            String Query = Console.ReadLine();

                            string path = @"C:\Users\MyPC\source\repos\CourierManagementSystem\CourierManagementSystem\Query.txt";

                            File.WriteAllText(path, "Name: " + name + "\n\n" + "Email: " + email + "\n\n" + "Phone number: " + "\n\n" + number3 + "\n\n" + "Query: " + Query);
                        File.AppendAllText(path, File.ReadAllText(path));
                       }
                    }

                    else
                    {
                        Console.WriteLine("\nInvalid username or password please try again");

                    }

                    ///////////////////////////Admin LOGIN//////////////////////////////////////        
                }

                if (DisplayOption == 2)

                {

                    Console.WriteLine("----------ADMIN LOGIN------------");
                    Console.WriteLine("Username: ");
                    Username = Console.ReadLine();

                    Console.WriteLine("\nPassword: ");
                    Password = Console.ReadLine();

                    if (Username.Equals("Admin") && Password.Equals("Admin123"))
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("\nLogin Successfully ");

                        Console.WriteLine("1.View Costumer Pick-up Request" +
                                          "\n2.View Costumer Query");

                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Select an Option");
                        String Soption = Console.ReadLine();
                        int AdminSelection = Int32.Parse(Soption);

                        if (AdminSelection == 1)
                        {

                            String filePath = @"C:\Users\MyPC\source\repos\CourierManagementSystem\CourierManagementSystem\Reciept.txt";
                            //String[] lines = File.

                            List<string> lines = new List<string>();
                            lines = File.ReadAllLines(filePath).ToList();

                            foreach (String line in lines)
                            {
                                Console.WriteLine(line);
                            }
                            Console.ReadLine();

                        }

                        if (AdminSelection == 2)
                        {

                            String filePath = @"C:\Users\MyPC\source\repos\CourierManagementSystem\CourierManagementSystem\Query.txt";
                            //String[] lines = File.

                            List<string> lines = new List<string>();
                            lines = File.ReadAllLines(filePath).ToList();

                            foreach (String line in lines)
                            {
                                Console.WriteLine(line);
                            }
                            Console.ReadLine();

                        }
                    }

                }

                   //////////////////////////Branch LOGIN//////////////////////////////////////
                if (DisplayOption == 3)
                {

                    Console.WriteLine("---------BRANCH LOGIN-----------");
                    Console.WriteLine("\nUsername: ");
                    Username = Console.ReadLine();

                    Console.WriteLine("\nPassword: ");
                    Password = Console.ReadLine();

                    if (Username.Equals("Branch") && Password.Equals("Branch123"))
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Login Successfully");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Please select an Option");

                        Console.WriteLine("1.ADD" +
                                          "\n2.VIEW PIC-UP REQUEST" +
                                          "\n3.BOOK COURIERS");

                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Input an Option");
                        String BranchOption = Console.ReadLine();
                        int BranchSelection = Int32.Parse(BranchOption);

                        if (BranchSelection == 1)
                        {
                            Console.WriteLine("--------Add agent-----------");
                            Console.WriteLine("State: ");
                            String Agentstate = Console.ReadLine();

                            Console.WriteLine("City: ");
                            String Agentcity = Console.ReadLine();

                            Console.WriteLine("Agent Name: ");
                            String Agentname = Console.ReadLine();

                            Console.WriteLine("Email: ");
                            String AgentEmail = Console.ReadLine();

                            Console.WriteLine("Agent Code: ");
                            String AgentCode = Console.ReadLine();

                            Console.WriteLine("Gender: ");
                            String AgentGender = Console.ReadLine();

                            Console.WriteLine("Phone Number: ");
                            String phonenumber = Console.ReadLine();
                            long AgentPhoneNumber = long.Parse(phonenumber);

                            Console.WriteLine("Address: ");
                            String AgentAddress = Console.ReadLine();

                            string path = @"C:\Users\MyPC\source\repos\CourierManagementSystem\CourierManagementSystem\AgentDetails.txt";

                            File.WriteAllText(path, "State" + Agentstate + "\n" + "City: " + Agentcity + "\n" + "Agent Name: " + Agentname + "\n"
                                               + "Email" + AgentEmail + "\n" + "Password: " + AgentCode + "\n" + "Gender: " + AgentGender
                                               + "\n" + "Phone Number: " + phonenumber + "\n" + "Address: " + AgentAddress);

                            Console.WriteLine("State" + Agentstate + "\n" + "City: " + Agentcity + "\n" + "Agent Name: " + Agentname + "\n"
                                               + "Email" + AgentEmail + "\n" + "Password: " + AgentCode + "\n" + "Gender: " + AgentGender
                                               + "\n" + "Phone Number: " + phonenumber + "\n" + "Address: " + AgentAddress);

                        File.AppendAllText(path, File.ReadAllText(path));
                    }

                        if (BranchSelection == 2)
                        {

                            //ReadFile ng Book Courier

                            Console.WriteLine("---------------------------");

                            String filePath = @"C:\Users\MyPC\source\repos\CourierManagementSystem\CourierManagementSystem\CourierDetails.txt";

                            List<string> lines = new List<string>();
                            lines = File.ReadAllLines(filePath).ToList();

                            foreach (String line in lines)
                            {
                                Console.WriteLine(line);
                            }
                            Console.ReadLine();

                        }

                        if (BranchSelection == 3)
                        {

                            Console.WriteLine("-------------BOOK COURIERS-----------");
                            Console.WriteLine("------------Courier Details----------");

                            Console.WriteLine("Courier Number: ");
                            String CNumber = Console.ReadLine();
                            int CourierNumber = Int32.Parse(CNumber);

                            Console.WriteLine("Agent Name: ");
                            String AgentName = Console.ReadLine();

                            string path = @"C:\Users\MyPC\source\repos\CourierManagementSystem\CourierManagementSystem\CourierDetails.txt";

                            File.WriteAllText(path, "Agent Name: " + AgentName + "\n" + "Courier Number: " + CourierNumber + "\n");


                            String filePath = @"C:\Users\MyPC\source\repos\CourierManagementSystem\CourierManagementSystem\Reciept.txt";

                            List<string> lines = new List<string>();
                            lines = File.ReadAllLines(filePath).ToList();

                            foreach (String line in lines)
                            {

                                Console.WriteLine(line);
                            }

                            File.AppendAllText(path, File.ReadAllText(filePath));


                            Console.ReadLine();

                        }
                    }

                }

                Console.ReadKey();
            }
    }
}
