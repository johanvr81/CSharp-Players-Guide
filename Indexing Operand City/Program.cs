Console.Title = "Indexing Operand City";

BlockCoordinate coordinate = new BlockCoordinate(4, 3);

Console.WriteLine(coordinate[0]);
Console.WriteLine(coordinate[1]);

public enum Direction { North, East, South, West }
public record BlockOffset(int RowOffset, int ColumnOffset);
public record BlockCoordinate(int Row, int Column)
{
    public int this[int index] => index switch { 0 => Row, 1 => Column };
}


//I don’t think so. coordinate.Row is clearer than coordinate[0].
//Indexers are best when the valid options aren’t known at compile time—like arrays, lists, or dictionaries, where elements or keys are determined at runtime.I don’t think so. coordinate.Row is clearer than coordinate[0].
//Indexers are best when the valid options aren’t known at compile time—like arrays, lists, or dictionaries, where elements or keys are determined at runtime.