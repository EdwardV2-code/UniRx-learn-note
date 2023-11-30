using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqLast : MonoBehaviour
{
    private void Start()
    {
        var ints = new List<int> { 1, 2, 3, 4, 5 };
        Debug.Log(ints.Last());
        //log 5
    }
}