using UniRx;
using UnityEngine;

public class UniRxAggregate : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Subject<int> s = new Subject<int>();
        s.Aggregate((sum, next) => sum + next)
            .Subscribe(x => Debug.Log(x));

        s.OnNext(1);
        s.OnNext(2);
        s.OnNext(3);
        s.OnNext(4);
        s.OnCompleted();
    }
}