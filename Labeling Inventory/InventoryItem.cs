using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    public class InventoryItem
    {
        public float Weight { get; }
        public float Volume { get; }

        public InventoryItem(float weight, float volume)
        {
            Weight = weight;
            Volume = volume;
        }
    }

    public class Arrow : InventoryItem
    {
        public Arrow() : base(0.1f, 0.05f) { }
        public override string ToString() => "Arrow";
    }

    public class Bow : InventoryItem
    {
        public Bow() : base(1, 4) { }
        public override string ToString() => "Bow";
    }

    public class Rope : InventoryItem
    {
        public Rope() : base(1, 1.5f) { }
        public override string ToString() => "Rope";
    }

    public class Water : InventoryItem
    {
        public Water() : base(2, 3) { }
        public override string ToString() => "Water";
    }

    public class Food : InventoryItem
    {
        public Food() : base(1, 0.5f) { }
        public override string ToString() => "Food";
    }

    public class Sword : InventoryItem
    {
        public Sword() : base(5, 3) { }
        public override string ToString() => "Sword";
    }
}
