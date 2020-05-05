using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public Waypoint currentDestination;
  public WaypointManager waypointManager;
  private int currentIndexWaypoint = 0;
  public float speed = 1;
  public int type;
  public int HP;
    public Tower target;
    private Vector3 currentPosition;

    private Renderer yes;
  public void Initialize(WaypointManager waypointManager)
  {
    this.waypointManager = waypointManager;
    GetNextWaypoint();
    transform.position = currentDestination.transform.position; // Move to WP0
    GetNextWaypoint();
        currentPosition = transform.position;
        yes = GetComponent<Renderer>();
  }

  void Update()
  {
        /*
        if (currentDestination == waypointManager.waypoints[waypointManager.getSize()])
        {
            doDamage(type);
            Destroy(gameObject);
        }
        */
        currentPosition = transform.position;
        if (currentPosition == waypointManager.waypoints[waypointManager.getLastIndex()].transform.position)
        {
            doDamage(type);
            Destroy(gameObject);
        }
        
        Vector3 direction = currentDestination.transform.position - transform.position;
    if (direction.magnitude < .2f)
    {
      GetNextWaypoint();
    }

    
    transform.Translate(direction.normalized * speed * Time.deltaTime);
       
    }

  private void GetNextWaypoint()
  {
        if (currentIndexWaypoint < waypointManager.getSize())
        {
            currentDestination = waypointManager.GetNeWaypoint(currentIndexWaypoint);
            currentIndexWaypoint++;
        }

  }

    private void doDamage(int t)
    {
        
        if (target.getHP() <= 0)
        {
            DestroyImmediate(target, true);
        }
        
        else if (t == 0)
        {
            target.takeDamage(5);
        }

        else if (t == 1)
        {
            target.takeDamage(3);
        }
    }

    public void takeDamage(int t)
    {
        HP = -3;
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }

}
