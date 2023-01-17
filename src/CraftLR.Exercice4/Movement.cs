namespace CraftLR.Exercice4;

public enum Movement
{
    LEFT,
    RIGHT,
    ADVANCE,
    NONE
}

public static class Movements
{
    public static Movement GetMovement(char instruction)
    {
        return instruction switch
        {
            'L' => Movement.LEFT,
            'R' => Movement.RIGHT,
            'A' => Movement.ADVANCE,
            _ => Movement.NONE,
        };
    }
}
