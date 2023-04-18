using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; 
    // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; 
    //이동 속력
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
            //위쪽 방향키 입력이 감지된 경우 z방향 힘 주기
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {

            playerRigidbody.AddForce(0f, 0f, -speed); 
            //아래쪽 방향키 입력이 감지된 경우 -z 방향 힘 주기
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {

            playerRigidbody.AddForce(speed, 0f, 0f); 
            //오른쪽 방향키 입력이 감지된 경우 x 방향 힘 주기
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {

            playerRigidbody.AddForce(-speed, 0f, 0f); 
            //왼쪽 방향키 입력이 감지된 경우 -x 방향 힘 주기
        }
    }
  public void die()
    {
        gameObject.SetActive(false);
    }
}
