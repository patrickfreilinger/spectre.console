namespace Spectre.Console.Rendering;

/// <summary>
/// Represents a heavy border.
/// </summary>
public sealed class HeavyBoxBorder : BoxBorder
{
    /// <inheritdoc/>
    public override BoxBorder? SafeBorder => BoxBorder.Square;

    public override string GetTopLeftSymbol()
    {
        return "┏";
    }

    public override string GetTopSymbol()
    {
        return "━";
    }

    public override string GetTopRightSymbol()
    {
        return "┓";
    }

    public override string GetLeftSymbol()
    {
        return "┃";
    }

    public override string GetRightSymbol()
    {
        return "┃";
    }

    public override string GetBottomLeftSymbol()
    {
        return "┗";
    }

    public override string GetBottomSymbol()
    {
        return "━";
    }

    public override string GetBottomRightSymbol()
    {
        return "┛";
    }
}