using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public Transform player;
    public float moveSpeed = 3f;
    private Vector3 target;

    //controls
    public KeyCode moveL;
    public KeyCode moveR;
    public KeyCode moveUL;
    public KeyCode moveUR;
    public Transform leftUpPoint;
    public Transform rightUpPoint;


    public float lethal = 0;


    void Start()
    {

    }

    void Update()
    {
        if ((Input.GetKeyDown(moveL)) && target != rightUpPoint.position)
        {
            if (transform.position.x != 0 && target != leftUpPoint.position)
            target += Vector3.left;

        }

        else if (Input.GetKeyDown(moveL) && target == rightUpPoint.position)
        {
           
            target += (Vector3.left + Vector3.down);
        }

        if (Input.GetKeyDown(moveR) && target != leftUpPoint.position)
        {
            if (transform.position.x != 1 && target != rightUpPoint.position)
                target += Vector3.right;

        }
        else if (Input.GetKeyDown(moveR) && target == leftUpPoint.position)
        {
            target += Vector3.right + Vector3.down;
        }

        if (Input.GetKeyDown(moveUL))
        {
            
            target = leftUpPoint.position;

        }
        if (Input.GetKeyDown(moveUR))
        {
            target = rightUpPoint.position;


        }
        player.transform.position = Vector3.MoveTowards(player.transform.position, target, moveSpeed * Time.deltaTime);
    }



}
