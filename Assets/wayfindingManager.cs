using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayfindingManager : MonoBehaviour
{
    public GameObject toGardenWF;
    public GameObject toKitchenWF;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleToGarden() {
        if(toGardenWF.activeSelf) {
            toGardenWF.SetActive(false);
        }
        else {
            toGardenWF.SetActive(true);
        }
    }

    public void ToggleToKitchen() {
        if(toKitchenWF.activeSelf) {
            toKitchenWF.SetActive(false);
        }
        else {
            toKitchenWF.SetActive(true);
        }
    }
}
