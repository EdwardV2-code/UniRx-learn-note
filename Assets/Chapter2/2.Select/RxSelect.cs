using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;

public class RxSelect : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.Space))
            .Select(_ => "get mouse down")
            .Subscribe(x => Debug.Log(x));

        (from x in Observable.EveryUpdate() where Input.GetKeyDown(KeyCode.Space) select "get mouse down").Subscribe(x => Debug.Log(x));
    }
}

public class LinqSelect : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var result = list.Select(x => x * 2);
        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }
}