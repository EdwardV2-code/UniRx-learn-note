using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Model : MonoBehaviour
{
    public static Model Instance;
    public IntReactiveProperty _TestInt;

    private void Awake()
    {
        Instance = this;
    }
}