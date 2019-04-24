using System;
using System.Collections.Generic;

namespace ToDoList
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the To Do List");
            Console.WriteLine("--------------------------");

            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Would you like to add an item to your list or view your list? [Add/View]");
                bool ansStart = Console.ReadLine().ToLower() == "add";
                if (ansStart)
                {
                    Console.WriteLine("What do you want to add?");
                    string toDo = Console.ReadLine();
                    new Item(toDo);
                }
                else 
                {
                    List<Item> listHold = Item.GetAll();
                    foreach (Item thisItem in listHold)
                    {
                        Console.WriteLine(thisItem.GetDescription());
                    }
                    i = 1;
                    break;
                }
            }
        
        
        }
    }
}
