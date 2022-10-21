using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetButton("left"))
    {
        transform.Rotate(0, 5, 0);
    }
    if (Input.GetButton("right"))
    {
        transform.Rotate(0, -5, 0);
    }
    }
}
