using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; 
    // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f; 
    //�̵� �ӷ�
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {

            playerRigidbody.AddForce(0f, 0f, speed); 
            //���� ����Ű �Է��� ������ ��� z���� �� �ֱ�
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {

            playerRigidbody.AddForce(0f, 0f, -speed); 
            //�Ʒ��� ����Ű �Է��� ������ ��� -z ���� �� �ֱ�
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {

            playerRigidbody.AddForce(speed, 0f, 0f); 
            //������ ����Ű �Է��� ������ ��� x ���� �� �ֱ�
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {

            playerRigidbody.AddForce(-speed, 0f, 0f); 
            //���� ����Ű �Է��� ������ ��� -x ���� �� �ֱ�
        }
    }
  public void die()
    {
        gameObject.SetActive(false);
    }
}
