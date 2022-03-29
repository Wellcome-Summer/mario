using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//태어날때 PauseUI를 비활성화하고싶다.
//PauseButton을 누를 때 PauseUI를 활성화하고싶다.
public class GameManager : MonoBehaviour
{
    public GameObject PauseUI = null;
    public GameObject PauseButton;
    public GameObject GameOverUI;
    public GameObject starImageUI;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;

    }
    void Start()
    {
        PauseUI.SetActive(false);
        GameOverUI.SetActive(false);
        starImageUI.SetActive(false);

    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (PauseUI.activeSelf)
            {
                PauseUI.SetActive(false);
            }
            else
            {
                PauseUI.SetActive(true);

            }
        }
    }

    public void OnClickPauseMenu()
    {
        PauseUI.SetActive(true);
    }
    public void OnClickContinueButton()
    {
        PauseUI.SetActive(false);
    }
    public void OnClickQuitButton()
    {
        Application.Quit();    }
    public void OnClickRestart()
    {
        print("OnClickRestart");
        // 현재Scene을 다시 로드하고싶다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    private void OnTriggerEnter(PlayerMove other)
    {
        if (other.transform.tag == "Star")
        {
            starImageUI.SetActive(true);
        }
    }

}
