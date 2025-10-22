using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Old_Robot
{
    public class OffCommand : RobotCommand
    {
        public override void Run(Robot robot) => robot.IsPowered = false;
    }

    public class OnCommand : RobotCommand
    {
        public override void Run(Robot robot) => robot.IsPowered = true;
    }

    public class WestCommand : RobotCommand
    {
        public override void Run(Robot robot) { if (robot.IsPowered) robot.X--; }
    }

    public class EastCommand : RobotCommand
    {
        public override void Run(Robot robot) { if (robot.IsPowered) robot.X++; }
    }

    public class SouthCommand : RobotCommand
    {
        public override void Run(Robot robot) { if (robot.IsPowered) robot.Y--; }
    }

    public class NorthCommand : RobotCommand
    {
        public override void Run(Robot robot) { if (robot.IsPowered) robot.Y++; }
    }

    public abstract class RobotCommand
    {
        public abstract void Run(Robot robot);
    }

    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }
        public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
        public void Run()
        {
            foreach (RobotCommand? command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
        }
    }
}
