using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public interface IGear
    {
        string Name { get; }
        IAttack Attack { get; }
    }
}
