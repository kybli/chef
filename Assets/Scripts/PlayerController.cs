using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tpToGarden()
    {
        transform.position = transform.position = new Vector3(5, transform.position.y, 15);
    }

    public void tpToKitchen()
    {
        transform.position = transform.position = new Vector3(0, transform.position.y, 0);
    }
}
