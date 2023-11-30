using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class UniRxDistinct : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Model.Instance._TestInt.Distinct()
                    .Subscribe(x => Debug.Log(x));
    }

    // Update is called once per frame
    private void Update()
    {
    }
}