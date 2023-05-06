using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chop : MonoBehaviour
{
    private int chopCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Knife") && chopCount<=)
        {
            // Create chopped food object at the same position and rotation as the original food object
            GameObject choppedFood = Instantiate(choppedFoodPrefab, transform.position, transform.rotation);

            // Set the chopped food object as a child of the original food object's parent
            choppedFood.transform.SetParent(transform.parent);

            // Destroy the original food object
            Destroy(gameObject);

            isChopped = true;
}
