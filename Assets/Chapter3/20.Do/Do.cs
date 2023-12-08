using UniRx;
using UnityEngine;

public class Do : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
        .Where(_ => Input.GetMouseButtonDown(0))
        .Take(5)
        .Do((next) => Debug.Log("Do: " + next), (error) => Debug.Log("error: " + error), () => Debug.Log("Complete"))
        .Subscribe();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}