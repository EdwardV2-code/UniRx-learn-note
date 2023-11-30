using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqOfType : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        ArrayList list = new ArrayList() { 1, 'c', "123", 12.0f };
        list.OfType<float>().ToList().ForEach(x => Debug.Log(x));
    }
}