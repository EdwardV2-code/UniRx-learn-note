using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Interval : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Interval(System.TimeSpan.FromSeconds(1))
            .Subscribe(x => Debug.Log(x));
        //x 为 时间，从0开始，每秒加1（由TimeSpan指定的时间间隔为准，如果指定ms x则为ms）
    }
}
