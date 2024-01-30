using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController2 : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float radius = 1f;
    
    private GameObject playerGo;

    private void Start()
    {
        this.playerGo = GameObject.Find("player");
    }


    void Update()
    {
        Vector3 movement = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movement);
        Debug.LogFormat("y : {0}", this.transform.position.y);
        if(this.transform.position.y <= -3.43f)
        {
            //Destroy(this);  // ArrowController 컴포넌트가 제거 된다.
            Destroy(this.gameObject);
        }
        // 거리 계산
        Vector2 p1 = this.transform.position; // 화살 위치
        Vector2 p2 = this.playerGo.transform.position; // 고양이의 위치
        // 방향
        Vector2 dir = p1 - p2;
        // 거리
        float distance2 = dir.magnitude;
        // 거리만 구할거면 float distance = Vector2.Distance(p1, p2);

        float r3 = this.radius;

        PlayerController2 controller = this.playerGo.GetComponent<PlayerController2>();
        float r4 = controller.radius;

        float sumRadius2 = r3 + r4;

        if(distance2 < sumRadius2) // 충돌
        {
            Debug.LogFormat("충돌함 : {0}, {1}", distance2, sumRadius2);
            Destroy(this.gameObject);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);

    }
}
