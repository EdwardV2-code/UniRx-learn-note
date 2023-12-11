using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ForEachAsync : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .ForEachAsync(value =>  Debug.Log( $"foreach:{value}") )
            .Subscribe(_ =>Debug.Log($"sub"));
    }
}
