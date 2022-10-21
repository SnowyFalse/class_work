using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotate : MonoBehaviour
{
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 25, 35) * Time.deltaTime * speed); 
    }
}
