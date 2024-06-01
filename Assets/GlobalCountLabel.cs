using BinDI;

[PublishFrom(typeof( GlobalCountProperty ))]
public sealed class GlobalCountLabel : IntPublishableLabel
{
    protected override string Convert(int value)
    {
        return $"GlobalCount: {value}";
    }
}
