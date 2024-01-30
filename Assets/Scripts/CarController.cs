using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 0.1f;
    [SerializeField] private float attenuation = 0.96f;
    [SerializeField] private float divied = 500f; 
    private float speed = 0;
    private Vector3 startPosition; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ��ư�� ��������
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("ȭ�� ��ġ ����");
            // ȭ���� ��ġ�� ��ġ ��������
            Debug.Log(Input.mousePosition);
            this.startPosition = Input.mousePosition;
           // speed = maxSpeed;   
        }

        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("ȭ�鿡�� ���� ��");
            Debug.Log(Input.mousePosition);
            float length = Input.mousePosition.x - this.startPosition.x;
            Debug.Log(length);
            Debug.Log(length / divied);
            speed = length / divied;
            Debug.LogFormat("<color=yellow>speed : {0}</color>", speed);

            // ȭ�鿡�� ���� �� ����.x - ��ġ�� ������ x

            //���� ����

            //���� ������Ʈ�� �پ� �ִ� ������Ʈ ��������
            AudioSource audioSource = this.gameObject.GetComponent<AudioSource>();
            audioSource.Play(); //�ν��Ͻ� �޼���


        }
        // 0.1 ���־� �� �����Ӹ��� �̵��Ѵ�
        this.gameObject.transform.Translate(new Vector3(speed, 0, 0));
        //�� �����Ӹ��� ���ǵ带 ���� �Ѵ�.
        speed *= attenuation;
    }
}
