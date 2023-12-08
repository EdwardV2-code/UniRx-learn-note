using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Try : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var subE = Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.E));
        var subQ = Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.Q));
        var subW = Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.W));
        var subR = Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.R));

        subE.Zip(subQ, subW, subR, (q, w, e, r) => q + w + e + r)
            .Subscribe(_ => Debug.Log("EQWR"));
    }
}
