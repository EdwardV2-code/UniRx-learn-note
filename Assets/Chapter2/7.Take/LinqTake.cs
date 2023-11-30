using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqTake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
        ints.Take(3)
            .ToList()
            .ForEach(x => Debug.Log(x));
    }
}
