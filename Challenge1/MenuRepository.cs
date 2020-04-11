using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class MenuRepository
    {
        List<Menu> _menu = new List<Menu>();

        public void AddItem(Menu item)
        {
            
            _menu.Add(item);
        }

        public void RemoveMenuItem(Menu item)
        {
            
            _menu.Remove(item);
        }

        public List<Menu> GetList()
        {
            return _menu;
        }

        public void RemoveSpecificItemFromList(int mealNumber)
        {
            foreach (Menu menu in _menu)
            {
                if (menu.MealNumber == mealNumber)
                {
                    RemoveMenuItem(menu);
                    break;
                }
            }
        }

    }
}