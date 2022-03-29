using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//�¾�� PauseUI�� ��Ȱ��ȭ�ϰ�ʹ�.
//PauseButton�� ���� �� PauseUI�� Ȱ��ȭ�ϰ�ʹ�.
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
        // ����Scene�� �ٽ� �ε��ϰ�ʹ�.
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
