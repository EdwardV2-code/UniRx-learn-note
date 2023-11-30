using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqSelectMany : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var strings = new List<string>() { "123", "456", "789" };
        strings.SelectMany(n => n + ";")
            .ToList()
            .ForEach(x => Debug.Log(x));
    }
}