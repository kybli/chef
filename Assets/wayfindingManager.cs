using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wayfindingManager : MonoBehaviour
{
    public GameObject toGardenWF;
    public GameObject toKitchenWF;
    public GameObject toGardenBG; // 1F2021
    public GameObject toKitchenBG;
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
            ToggleToGardenOff();
        }
        else {
            ToggleToGardenOn();
            ToggleToKitchenOff();
        }
    }

    private void ToggleToGardenOn()
    {
        toGardenWF.SetActive(true);
        toGardenBG.GetComponent<Image>().color = new Color32(0, 74, 185, 255);
    }

    private void ToggleToGardenOff()
    {
        toGardenWF.SetActive(false);
        toGardenBG.GetComponent<Image>().color = new Color32(31, 32, 32, 0);
    }




    public void ToggleToKitchen() {
        if(toKitchenWF.activeSelf) {
            ToggleToKitchenOff();
        }
        else {
            ToggleToKitchenOn();
            ToggleToGardenOff();
        }
    }

    private void ToggleToKitchenOn()
    {
        toKitchenWF.SetActive(true);
        toKitchenBG.GetComponent<Image>().color = new Color32(0, 74, 185, 255);
    }

    private void ToggleToKitchenOff()
    {
        toKitchenWF.SetActive(false);
        toKitchenBG.GetComponent<Image>().color = new Color32(31, 32, 32, 0);
    }
}
