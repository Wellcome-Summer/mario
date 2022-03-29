using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingpongCube : MonoBehaviour
{
    public Transform DestinationSpot;
    public Transform OriginSpot;
    public float Speed;
    public float pause = 5f;
    float Stoptimer = 0;
    bool flag = false;

    private void Start()
    {
    }
    void FixedUpdate()
    {
        if (transform.position == OriginSpot.position && flag == true)
        {
            flag = false;
            Stoptimer = 0f;
        }
        if (transform.position == DestinationSpot.position && flag == false)
        {
            flag = true;
            Stoptimer = 0f;
        }
        if (flag == true)
        {
            if(Stoptimer >= pause)
            {
                transform.position = Vector3.MoveTowards(transform.position, OriginSpot.position, Speed * Time.deltaTime);
            }
            else
            {
                Stoptimer += Time.deltaTime;
            }
        }
        else
        {
            if (Stoptimer >= pause)
            {
                transform.position = Vector3.MoveTowards(transform.position, DestinationSpot.position, Speed * Time.deltaTime);
            }
            else
            {
                Stoptimer += Time.deltaTime;
            }
        }

    }
}
