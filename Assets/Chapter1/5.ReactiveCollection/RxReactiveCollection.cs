using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class RxReactiveCollection : MonoBehaviour
{
    public ReactiveCollection<string> _ReactiveCollection;

    // Start is called before the first frame update
    private void Start()
    {
        _ReactiveCollection.ObserveAdd()
            .Where(x => x.Value != null)
            .Subscribe();

        _ReactiveCollection.ObserveRemove()
            .Where(x => x.Value != null)
            .Subscribe();

        _ReactiveCollection.ObserveReplace()
            .Where(x => x.NewValue != null)
            .Subscribe();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}