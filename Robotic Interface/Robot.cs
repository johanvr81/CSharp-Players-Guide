using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic_Interface
{
    public class OffCommand : IRobotCommand
    {
        public void Run(Robot robot) => robot.IsPowered = false;
    }

    public class OnCommand : IRobotCommand
    {
        public void Run(Robot robot) => robot.IsPowered = true;
    }

    public class WestCommand : IRobotCommand
    {
        public void Run(Robot robot) { if (robot.IsPowered) robot.X--; }
    }

    public class EastCommand : IRobotCommand
    {
        public void Run(Robot robot) { if (robot.IsPowered) robot.X++; }
    }

    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot) { if (robot.IsPowered) robot.Y--; }
    }

    public class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot) { if (robot.IsPowered) robot.Y++; }
    }

    public interface IRobotCommand
    {
        void Run(Robot robot);
    }

    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }
        public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
        public void Run()
        {
            foreach (IRobotCommand? command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
        }
    }

}
