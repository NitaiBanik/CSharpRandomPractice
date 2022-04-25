public enum Grade
{
    A = 0,
    B = 1,
    C = 2,
    D = 3
}

public int GetNumberOfPoints(Grade grade)
{
    return grade switch
    {
        Grade.A => 10,
        Grade.B => 8,
        Grade.C => 4,
        Grade.D => 2,
        _ => throw new ArgumentException()
    };
}

///Better way with Enumeration pattern

public class Grade
{
    public static readonly Grade A = new Grade(0, "A");
    public static readonly Grade B = new Grade(1, "B");
    public static readonly Grade C = new Grade(2, "C");
    public static readonly Grade D = new Grade(3, "D");

    public int Id { get; }
    public string Name { get; }

    private Grade(int id, string name)
    {
        Name = name;
        Id = id;
    }

    public int GetNumberOfPoints()
    {
        if (this == A)
            return 10;

        if (this == B)
            return 8;

        if (this == C)
            return 4;

        if (this == D)
            return 10;

        if (this == A)
            return 2;

        throw new ArgumentException()
    }
}

///Final way
public class Grade
{
    public static readonly Grade A = new Grade(0, "A", 10);
    public static readonly Grade B = new Grade(1, "B", 8);
    public static readonly Grade C = new Grade(2, "C", 4);
    public static readonly Grade D = new Grade(3, "D", 2);

    public int Id { get; }
    public string Name { get; }
    public int NumberOfPoints { get; }

    private Grade(int id, string name, int numberOfPoints)
    {
        Name = name;
        Id = id;
        NumberOfPoints = numberOfPoints;
    }
}