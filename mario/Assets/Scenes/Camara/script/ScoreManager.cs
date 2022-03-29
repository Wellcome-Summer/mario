using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance = null;

    private void Awake()
    {
        instance = this;
    }

    // SCORE s===================================
    int score = 0;
    public Text textScore = null;

    // property : �Լ��ε� ����ó�� ����� �� �ִ�.
    public int SCORE
    {
        get { return score; }
        set
        {
            score = value;
            textScore.text = "���� : " + score + "��";

        }
    }
    void Start()
    {
        // �¾ �� ������ 0������ �ϰ� UI���� 0�� �̶�� ǥ���ϰ�ʹ�.
        SCORE = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
