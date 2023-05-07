using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ingredientObj;
    private int collisions;
    private Collider m_Collider;
    private Vector3 cur_scale;
    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider>();
        cur_scale =  m_Collider.bounds.size / 2;
        collisions = 0;
        Instantiate(ingredientObj, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Physics.SyncTransforms();

        Collider[] hitColliders = Physics.OverlapBox(m_Collider.bounds.center, cur_scale, transform.rotation);
        int i = 0;
        //Check when there is a new collider coming into contact with the box
        while (i < hitColliders.Length)
        {
            //Output all of the collider names
            if(hitColliders[i].gameObject != gameObject) {
                Debug.Log("Hit : " + hitColliders[i].name + i);
                Debug.Log(hitColliders[i]);
            }
            //Increase the number of Colliders in the array
            i++;
        }

        if(hitColliders.Length == 0) {
            Instantiate(ingredientObj, transform.position, transform.rotation);
        }
    }
    // private void OnCollisionEnter(Collision collision)
    // {
    //     collisions++;
    //     if (collision.gameObject.CompareTag(ingredientObj.tag))
    //     {
    //         Debug.Log("spawned watermelon removed --> spawning new watermelon");
    //         // Perform any other necessary actions here
    //         collision.gameObject.tag = "spawned_" + ingredientObj.tag;

    //         Instantiate(ingredientObj, transform.position, transform.rotation);
    //     }
    // }

    // private void OnCollisionExit(Collision collision)
    // {
    //     collisions--;
    //     if (collision.gameObject.CompareTag(ingredientObj.tag))
    //     {
    //         Debug.Log("spawned watermelon removed --> spawning new watermelon");
    //         // Perform any other necessary actions here
    //         collision.gameObject.tag = "spawned_" + ingredientObj.tag;
    //         if (collisions == 0) {
    //             Instantiate(ingredientObj, transform.position, transform.rotation);
    //         }
    //     }
    // }
}
