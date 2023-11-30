using UniRx;
using UnityEngine;

public class RxSingle : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Subject<int> s = new Subject<int>();
        s.Single(x => x % 2 == 0).Subscribe(x => Debug.Log(x));
        s.OnNext(1);
        s.OnNext(2);
        s.OnNext(3);
        s.OnCompleted();
    }
}
