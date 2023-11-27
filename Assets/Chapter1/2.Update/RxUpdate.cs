using UniRx;
using UnityEngine;

public class RxUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Subscribe(_ => Debug.Log("Left Mouse button is pressed"));

        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(1))
            .Subscribe(_ => Debug.Log("Right Mouse button is pressed"));

        Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.Q))
            .Subscribe(_ => Debug.Log("Q key is pressed"));

        Observable.EveryUpdate()
            .Where(_ => flag)
            .Subscribe(_ => Debug.Log("flag is true"));
    }

    private bool flag = false;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Left Mouse button is pressed");
            flag = true;
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("Right Mouse button is pressed");
            flag = false;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q key is pressed");
        }
        if (flag)
        {
            Debug.Log("flag is true");
        }
        //......
    }
}