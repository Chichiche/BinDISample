using BinDI;
using UnityEngine;

[RegisterTo(typeof(Canvas))]
public sealed class DynamicObjectParentProperty : ReadOnlyProperty<Transform>
{
    public DynamicObjectParentProperty(DynamicObjectParent dynamicObjectParent)
    {
        Publish(dynamicObjectParent.transform);
    }
}
