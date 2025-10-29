using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charberry_Trees
{
    public class Harvester
    {
        private int _harvestCount;
        private CharberryTree _tree;
        public Harvester(CharberryTree tree)
        {
            _tree = tree;
            _tree.Ripened += OnTreeRipened;
        }

        private void OnTreeRipened()
        {
            _harvestCount++;
            _tree.Ripe = false;
            Console.WriteLine($"The tree has been harvested {_harvestCount} times.");
        }
    }
}
