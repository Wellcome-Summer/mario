using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDataBase : MonoBehaviour
{
    public GameObject starImagePrefab;
    public GameObject Slot;
    static StarDataBase instance;
    private void Awake()
    {
        instance = this;
    }

    public List<StarInven> starDB = new List<StarInven>();
    public Vector3 pos;

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            pos += Slot.transform.position;
            GameObject go = Instantiate(starImagePrefab, pos, Quaternion.identity);
        }
    }
}
