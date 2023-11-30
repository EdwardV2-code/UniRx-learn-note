using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
public class RxSkipWhile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .SkipWhile((_,num) => !Input.GetMouseButtonDown(0) && num < 100)
            .Subscribe(_ => Debug.Log("Mouse button down"));
    }
}
