using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ȭ���� ��ġ �ϸ� ���콺 ��ġ�� ����Ѵ� 
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //������ġ      ����          ����      ���ʵ��� ������
            //Debug.DrawRay(ray.origin, ray.direction, Color.red, 10f);

            DrawArrow.ForDebug(ray.origin, ray.direction, 10, Color.red, ArrowType.Solid);
        }
    }
}