using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : MonoBehaviour
{
    // reference to the prefab that we want to switch to
    public GameObject newPrefab;
    public AudioClip sizzleSound;
    public GameObject stove;
    public GameObject pan;
    private AudioSource audioSource;

    [SerializeField]
    private float t = 5;

    private bool bCooking;

    private void start ()
    {
        bCooking = false;
    }

    private void Update ()
    {
        // check if everything is touching. If so, start cooking
        if (transform.GetComponent<Collider>().bounds.Intersects(pan.GetComponent<Collider>().bounds) &&
                pan.GetComponent<Collider>().bounds.Intersects(stove.GetComponent<Collider>().bounds))
        {
            if (!bCooking)
                StartCoroutine(SwitchToNewPrefab());
        }


    }

    private IEnumerator SwitchToNewPrefab()
    {
        bCooking = true;
        // play the sizzling sound to show user it is cooking
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = sizzleSound;
        audioSource.Play();
        
        // wait for 5 seconds
        yield return new WaitForSeconds(t);

        audioSource.Stop();
        Destroy(audioSource);

        // new Vector3 (1.203f, 1.296f, 1.859f)

        // switch to the cooked prefab
        Instantiate(newPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        

    }

}
