using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ui���� ���̺귯��
using UnityEngine.SceneManagement; // �� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText; // ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText; // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime; // ���� �ð�
    private bool isGameover; // ���ӿ��� ����
    
    void Start()
    {
        //���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0;
        isGameover = false;
    }


    void Update()
    {
        if (!isGameover)
        {
            //�����ð� ����
            surviveTime += Time.deltaTime;
            //������ ���� �ð��� Ÿ���ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time: " + (int)surviveTime;
        }
        else
        {
            //���ӿ��� ���¿��� rŰ�� ���� ���
            if (Input.GetKeyDown(KeyCode.R))
            {
                //���ý� �ε�
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    // ���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {
        isGameover = true; // ���� ���¸� ���ӿ��� ���·� ��ȯ
        gameoverText.SetActive(true); //���ӿ��� �ؽ�Ʈ ���� ������Ʈ Ȱ��ȭ

        //����ƮŸ�� Ű�� ����� ���������� �ְ� ��� ��������
        float bestTime = PlayerPrefs.GetFloat("BestTime");
        //���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if (surviveTime > bestTime)
        {
            //�ְ� ��� ���� ���� ���� �ð� ������ ����
            bestTime = surviveTime;
            //����� �ְ� ����� ����ƮŸ�� Ű�� ����
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        //�ְ� ����� ���ڵ��ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
        recordText.text = "Best Time: " + (int)bestTime;

    }
}
