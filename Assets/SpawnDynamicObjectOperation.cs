using BinDI;
using UnityEngine;
using VContainer;

[RegisterTo(typeof(Canvas))]
public sealed class SpawnDynamicObjectOperation : IPublishable
{
    [Inject] readonly PrefabBuilder _prefabBuilder;
    [Inject] readonly DynamicObjectParentProperty _dynamicObjectParentProperty;
    [Inject] readonly DynamicObject _dynamicObjectPrefab;
    
    public void Publish()
    {
        _prefabBuilder.Build(_dynamicObjectPrefab, _dynamicObjectParentProperty.Value);
    }
}
