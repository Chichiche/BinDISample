using BinDI;

[PublishFrom(typeof( SumCountProperty ))]
public sealed class SumCountLabel : IntPublishableLabel
{
    protected override string Convert(int value)
    {
        return $"Global+Local: {value}";
    }
}
