using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] List<GameObject> waypoints;
    [SerializeField] float speed;
    int index = 0;

    private void Update()
    {
        waypoint();
    }

    void waypoint()
    {
        Vector3 Destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position,Destination, speed * Time.deltaTime);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position,Destination);

        if(distance <= 0)
        {
            if(index < waypoints.Count -1)
            {
                index++;
            }
            else
            {
                index = 0;
                transform.position = waypoints[index].transform.position;
            }
        }
    }

}
