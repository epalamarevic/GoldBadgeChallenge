using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI();
            program.Run();
        }
    }

    public class ProgramUI
    {
       private MenuRepository _menuRepo = new MenuRepository();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        { 
            ////set bool for while loop
            bool running = true;
            ///start while loop
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add a item to the menu:\n" +
                    "2. Remove a item from the menu?\n" +
                    "3. Display the Menu:\n" +
                    "4. Exit");

                

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddMenuItem();
                        break;
                    case 2:
                        RemoveMenuItem();
                        break;
                    case 3:
                        DisplayMenu();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }

        private void AddMenuItem()
        {
            Console.Clear();

            Menu newMeal = new Menu();

            Console.WriteLine("What is number of meal?");
            newMeal.MealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What is name of meal?");
            newMeal.Name = Console.ReadLine();

            Console.WriteLine("Add the description of the meal");
            newMeal.Description = Console.ReadLine();

            Console.WriteLine("Add the ingredients of the meal");
            newMeal.Ingredients = Console.ReadLine();

            Console.WriteLine("What is the price of the meal?"):
            newMeal.Price = decimal.Parse(Console.ReadLine());

            _menuRepo.AddItem(newMeal);
        }

        private void RemoveMenuItem()
        {
            Console.Clear();
           
            DisplayMenu();

            Console.WriteLine("What menu item would you like to remove?, select by meal number");

            int mealNumber = int.Parse(Console.ReadLine());
            _menuRepo.RemoveSpecificItemFromList(mealNumber);



        }

        private void DisplayMenu()
        {
            Console.Clear();
            int index = 1;

            List<Menu> menus = _menuRepo.GetList();
            
            foreach (Menu menu in menus)
            {
                Console.WriteLine($"{index++}" +
                    $".{menu.MealNumber}" +
                    $".{menu.Name}" +
                    $".{menu.Description}" +
                    $".{menu.Ingredients}" +
                    $".{menu.Price}");
            }

        }
    }
}