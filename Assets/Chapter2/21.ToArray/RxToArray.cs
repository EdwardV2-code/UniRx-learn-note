using UniRx;
using UnityEngine;

public class RxToArray : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Subject<int> s = new Subject<int>();
        s.ToArray()
            .Subscribe(x => 
            {
                foreach (var item in x)
                {
                    Debug.Log(item);
                }
            });
        s.OnNext(1);
        s.OnNext(2);
        s.OnNext(3);
        s.OnCompleted();
    }
}