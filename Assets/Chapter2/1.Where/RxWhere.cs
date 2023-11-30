using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;

public class RxWhere : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        List<string> strings = new List<string>();
        strings.Where(x => x.Length > 1)
            .ToList()
            .ForEach(x => Debug.Log(x));

        var a = from x in strings where x.Length > 1 select x;  // LINQ 查询表达式
        a.ToList().ForEach(a => Debug.Log(a));
    }

    // Update is called once per frame
    private void Update()
    {
    }
}

public class RxWhere2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Subscribe();

        (from x in Observable.EveryUpdate() where Input.GetMouseButtonDown(0) select x).Subscribe();
    }
}