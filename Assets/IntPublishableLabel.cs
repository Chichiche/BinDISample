using BinDI;
using UnityEngine;
using UnityEngine.UI;

public abstract class IntPublishableLabel : MonoBehaviour, IPublishable<int>
{
    [SerializeField] Text _text;
    
    void Reset()
    {
        _text = GetComponent<Text>();
    }
    
    public void Publish(int value)
    {
        _text.text = Convert(value);
    }
    
    protected virtual string Convert(int value) => value.ToString();
}
