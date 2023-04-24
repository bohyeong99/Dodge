using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; //������ ź���� ���� ������
    public float spawnRateMin = 0.5f; //�ּ� ���� �ֱ�
    public float spawnRateMax = 3f; //�ִ� ���� �ֱ�

    private Transform target; //�߻��� ���
    private float spawnRate; //���� �ֱ�
    private float timeAfterSpawn; //�ֱ� ���� �������� ���� �ð�
    // Start is called before the first frame update
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        //ź�� ���� ������ ��������Ʈ���ΰ� ��������Ʈ�ƽ� ���̿��� ���� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        //�÷��̾� ��Ʈ�ѷ� ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<PlayerController>().transform;

    }

    // Update is called once per frame
    void Update()
    {
        //timeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;

        //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (timeAfterSpawn >= spawnRate)
        {
            //������ �ð��� ����
            timeAfterSpawn = 0f;

            //�Ҹ��������� ��������
            //Ʈ������������ ��ġ�� Ʈ�����������̼� ȸ������ ����
            GameObject bullet
                = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //������ �Ҹ� ���� ������Ʈ�� ���� ������ Ÿ���� ���ϵ��� ȸ��
            bullet.transform.LookAt(target);

            //������ ���� ������ ��������Ʈ��, ��������Ʈ�ƽ� ���̿��� ���� ����
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
