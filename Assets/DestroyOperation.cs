using BinDI;
using UnityEngine;
using VContainer;
using UnityObject = UnityEngine.Object;

[RegisterToGlobal(Lifetime.Scoped)]
public sealed class DestroyOperation : IPublishable
{
    [Inject] readonly GameObject _gameObject;
    
    public void Publish()
    {
        if (! _gameObject) return;
        UnityObject.Destroy(_gameObject);
    }
}
