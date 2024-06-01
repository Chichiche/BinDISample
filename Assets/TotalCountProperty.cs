using System;
using System.Collections.Generic;
using System.Linq;
using BinDI;
using UniRx;

[RegisterToGlobal]
public sealed class TotalCountProperty : ReadOnlyProperty<int>
{
    readonly List<IBufferedSubscribable<int>> _properties = new();
    
    public TotalCountProperty(GlobalCountProperty globalCountProperty, IScopedDisposable scopedDisposable)
    {
        RegisterProperty(globalCountProperty).AddTo(scopedDisposable);
    }
    
    public IDisposable RegisterProperty(IBufferedSubscribable<int> property)
    {
        _properties.Add(property);
        var subscription = property.Subscribe(_ => Publish());
        return Disposable.Create(() =>
        {
            subscription.Dispose();
            _properties.Remove(property);
            Publish();
        });
    }
    
    void Publish()
    {
        Publish(_properties.Sum(property => property.Value));
    }
}
