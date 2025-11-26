using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public interface IItem
    {
        string Name { get; }
        void Use(Fight battle, Character user);
    }

    public class HealthPotion : IItem
    {
        public string Name => "HEALTH POTION";

        public void Use(Fight battle, Character user)
        {
            user.HP += 10;
            Console.WriteLine($"{user.Name}'s HP was increased by 10."); 
        }
    }
}
