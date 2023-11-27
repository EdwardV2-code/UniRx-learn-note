using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class RxTimer : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.Timer(TimeSpan.FromSeconds(5))       //send a message after 5 seconds
            .Subscribe(_ => { Debug.Log("Excute"); });  //subscribe to the message
    }

    // Update is called once per frame
    private void Update()
    {
    }
}