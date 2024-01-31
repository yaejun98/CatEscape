using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.SceneManagement;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float moveForce = 100f;
    [SerializeField] private float jumpForce = 680f;

    [SerializeField]
    private ClimbCloudGameDirector gameDirector;

    private Animator anim;

    private void Start()
    {
        //this.gameObject.GetComponent<Animation>();

        anim = GetComponent<Animator>();

        //this.gameDirector = GameObject.Find("GameDirector").GetComponent<ClimbCloudGameDirector>();
        //this.gameDirector = GameObject.FindAnyObjectByType<ClimbCloudGameDirector>();
   
    }

    void Update()
    {
        
        //�����̽��ٸ� ������ 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //���� ���Ѵ� 
            this.rbody.AddForce(this.transform.up * this.jumpForce);
            //this.rbody.AddForce(Vector3.up * this.force);
        }

        // -1, 0, 1 : ���� 
        int dirX = 0;
        //����ȭ��ǥŰ�� ������ �ִ� ���ȿ� 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dirX = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            dirX = 1;
        }

        // Debug.Log(dirX); //���� -1, 0, 1

        //������ X�� ���� �ϴµ� Ű�� ������ ���� 
        //Ű�� ���������� = (dirX != 0)
        if (dirX != 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }


        //������ �� 
        //Debug.Log(this.transform.right * dirX);  //����3

        //���� ! : �ӵ��� �������� 
        //velocity.x �� 3������ �Ѿ�ϱ� �������°� �����...
        if (Mathf.Abs(this.rbody.velocity.x) < 3)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveForce);
        }

        this.anim.speed = (Mathf.Abs(this.rbody.velocity.x) / 2f);
        this.gameDirector.UpdateVelocityText(this.rbody.velocity);

        
        // Debug.Log(this.transform.position);
        
        float clampX = Mathf.Clamp(this.transform.position.x, -2.39f, 2.35f);
        Vector3 pos = this.transform.position;
        pos.x = clampX;
        this.transform.position = pos;


    }

    // Trigger ��� �ϰ�� �浹 ������ ���ִ� �̺�Ʈ �Լ�
    private bool hasEntered = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (!hasEntered)
        {
            Debug.LogFormat("OnTriggerEnter2D: {0}", collision);
            SceneManager.LoadScene("ClimbCloudClear");
            hasEntered = true; // �� �� �̺�Ʈ�� �߻��ϸ� �� ������ true�� �����Ͽ� �� �� �̻� ȣ����� �ʵ��� ��
           
        }
       
    }
    
   

}