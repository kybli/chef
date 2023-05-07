using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloneScript : MonoBehaviour
{
    public GameObject clonedObjectPrefab;
    private GameObject clonedObject;
    // private IGrabbable grabbable;

    // Start is called before the first frame update
    void Start()
    {
        // grabbable = GetComponent<IGrabbable>();
        // grabbable.OnGrabBegin += OnGrabBeginHandler;
        // grabbable.OnGrabEnd += OnGrabEndHandler;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        // grabbable.OnGrabBegin -= OnGrabBeginHandler;
       //  grabbable.OnGrabEnd -= OnGrabEndHandler;
    }

    private void OnGrabBeginHandler()
    {
        // Clone the object
        // clonedObject = Instantiate(clonedObjectPrefab, transform.position, transform.rotation);

        // Attach the cloned object to the grabber
        // OVRGrabber grabber = grabbable.grabbedBy.GetComponent<OVRGrabber>();
        // grabber.ForceRelease(grabbable);
        // grabber.GrabBegin(clonedObject);
    }

    private void OnGrabEndHandler()
    {
        // Destroy the cloned object
        Destroy(clonedObject);
    }
}
