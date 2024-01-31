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
        
        //스페이스바를 누르면 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //힘을 가한다 
            this.rbody.AddForce(this.transform.up * this.jumpForce);
            //this.rbody.AddForce(Vector3.up * this.force);
        }

        // -1, 0, 1 : 방향 
        int dirX = 0;
        //왼쪽화살표키를 누르고 있는 동안에 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dirX = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            dirX = 1;
        }

        // Debug.Log(dirX); //방향 -1, 0, 1

        //스케일 X를 변경 하는데 키가 눌렸을 때만 
        //키가 눌렸을때만 = (dirX != 0)
        if (dirX != 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }


        //벡터의 곱 
        //Debug.Log(this.transform.right * dirX);  //벡터3

        //도전 ! : 속도를 제한하자 
        //velocity.x 가 3정도가 넘어가니깐 빨라지는거 같드라구...
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

    // Trigger 모드 일경우 충돌 판정을 해주는 이벤트 함수
    private bool hasEntered = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (!hasEntered)
        {
            Debug.LogFormat("OnTriggerEnter2D: {0}", collision);
            SceneManager.LoadScene("ClimbCloudClear");
            hasEntered = true; // 한 번 이벤트가 발생하면 이 변수를 true로 설정하여 두 번 이상 호출되지 않도록 함
           
        }
       
    }
    
   

}