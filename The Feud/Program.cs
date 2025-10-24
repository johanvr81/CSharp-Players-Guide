using IField;
using McDroid;
using McPig = McDroid.Pig;

Console.Title = "The Feud";

Sheep sheep = new Sheep();
Cow cow = new Cow();

IField.Pig pig1 = new IField.Pig(); 
McPig pig2 = new McPig();       


namespace IField
{
    public class Sheep { }
    public class Pig { }
}

namespace McDroid
{
    public class Cow { }
    public class Pig { }
}
