using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    public Waypoint[] waypoints;
    private int lastIndex = 0;
    private int size = 0;
  void Awake()
  {

    waypoints = GetComponentsInChildren<Waypoint>();
        getLocations();
        Debug.Log(string.Format("{0}", lastIndex));
  }

  public Waypoint GetNeWaypoint(int currentIndex)
  {
    return waypoints[currentIndex++];
  }

  public int getLastIndex()
    {
        return lastIndex;
    }

    private void getLocations()
    {
        foreach(Waypoint A in waypoints)
        {
            lastIndex++;
            Debug.Log(A.transform.position);
        }
        size = lastIndex;
        lastIndex--;
    }

    public int getSize()
    {
        return size;
    }

}
