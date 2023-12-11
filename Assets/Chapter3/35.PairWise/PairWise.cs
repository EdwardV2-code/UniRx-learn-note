using UniRx;
using UnityEngine;

public class PairWise : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.Range(0, 10)
            .Pairwise()
            .Subscribe(value =>
            {
                Debug.Log($"{value.Current}£º{value.Previous}");
            });
    }
}