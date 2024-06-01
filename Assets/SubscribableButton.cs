using System;
using BinDI;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public abstract class SubscribableButton : MonoBehaviour, ISubscribable
{
    [SerializeField] Button _button;
    
    void Reset()
    {
        _button = GetComponent<Button>();
    }
    
    public IDisposable Subscribe(IPublishable publishable)
    {
        return _button.OnClickAsObservable().Subscribe(publishable);
    }
}
