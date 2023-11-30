using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqSkipWhile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> ints = new List<int>() { 1, 7, 6, 5, 2 };
        ints.SkipWhile(x => x < 4)
            .ToList()
            .ForEach(x => Debug.Log(x));
    }
}
