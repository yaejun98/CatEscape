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
        //�����̽� ������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //���� ���Ѵ�
            this.rbody.AddForce(this.transform.up * this.force); // => local 
            //this.rbody.AddForce(Vector3.up * this.force);  => �̷����ϸ� ������ �ٲ��� �������� ���θ� ������ => world
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
    }
}
