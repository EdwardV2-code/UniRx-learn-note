using UniRx;
using UnityEngine;

public class RxGroupBy : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var s = new Subject<int>();

        s.GroupBy(x =>
        {
            if (x % 2 == 0)
                return "Å¼Êý";
            else
                return "ÆæÊý";
        })
            .Subscribe(x =>
            {
                x.Subscribe(y => Debug.Log($"{x.Key} : {y}"));
            }).AddTo(this);

        s.OnNext(1);
        s.OnNext(2);
        s.OnNext(3);
        s.OnNext(4);
        s.OnNext(5);
        s.OnCompleted();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}