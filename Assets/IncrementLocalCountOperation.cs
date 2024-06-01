using BinDI;
using VContainer;

[RegisterTo(typeof( LocalScope ))]
public sealed class IncrementLocalCountOperation : IPublishable
{
    [Inject] readonly LocalCountProperty _localCountProperty;
    
    public void Publish()
    {
        _localCountProperty.Publish(_localCountProperty.Value + 1);
    }
}