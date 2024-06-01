using BinDI;

[RegisterTo(typeof( LocalScope ))]
public sealed class LocalCountProperty : Property<int>
{
    public LocalCountProperty(TotalCountProperty totalCountProperty, IScopedDisposable scopedDisposable)
    {
        totalCountProperty.RegisterProperty(this).AddTo(scopedDisposable);
    }
}
