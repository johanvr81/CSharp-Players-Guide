using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charberry_Trees
{
    public class Notifier
    {
        public Notifier(CharberryTree tree)
        {
            tree.Ripened += OnTreeRipened;
        }

        private void OnTreeRipened() => Console.WriteLine("The tree is ripe.");
    }
}
