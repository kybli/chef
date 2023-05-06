using UnityEngine;

public class SteakCooking : MonoBehaviour
{
    public GameObject rawSteakPrefab;
    public GameObject cookedSteakPrefab;
    public GameObject stove;
    public GameObject pan;

    private GameObject currentSteak;
    private bool isCooking = false;

    private void Start()
    {
        currentSteak = Instantiate(rawSteakPrefab, transform.position, Quaternion.identity);
    }

    private void Update()
    {
        if (isCooking)
        {
            if (currentSteak != null && stove != null && pan != null &&
                currentSteak.GetComponent<Collider>().bounds.Intersects(pan.GetComponent<Collider>().bounds) &&
                pan.GetComponent<Collider>().bounds.Intersects(stove.GetComponent<Collider>().bounds))
            {
                CookSteak();
            }
        }
    }

    private void CookSteak()
    {
        Destroy(currentSteak);
        currentSteak = Instantiate(cookedSteakPrefab, transform.position, Quaternion.identity);
    }

    public void StartCooking()
    {
        isCooking = true;
    }
}

