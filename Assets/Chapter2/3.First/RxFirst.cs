using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;

public class RxFirst : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.Space))
            .Select(_ => "get space down")
            .First()
            .Subscribe(x => Debug.Log(x));

        (from x in Observable.EveryUpdate() where Input.GetKeyDown(KeyCode.Space) select "get space down")
            .First().Subscribe(x => Debug.Log(x));
    }
}

public class LinqFirst : MonoBehaviour
{
    private void Start()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        int a = list.Where(x => x > 3) .First();
        Debug.Log(a);
    }
}
