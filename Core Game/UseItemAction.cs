using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class UseItemAction : IAction
    {
        private readonly IItem _item;

        public UseItemAction(IItem item) => _item = item;

        public void Run(Fight battle, Character actor)
        {
            Console.WriteLine($"{actor.Name} used {_item.Name}.");

            _item.Use(battle, actor);

            battle.GetPartyFor(actor).Items.Remove(_item);
        }
    }
}
