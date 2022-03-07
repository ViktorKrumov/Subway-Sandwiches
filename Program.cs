using System;
using System.Collections.Generic;

namespace SubwaySandvichi
{
    class Program
    {
        static void Main(string[] args)
        {

            bool gotaprice1 = false;
            bool gotaprice2 = false;

            decimal price1 = 0;
            decimal price2 = 0;

            string known = string.Empty;
            

            Console.WriteLine("Menu");
            Console.WriteLine("------------");
            Console.WriteLine("sandwiches:");
            Console.WriteLine("We still don't have any sandwiches");

            Sandwich<string> FirstSandwich = new Sandwich<string>(known);
            Sandwich<string> SecondSandwich = new Sandwich<string>(known);


            Menu<string> menu = new Menu<string>(FirstSandwich, SecondSandwich);


            int detail = 0;



            string command = Console.ReadLine();
            while(command != "Bye")
            {
                Console.WriteLine("-----------");


                


                if (command == "Create")
                {
                    detail++;
                    Console.WriteLine("Bread type 1:");
                    string breadType = Console.ReadLine();

                    Console.WriteLine("Bread type 2:");
                    string breadType2 = Console.ReadLine();

                    Console.WriteLine("Products count for 1:");
                    int amount = int.Parse(Console.ReadLine());

                    

                    for (int i = 0; i < amount; i++)
                    {
                        string Products = Console.ReadLine();
                        FirstSandwich.Content.Add(Products);
                    }

                    //Console.WriteLine(string.Join(' ', FirstSandwich.Content));

                    Console.WriteLine("Products count for 2:");
                    int amount2 = int.Parse(Console.ReadLine());

                    for (int i = 0; i < amount2; i++)
                    {
                        string Products2 = Console.ReadLine();
                        SecondSandwich.Content.Add(Products2);
                    }

                    //Console.WriteLine(string.Join(' ', SecondSandwich.Content));

                    FirstSandwich.Bread = breadType;
                    SecondSandwich.Bread = breadType2;

                    Console.WriteLine("-----------");
                    Console.WriteLine("Commands: ");
                    Console.WriteLine("1- Add to..");
                    Console.WriteLine("2- Chek the ...");
                    Console.WriteLine("3- Count the ...");
                    Console.WriteLine("4- Price ..");
                    Console.WriteLine("5- Change the last product in ...");
                    Console.WriteLine("6- Compare");
                    Console.WriteLine("7- Print all we have in ...");
                    Console.WriteLine("8- Reset ...");
                    Console.WriteLine("9- Final price");
                    Console.WriteLine("-----------");
                    Console.WriteLine("10- Change the name of the ...");
                    Console.WriteLine();
                    string bonusComand = Console.ReadLine();

                    while(bonusComand != "Done")
                    {
                        if (bonusComand == "Add to 1")
                        {
                            Console.WriteLine("New Product: ");
                            string whatToAdd = Console.ReadLine();
                            FirstSandwich.Add(whatToAdd);
                        }
                        else if( bonusComand == "Add to 2")
                        {
                            Console.WriteLine("New Product: ");
                            string whatToAdd = Console.ReadLine();
                            SecondSandwich.Add(whatToAdd);
                        }

                        else if (bonusComand == "Chek the first")
                        {
                            Console.WriteLine("Space left " + FirstSandwich.Chek());
                        }
                        else if (bonusComand == "Chek the second")
                        {
                            Console.WriteLine("Space left " + SecondSandwich.Chek());
                        }

                        else if(bonusComand == "Count the first")
                        {
                            Console.WriteLine("Products count is " + FirstSandwich.CountSystavki());
                        }
                        else if (bonusComand == "Count the second")
                        {
                            Console.WriteLine("Products count is " + SecondSandwich.CountSystavki());
                        }

                        else if(bonusComand == "Price 1" && gotaprice1 == false)
                        {
                             price1 = FirstSandwich.Price();
                            Console.WriteLine("Price for 1 is " + price1 + " lv");
                            gotaprice1 = true;
                        }
                        else if (bonusComand == "Price 2" && gotaprice2 == false)
                        {
                             price2 = SecondSandwich.Price();
                            Console.WriteLine("Price for 2 is " + price2 + " lv");
                            gotaprice2 = true;
                        }
                        else if ((bonusComand == "Price 1" || bonusComand == "Price 2" )&& (gotaprice1 == true || gotaprice2 == true))
                        {
                            Console.WriteLine("You already have a price");
                        }

                        else if(bonusComand == "Change the last product in the first")
                        {
                            string newProduct = Console.ReadLine(); 
                            Console.WriteLine("The last Products is now " + FirstSandwich.ChangeLastProduct(newProduct));
                        }
                        else if (bonusComand == "Change the last product in the second")
                        {
                            string newProduct = Console.ReadLine();
                            Console.WriteLine("The last Products is now " + SecondSandwich.ChangeLastProduct(newProduct));
                        }
                        else if(bonusComand == "Compare")
                        {
                            if (FirstSandwich.CompareTo(SecondSandwich) < 0)
                            {
                                Console.WriteLine("The second sandwich has more Productss");
                            }
                            else if(FirstSandwich.CompareTo(SecondSandwich) == 0)
                            {
                                Console.WriteLine("They have equal amount of Productss");
                            }
                            else
                            {
                                Console.WriteLine("The first sandwich has more Productss");
                            }
                            
                        }
                        else if(bonusComand == "Print all we have in the first")
                        {
                            Console.WriteLine(String.Join(", ", FirstSandwich.PrintAll(FirstSandwich.Content)));
                        }
                        else if (bonusComand == "Print all we have in the second")
                        {
                            Console.WriteLine(String.Join(", ", SecondSandwich.PrintAll(SecondSandwich.Content)));
                        }
                        else if(bonusComand == "Reset first")
                        {
                            FirstSandwich.Reset();

                        }
                        else if (bonusComand == "Reset second")
                        {
                            SecondSandwich.Reset();

                        }

                        else if(bonusComand == "Final price")
                        {
                            Console.WriteLine(FirstSandwich.FinalPrice(price1, price2) + "lv");
                        }
                        bonusComand = Console.ReadLine();

                    }
                    Console.WriteLine("Name your first sandwich: ");
                    string name1 = Console.ReadLine();
                    FirstSandwich.Name = name1;

                    Console.WriteLine("--------------");

                    Console.WriteLine("Name your second sandwich: ");
                    string name2 = Console.ReadLine();
                    SecondSandwich.Name = name2;

                    Console.WriteLine("Are you done with the names?");
                    string aboutName = Console.ReadLine();

                    while(aboutName != "Yes")
                    {
                        if(aboutName == "Change the name of the first")
                        {
                            Console.WriteLine("New name: ");
                            string newName = Console.ReadLine();
                            Console.WriteLine(FirstSandwich.ChangeName(newName));
                        }
                        else if (aboutName == "Change the name of the second")
                        {
                            Console.WriteLine("New name: ");
                            string newName = Console.ReadLine();
                            Console.WriteLine(SecondSandwich.ChangeName(newName));
                        }
                        Console.WriteLine("Are you done now?");
                        aboutName = Console.ReadLine();
                    }


                    Console.WriteLine("Congrats you have your own sandwiches");
                     menu = new Menu<string>(FirstSandwich, SecondSandwich);

                    
                }
                else if(command == "What is the menu")
                {
                   foreach(var sandvich in menu)
                   {
                        Console.Write("Name: ");
                        Console.Write(sandvich.Name + " - ");
                        Console.Write("Bread type is " + sandvich.Bread + " ");
                        Console.WriteLine(string.Join(" , ", sandvich.Content));
                   }

                }
                










                command = Console.ReadLine();

            }
            

            if(detail != 0)
            {
                Console.WriteLine("Thank you for the new sandwiches Bye");
            }
            else
            {
                Console.WriteLine("Bye");
            }
            
            
            
            
            
            
        }
    }
}
