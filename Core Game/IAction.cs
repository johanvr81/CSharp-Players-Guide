using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public interface IAction
    {
        void Run(Fight battle, Character actor);
    }

    public record MenuChoice(string Description, IAction? Action)
    {
        public bool Enabled => Action != null;
    }
}
