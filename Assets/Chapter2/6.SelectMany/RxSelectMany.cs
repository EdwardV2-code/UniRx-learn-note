using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RxSelectMany : MonoBehaviour
{
    private IEnumerator A()
    {
        Debug.Log("A");
        yield return new WaitForSeconds(1);
    }

    private IEnumerator B()
    {
        Debug.Log("B");
        yield return new WaitForSeconds(1);
    }

    private IEnumerator C()
    {
        Debug.Log("C");
        yield return new WaitForSeconds(1);
    }

    private void Start()
    {
        Observable.FromCoroutine(A)
            .SelectMany(_ => Observable.FromCoroutine(B))
            .SelectMany(_ => Observable.FromCoroutine(C))
            .Subscribe();
    }
}