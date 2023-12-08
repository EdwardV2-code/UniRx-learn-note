using UniRx;
using UnityEngine;

public class Timeout : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(Observable => Input.GetMouseButtonDown(0))
            .Timeout(System.TimeSpan.FromSeconds(5))
            .Subscribe(_ => Debug.Log("Clicked!"), ex => Debug.Log("Timeout!"));
    }
}