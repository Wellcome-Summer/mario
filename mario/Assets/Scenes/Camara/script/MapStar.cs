using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapStar : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //���࿡ other�� �÷��̾���
        if (other.transform.tag == "Player")
        {
            GetStars gstar = other.GetComponent<GetStars>();
                //UI�� ����
                gstar.AddSTAR(1); 
                Destroy(gameObject);
        }
    }
}
