using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapPosition : MonoBehaviour
{
    public Transform tracker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = tracker.position; // + (tracker.forward * -0.1f);
        transform.rotation = tracker.rotation * Quaternion.Euler(200f, 180f, 20f);
    }
}