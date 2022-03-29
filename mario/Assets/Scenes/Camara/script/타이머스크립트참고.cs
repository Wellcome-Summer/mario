using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//태어날때 PauseMenu를르 빙
public class MainUI : MonoBehaviour
{
    public Image dashImage;
    bool isCoolTime = false;
    float currentTime = 5f;
    float delayTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            

            if (isCoolTime)
            {
                currentTime -= Time.deltaTime;
                dashImage.fillAmount = currentTime / delayTime;

                if (currentTime <= 0)
                {
                    isCoolTime = false;
                    currentTime = delayTime;
                    dashImage.fillAmount = currentTime;
                }
            }

        }
    }
    public void Change()
    {
        isCoolTime = true;
    }

}
