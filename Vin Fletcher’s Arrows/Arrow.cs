using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vin_Fletcher_s_Arrows
{    class Arrow
    {
        public ArrowHead _arrowHead;
        public Fletching _fletching;
        public float _length;

        public Arrow(ArrowHead arrowHead, Fletching fletching, float length)
        {
            _arrowHead = arrowHead;
            _fletching = fletching;
            _length = length;
        }

        public float GetCost()
        {
            float ArrowHeadCost = _arrowHead switch
            {
                ArrowHead.Steel => 10,
                ArrowHead.Wood => 3,
                ArrowHead.Obsidian => 5
            };

            float fletchingCost = _fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.TurkeyFeathers => 5,
                Fletching.GooseFeathers => 3
            };

            float shaftCost = 0.05f * _length;

            return ArrowHeadCost + fletchingCost + shaftCost;
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
