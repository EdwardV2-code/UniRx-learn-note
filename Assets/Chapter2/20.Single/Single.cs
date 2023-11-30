using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Single : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
        Debug.Log(ints.Single(i => i > 4));
        //Debug.Log(ints.Single(i => i > 3));
    }
}