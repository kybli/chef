using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chop : MonoBehaviour
{
    private int chopCount = 0;
    public GameObject choppedFoodPrefab;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Knife") && chopCount< 5)
        {
            GameObject choppedFood = Instantiate(choppedFoodPrefab, transform.position, transform.rotation);

            choppedFood.transform.SetParent(transform.parent);

            // destroy  original food object
            Destroy(gameObject);

            chopCount++;
        }
    }
}
