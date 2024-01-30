using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float speed = 1f;
    [SerializeField] private float radius =0.5f;
    //[SerializeField] private GameObject playerGo;
    private GameObject playerGo;
    //동적으로 생성되는 애는 씬에 있는거 assign 할수 없다.
    [Serialize] private CatEscapeGameDirector gameDirector;
    void Start()
    {
        //이름으로 게임오브젝트를 찾는다.
        this.playerGo = GameObject.Find("player");
        // 타입으로 컴포넌트를 찾는다
        this.gameDirector = GameObject.FindObjectOfType<CatEscapeGameDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        //방향*속도*시간
        Vector3 movement = Vector3.down * 1 * Time.deltaTime;
        this.transform.Translate(movement);
        //Debug.LogFormat("y : {0}", this.transform.position.y); // 화살표의 위치 출력
        // 현재 y좌표가 -3.5보다 작아졌을때 씬에서 제거
        if (this.transform.position.y <= -3.5f)
        {
            //Debug.Log("에러");
            //Destroy(gameObject); => ArrowController 컴포넌트가 제거된다.
            Destroy(this.gameObject); //게임오브젝트를 씬에서 제거
        }

        // 거리 계산
        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.playerGo.transform.position;
        Vector2 dir = p1 - p2; // 방향
        float distance = dir.magnitude; //거리
        // float distance = Vector2.Distance(p1, p2); => 방향이 필요없을 때

        float r1 = this.radius;
        float r2 = this.playerGo.GetComponent<PlayerController>().radius;
        float sumRadius = r1 + r2;
        if(distance < sumRadius){
            Debug.LogFormat("충돌함: {0}, {1}", distance, sumRadius);
            Destroy(this.gameObject);

            this.gameDirector.DecreaseHp();
        }
    }
       
    // 이벤트 함수
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }

}
