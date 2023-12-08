using UniRx;
using UnityEngine;

public class Scan : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.Range(1, 10)
            .Scan((x, y) => x == 5 ? x : y)
            .Subscribe(x => Debug.Log(x));
    }
}