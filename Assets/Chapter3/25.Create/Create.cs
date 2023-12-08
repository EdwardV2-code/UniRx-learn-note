using UniRx;
using UnityEngine;

public class Create : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.Create<int>((ob) =>
        {
            ob.OnNext(1);
            ob.OnNext(2);
            ob.OnCompleted();
            return Disposable.Empty;
        }).Subscribe(x => Debug.Log(x));
    }
}