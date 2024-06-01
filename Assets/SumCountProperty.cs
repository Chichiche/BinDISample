using BinDI;
using UniRx;
using VContainer;
using VContainer.Unity;

[RegisterTo(typeof( LocalScope ))]
public sealed class SumCountProperty : ReadOnlyProperty<int>, IInitializable
{
    [Inject] readonly GlobalCountProperty _globalCountProperty;
    [Inject] readonly LocalCountProperty _localCountProperty;
    [Inject] readonly IScopedDisposable _scopedDisposable;
    
    public void Initialize()
    {
        Observable.ReturnUnit()
            .Merge(_globalCountProperty.AsObservable().AsUnitObservable())
            .Merge(_localCountProperty.AsObservable().AsUnitObservable())
            .Select(_ => _globalCountProperty.Value + _localCountProperty.Value)
            .Subscribe(Publish)
            .AddTo(_scopedDisposable);
    }
}
