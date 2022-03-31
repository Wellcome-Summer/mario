using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//�¾�� PauseUI�� ��Ȱ��ȭ�ϰ�ʹ�.
//PauseButton�� ���� �� PauseUI�� Ȱ��ȭ�ϰ�ʹ�.
public class GameManager : MonoBehaviour
{
    public GameObject PauseUI = null;
    public GameObject GameOverUI;
    public GameObject GameOverCamera;
    public GameObject GameClearUI;
    public GameObject GameClearCamera;
    public GameObject MainUI;
    public GameObject MainCamera;
    public GameObject StartGame;
    public GameObject GameMode;


    public static GameManager instance;

    private void Awake()
    {
        instance = this;

    }
    void Start()
    {
        StartGame.SetActive(true);
        print("StartGameO");
        MainUI.SetActive(false);
        print("GameModeX");
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (PauseUI.activeSelf)
            {
                PauseUI.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                PauseUI.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void OnClickPauseMenu()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void OnClickContinueButton()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void OnClickQuitButton()
    {
        Application.Quit();
    }
    public void OnClickStartButton()
    {
        MainUI.SetActive(true);
        print("GameModeO");
        StartGame.SetActive(false);
        print("StartGameX");
    }
    public void OnClickRestart()
    {
        // ����Scene�� �ٽ� �ε��ϰ�ʹ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}
