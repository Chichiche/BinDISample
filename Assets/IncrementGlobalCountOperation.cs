using BinDI;
using VContainer;

[RegisterToGlobal]
public sealed class IncrementGlobalCountOperation : IPublishable
{
    [Inject] readonly GlobalCountProperty _globalCountProperty;
    
    public void Publish()
    {
        _globalCountProperty.Publish(_globalCountProperty.Value + 1);
    }
}