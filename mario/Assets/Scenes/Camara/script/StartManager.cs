using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Wall;
    public float Wspeed = 3;
    public GameObject Flower;
    public float Fspeed = 3;
    public GameObject Button;
    public GameObject Luizy;
    public GameObject Mario;
    public float LMspeed = 3;
    public GameObject Peach;
    public GameObject Princess;
    public float PPspeed = 1;
    public GameObject CaptainToad;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return StartCoroutine("IEPanelOff");
        yield return StartCoroutine("IEPanelON");
        yield return StartCoroutine("IEWallUp");
        yield return StartCoroutine("IEFlowerUp");
        yield return StartCoroutine("IEPPrincess");
        yield return StartCoroutine("IELuizyMario");
        yield return StartCoroutine("CaptainToadOn");
        StartCoroutine("ButtonOn");
        yield return 0;
    }


    IEnumerator IEPanelOff()
    {
        for (float t = 0; t <= 0; t += Time.deltaTime)
        {
            Panel.SetActive(false);
            yield return 0;
        }
    }
    IEnumerator IEPanelON()
    {
        for (float t = 0; t <= 1; t += Time.deltaTime)
        {
            Panel.SetActive(true);
            yield return 0;
        }
    }
    IEnumerator IEWallUp()
    {
        for (float t = 0; t <= 1; t += Time.deltaTime)
        {
            Wall.transform.position += Vector3.up * Wspeed * Time.deltaTime;
            yield return 0;
        }
    }
    IEnumerator IEFlowerUp()
    {
        for (float t = 0; t <= 1; t += Time.deltaTime)
        {
            Flower.transform.position += Vector3.up * Fspeed * Time.deltaTime;
            yield return 0;
        }
    }
    IEnumerator IEPPrincess()
    {
        for (float t = 0; t <= 1; t += Time.deltaTime)
        {
            Peach.transform.position += Vector3.right * PPspeed * Time.deltaTime;
            Princess.transform.position += Vector3.left * PPspeed * Time.deltaTime;
            yield return 0;
        }
    }
    IEnumerator IELuizyMario()
    {
        for (float t = 0; t <= 1; t += Time.deltaTime)
        {
            Luizy.transform.position += Vector3.right * LMspeed * Time.deltaTime;
            Mario.transform.position += Vector3.left * LMspeed * Time.deltaTime;
            yield return 0;
        }
    }
    IEnumerator CaptainToadOn()
    {
        for (float t = 0; t <= 1; t += Time.deltaTime)
        {
            CaptainToad.SetActive(true);
            yield return 0;
        }
    }
    IEnumerator ButtonOn()
    {
        for (float t = 0; t <= 1; t += Time.deltaTime)
        {
            Button.SetActive(true);
            yield return 0;
        }
    }



}
