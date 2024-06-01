using BinDI;

[PublishFrom(typeof( TotalCountProperty ))]
public sealed class TotalCountLabel : IntPublishableLabel
{
    protected override string Convert(int value)
    {
        return $"TotalCount: {value}";
    }
}
