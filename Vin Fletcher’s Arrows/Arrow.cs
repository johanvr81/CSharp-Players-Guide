using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vin_Fletcher_s_Arrows
{    class Arrow
    {
        public ArrowHead Arrowhead { get; }
        public Fletching Fletching { get; }
        public float Length { get; }

        public Arrow(ArrowHead arrowHead, Fletching fletching, float length)
        {
            Arrowhead = arrowHead;
            Fletching = fletching;
            Length = length;
        }

        public float Cost
        {
            get
            {
                float arrowHeadCost = Arrowhead switch
                {
                    ArrowHead.Steel => 10,
                    ArrowHead.Wood => 3,
                    ArrowHead.Obsidian => 5
                };

                float fletchingCost = Fletching switch
                {
                    Fletching.Plastic => 10,
                    Fletching.TurkeyFeathers => 5,
                    Fletching.GooseFeathers => 3
                };

                float shaftCost = 0.05f * Length;

                return arrowHeadCost + fletchingCost + shaftCost;
            }
        }
    }

    public enum ArrowHead
    {
        Steel,
        Wood,
        Obsidian
    }

    public enum Fletching
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }
}
