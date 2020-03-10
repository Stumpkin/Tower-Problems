using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    private Vector3 location;
    // Start is called before the first frame update
    void Start()
    {
        location = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.y);

    }

    // Update is called once per frame
    Vector3 getPosition()
    {
        return location;
    }
}
