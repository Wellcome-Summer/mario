using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapStar : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //만약에 other가 플레이어라면
        if (other.transform.tag == "Player")
        {
            GetStars gstar = other.GetComponent<GetStars>();
                //UI를 생성
                gstar.AddSTAR(1); 
                Destroy(gameObject);
        }
    }
}
