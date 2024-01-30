using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float force = 680f;
    //private float arrowForce = ForceMode 
   
    void Update()
    {
        //스페이스 누를때
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //힘을 가한다
            this.rbody.AddForce(this.transform.up * this.force); // => local 
            //this.rbody.AddForce(Vector3.up * this.force);  => 이렇게하면 방향이 바껴도 일직선상 위로만 움직임 => world
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.rbody.AddForce(-this.transform.right * this.force/10f); // 왼쪽방향키 누르면 왼쪽으로 이동
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rbody.AddForce(this.transform.right * this.force/10f);// 오른쪽 방향키 누르면 왼쪽으로 이동

        }
    }
}
