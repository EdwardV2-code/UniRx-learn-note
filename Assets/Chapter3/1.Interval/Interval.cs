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
        //x Ϊ ʱ�䣬��0��ʼ��ÿ���1����TimeSpanָ����ʱ����Ϊ׼�����ָ��ms x��Ϊms��
    }
}
