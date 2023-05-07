using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapTransform : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void LateUpdate()
    {
        Vector3 nextPos = player.position;
        nextPos.y = transform.position.y;
        transform.position = nextPos;

        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, player.eulerAngles.y, 0f);
    }
}
