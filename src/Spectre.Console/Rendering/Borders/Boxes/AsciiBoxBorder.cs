namespace Spectre.Console.Rendering;

/// <summary>
/// Represents an old school ASCII border.
/// </summary>
public sealed class AsciiBoxBorder : BoxBorder
{
    public override string GetTopLeftSymbol()
    {
        return "+";
    }

    public override string GetTopSymbol()
    {
        return "-";
    }

    public override string GetTopRightSymbol()
    {
        return "+";
    }

    public override string GetLeftSymbol()
    {
        return "|";
    }

    public override string GetRightSymbol()
    {
        return "|";
    }

    public override string GetBottomLeftSymbol()
    {
        return "+";
    }

    public override string GetBottomSymbol()
    {
        return "-";
    }

    public override string GetBottomRightSymbol()
    {
        return "+";
    }
}