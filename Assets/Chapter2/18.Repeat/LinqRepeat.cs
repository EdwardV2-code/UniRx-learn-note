using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqRepeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var strings = Enumerable.Repeat("Hello", 3);
        strings.ToList()
            .ForEach(x => Debug.Log(x));
    }
}

