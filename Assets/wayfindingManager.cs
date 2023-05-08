using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayfindingManager : MonoBehaviour
{
    public GameObject toGardenWFArrow1;
    public GameObject toGardenWFArrow2;
    public GameObject toGardenWFArrow3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleToGarden() {
        if(toGardenWFArrow1.activeSelf) {
            toGardenWFArrow1.SetActive(false);
            toGardenWFArrow2.SetActive(false);
            toGardenWFArrow3.SetActive(false);
        }
        else {
            toGardenWFArrow1.SetActive(true);
            toGardenWFArrow2.SetActive(true);
            toGardenWFArrow3.SetActive(true);
        }
    }
}
