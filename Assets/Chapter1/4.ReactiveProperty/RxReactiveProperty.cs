using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RxReactiveProperty : MonoBehaviour
{
    public IntReactiveProperty _IntReactiveProperty;
    public FloatReactiveProperty _FloatReactiveProperty;
    public ReactiveProperty<int> I;
    public int Index
    {
        get 
        {
            return Index;
        }
        set
        {
            if(value != Index)
            {
                Index = value;
                // Call Event
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        I.Subscribe(i => Debug.Log("I is " + i));
        _IntReactiveProperty.Subscribe(i => Debug.Log("IntReactiveProperty is " + i));
        _FloatReactiveProperty.Subscribe(i => Debug.Log("FloatReactiveProperty is " + i));
    }
}
