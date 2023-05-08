using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : MonoBehaviour
{
    // Reference to the prefab that we want to switch to
    public GameObject newPrefab;
    public AudioClip sizzleSound;
    public GameObject stove;
    public GameObject pan;
    private AudioSource audioSource;

    private void Update ()
    {
        // check if everything is touching. If so, start cooking
        if (transform.GetComponent<Collider>().bounds.Intersects(pan.GetComponent<Collider>().bounds) &&
                pan.GetComponent<Collider>().bounds.Intersects(stove.GetComponent<Collider>().bounds))
        {
            StartCoroutine(SwitchToNewPrefab());
        }


    }

    private IEnumerator SwitchToNewPrefab()
    {
        // play the sizzling sound to show user it is cooking
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = sizzleSound;
        audioSource.Play();
        
        // wait for 5 seconds
        yield return new WaitForSeconds(5f);

        audioSource.Stop();
        Destroy(audioSource);

        // switch to the cooked prefab
        Instantiate(newPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        

    }

}
