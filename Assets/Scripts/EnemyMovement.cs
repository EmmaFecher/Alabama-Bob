using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public  float speed = 10;
    private int wayPointIndex = 0;

    private void Start()
    {
        //set pos to first waypoint
        transform.position = waypoints[wayPointIndex].transform.position;
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        if(wayPointIndex <= waypoints.Length - 1)
        {   //move enemy from current waypoint to next
            transform.position = Vector2.MoveTowards(transform.position,
                waypoints[wayPointIndex].transform.position,
                speed * Time.deltaTime);

            //look at next target
            Vector3 diff = (waypoints[wayPointIndex].position - transform.position);
            float angle = Mathf.Atan2(diff.y, diff.x);
            transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg);


            //if boss reaches pos of waypoint he walked to, then waypoint Index +=1, and starts walking to next
            if (transform.position == waypoints[wayPointIndex].transform.position)
            {
                wayPointIndex += 1;
            }
        }
        else
        {
            //reset back to 0
            wayPointIndex = 0;
        }
    }
    //for stoping the game
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.name == "Player")
        {
            this.enabled = false;
        }
    }
}