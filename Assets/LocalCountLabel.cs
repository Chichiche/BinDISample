using BinDI;

[PublishFrom(typeof( LocalCountProperty ))]
public sealed class LocalCountLabel : IntPublishableLabel
{
    protected override string Convert(int value)
    {
        return $"LocalCount: {value}";
    }
}
