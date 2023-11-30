using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RxWhenAll : MonoBehaviour
{
    private IEnumerator A()
    {
        yield return null;
    }

    private IEnumerator B()
    {
        yield return null;
    }

    // Start is called before the first frame update
    private void Start()
    {
        Observable.WhenAll(Observable.FromCoroutine(A), Observable.FromCoroutine(B))
            .Subscribe(_ => Debug.Log("All done!"));
    }
}