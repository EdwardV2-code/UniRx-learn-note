using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqDistinct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var list = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3 };
        list.Distinct().ToList().ForEach(x => Debug.Log(x));
    }
}
