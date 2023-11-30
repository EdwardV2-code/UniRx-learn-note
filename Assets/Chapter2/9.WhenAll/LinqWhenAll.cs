using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqWhenAll : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
        Debug.Log(ints.All(x => x > 10));
    }
}