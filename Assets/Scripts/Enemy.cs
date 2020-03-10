using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public WayPoint currentWayPoint;
    public WaypointM waypointMangement;
    public Vector3 currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        currentPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
